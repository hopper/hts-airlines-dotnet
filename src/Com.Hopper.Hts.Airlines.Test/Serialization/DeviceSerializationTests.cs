using System;
using System.Text.Json;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;
using Xunit;

namespace Com.Hopper.Hts.Airlines.Test.Serialization
{
    public class DeviceSerializationTests
    {
        /// <summary>
        /// Reproduces the reported bug: serializing a Device with only DeviceJsonConverter
        /// registered used to throw InvalidOperationException because the Write() method
        /// searched for sub-converters (e.g. MobileJsonConverter) via First() on the
        /// options converter list.
        /// </summary>
        [Fact]
        public void Serialize_MobileDevice_WithMinimalConverters_DoesNotThrow()
        {
            var device = new Device(new Mobile(
                id: "device-123",
                type: Mobile.TypeEnum.Mobile,
                platform: new Option<Platform?>(new Platform(new App(
                    type: App.TypeEnum.App,
                    varOperatingSystem: new Option<ModelOperatingSystem?>(new ModelOperatingSystem(new Android(
                        type: Android.TypeEnum.Android,
                        varVersion: new Option<string?>("15")
                    )))
                ))),
                uiTheme: new Option<string?>("mobile_native"),
                releaseBuild: new Option<string?>("3.4.1")
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.NotNull(json);
            Assert.Contains("device-123", json);
        }

        [Fact]
        public void Serialize_DesktopDevice_WithMinimalConverters_DoesNotThrow()
        {
            var device = new Device(new Desktop(
                id: "desktop-456",
                type: Desktop.TypeEnum.Desktop
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.NotNull(json);
            Assert.Contains("desktop-456", json);
        }

        [Fact]
        public void Serialize_TabletDevice_WithMinimalConverters_DoesNotThrow()
        {
            var device = new Device(new Tablet(
                id: "tablet-789",
                type: Tablet.TypeEnum.Tablet
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.NotNull(json);
            Assert.Contains("tablet-789", json);
        }

        /// <summary>
        /// Verifies that the full nested oneOf chain serializes correctly:
        /// Device -> Mobile -> Platform -> App -> ModelOperatingSystem -> Android
        /// </summary>
        [Fact]
        public void Serialize_MobileDevice_ContainsExpectedJsonFields()
        {
            var device = new Device(new Mobile(
                id: "nested-test",
                type: Mobile.TypeEnum.Mobile,
                platform: new Option<Platform?>(new Platform(new App(
                    type: App.TypeEnum.App,
                    varOperatingSystem: new Option<ModelOperatingSystem?>(new ModelOperatingSystem(new Android(
                        type: Android.TypeEnum.Android,
                        varVersion: new Option<string?>("14")
                    )))
                ))),
                uiTheme: new Option<string?>("dark"),
                releaseBuild: new Option<string?>("2.0.0")
            ));

            var options = new JsonSerializerOptions
            {
                Converters =
                {
                    new DeviceJsonConverter(),
                    new MobileJsonConverter(),
                    new PlatformJsonConverter(),
                    new AppJsonConverter(),
                    new ModelOperatingSystemJsonConverter(),
                    new AndroidJsonConverter()
                }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.Contains("\"id\":\"nested-test\"", json);
            Assert.Contains("\"type\":\"mobile\"", json);
            Assert.Contains("\"ui_theme\":\"dark\"", json);
            Assert.Contains("\"release_build\":\"2.0.0\"", json);
        }

        /// <summary>
        /// Verifies round-trip serialization: serialize then deserialize
        /// produces an equivalent Device object.
        /// </summary>
        [Fact]
        public void RoundTrip_MobileDevice_DeserializesCorrectly()
        {
            var original = new Device(new Mobile(
                id: "roundtrip-001",
                type: Mobile.TypeEnum.Mobile,
                uiTheme: new Option<string?>("light"),
                releaseBuild: new Option<string?>("1.0.0")
            ));

            var options = new JsonSerializerOptions
            {
                Converters =
                {
                    new DeviceJsonConverter(),
                    new MobileJsonConverter(),
                    new DesktopJsonConverter(),
                    new TabletJsonConverter()
                }
            };

            var json = JsonSerializer.Serialize(original, options);
            var deserialized = JsonSerializer.Deserialize<Device>(json, options);

            Assert.NotNull(deserialized);
            Assert.NotNull(deserialized!.Mobile);
            Assert.Equal("roundtrip-001", deserialized.Mobile!.Id);
            Assert.Equal(Mobile.TypeEnum.Mobile, deserialized.Mobile.Type);
            Assert.Equal("light", deserialized.Mobile.UiTheme);
            Assert.Equal("1.0.0", deserialized.Mobile.ReleaseBuild);
        }

        /// <summary>
        /// Verifies all nested type discriminator fields are present in serialized JSON:
        /// device.type, platform.type, operating_system.type
        /// </summary>
        [Fact]
        public void Serialize_NestedDevice_AllTypeDiscriminatorsPresent()
        {
            var device = new Device(new Mobile(
                id: "discriminator-test",
                type: Mobile.TypeEnum.Mobile,
                platform: new Option<Platform?>(new Platform(new App(
                    type: App.TypeEnum.App,
                    varOperatingSystem: new Option<ModelOperatingSystem?>(new ModelOperatingSystem(new Android(
                        type: Android.TypeEnum.Android,
                        varVersion: new Option<string?>("15")
                    )))
                )))
            ));

            var options = new JsonSerializerOptions
            {
                Converters =
                {
                    new DeviceJsonConverter(),
                    new MobileJsonConverter(),
                    new PlatformJsonConverter(),
                    new AppJsonConverter(),
                    new ModelOperatingSystemJsonConverter(),
                    new AndroidJsonConverter()
                }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.Contains("\"type\":\"mobile\"", json);
            Assert.Contains("\"type\":\"app\"", json);
            Assert.Contains("\"type\":\"android\"", json);
            Assert.Contains("\"operating_system\"", json);
            Assert.Contains("\"version\":\"15\"", json);
        }

        /// <summary>
        /// Verifies that ReleaseBuild can be omitted entirely (not a breaking change).
        /// </summary>
        [Fact]
        public void Serialize_MobileDevice_ReleaseBuildOmitted_Succeeds()
        {
            var device = new Device(new Mobile(
                id: "no-release-build",
                type: Mobile.TypeEnum.Mobile
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.Contains("\"id\":\"no-release-build\"", json);
            Assert.Contains("\"type\":\"mobile\"", json);
            Assert.DoesNotContain("release_build", json);
        }

        /// <summary>
        /// Verifies that explicitly setting ReleaseBuild to null serializes
        /// without throwing (the API accepts null for this field).
        /// </summary>
        [Fact]
        public void Serialize_MobileDevice_ReleaseBuildExplicitNull_Succeeds()
        {
            var device = new Device(new Mobile(
                id: "null-release-build",
                type: Mobile.TypeEnum.Mobile,
                releaseBuild: new Option<string?>(null)
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.Contains("\"id\":\"null-release-build\"", json);
            Assert.Contains("\"type\":\"mobile\"", json);
        }

        /// <summary>
        /// Verifies that setting ReleaseBuild to a value works correctly.
        /// </summary>
        [Fact]
        public void Serialize_MobileDevice_ReleaseBuildWithValue_Succeeds()
        {
            var device = new Device(new Mobile(
                id: "with-release-build",
                type: Mobile.TypeEnum.Mobile,
                releaseBuild: new Option<string?>("3.4.1")
            ));

            var options = new JsonSerializerOptions
            {
                Converters = { new DeviceJsonConverter() }
            };

            var json = JsonSerializer.Serialize(device, options);

            Assert.Contains("\"release_build\":\"3.4.1\"", json);
        }
    }
}
