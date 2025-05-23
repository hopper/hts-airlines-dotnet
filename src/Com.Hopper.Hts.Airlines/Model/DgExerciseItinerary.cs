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
    /// Itinerary of the user when the contract exercise was initiated (only active segments should be provided)
    /// </summary>
    public partial class DgExerciseItinerary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgExerciseItinerary" /> class.
        /// </summary>
        /// <param name="passengerCount">List of passengers type and count for the itinerary</param>
        /// <param name="slices">List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed</param>
        /// <param name="passengers">Details of the passengers</param>
        [JsonConstructor]
        public DgExerciseItinerary(List<DgPassengerCount> passengerCount, List<DgExerciseItinerarySlice> slices, Option<List<DgPassenger>?> passengers = default)
        {
            PassengerCount = passengerCount;
            Slices = slices;
            PassengersOption = passengers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// List of passengers type and count for the itinerary
        /// </summary>
        /// <value>List of passengers type and count for the itinerary</value>
        [JsonPropertyName("passenger_count")]
        public List<DgPassengerCount> PassengerCount { get; set; }

        /// <summary>
        /// List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed
        /// </summary>
        /// <value>List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed</value>
        [JsonPropertyName("slices")]
        public List<DgExerciseItinerarySlice> Slices { get; set; }

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
            sb.Append("class DgExerciseItinerary {\n");
            sb.Append("  PassengerCount: ").Append(PassengerCount).Append("\n");
            sb.Append("  Slices: ").Append(Slices).Append("\n");
            sb.Append("  Passengers: ").Append(Passengers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DgExerciseItinerary" />
    /// </summary>
    public class DgExerciseItineraryJsonConverter : JsonConverter<DgExerciseItinerary>
    {
        /// <summary>
        /// Deserializes json to <see cref="DgExerciseItinerary" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DgExerciseItinerary Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<DgPassengerCount>?> passengerCount = default;
            Option<List<DgExerciseItinerarySlice>?> slices = default;
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
                        case "passenger_count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                passengerCount = new Option<List<DgPassengerCount>?>(JsonSerializer.Deserialize<List<DgPassengerCount>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "slices":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                slices = new Option<List<DgExerciseItinerarySlice>?>(JsonSerializer.Deserialize<List<DgExerciseItinerarySlice>>(ref utf8JsonReader, jsonSerializerOptions)!);
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

            if (!passengerCount.IsSet)
                throw new ArgumentException("Property is required for class DgExerciseItinerary.", nameof(passengerCount));

            if (!slices.IsSet)
                throw new ArgumentException("Property is required for class DgExerciseItinerary.", nameof(slices));

            if (passengerCount.IsSet && passengerCount.Value == null)
                throw new ArgumentNullException(nameof(passengerCount), "Property is not nullable for class DgExerciseItinerary.");

            if (slices.IsSet && slices.Value == null)
                throw new ArgumentNullException(nameof(slices), "Property is not nullable for class DgExerciseItinerary.");

            if (passengers.IsSet && passengers.Value == null)
                throw new ArgumentNullException(nameof(passengers), "Property is not nullable for class DgExerciseItinerary.");

            return new DgExerciseItinerary(passengerCount.Value!, slices.Value!, passengers);
        }

        /// <summary>
        /// Serializes a <see cref="DgExerciseItinerary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgExerciseItinerary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DgExerciseItinerary dgExerciseItinerary, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dgExerciseItinerary, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DgExerciseItinerary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dgExerciseItinerary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DgExerciseItinerary dgExerciseItinerary, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dgExerciseItinerary.PassengerCount == null)
                throw new ArgumentNullException(nameof(dgExerciseItinerary.PassengerCount), "Property is required for class DgExerciseItinerary.");

            if (dgExerciseItinerary.Slices == null)
                throw new ArgumentNullException(nameof(dgExerciseItinerary.Slices), "Property is required for class DgExerciseItinerary.");

            if (dgExerciseItinerary.PassengersOption.IsSet && dgExerciseItinerary.Passengers == null)
                throw new ArgumentNullException(nameof(dgExerciseItinerary.Passengers), "Property is required for class DgExerciseItinerary.");

            writer.WritePropertyName("passenger_count");
            JsonSerializer.Serialize(writer, dgExerciseItinerary.PassengerCount, jsonSerializerOptions);
            writer.WritePropertyName("slices");
            JsonSerializer.Serialize(writer, dgExerciseItinerary.Slices, jsonSerializerOptions);
            if (dgExerciseItinerary.PassengersOption.IsSet)
            {
                writer.WritePropertyName("passengers");
                JsonSerializer.Serialize(writer, dgExerciseItinerary.Passengers, jsonSerializerOptions);
            }
        }
    }
}
