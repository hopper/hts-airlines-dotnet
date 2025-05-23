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
    /// Web
    /// </summary>
    public partial class Web
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="varOperatingSystem">varOperatingSystem</param>
        /// <param name="browser">browser</param>
        [JsonConstructor]
        public Web(string type, Option<ModelOperatingSystem?> varOperatingSystem = default, Option<Browser?> browser = default)
        {
            Type = type;
            VarOperatingSystemOption = varOperatingSystem;
            BrowserOption = browser;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /* <example>app</example> */
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Used to track the state of VarOperatingSystem
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ModelOperatingSystem?> VarOperatingSystemOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarOperatingSystem
        /// </summary>
        [JsonPropertyName("operating_system")]
        public ModelOperatingSystem? VarOperatingSystem { get { return this.VarOperatingSystemOption; } set { this.VarOperatingSystemOption = new Option<ModelOperatingSystem?>(value); } }

        /// <summary>
        /// Used to track the state of Browser
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Browser?> BrowserOption { get; private set; }

        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [JsonPropertyName("browser")]
        public Browser? Browser { get { return this.BrowserOption; } set { this.BrowserOption = new Option<Browser?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Web {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarOperatingSystem: ").Append(VarOperatingSystem).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Web" />
    /// </summary>
    public class WebJsonConverter : JsonConverter<Web>
    {
        /// <summary>
        /// Deserializes json to <see cref="Web" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Web Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> type = default;
            Option<ModelOperatingSystem?> varOperatingSystem = default;
            Option<Browser?> browser = default;

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
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "operating_system":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varOperatingSystem = new Option<ModelOperatingSystem?>(JsonSerializer.Deserialize<ModelOperatingSystem>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "browser":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                browser = new Option<Browser?>(JsonSerializer.Deserialize<Browser>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class Web.", nameof(type));

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class Web.");

            if (varOperatingSystem.IsSet && varOperatingSystem.Value == null)
                throw new ArgumentNullException(nameof(varOperatingSystem), "Property is not nullable for class Web.");

            if (browser.IsSet && browser.Value == null)
                throw new ArgumentNullException(nameof(browser), "Property is not nullable for class Web.");

            return new Web(type.Value!, varOperatingSystem, browser);
        }

        /// <summary>
        /// Serializes a <see cref="Web" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="web"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Web web, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, web, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Web" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="web"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Web web, JsonSerializerOptions jsonSerializerOptions)
        {
            if (web.Type == null)
                throw new ArgumentNullException(nameof(web.Type), "Property is required for class Web.");

            if (web.VarOperatingSystemOption.IsSet && web.VarOperatingSystem == null)
                throw new ArgumentNullException(nameof(web.VarOperatingSystem), "Property is required for class Web.");

            if (web.BrowserOption.IsSet && web.Browser == null)
                throw new ArgumentNullException(nameof(web.Browser), "Property is required for class Web.");

            writer.WriteString("type", web.Type);

            if (web.VarOperatingSystemOption.IsSet)
            {
                writer.WritePropertyName("operating_system");
                JsonSerializer.Serialize(writer, web.VarOperatingSystem, jsonSerializerOptions);
            }
            if (web.BrowserOption.IsSet)
            {
                writer.WritePropertyName("browser");
                JsonSerializer.Serialize(writer, web.Browser, jsonSerializerOptions);
            }
        }
    }
}
