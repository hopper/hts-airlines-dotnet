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
    /// DgPayment
    /// </summary>
    [DataContract(Name = "dg_payment")]
    public partial class DgPayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DgPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgPayment" /> class.
        /// </summary>
        /// <param name="succeeded">Indicates if the transaction is successful (required).</param>
        public DgPayment(bool succeeded = default(bool))
        {
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Indicates if the transaction is successful
        /// </summary>
        /// <value>Indicates if the transaction is successful</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "succeeded", IsRequired = true, EmitDefaultValue = true)]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgPayment {\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
