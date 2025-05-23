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
    /// Desktop
    /// </summary>
    public partial class Desktop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Desktop" /> class.
        /// </summary>
        /// <param name="id">A unique identifier for the end-user&#39;s device, generated by the partner</param>
        /// <param name="type">type</param>
        /// <param name="platform">platform</param>
        [JsonConstructor]
        public Desktop(string id, string type, Option<Platform?> platform = default)
        {
            Id = id;
            Type = type;
            PlatformOption = platform;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A unique identifier for the end-user&#39;s device, generated by the partner
        /// </summary>
        /// <value>A unique identifier for the end-user&#39;s device, generated by the partner</value>
        /* <example>eb2dddb7-dc69-4521-9fbb-762b96eb921f</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /* <example>mobile</example> */
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Used to track the state of Platform
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Platform?> PlatformOption { get; private set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [JsonPropertyName("platform")]
        public Platform? Platform { get { return this.PlatformOption; } set { this.PlatformOption = new Option<Platform?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Desktop {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Desktop" />
    /// </summary>
    public class DesktopJsonConverter : JsonConverter<Desktop>
    {
        /// <summary>
        /// Deserializes json to <see cref="Desktop" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Desktop Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> type = default;
            Option<Platform?> platform = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "platform":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                platform = new Option<Platform?>(JsonSerializer.Deserialize<Platform>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Desktop.", nameof(id));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class Desktop.", nameof(type));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Desktop.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class Desktop.");

            if (platform.IsSet && platform.Value == null)
                throw new ArgumentNullException(nameof(platform), "Property is not nullable for class Desktop.");

            return new Desktop(id.Value!, type.Value!, platform);
        }

        /// <summary>
        /// Serializes a <see cref="Desktop" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="desktop"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Desktop desktop, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, desktop, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Desktop" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="desktop"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Desktop desktop, JsonSerializerOptions jsonSerializerOptions)
        {
            if (desktop.Id == null)
                throw new ArgumentNullException(nameof(desktop.Id), "Property is required for class Desktop.");

            if (desktop.Type == null)
                throw new ArgumentNullException(nameof(desktop.Type), "Property is required for class Desktop.");

            if (desktop.PlatformOption.IsSet && desktop.Platform == null)
                throw new ArgumentNullException(nameof(desktop.Platform), "Property is required for class Desktop.");

            writer.WriteString("id", desktop.Id);

            writer.WriteString("type", desktop.Type);

            if (desktop.PlatformOption.IsSet)
            {
                writer.WritePropertyName("platform");
                JsonSerializer.Serialize(writer, desktop.Platform, jsonSerializerOptions);
            }
        }
    }
}
