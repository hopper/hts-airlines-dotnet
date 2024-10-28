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
    /// PassengerPricing
    /// </summary>
    [DataContract(Name = "passenger_pricing")]
    public partial class PassengerPricing : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassengerPricing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PassengerPricing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PassengerPricing" /> class.
        /// </summary>
        /// <param name="passengerCount">passengerCount (required).</param>
        /// <param name="individualPrice">Price per passenger (excluding ancillaries) (required).</param>
        /// <param name="taxes">Taxes applicable per passenger.</param>
        public PassengerPricing(PassengerCount passengerCount = default(PassengerCount), string individualPrice = default(string), List<CfarPassengerTax> taxes = default(List<CfarPassengerTax>))
        {
            // to ensure "passengerCount" is required (not null)
            if (passengerCount == null)
            {
                throw new ArgumentNullException("passengerCount is a required property for PassengerPricing and cannot be null");
            }
            this.PassengerCount = passengerCount;
            // to ensure "individualPrice" is required (not null)
            if (individualPrice == null)
            {
                throw new ArgumentNullException("individualPrice is a required property for PassengerPricing and cannot be null");
            }
            this.IndividualPrice = individualPrice;
            this.Taxes = taxes;
        }

        /// <summary>
        /// Gets or Sets PassengerCount
        /// </summary>
        [DataMember(Name = "passenger_count", IsRequired = true, EmitDefaultValue = true)]
        public PassengerCount PassengerCount { get; set; }

        /// <summary>
        /// Price per passenger (excluding ancillaries)
        /// </summary>
        /// <value>Price per passenger (excluding ancillaries)</value>
        /*
        <example>200.55</example>
        */
        [DataMember(Name = "individual_price", IsRequired = true, EmitDefaultValue = true)]
        public string IndividualPrice { get; set; }

        /// <summary>
        /// Taxes applicable per passenger
        /// </summary>
        /// <value>Taxes applicable per passenger</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<CfarPassengerTax> Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PassengerPricing {\n");
            sb.Append("  PassengerCount: ").Append(PassengerCount).Append("\n");
            sb.Append("  IndividualPrice: ").Append(IndividualPrice).Append("\n");
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
