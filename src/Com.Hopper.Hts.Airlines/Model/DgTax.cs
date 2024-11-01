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
    /// DgTax
    /// </summary>
    [DataContract(Name = "dg_tax")]
    public partial class DgTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgTax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DgTax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgTax" /> class.
        /// </summary>
        /// <param name="name">Name of the tax (required).</param>
        /// <param name="rate">The rate of the tax (required).</param>
        /// <param name="amount">The amount of the tax (required).</param>
        /// <param name="registrationNumber">Registration number of the tax if applicable.</param>
        public DgTax(string name = default(string), string rate = default(string), string amount = default(string), string registrationNumber = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DgTax and cannot be null");
            }
            this.Name = name;
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new ArgumentNullException("rate is a required property for DgTax and cannot be null");
            }
            this.Rate = rate;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for DgTax and cannot be null");
            }
            this.Amount = amount;
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
        /// Registration number of the tax if applicable
        /// </summary>
        /// <value>Registration number of the tax if applicable</value>
        /*
        <example>0123456ABCDEF</example>
        */
        [DataMember(Name = "registration_number", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgTax {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
