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
    /// DgContents
    /// </summary>
    public partial class DgContents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgContents" /> class.
        /// </summary>
        /// <param name="bulletPoints">An array containing the bullet points to be displayed</param>
        /// <param name="labels">labels</param>
        [JsonConstructor]
        public DgContents(List<string> bulletPoints, Dictionary<string, string> labels)
        {
            BulletPoints = bulletPoints;
            Labels = labels;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// An array containing the bullet points to be displayed
        /// </summary>
        /// <value>An array containing the bullet points to be displayed</value>
        [JsonPropertyName("bullet_points")]
        public List<string> BulletPoints { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [JsonPropertyName("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgContents {\n");
            sb.Append("  BulletPoints: ").Append(BulletPoints).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DgContents" />
    /// </summary>
    public class DgContentsJsonConverter : JsonConverter<DgContents>
    {
        /// <summary>
        /// Deserializes json to <see cref="DgContents" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DgContents Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> bulletPoints = default;
            Option<Dictionary<string, string>?> labels = default;

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
                        case "bullet_points":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bulletPoints = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "labels":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                labels = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!bulletPoints.IsSet)
                throw new ArgumentException("Property is required for class DgContents.", nameof(bulletPoints));

            if (!labels.IsSet)
                throw new ArgumentException("Property is required for class DgContents.", nameof(labels));

            if (bulletPoints.IsSet && bulletPoints.Value == null)
                throw new ArgumentNullException(nameof(bulletPoints), "Property is not nullable for class DgContents.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class DgContents.");

            return new DgContents(bulletPoints.Value!, labels.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="DgContents" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgContents"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DgContents dgContents, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dgContents, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DgContents" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgContents"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DgContents dgContents, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dgContents.BulletPoints == null)
                throw new ArgumentNullException(nameof(dgContents.BulletPoints), "Property is required for class DgContents.");

            if (dgContents.Labels == null)
                throw new ArgumentNullException(nameof(dgContents.Labels), "Property is required for class DgContents.");

            writer.WritePropertyName("bullet_points");
            JsonSerializer.Serialize(writer, dgContents.BulletPoints, jsonSerializerOptions);
            writer.WritePropertyName("labels");
            JsonSerializer.Serialize(writer, dgContents.Labels, jsonSerializerOptions);
        }
    }
}
