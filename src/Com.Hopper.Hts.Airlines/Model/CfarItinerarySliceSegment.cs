/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Hopper.Hts.Airlines.Client.OpenAPIDateConverter;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// An object detailing a segment of a fare slice
    /// </summary>
    [DataContract(Name = "cfar_itinerary_slice_segment")]
    public partial class CfarItinerarySliceSegment : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FareClass
        /// </summary>
        [DataMember(Name = "fare_class", IsRequired = true, EmitDefaultValue = true)]
        public FareClass FareClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerarySliceSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarItinerarySliceSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerarySliceSegment" /> class.
        /// </summary>
        /// <param name="originAirport">IATA airport code of origin (required).</param>
        /// <param name="destinationAirport">IATA airport code of destination (required).</param>
        /// <param name="departureDateTime">The local date and time of departure in ISO Local Date Time format (required).</param>
        /// <param name="arrivalDateTime">The local date and time of arrival in ISO Local Date Time format (required).</param>
        /// <param name="flightNumber">The number of the flight (required).</param>
        /// <param name="validatingCarrierCode">The IATA airline code of the validating carrier for this segment (required).</param>
        /// <param name="fareClass">fareClass (required).</param>
        /// <param name="fareBrand">Name of the fare brand applied to the segment (if applicable).</param>
        public CfarItinerarySliceSegment(string originAirport = default(string), string destinationAirport = default(string), string departureDateTime = default(string), string arrivalDateTime = default(string), string flightNumber = default(string), string validatingCarrierCode = default(string), FareClass fareClass = default(FareClass), string fareBrand = default(string))
        {
            // to ensure "originAirport" is required (not null)
            if (originAirport == null)
            {
                throw new ArgumentNullException("originAirport is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.OriginAirport = originAirport;
            // to ensure "destinationAirport" is required (not null)
            if (destinationAirport == null)
            {
                throw new ArgumentNullException("destinationAirport is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.DestinationAirport = destinationAirport;
            // to ensure "departureDateTime" is required (not null)
            if (departureDateTime == null)
            {
                throw new ArgumentNullException("departureDateTime is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.DepartureDateTime = departureDateTime;
            // to ensure "arrivalDateTime" is required (not null)
            if (arrivalDateTime == null)
            {
                throw new ArgumentNullException("arrivalDateTime is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.ArrivalDateTime = arrivalDateTime;
            // to ensure "flightNumber" is required (not null)
            if (flightNumber == null)
            {
                throw new ArgumentNullException("flightNumber is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.FlightNumber = flightNumber;
            // to ensure "validatingCarrierCode" is required (not null)
            if (validatingCarrierCode == null)
            {
                throw new ArgumentNullException("validatingCarrierCode is a required property for CfarItinerarySliceSegment and cannot be null");
            }
            this.ValidatingCarrierCode = validatingCarrierCode;
            this.FareClass = fareClass;
            this.FareBrand = fareBrand;
        }

        /// <summary>
        /// IATA airport code of origin
        /// </summary>
        /// <value>IATA airport code of origin</value>
        /*
        <example>BOS</example>
        */
        [DataMember(Name = "origin_airport", IsRequired = true, EmitDefaultValue = true)]
        public string OriginAirport { get; set; }

        /// <summary>
        /// IATA airport code of destination
        /// </summary>
        /// <value>IATA airport code of destination</value>
        /*
        <example>LGA</example>
        */
        [DataMember(Name = "destination_airport", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationAirport { get; set; }

        /// <summary>
        /// The local date and time of departure in ISO Local Date Time format
        /// </summary>
        /// <value>The local date and time of departure in ISO Local Date Time format</value>
        /*
        <example>2022-04-02T18:34:30</example>
        */
        [DataMember(Name = "departure_date_time", IsRequired = true, EmitDefaultValue = true)]
        public string DepartureDateTime { get; set; }

        /// <summary>
        /// The local date and time of arrival in ISO Local Date Time format
        /// </summary>
        /// <value>The local date and time of arrival in ISO Local Date Time format</value>
        /*
        <example>2022-04-02T19:12:30</example>
        */
        [DataMember(Name = "arrival_date_time", IsRequired = true, EmitDefaultValue = true)]
        public string ArrivalDateTime { get; set; }

        /// <summary>
        /// The number of the flight
        /// </summary>
        /// <value>The number of the flight</value>
        /*
        <example>JB776</example>
        */
        [DataMember(Name = "flight_number", IsRequired = true, EmitDefaultValue = true)]
        public string FlightNumber { get; set; }

        /// <summary>
        /// The IATA airline code of the validating carrier for this segment
        /// </summary>
        /// <value>The IATA airline code of the validating carrier for this segment</value>
        /*
        <example>B6</example>
        */
        [DataMember(Name = "validating_carrier_code", IsRequired = true, EmitDefaultValue = true)]
        public string ValidatingCarrierCode { get; set; }

        /// <summary>
        /// Name of the fare brand applied to the segment (if applicable)
        /// </summary>
        /// <value>Name of the fare brand applied to the segment (if applicable)</value>
        [DataMember(Name = "fare_brand", EmitDefaultValue = false)]
        public string FareBrand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarItinerarySliceSegment {\n");
            sb.Append("  OriginAirport: ").Append(OriginAirport).Append("\n");
            sb.Append("  DestinationAirport: ").Append(DestinationAirport).Append("\n");
            sb.Append("  DepartureDateTime: ").Append(DepartureDateTime).Append("\n");
            sb.Append("  ArrivalDateTime: ").Append(ArrivalDateTime).Append("\n");
            sb.Append("  FlightNumber: ").Append(FlightNumber).Append("\n");
            sb.Append("  ValidatingCarrierCode: ").Append(ValidatingCarrierCode).Append("\n");
            sb.Append("  FareClass: ").Append(FareClass).Append("\n");
            sb.Append("  FareBrand: ").Append(FareBrand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.OriginAirport != null) {
                // OriginAirport (string) pattern
                Regex regexOriginAirport = new Regex(@"[A-Z]{3}", RegexOptions.CultureInvariant);
                if (!regexOriginAirport.Match(this.OriginAirport).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginAirport, must match a pattern of " + regexOriginAirport, new [] { "OriginAirport" });
                }
            }

            if (this.DestinationAirport != null) {
                // DestinationAirport (string) pattern
                Regex regexDestinationAirport = new Regex(@"[A-Z]{3}", RegexOptions.CultureInvariant);
                if (!regexDestinationAirport.Match(this.DestinationAirport).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DestinationAirport, must match a pattern of " + regexDestinationAirport, new [] { "DestinationAirport" });
                }
            }

            if (this.FlightNumber != null) {
                // FlightNumber (string) pattern
                Regex regexFlightNumber = new Regex(@"([A-Z][0-9]{2,5}|[0-9]{1,4}|[0-9][A-Z][0-9]{1,4}|[A-Z]{2}[0-9]{1,4})", RegexOptions.CultureInvariant);
                if (!regexFlightNumber.Match(this.FlightNumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlightNumber, must match a pattern of " + regexFlightNumber, new [] { "FlightNumber" });
                }
            }

            if (this.ValidatingCarrierCode != null) {
                // ValidatingCarrierCode (string) pattern
                Regex regexValidatingCarrierCode = new Regex(@"[A-Z0-9]{2}", RegexOptions.CultureInvariant);
                if (!regexValidatingCarrierCode.Match(this.ValidatingCarrierCode).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ValidatingCarrierCode, must match a pattern of " + regexValidatingCarrierCode, new [] { "ValidatingCarrierCode" });
                }
            }

            yield break;
        }
    }

}