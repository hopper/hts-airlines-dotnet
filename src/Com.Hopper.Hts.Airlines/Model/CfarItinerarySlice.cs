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
using OpenAPIDateConverter = Com.Hopper.Hts.Airlines.Client.OpenAPIDateConverter;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// An object containing the list of flight segments for a fare slice
    /// </summary>
    [DataContract(Name = "cfar_itinerary_slice")]
    public partial class CfarItinerarySlice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerarySlice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarItinerarySlice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarItinerarySlice" /> class.
        /// </summary>
        /// <param name="segments">A list of segments which make up the slice (required).</param>
        /// <param name="passengerPricing">List of passengers type, count and pricing for the slice.</param>
        /// <param name="totalPrice">The price of the slice for all the passengers.</param>
        /// <param name="fareBrand">Name of the fare brand applied to the slice.</param>
        /// <param name="fareBasis">Code of the fare basis applied to the slice.</param>
        /// <param name="fareRules">The fare rules associated to the slice.</param>
        /// <param name="otherFares">Other available fares in the same cabin.</param>
        public CfarItinerarySlice(List<CfarItinerarySliceSegment> segments = default(List<CfarItinerarySliceSegment>), List<PassengerPricing> passengerPricing = default(List<PassengerPricing>), string totalPrice = default(string), string fareBrand = default(string), string fareBasis = default(string), List<FareRule> fareRules = default(List<FareRule>), List<Fare> otherFares = default(List<Fare>))
        {
            // to ensure "segments" is required (not null)
            if (segments == null)
            {
                throw new ArgumentNullException("segments is a required property for CfarItinerarySlice and cannot be null");
            }
            this.Segments = segments;
            this.PassengerPricing = passengerPricing;
            this.TotalPrice = totalPrice;
            this.FareBrand = fareBrand;
            this.FareBasis = fareBasis;
            this.FareRules = fareRules;
            this.OtherFares = otherFares;
        }

        /// <summary>
        /// A list of segments which make up the slice
        /// </summary>
        /// <value>A list of segments which make up the slice</value>
        [DataMember(Name = "segments", IsRequired = true, EmitDefaultValue = true)]
        public List<CfarItinerarySliceSegment> Segments { get; set; }

        /// <summary>
        /// List of passengers type, count and pricing for the slice
        /// </summary>
        /// <value>List of passengers type, count and pricing for the slice</value>
        [DataMember(Name = "passenger_pricing", EmitDefaultValue = false)]
        public List<PassengerPricing> PassengerPricing { get; set; }

        /// <summary>
        /// The price of the slice for all the passengers
        /// </summary>
        /// <value>The price of the slice for all the passengers</value>
        /*
        <example>401.10</example>
        */
        [DataMember(Name = "total_price", EmitDefaultValue = false)]
        public string TotalPrice { get; set; }

        /// <summary>
        /// Name of the fare brand applied to the slice
        /// </summary>
        /// <value>Name of the fare brand applied to the slice</value>
        /*
        <example>flex</example>
        */
        [DataMember(Name = "fare_brand", EmitDefaultValue = false)]
        public string FareBrand { get; set; }

        /// <summary>
        /// Code of the fare basis applied to the slice
        /// </summary>
        /// <value>Code of the fare basis applied to the slice</value>
        /*
        <example>YBA123US</example>
        */
        [DataMember(Name = "fare_basis", EmitDefaultValue = false)]
        public string FareBasis { get; set; }

        /// <summary>
        /// The fare rules associated to the slice
        /// </summary>
        /// <value>The fare rules associated to the slice</value>
        [DataMember(Name = "fare_rules", EmitDefaultValue = false)]
        public List<FareRule> FareRules { get; set; }

        /// <summary>
        /// Other available fares in the same cabin
        /// </summary>
        /// <value>Other available fares in the same cabin</value>
        [DataMember(Name = "other_fares", EmitDefaultValue = false)]
        public List<Fare> OtherFares { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarItinerarySlice {\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  PassengerPricing: ").Append(PassengerPricing).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  FareBrand: ").Append(FareBrand).Append("\n");
            sb.Append("  FareBasis: ").Append(FareBasis).Append("\n");
            sb.Append("  FareRules: ").Append(FareRules).Append("\n");
            sb.Append("  OtherFares: ").Append(OtherFares).Append("\n");
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

    }

}
