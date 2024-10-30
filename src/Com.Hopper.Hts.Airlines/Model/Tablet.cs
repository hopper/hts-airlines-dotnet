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
    /// Tablet
    /// </summary>
    [DataContract(Name = "tablet")]
    public partial class Tablet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tablet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tablet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tablet" /> class.
        /// </summary>
        /// <param name="id">A unique identifier for the end-user&#39;s device, generated by the partner (required).</param>
        /// <param name="platform">platform.</param>
        /// <param name="type">type (required).</param>
        public Tablet(string id = default(string), Platform platform = default(Platform), string type = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Tablet and cannot be null");
            }
            this.Id = id;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Tablet and cannot be null");
            }
            this.Type = type;
            this.Platform = platform;
        }

        /// <summary>
        /// A unique identifier for the end-user&#39;s device, generated by the partner
        /// </summary>
        /// <value>A unique identifier for the end-user&#39;s device, generated by the partner</value>
        /*
        <example>eb2dddb7-dc69-4521-9fbb-762b96eb921f</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /*
        <example>mobile</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tablet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
