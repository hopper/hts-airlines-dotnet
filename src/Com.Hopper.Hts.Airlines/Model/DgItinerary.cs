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
    /// DgItinerary
    /// </summary>
    [DataContract(Name = "dg_itinerary")]
    public partial class DgItinerary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgItinerary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DgItinerary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgItinerary" /> class.
        /// </summary>
        /// <param name="passengerPricing">List of passengers type, count and pricing for the itinerary (required).</param>
        /// <param name="currency">Currency of pricing fields (required).</param>
        /// <param name="slices">List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed (required).</param>
        /// <param name="ancillaries">Ancillaries attached to the itinerary and their prices.</param>
        /// <param name="totalPrice">Total price of the itinerary.</param>
        /// <param name="passengers">Details of the passengers.</param>
        public DgItinerary(List<DgPassengerPricing> passengerPricing = default(List<DgPassengerPricing>), string currency = default(string), List<DgItinerarySlice> slices = default(List<DgItinerarySlice>), List<DgAncillary> ancillaries = default(List<DgAncillary>), string totalPrice = default(string), List<DgPassenger> passengers = default(List<DgPassenger>))
        {
            // to ensure "passengerPricing" is required (not null)
            if (passengerPricing == null)
            {
                throw new ArgumentNullException("passengerPricing is a required property for DgItinerary and cannot be null");
            }
            this.PassengerPricing = passengerPricing;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for DgItinerary and cannot be null");
            }
            this.Currency = currency;
            // to ensure "slices" is required (not null)
            if (slices == null)
            {
                throw new ArgumentNullException("slices is a required property for DgItinerary and cannot be null");
            }
            this.Slices = slices;
            this.Ancillaries = ancillaries;
            this.TotalPrice = totalPrice;
            this.Passengers = passengers;
        }

        /// <summary>
        /// List of passengers type, count and pricing for the itinerary
        /// </summary>
        /// <value>List of passengers type, count and pricing for the itinerary</value>
        [DataMember(Name = "passenger_pricing", IsRequired = true, EmitDefaultValue = true)]
        public List<DgPassengerPricing> PassengerPricing { get; set; }

        /// <summary>
        /// Currency of pricing fields
        /// </summary>
        /// <value>Currency of pricing fields</value>
        /*
        <example>CAD</example>
        */
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed
        /// </summary>
        /// <value>List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed</value>
        [DataMember(Name = "slices", IsRequired = true, EmitDefaultValue = true)]
        public List<DgItinerarySlice> Slices { get; set; }

        /// <summary>
        /// Ancillaries attached to the itinerary and their prices
        /// </summary>
        /// <value>Ancillaries attached to the itinerary and their prices</value>
        [DataMember(Name = "ancillaries", EmitDefaultValue = true)]
        public List<DgAncillary> Ancillaries { get; set; }

        /// <summary>
        /// Total price of the itinerary
        /// </summary>
        /// <value>Total price of the itinerary</value>
        /*
        <example>401.10</example>
        */
        [DataMember(Name = "total_price", EmitDefaultValue = true)]
        public string TotalPrice { get; set; }

        /// <summary>
        /// Details of the passengers
        /// </summary>
        /// <value>Details of the passengers</value>
        [DataMember(Name = "passengers", EmitDefaultValue = true)]
        public List<DgPassenger> Passengers { get; set; }

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
            yield break;
        }
    }

}
