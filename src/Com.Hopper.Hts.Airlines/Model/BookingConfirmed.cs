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
    /// BookingConfirmed
    /// </summary>
    public partial class BookingConfirmed
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingConfirmed" /> class.
        /// </summary>
        /// <param name="occurredDateTime">A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device</param>
        /// <param name="type">type</param>
        /// <param name="cfarContractId">The purchased CFAR contract, if one is present</param>
        /// <param name="dgContractId">The purchased DG contract, if one is present</param>
        [JsonConstructor]
        public BookingConfirmed(DateTime occurredDateTime, string type, Option<string?> cfarContractId = default, Option<string?> dgContractId = default)
        {
            OccurredDateTime = occurredDateTime;
            Type = type;
            CfarContractIdOption = cfarContractId;
            DgContractIdOption = dgContractId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device
        /// </summary>
        /// <value>A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device</value>
        /* <example>2022-01-24T15:34:30Z</example> */
        [JsonPropertyName("occurred_date_time")]
        public DateTime OccurredDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Used to track the state of CfarContractId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CfarContractIdOption { get; private set; }

        /// <summary>
        /// The purchased CFAR contract, if one is present
        /// </summary>
        /// <value>The purchased CFAR contract, if one is present</value>
        [JsonPropertyName("cfar_contract_id")]
        public string? CfarContractId { get { return this.CfarContractIdOption; } set { this.CfarContractIdOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of DgContractId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DgContractIdOption { get; private set; }

        /// <summary>
        /// The purchased DG contract, if one is present
        /// </summary>
        /// <value>The purchased DG contract, if one is present</value>
        [JsonPropertyName("dg_contract_id")]
        public string? DgContractId { get { return this.DgContractIdOption; } set { this.DgContractIdOption = new Option<string?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BookingConfirmed {\n");
            sb.Append("  OccurredDateTime: ").Append(OccurredDateTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CfarContractId: ").Append(CfarContractId).Append("\n");
            sb.Append("  DgContractId: ").Append(DgContractId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="BookingConfirmed" />
    /// </summary>
    public class BookingConfirmedJsonConverter : JsonConverter<BookingConfirmed>
    {
        /// <summary>
        /// The format to use to serialize OccurredDateTime
        /// </summary>
        public static string OccurredDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="BookingConfirmed" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BookingConfirmed Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> occurredDateTime = default;
            Option<string?> type = default;
            Option<string?> cfarContractId = default;
            Option<string?> dgContractId = default;

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
                        case "occurred_date_time":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                occurredDateTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "cfar_contract_id":
                            cfarContractId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "dg_contract_id":
                            dgContractId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!occurredDateTime.IsSet)
                throw new ArgumentException("Property is required for class BookingConfirmed.", nameof(occurredDateTime));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class BookingConfirmed.", nameof(type));

            if (occurredDateTime.IsSet && occurredDateTime.Value == null)
                throw new ArgumentNullException(nameof(occurredDateTime), "Property is not nullable for class BookingConfirmed.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class BookingConfirmed.");

            if (cfarContractId.IsSet && cfarContractId.Value == null)
                throw new ArgumentNullException(nameof(cfarContractId), "Property is not nullable for class BookingConfirmed.");

            if (dgContractId.IsSet && dgContractId.Value == null)
                throw new ArgumentNullException(nameof(dgContractId), "Property is not nullable for class BookingConfirmed.");

            return new BookingConfirmed(occurredDateTime.Value!.Value!, type.Value!, cfarContractId, dgContractId);
        }

        /// <summary>
        /// Serializes a <see cref="BookingConfirmed" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bookingConfirmed"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BookingConfirmed bookingConfirmed, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bookingConfirmed, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BookingConfirmed" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bookingConfirmed"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BookingConfirmed bookingConfirmed, JsonSerializerOptions jsonSerializerOptions)
        {
            if (bookingConfirmed.Type == null)
                throw new ArgumentNullException(nameof(bookingConfirmed.Type), "Property is required for class BookingConfirmed.");

            if (bookingConfirmed.CfarContractIdOption.IsSet && bookingConfirmed.CfarContractId == null)
                throw new ArgumentNullException(nameof(bookingConfirmed.CfarContractId), "Property is required for class BookingConfirmed.");

            if (bookingConfirmed.DgContractIdOption.IsSet && bookingConfirmed.DgContractId == null)
                throw new ArgumentNullException(nameof(bookingConfirmed.DgContractId), "Property is required for class BookingConfirmed.");

            writer.WriteString("occurred_date_time", bookingConfirmed.OccurredDateTime.ToString(OccurredDateTimeFormat));

            writer.WriteString("type", bookingConfirmed.Type);

            if (bookingConfirmed.CfarContractIdOption.IsSet)
                writer.WriteString("cfar_contract_id", bookingConfirmed.CfarContractId);

            if (bookingConfirmed.DgContractIdOption.IsSet)
                writer.WriteString("dg_contract_id", bookingConfirmed.DgContractId);
        }
    }
}
