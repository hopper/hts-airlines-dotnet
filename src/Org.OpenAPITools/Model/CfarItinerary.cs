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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CfarItinerary
    /// </summary>
    [DataContract(Name = "cfar_itinerary")]
    public partial class CfarItinerary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarItinerary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerary" /> class.
        /// </summary>
        /// <param name="passengerPricing">List of passengers type, count and pricing for the itinerary (required).</param>
        /// <param name="currency">Currency of pricing fields (required).</param>
        /// <param name="slices">List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed (required).</param>
        /// <param name="ancillaries">Ancillaries attached to the itinerary and their prices. Only ancillaries covered by CFAR must be filled.</param>
        /// <param name="totalPrice">Total price to be covered by CFAR (including ancillaries if applicable).</param>
        /// <param name="passengers">Details of the passengers.</param>
        /// <param name="fareRules">The fare rules associated to the itinerary. If different fare rules apply to different slices in the itinerary, indicate the most restrictive..</param>
        /// <param name="taxes">Taxes applicable to this itinerary.</param>
        public CfarItinerary(List<PassengerPricing> passengerPricing = default(List<PassengerPricing>), string currency = default(string), List<CfarItinerarySlice> slices = default(List<CfarItinerarySlice>), List<Ancillary> ancillaries = default(List<Ancillary>), string totalPrice = default(string), List<CfarPassenger> passengers = default(List<CfarPassenger>), List<FareRule> fareRules = default(List<FareRule>), List<CfarPassengerTax> taxes = default(List<CfarPassengerTax>))
        {
            // to ensure "passengerPricing" is required (not null)
            if (passengerPricing == null)
            {
                throw new ArgumentNullException("passengerPricing is a required property for CfarItinerary and cannot be null");
            }
            this.PassengerPricing = passengerPricing;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for CfarItinerary and cannot be null");
            }
            this.Currency = currency;
            // to ensure "slices" is required (not null)
            if (slices == null)
            {
                throw new ArgumentNullException("slices is a required property for CfarItinerary and cannot be null");
            }
            this.Slices = slices;
            this.Ancillaries = ancillaries;
            this.TotalPrice = totalPrice;
            this.Passengers = passengers;
            this.FareRules = fareRules;
            this.Taxes = taxes;
        }

        /// <summary>
        /// List of passengers type, count and pricing for the itinerary
        /// </summary>
        /// <value>List of passengers type, count and pricing for the itinerary</value>
        [DataMember(Name = "passenger_pricing", IsRequired = true, EmitDefaultValue = true)]
        public List<PassengerPricing> PassengerPricing { get; set; }

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
        public List<CfarItinerarySlice> Slices { get; set; }

        /// <summary>
        /// Ancillaries attached to the itinerary and their prices. Only ancillaries covered by CFAR must be filled
        /// </summary>
        /// <value>Ancillaries attached to the itinerary and their prices. Only ancillaries covered by CFAR must be filled</value>
        [DataMember(Name = "ancillaries", EmitDefaultValue = false)]
        public List<Ancillary> Ancillaries { get; set; }

        /// <summary>
        /// Total price to be covered by CFAR (including ancillaries if applicable)
        /// </summary>
        /// <value>Total price to be covered by CFAR (including ancillaries if applicable)</value>
        /*
        <example>401.10</example>
        */
        [DataMember(Name = "total_price", EmitDefaultValue = false)]
        public string TotalPrice { get; set; }

        /// <summary>
        /// Details of the passengers
        /// </summary>
        /// <value>Details of the passengers</value>
        [DataMember(Name = "passengers", EmitDefaultValue = false)]
        public List<CfarPassenger> Passengers { get; set; }

        /// <summary>
        /// The fare rules associated to the itinerary. If different fare rules apply to different slices in the itinerary, indicate the most restrictive.
        /// </summary>
        /// <value>The fare rules associated to the itinerary. If different fare rules apply to different slices in the itinerary, indicate the most restrictive.</value>
        [DataMember(Name = "fare_rules", EmitDefaultValue = false)]
        public List<FareRule> FareRules { get; set; }

        /// <summary>
        /// Taxes applicable to this itinerary
        /// </summary>
        /// <value>Taxes applicable to this itinerary</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<CfarPassengerTax> Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarItinerary {\n");
            sb.Append("  PassengerPricing: ").Append(PassengerPricing).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Slices: ").Append(Slices).Append("\n");
            sb.Append("  Ancillaries: ").Append(Ancillaries).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Passengers: ").Append(Passengers).Append("\n");
            sb.Append("  FareRules: ").Append(FareRules).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
