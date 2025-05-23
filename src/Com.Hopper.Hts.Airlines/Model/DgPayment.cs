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
    /// DgPayment
    /// </summary>
    public partial class DgPayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgPayment" /> class.
        /// </summary>
        /// <param name="succeeded">Indicates if the transaction is successful</param>
        [JsonConstructor]
        public DgPayment(bool succeeded)
        {
            Succeeded = succeeded;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Indicates if the transaction is successful
        /// </summary>
        /// <value>Indicates if the transaction is successful</value>
        /* <example>true</example> */
        [JsonPropertyName("succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgPayment {\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DgPayment" />
    /// </summary>
    public class DgPaymentJsonConverter : JsonConverter<DgPayment>
    {
        /// <summary>
        /// Deserializes json to <see cref="DgPayment" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DgPayment Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> succeeded = default;

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
                        case "succeeded":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                succeeded = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!succeeded.IsSet)
                throw new ArgumentException("Property is required for class DgPayment.", nameof(succeeded));

            if (succeeded.IsSet && succeeded.Value == null)
                throw new ArgumentNullException(nameof(succeeded), "Property is not nullable for class DgPayment.");

            return new DgPayment(succeeded.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="DgPayment" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgPayment"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DgPayment dgPayment, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dgPayment, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DgPayment" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgPayment"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DgPayment dgPayment, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteBoolean("succeeded", dgPayment.Succeeded);
        }
    }
}
