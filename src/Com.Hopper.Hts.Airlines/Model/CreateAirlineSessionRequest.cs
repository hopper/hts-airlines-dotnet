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
    /// CreateAirlineSessionRequest
    /// </summary>
    [DataContract(Name = "create_airline_session_request")]
    public partial class CreateAirlineSessionRequest
    {

        /// <summary>
        /// Gets or Sets FlowType
        /// </summary>
        [DataMember(Name = "flow_type", IsRequired = true, EmitDefaultValue = true)]
        public FlowType FlowType { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public Product? Product { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAirlineSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAirlineSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAirlineSessionRequest" /> class.
        /// </summary>
        /// <param name="flowType">flowType (required).</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="device">device.</param>
        /// <param name="pointOfSale">An ISO 3166-1-alpha-2 country code; the point of sale of the user (required).</param>
        /// <param name="language">A ISO_639-1 country code; the language associated with the user (required).</param>
        /// <param name="product">product.</param>
        public CreateAirlineSessionRequest(FlowType flowType = default(FlowType), UserInfo userInfo = default(UserInfo), Device device = default(Device), string pointOfSale = default(string), string language = default(string), Product? product = default(Product?))
        {
            this.FlowType = flowType;
            // to ensure "pointOfSale" is required (not null)
            if (pointOfSale == null)
            {
                throw new ArgumentNullException("pointOfSale is a required property for CreateAirlineSessionRequest and cannot be null");
            }
            this.PointOfSale = pointOfSale;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for CreateAirlineSessionRequest and cannot be null");
            }
            this.Language = language;
            this.UserInfo = userInfo;
            this.Device = device;
            this.Product = product;
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
            sb.Append("class CreateAirlineSessionRequest {\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  PointOfSale: ").Append(PointOfSale).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
