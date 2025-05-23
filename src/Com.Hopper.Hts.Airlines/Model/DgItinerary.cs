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
    /// DgItinerary
    /// </summary>
    public partial class DgItinerary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgItinerary" /> class.
        /// </summary>
        /// <param name="passengerPricing">List of passengers type, count and pricing for the itinerary</param>
        /// <param name="currency">Currency of pricing fields</param>
        /// <param name="slices">List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed</param>
        /// <param name="ancillaries">Ancillaries attached to the itinerary and their prices</param>
        /// <param name="totalPrice">Total price of the itinerary</param>
        /// <param name="passengers">Details of the passengers</param>
        [JsonConstructor]
        public DgItinerary(List<DgPassengerPricing> passengerPricing, string currency, List<DgItinerarySlice> slices, Option<List<DgAncillary>?> ancillaries = default, Option<string?> totalPrice = default, Option<List<DgPassenger>?> passengers = default)
        {
            PassengerPricing = passengerPricing;
            Currency = currency;
            Slices = slices;
            AncillariesOption = ancillaries;
            TotalPriceOption = totalPrice;
            PassengersOption = passengers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// List of passengers type, count and pricing for the itinerary
        /// </summary>
        /// <value>List of passengers type, count and pricing for the itinerary</value>
        [JsonPropertyName("passenger_pricing")]
        public List<DgPassengerPricing> PassengerPricing { get; set; }

        /// <summary>
        /// Currency of pricing fields
        /// </summary>
        /// <value>Currency of pricing fields</value>
        /* <example>CAD</example> */
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed
        /// </summary>
        /// <value>List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed</value>
        [JsonPropertyName("slices")]
        public List<DgItinerarySlice> Slices { get; set; }

        /// <summary>
        /// Used to track the state of Ancillaries
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DgAncillary>?> AncillariesOption { get; private set; }

        /// <summary>
        /// Ancillaries attached to the itinerary and their prices
        /// </summary>
        /// <value>Ancillaries attached to the itinerary and their prices</value>
        [JsonPropertyName("ancillaries")]
        public List<DgAncillary>? Ancillaries { get { return this.AncillariesOption; } set { this.AncillariesOption = new Option<List<DgAncillary>?>(value); } }

        /// <summary>
        /// Used to track the state of TotalPrice
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TotalPriceOption { get; private set; }

        /// <summary>
        /// Total price of the itinerary
        /// </summary>
        /// <value>Total price of the itinerary</value>
        /* <example>401.10</example> */
        [JsonPropertyName("total_price")]
        public string? TotalPrice { get { return this.TotalPriceOption; } set { this.TotalPriceOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Passengers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DgPassenger>?> PassengersOption { get; private set; }

        /// <summary>
        /// Details of the passengers
        /// </summary>
        /// <value>Details of the passengers</value>
        [JsonPropertyName("passengers")]
        public List<DgPassenger>? Passengers { get { return this.PassengersOption; } set { this.PassengersOption = new Option<List<DgPassenger>?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgItinerary {\n");
            sb.Append("  PassengerPricing: ").Append(PassengerPricing).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Slices: ").Append(Slices).Append("\n");
            sb.Append("  Ancillaries: ").Append(Ancillaries).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Passengers: ").Append(Passengers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DgItinerary" />
    /// </summary>
    public class DgItineraryJsonConverter : JsonConverter<DgItinerary>
    {
        /// <summary>
        /// Deserializes json to <see cref="DgItinerary" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DgItinerary Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<DgPassengerPricing>?> passengerPricing = default;
            Option<string?> currency = default;
            Option<List<DgItinerarySlice>?> slices = default;
            Option<List<DgAncillary>?> ancillaries = default;
            Option<string?> totalPrice = default;
            Option<List<DgPassenger>?> passengers = default;

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
                        case "passenger_pricing":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passengerPricing = new Option<List<DgPassengerPricing>?>(JsonSerializer.Deserialize<List<DgPassengerPricing>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "currency":
                            currency = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "slices":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                slices = new Option<List<DgItinerarySlice>?>(JsonSerializer.Deserialize<List<DgItinerarySlice>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "ancillaries":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ancillaries = new Option<List<DgAncillary>?>(JsonSerializer.Deserialize<List<DgAncillary>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "total_price":
                            totalPrice = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "passengers":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passengers = new Option<List<DgPassenger>?>(JsonSerializer.Deserialize<List<DgPassenger>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!passengerPricing.IsSet)
                throw new ArgumentException("Property is required for class DgItinerary.", nameof(passengerPricing));

            if (!currency.IsSet)
                throw new ArgumentException("Property is required for class DgItinerary.", nameof(currency));

            if (!slices.IsSet)
                throw new ArgumentException("Property is required for class DgItinerary.", nameof(slices));

            if (passengerPricing.IsSet && passengerPricing.Value == null)
                throw new ArgumentNullException(nameof(passengerPricing), "Property is not nullable for class DgItinerary.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class DgItinerary.");

            if (slices.IsSet && slices.Value == null)
                throw new ArgumentNullException(nameof(slices), "Property is not nullable for class DgItinerary.");

            if (ancillaries.IsSet && ancillaries.Value == null)
                throw new ArgumentNullException(nameof(ancillaries), "Property is not nullable for class DgItinerary.");

            if (totalPrice.IsSet && totalPrice.Value == null)
                throw new ArgumentNullException(nameof(totalPrice), "Property is not nullable for class DgItinerary.");

            if (passengers.IsSet && passengers.Value == null)
                throw new ArgumentNullException(nameof(passengers), "Property is not nullable for class DgItinerary.");

            return new DgItinerary(passengerPricing.Value!, currency.Value!, slices.Value!, ancillaries, totalPrice, passengers);
        }

        /// <summary>
        /// Serializes a <see cref="DgItinerary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgItinerary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DgItinerary dgItinerary, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dgItinerary, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DgItinerary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgItinerary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DgItinerary dgItinerary, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dgItinerary.PassengerPricing == null)
                throw new ArgumentNullException(nameof(dgItinerary.PassengerPricing), "Property is required for class DgItinerary.");

            if (dgItinerary.Currency == null)
                throw new ArgumentNullException(nameof(dgItinerary.Currency), "Property is required for class DgItinerary.");

            if (dgItinerary.Slices == null)
                throw new ArgumentNullException(nameof(dgItinerary.Slices), "Property is required for class DgItinerary.");

            if (dgItinerary.AncillariesOption.IsSet && dgItinerary.Ancillaries == null)
                throw new ArgumentNullException(nameof(dgItinerary.Ancillaries), "Property is required for class DgItinerary.");

            if (dgItinerary.TotalPriceOption.IsSet && dgItinerary.TotalPrice == null)
                throw new ArgumentNullException(nameof(dgItinerary.TotalPrice), "Property is required for class DgItinerary.");

            if (dgItinerary.PassengersOption.IsSet && dgItinerary.Passengers == null)
                throw new ArgumentNullException(nameof(dgItinerary.Passengers), "Property is required for class DgItinerary.");

            writer.WritePropertyName("passenger_pricing");
            JsonSerializer.Serialize(writer, dgItinerary.PassengerPricing, jsonSerializerOptions);
            writer.WriteString("currency", dgItinerary.Currency);

            writer.WritePropertyName("slices");
            JsonSerializer.Serialize(writer, dgItinerary.Slices, jsonSerializerOptions);
            if (dgItinerary.AncillariesOption.IsSet)
            {
                writer.WritePropertyName("ancillaries");
                JsonSerializer.Serialize(writer, dgItinerary.Ancillaries, jsonSerializerOptions);
            }
            if (dgItinerary.TotalPriceOption.IsSet)
                writer.WriteString("total_price", dgItinerary.TotalPrice);

            if (dgItinerary.PassengersOption.IsSet)
            {
                writer.WritePropertyName("passengers");
                JsonSerializer.Serialize(writer, dgItinerary.Passengers, jsonSerializerOptions);
            }
        }
    }
}
