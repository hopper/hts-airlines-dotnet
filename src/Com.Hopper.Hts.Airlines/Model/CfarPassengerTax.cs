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
    /// CfarPassengerTax
    /// </summary>
    public partial class CfarPassengerTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarPassengerTax" /> class.
        /// </summary>
        /// <param name="code">Code of the tax</param>
        /// <param name="amount">The amount of the tax</param>
        /// <param name="currency">The currency of the tax</param>
        [JsonConstructor]
        public CfarPassengerTax(string code, string amount, string currency)
        {
            Code = code;
            Amount = amount;
            Currency = currency;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Code of the tax
        /// </summary>
        /// <value>Code of the tax</value>
        /* <example>RC</example> */
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The amount of the tax
        /// </summary>
        /// <value>The amount of the tax</value>
        /* <example>0.20</example> */
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The currency of the tax
        /// </summary>
        /// <value>The currency of the tax</value>
        /* <example>CAD</example> */
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarPassengerTax {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CfarPassengerTax" />
    /// </summary>
    public class CfarPassengerTaxJsonConverter : JsonConverter<CfarPassengerTax>
    {
        /// <summary>
        /// Deserializes json to <see cref="CfarPassengerTax" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CfarPassengerTax Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> code = default;
            Option<string?> amount = default;
            Option<string?> currency = default;

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
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "amount":
                            amount = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "currency":
                            currency = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!code.IsSet)
                throw new ArgumentException("Property is required for class CfarPassengerTax.", nameof(code));

            if (!amount.IsSet)
                throw new ArgumentException("Property is required for class CfarPassengerTax.", nameof(amount));

            if (!currency.IsSet)
                throw new ArgumentException("Property is required for class CfarPassengerTax.", nameof(currency));

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class CfarPassengerTax.");

            if (amount.IsSet && amount.Value == null)
                throw new ArgumentNullException(nameof(amount), "Property is not nullable for class CfarPassengerTax.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class CfarPassengerTax.");

            return new CfarPassengerTax(code.Value!, amount.Value!, currency.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CfarPassengerTax" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarPassengerTax"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CfarPassengerTax cfarPassengerTax, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, cfarPassengerTax, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CfarPassengerTax" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarPassengerTax"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CfarPassengerTax cfarPassengerTax, JsonSerializerOptions jsonSerializerOptions)
        {
            if (cfarPassengerTax.Code == null)
                throw new ArgumentNullException(nameof(cfarPassengerTax.Code), "Property is required for class CfarPassengerTax.");

            if (cfarPassengerTax.Amount == null)
                throw new ArgumentNullException(nameof(cfarPassengerTax.Amount), "Property is required for class CfarPassengerTax.");

            if (cfarPassengerTax.Currency == null)
                throw new ArgumentNullException(nameof(cfarPassengerTax.Currency), "Property is required for class CfarPassengerTax.");

            writer.WriteString("code", cfarPassengerTax.Code);

            writer.WriteString("amount", cfarPassengerTax.Amount);

            writer.WriteString("currency", cfarPassengerTax.Currency);
        }
    }
}
