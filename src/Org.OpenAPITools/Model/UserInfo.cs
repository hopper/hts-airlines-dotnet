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
    /// An object containing information related to the airline&#39;s user. Should be included if known, but not if the user is anonymous.
    /// </summary>
    [DataContract(Name = "user_info")]
    public partial class UserInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="airlineUserId">The airline&#39;s unique identifier for a user; can be an arbitrary string (required).</param>
        /// <param name="createdDateTime">A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a user&#39;s account was created.</param>
        /// <param name="previousBookings">Number of prior bookings a user has made.</param>
        public UserInfo(string airlineUserId = default(string), DateTime createdDateTime = default(DateTime), int previousBookings = default(int))
        {
            // to ensure "airlineUserId" is required (not null)
            if (airlineUserId == null)
            {
                throw new ArgumentNullException("airlineUserId is a required property for UserInfo and cannot be null");
            }
            this.AirlineUserId = airlineUserId;
            this.CreatedDateTime = createdDateTime;
            this.PreviousBookings = previousBookings;
        }

        /// <summary>
        /// The airline&#39;s unique identifier for a user; can be an arbitrary string
        /// </summary>
        /// <value>The airline&#39;s unique identifier for a user; can be an arbitrary string</value>
        /*
        <example>2bcd6619-ac3e-403b-9982-3e12f2698a53</example>
        */
        [DataMember(Name = "airline_user_id", IsRequired = true, EmitDefaultValue = true)]
        public string AirlineUserId { get; set; }

        /// <summary>
        /// A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a user&#39;s account was created
        /// </summary>
        /// <value>A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a user&#39;s account was created</value>
        /*
        <example>2020-11-02T18:34:30Z</example>
        */
        [DataMember(Name = "created_date_time", EmitDefaultValue = false)]
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Number of prior bookings a user has made
        /// </summary>
        /// <value>Number of prior bookings a user has made</value>
        /*
        <example>3</example>
        */
        [DataMember(Name = "previous_bookings", EmitDefaultValue = false)]
        public int PreviousBookings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  AirlineUserId: ").Append(AirlineUserId).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  PreviousBookings: ").Append(PreviousBookings).Append("\n");
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
            // PreviousBookings (int) minimum
            if (this.PreviousBookings < (int)0)
            {
                yield return new ValidationResult("Invalid value for PreviousBookings, must be a value greater than or equal to 0.", new [] { "PreviousBookings" });
            }

            yield break;
        }
    }

}
