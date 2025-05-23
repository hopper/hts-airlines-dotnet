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
    /// CfarCreateExercisePassengerPricing
    /// </summary>
    public partial class CfarCreateExercisePassengerPricing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarCreateExercisePassengerPricing" /> class.
        /// </summary>
        /// <param name="passengerCount">passengerCount</param>
        /// <param name="individualPrice">Price per passenger (excluding ancillaries)</param>
        /// <param name="taxes">Taxes applicable per passenger</param>
        [JsonConstructor]
        public CfarCreateExercisePassengerPricing(PassengerCount passengerCount, Option<string?> individualPrice = default, Option<List<CfarPassengerTax>?> taxes = default)
        {
            PassengerCount = passengerCount;
            IndividualPriceOption = individualPrice;
            TaxesOption = taxes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PassengerCount
        /// </summary>
        [JsonPropertyName("passenger_count")]
        public PassengerCount PassengerCount { get; set; }

        /// <summary>
        /// Used to track the state of IndividualPrice
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IndividualPriceOption { get; private set; }

        /// <summary>
        /// Price per passenger (excluding ancillaries)
        /// </summary>
        /// <value>Price per passenger (excluding ancillaries)</value>
        /* <example>200.55</example> */
        [JsonPropertyName("individual_price")]
        public string? IndividualPrice { get { return this.IndividualPriceOption; } set { this.IndividualPriceOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Taxes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<CfarPassengerTax>?> TaxesOption { get; private set; }

        /// <summary>
        /// Taxes applicable per passenger
        /// </summary>
        /// <value>Taxes applicable per passenger</value>
        [JsonPropertyName("taxes")]
        public List<CfarPassengerTax>? Taxes { get { return this.TaxesOption; } set { this.TaxesOption = new Option<List<CfarPassengerTax>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarCreateExercisePassengerPricing {\n");
            sb.Append("  PassengerCount: ").Append(PassengerCount).Append("\n");
            sb.Append("  IndividualPrice: ").Append(IndividualPrice).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CfarCreateExercisePassengerPricing" />
    /// </summary>
    public class CfarCreateExercisePassengerPricingJsonConverter : JsonConverter<CfarCreateExercisePassengerPricing>
    {
        /// <summary>
        /// Deserializes json to <see cref="CfarCreateExercisePassengerPricing" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CfarCreateExercisePassengerPricing Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PassengerCount?> passengerCount = default;
            Option<string?> individualPrice = default;
            Option<List<CfarPassengerTax>?> taxes = default;

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
                        case "passenger_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passengerCount = new Option<PassengerCount?>(JsonSerializer.Deserialize<PassengerCount>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "individual_price":
                            individualPrice = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "taxes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                taxes = new Option<List<CfarPassengerTax>?>(JsonSerializer.Deserialize<List<CfarPassengerTax>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!passengerCount.IsSet)
                throw new ArgumentException("Property is required for class CfarCreateExercisePassengerPricing.", nameof(passengerCount));

            if (passengerCount.IsSet && passengerCount.Value == null)
                throw new ArgumentNullException(nameof(passengerCount), "Property is not nullable for class CfarCreateExercisePassengerPricing.");

            if (individualPrice.IsSet && individualPrice.Value == null)
                throw new ArgumentNullException(nameof(individualPrice), "Property is not nullable for class CfarCreateExercisePassengerPricing.");

            if (taxes.IsSet && taxes.Value == null)
                throw new ArgumentNullException(nameof(taxes), "Property is not nullable for class CfarCreateExercisePassengerPricing.");

            return new CfarCreateExercisePassengerPricing(passengerCount.Value!, individualPrice, taxes);
        }

        /// <summary>
        /// Serializes a <see cref="CfarCreateExercisePassengerPricing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarCreateExercisePassengerPricing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CfarCreateExercisePassengerPricing cfarCreateExercisePassengerPricing, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, cfarCreateExercisePassengerPricing, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CfarCreateExercisePassengerPricing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarCreateExercisePassengerPricing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CfarCreateExercisePassengerPricing cfarCreateExercisePassengerPricing, JsonSerializerOptions jsonSerializerOptions)
        {
            if (cfarCreateExercisePassengerPricing.PassengerCount == null)
                throw new ArgumentNullException(nameof(cfarCreateExercisePassengerPricing.PassengerCount), "Property is required for class CfarCreateExercisePassengerPricing.");

            if (cfarCreateExercisePassengerPricing.IndividualPriceOption.IsSet && cfarCreateExercisePassengerPricing.IndividualPrice == null)
                throw new ArgumentNullException(nameof(cfarCreateExercisePassengerPricing.IndividualPrice), "Property is required for class CfarCreateExercisePassengerPricing.");

            if (cfarCreateExercisePassengerPricing.TaxesOption.IsSet && cfarCreateExercisePassengerPricing.Taxes == null)
                throw new ArgumentNullException(nameof(cfarCreateExercisePassengerPricing.Taxes), "Property is required for class CfarCreateExercisePassengerPricing.");

            writer.WritePropertyName("passenger_count");
            JsonSerializer.Serialize(writer, cfarCreateExercisePassengerPricing.PassengerCount, jsonSerializerOptions);
            if (cfarCreateExercisePassengerPricing.IndividualPriceOption.IsSet)
                writer.WriteString("individual_price", cfarCreateExercisePassengerPricing.IndividualPrice);

            if (cfarCreateExercisePassengerPricing.TaxesOption.IsSet)
            {
                writer.WritePropertyName("taxes");
                JsonSerializer.Serialize(writer, cfarCreateExercisePassengerPricing.Taxes, jsonSerializerOptions);
            }
        }
    }
}
