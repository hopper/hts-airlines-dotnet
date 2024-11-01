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
    /// Web
    /// </summary>
    [DataContract(Name = "web")]
    public partial class Web
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Web() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        /// <param name="varOperatingSystem">varOperatingSystem.</param>
        /// <param name="browser">browser.</param>
        /// <param name="type">type (required).</param>
        public Web(ModelOperatingSystem varOperatingSystem = default(ModelOperatingSystem), Browser browser = default(Browser), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Web and cannot be null");
            }
            this.Type = type;
            this.VarOperatingSystem = varOperatingSystem;
            this.Browser = browser;
        }

        /// <summary>
        /// Gets or Sets VarOperatingSystem
        /// </summary>
        [DataMember(Name = "operating_system", EmitDefaultValue = false)]
        public ModelOperatingSystem VarOperatingSystem { get; set; }

        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [DataMember(Name = "browser", EmitDefaultValue = false)]
        public Browser Browser { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /*
        <example>app</example>
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
            sb.Append("class Web {\n");
            sb.Append("  VarOperatingSystem: ").Append(VarOperatingSystem).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
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

    }

}
