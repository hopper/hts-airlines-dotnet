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
    /// CreateCfarOfferRequest
    /// </summary>
    [DataContract(Name = "create_cfar_offer_request")]
    public partial class CreateCfarOfferRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "request_type", IsRequired = true, EmitDefaultValue = true)]
        public RequestType RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCfarOfferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCfarOfferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCfarOfferRequest" /> class.
        /// </summary>
        /// <param name="itinerary">An object detailing the itinerary and fare used to create a CFAR offer (required).</param>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="bookingDateTime">A UTC RFC3339 datetime; the date and time at which the booking was made. To be used only with the request type \&quot;post_booking\&quot;.</param>
        /// <param name="extAttributes">extAttributes (required).</param>
        /// <param name="session">session.</param>
        public CreateCfarOfferRequest(List<CfarOfferItinerary> itinerary = default(List<CfarOfferItinerary>), RequestType requestType = default(RequestType), DateTime bookingDateTime = default(DateTime), Dictionary<string, string> extAttributes = default(Dictionary<string, string>), CreateAirlineCfarSessionRequest session = default(CreateAirlineCfarSessionRequest))
        {
            // to ensure "itinerary" is required (not null)
            if (itinerary == null)
            {
                throw new ArgumentNullException("itinerary is a required property for CreateCfarOfferRequest and cannot be null");
            }
            this.Itinerary = itinerary;
            this.RequestType = requestType;
            // to ensure "extAttributes" is required (not null)
            if (extAttributes == null)
            {
                throw new ArgumentNullException("extAttributes is a required property for CreateCfarOfferRequest and cannot be null");
            }
            this.ExtAttributes = extAttributes;
            this.BookingDateTime = bookingDateTime;
            this.Session = session;
        }

        /// <summary>
        /// An object detailing the itinerary and fare used to create a CFAR offer
        /// </summary>
        /// <value>An object detailing the itinerary and fare used to create a CFAR offer</value>
        [DataMember(Name = "itinerary", IsRequired = true, EmitDefaultValue = true)]
        public List<CfarOfferItinerary> Itinerary { get; set; }

        /// <summary>
        /// A UTC RFC3339 datetime; the date and time at which the booking was made. To be used only with the request type \&quot;post_booking\&quot;
        /// </summary>
        /// <value>A UTC RFC3339 datetime; the date and time at which the booking was made. To be used only with the request type \&quot;post_booking\&quot;</value>
        /*
        <example>2022-01-01T18:30Z</example>
        */
        [DataMember(Name = "booking_date_time", EmitDefaultValue = false)]
        public DateTime BookingDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ExtAttributes
        /// </summary>
        [DataMember(Name = "ext_attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ExtAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public CreateAirlineCfarSessionRequest Session { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCfarOfferRequest {\n");
            sb.Append("  Itinerary: ").Append(Itinerary).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  BookingDateTime: ").Append(BookingDateTime).Append("\n");
            sb.Append("  ExtAttributes: ").Append(ExtAttributes).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
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
