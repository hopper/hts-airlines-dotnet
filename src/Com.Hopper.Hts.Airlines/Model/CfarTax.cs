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
    /// CfarTax
    /// </summary>
    [DataContract(Name = "cfar_tax")]
    public partial class CfarTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarTax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarTax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarTax" /> class.
        /// </summary>
        /// <param name="name">Name of the tax (required).</param>
        /// <param name="rate">The rate of the tax (required).</param>
        /// <param name="amount">The amount of the tax (required).</param>
        /// <param name="estimated">True if the tax amount is estimated, the real amount will be known only at contract confirmation (required).</param>
        /// <param name="registrationNumber">Registration number of the tax if applicable.</param>
        public CfarTax(string name = default(string), string rate = default(string), string amount = default(string), bool estimated = default(bool), string registrationNumber = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CfarTax and cannot be null");
            }
            this.Name = name;
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new ArgumentNullException("rate is a required property for CfarTax and cannot be null");
            }
            this.Rate = rate;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for CfarTax and cannot be null");
            }
            this.Amount = amount;
            this.Estimated = estimated;
            this.RegistrationNumber = registrationNumber;
        }

        /// <summary>
        /// Name of the tax
        /// </summary>
        /// <value>Name of the tax</value>
        /*
        <example>VAT</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The rate of the tax
        /// </summary>
        /// <value>The rate of the tax</value>
        /*
        <example>12.00</example>
        */
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = true)]
        public string Rate { get; set; }

        /// <summary>
        /// The amount of the tax
        /// </summary>
        /// <value>The amount of the tax</value>
        /*
        <example>20.00</example>
        */
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// True if the tax amount is estimated, the real amount will be known only at contract confirmation
        /// </summary>
        /// <value>True if the tax amount is estimated, the real amount will be known only at contract confirmation</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "estimated", IsRequired = true, EmitDefaultValue = true)]
        public bool Estimated { get; set; }

        /// <summary>
        /// Registration number of the tax if applicable
        /// </summary>
        /// <value>Registration number of the tax if applicable</value>
        /*
        <example>0123456ABCDEF</example>
        */
        [DataMember(Name = "registration_number", EmitDefaultValue = true)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarTax {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Estimated: ").Append(Estimated).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
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
