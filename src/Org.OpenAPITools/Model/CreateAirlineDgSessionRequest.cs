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
    /// An object containing information related to the user&#39;s session
    /// </summary>
    [DataContract(Name = "create_airline_dg_session_request")]
    public partial class CreateAirlineDgSessionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAirlineDgSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAirlineDgSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAirlineDgSessionRequest" /> class.
        /// </summary>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="device">device.</param>
        /// <param name="pointOfSale">An ISO 3166-1-alpha-2 country code; the point of sale of the user (required).</param>
        /// <param name="language">A ISO_639-1 country code; the language associated with the user (required).</param>
        public CreateAirlineDgSessionRequest(UserInfo userInfo = default(UserInfo), Device device = default(Device), string pointOfSale = default(string), string language = default(string))
        {
            // to ensure "pointOfSale" is required (not null)
            if (pointOfSale == null)
            {
                throw new ArgumentNullException("pointOfSale is a required property for CreateAirlineDgSessionRequest and cannot be null");
            }
            this.PointOfSale = pointOfSale;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for CreateAirlineDgSessionRequest and cannot be null");
            }
            this.Language = language;
            this.UserInfo = userInfo;
            this.Device = device;
        }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name = "user_info", EmitDefaultValue = false)]
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public Device Device { get; set; }

        /// <summary>
        /// An ISO 3166-1-alpha-2 country code; the point of sale of the user
        /// </summary>
        /// <value>An ISO 3166-1-alpha-2 country code; the point of sale of the user</value>
        /*
        <example>US</example>
        */
        [DataMember(Name = "point_of_sale", IsRequired = true, EmitDefaultValue = true)]
        public string PointOfSale { get; set; }

        /// <summary>
        /// A ISO_639-1 country code; the language associated with the user
        /// </summary>
        /// <value>A ISO_639-1 country code; the language associated with the user</value>
        /*
        <example>es</example>
        */
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAirlineDgSessionRequest {\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  PointOfSale: ").Append(PointOfSale).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
