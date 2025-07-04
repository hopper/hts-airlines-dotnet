// <auto-generated>
/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using Com.Hopper.Hts.Airlines.Client;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// An object containing information related to the user&#39;s session
    /// </summary>
    public partial class CreateAirlineDgSessionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAirlineDgSessionRequest" /> class.
        /// </summary>
        /// <param name="pointOfSale">An ISO 3166-1-alpha-2 country code; the point of sale of the user</param>
        /// <param name="language">A ISO_639-1 country code; the language associated with the user</param>
        /// <param name="userInfo">userInfo</param>
        /// <param name="device">device</param>
        /// <param name="sessionId">The custom identifier for the customer&#39;s session. If omitted, a new session ID will be generated.</param>
        [JsonConstructor]
        public CreateAirlineDgSessionRequest(string pointOfSale, string language, Option<UserInfo?> userInfo = default, Option<Device?> device = default, Option<string?> sessionId = default)
        {
            PointOfSale = pointOfSale;
            Language = language;
            UserInfoOption = userInfo;
            DeviceOption = device;
            SessionIdOption = sessionId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// An ISO 3166-1-alpha-2 country code; the point of sale of the user
        /// </summary>
        /// <value>An ISO 3166-1-alpha-2 country code; the point of sale of the user</value>
        /* <example>US</example> */
        [JsonPropertyName("point_of_sale")]
        public string PointOfSale { get; set; }

        /// <summary>
        /// A ISO_639-1 country code; the language associated with the user
        /// </summary>
        /// <value>A ISO_639-1 country code; the language associated with the user</value>
        /* <example>es</example> */
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Used to track the state of UserInfo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<UserInfo?> UserInfoOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [JsonPropertyName("user_info")]
        public UserInfo? UserInfo { get { return this.UserInfoOption; } set { this.UserInfoOption = new Option<UserInfo?>(value); } }

        /// <summary>
        /// Used to track the state of Device
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Device?> DeviceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [JsonPropertyName("device")]
        public Device? Device { get { return this.DeviceOption; } set { this.DeviceOption = new Option<Device?>(value); } }

        /// <summary>
        /// Used to track the state of SessionId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SessionIdOption { get; private set; }

        /// <summary>
        /// The custom identifier for the customer&#39;s session. If omitted, a new session ID will be generated.
        /// </summary>
        /// <value>The custom identifier for the customer&#39;s session. If omitted, a new session ID will be generated.</value>
        /* <example>d93dd7c9-39c0-499d-903b-d837282231c7</example> */
        [JsonPropertyName("session_id")]
        public string? SessionId { get { return this.SessionIdOption; } set { this.SessionIdOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAirlineDgSessionRequest {\n");
            sb.Append("  PointOfSale: ").Append(PointOfSale).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CreateAirlineDgSessionRequest" />
    /// </summary>
    public class CreateAirlineDgSessionRequestJsonConverter : JsonConverter<CreateAirlineDgSessionRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateAirlineDgSessionRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateAirlineDgSessionRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> pointOfSale = default;
            Option<string?> language = default;
            Option<UserInfo?> userInfo = default;
            Option<Device?> device = default;
            Option<string?> sessionId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "point_of_sale":
                            pointOfSale = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "language":
                            language = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "user_info":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userInfo = new Option<UserInfo?>(JsonSerializer.Deserialize<UserInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "device":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                device = new Option<Device?>(JsonSerializer.Deserialize<Device>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "session_id":
                            sessionId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!pointOfSale.IsSet)
                throw new ArgumentException("Property is required for class CreateAirlineDgSessionRequest.", nameof(pointOfSale));

            if (!language.IsSet)
                throw new ArgumentException("Property is required for class CreateAirlineDgSessionRequest.", nameof(language));

            if (pointOfSale.IsSet && pointOfSale.Value == null)
                throw new ArgumentNullException(nameof(pointOfSale), "Property is not nullable for class CreateAirlineDgSessionRequest.");

            if (language.IsSet && language.Value == null)
                throw new ArgumentNullException(nameof(language), "Property is not nullable for class CreateAirlineDgSessionRequest.");

            if (userInfo.IsSet && userInfo.Value == null)
                throw new ArgumentNullException(nameof(userInfo), "Property is not nullable for class CreateAirlineDgSessionRequest.");

            if (device.IsSet && device.Value == null)
                throw new ArgumentNullException(nameof(device), "Property is not nullable for class CreateAirlineDgSessionRequest.");

            if (sessionId.IsSet && sessionId.Value == null)
                throw new ArgumentNullException(nameof(sessionId), "Property is not nullable for class CreateAirlineDgSessionRequest.");

            return new CreateAirlineDgSessionRequest(pointOfSale.Value!, language.Value!, userInfo, device, sessionId);
        }

        /// <summary>
        /// Serializes a <see cref="CreateAirlineDgSessionRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createAirlineDgSessionRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateAirlineDgSessionRequest createAirlineDgSessionRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createAirlineDgSessionRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateAirlineDgSessionRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createAirlineDgSessionRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateAirlineDgSessionRequest createAirlineDgSessionRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createAirlineDgSessionRequest.PointOfSale == null)
                throw new ArgumentNullException(nameof(createAirlineDgSessionRequest.PointOfSale), "Property is required for class CreateAirlineDgSessionRequest.");

            if (createAirlineDgSessionRequest.Language == null)
                throw new ArgumentNullException(nameof(createAirlineDgSessionRequest.Language), "Property is required for class CreateAirlineDgSessionRequest.");

            if (createAirlineDgSessionRequest.UserInfoOption.IsSet && createAirlineDgSessionRequest.UserInfo == null)
                throw new ArgumentNullException(nameof(createAirlineDgSessionRequest.UserInfo), "Property is required for class CreateAirlineDgSessionRequest.");

            if (createAirlineDgSessionRequest.DeviceOption.IsSet && createAirlineDgSessionRequest.Device == null)
                throw new ArgumentNullException(nameof(createAirlineDgSessionRequest.Device), "Property is required for class CreateAirlineDgSessionRequest.");

            if (createAirlineDgSessionRequest.SessionIdOption.IsSet && createAirlineDgSessionRequest.SessionId == null)
                throw new ArgumentNullException(nameof(createAirlineDgSessionRequest.SessionId), "Property is required for class CreateAirlineDgSessionRequest.");

            writer.WriteString("point_of_sale", createAirlineDgSessionRequest.PointOfSale);

            writer.WriteString("language", createAirlineDgSessionRequest.Language);

            if (createAirlineDgSessionRequest.UserInfoOption.IsSet)
            {
                writer.WritePropertyName("user_info");
                JsonSerializer.Serialize(writer, createAirlineDgSessionRequest.UserInfo, jsonSerializerOptions);
            }
            if (createAirlineDgSessionRequest.DeviceOption.IsSet)
            {
                writer.WritePropertyName("device");
                JsonSerializer.Serialize(writer, createAirlineDgSessionRequest.Device, jsonSerializerOptions);
            }
            if (createAirlineDgSessionRequest.SessionIdOption.IsSet)
                writer.WriteString("session_id", createAirlineDgSessionRequest.SessionId);
        }
    }
}
