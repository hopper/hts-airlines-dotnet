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
    /// A create CFAR contract exercise request
    /// </summary>
    [DataContract(Name = "create_cfar_contract_exercise_request")]
    public partial class CreateCfarContractExerciseRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AirlineRefundMethod
        /// </summary>
        [DataMember(Name = "airline_refund_method", EmitDefaultValue = true)]
        public AirlineRefundMethod? AirlineRefundMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCfarContractExerciseRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCfarContractExerciseRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCfarContractExerciseRequest" /> class.
        /// </summary>
        /// <param name="contractId">A unique identifier for a CFAR contract.</param>
        /// <param name="itinerary">itinerary (required).</param>
        /// <param name="emailAddress">Email address of the user.</param>
        /// <param name="pnrReference">pnrReference (required).</param>
        /// <param name="airlineRefundPenalty">The penalty fee applied by the airline when issuing a refund for the booking.</param>
        /// <param name="airlineRefundMethod">airlineRefundMethod.</param>
        /// <param name="currency">The currency of the airline&#39;s refund allowance.</param>
        /// <param name="extAttributes">extAttributes (required).</param>
        /// <param name="session">session.</param>
        /// <param name="callbackUrl">URL on which the customer should be redirected after the exercise (if applicable).</param>
        /// <param name="redirectbackUrl">URL on which the customer should be redirected if the exercise is aborted (if applicable).</param>
        /// <param name="firstName">First name of the cardholder.</param>
        /// <param name="lastName">Last name of the cardholder.</param>
        public CreateCfarContractExerciseRequest(string contractId = default(string), CfarCreateExerciseItinerary itinerary = default(CfarCreateExerciseItinerary), string emailAddress = default(string), string pnrReference = default(string), string airlineRefundPenalty = default(string), AirlineRefundMethod? airlineRefundMethod = default(AirlineRefundMethod?), string currency = default(string), Dictionary<string, string> extAttributes = default(Dictionary<string, string>), CreateAirlineCfarSessionRequest session = default(CreateAirlineCfarSessionRequest), string callbackUrl = default(string), string redirectbackUrl = default(string), string firstName = default(string), string lastName = default(string))
        {
            // to ensure "itinerary" is required (not null)
            if (itinerary == null)
            {
                throw new ArgumentNullException("itinerary is a required property for CreateCfarContractExerciseRequest and cannot be null");
            }
            this.Itinerary = itinerary;
            // to ensure "pnrReference" is required (not null)
            if (pnrReference == null)
            {
                throw new ArgumentNullException("pnrReference is a required property for CreateCfarContractExerciseRequest and cannot be null");
            }
            this.PnrReference = pnrReference;
            // to ensure "extAttributes" is required (not null)
            if (extAttributes == null)
            {
                throw new ArgumentNullException("extAttributes is a required property for CreateCfarContractExerciseRequest and cannot be null");
            }
            this.ExtAttributes = extAttributes;
            this.ContractId = contractId;
            this.EmailAddress = emailAddress;
            this.AirlineRefundPenalty = airlineRefundPenalty;
            this.AirlineRefundMethod = airlineRefundMethod;
            this.Currency = currency;
            this.Session = session;
            this.CallbackUrl = callbackUrl;
            this.RedirectbackUrl = redirectbackUrl;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// A unique identifier for a CFAR contract
        /// </summary>
        /// <value>A unique identifier for a CFAR contract</value>
        /*
        <example>1ec9ef29-be31-6ed3-beec-9f5ae0d164ee</example>
        */
        [DataMember(Name = "contract_id", EmitDefaultValue = true)]
        public string ContractId { get; set; }

        /// <summary>
        /// Gets or Sets Itinerary
        /// </summary>
        [DataMember(Name = "itinerary", IsRequired = true, EmitDefaultValue = true)]
        public CfarCreateExerciseItinerary Itinerary { get; set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        /// <value>Email address of the user</value>
        /*
        <example>john@doe.com</example>
        */
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets PnrReference
        /// </summary>
        /*
        <example>ABC123</example>
        */
        [DataMember(Name = "pnr_reference", IsRequired = true, EmitDefaultValue = true)]
        public string PnrReference { get; set; }

        /// <summary>
        /// The penalty fee applied by the airline when issuing a refund for the booking
        /// </summary>
        /// <value>The penalty fee applied by the airline when issuing a refund for the booking</value>
        /*
        <example>99.0</example>
        */
        [DataMember(Name = "airline_refund_penalty", EmitDefaultValue = true)]
        public string AirlineRefundPenalty { get; set; }

        /// <summary>
        /// The currency of the airline&#39;s refund allowance
        /// </summary>
        /// <value>The currency of the airline&#39;s refund allowance</value>
        /*
        <example>CAD</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets ExtAttributes
        /// </summary>
        [DataMember(Name = "ext_attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ExtAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = true)]
        public CreateAirlineCfarSessionRequest Session { get; set; }

        /// <summary>
        /// URL on which the customer should be redirected after the exercise (if applicable)
        /// </summary>
        /// <value>URL on which the customer should be redirected after the exercise (if applicable)</value>
        /*
        <example>https://hts.hopper.com/</example>
        */
        [DataMember(Name = "callback_url", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// URL on which the customer should be redirected if the exercise is aborted (if applicable)
        /// </summary>
        /// <value>URL on which the customer should be redirected if the exercise is aborted (if applicable)</value>
        /*
        <example>https://hts.hopper.com/</example>
        */
        [DataMember(Name = "redirectback_url", EmitDefaultValue = true)]
        public string RedirectbackUrl { get; set; }

        /// <summary>
        /// First name of the cardholder
        /// </summary>
        /// <value>First name of the cardholder</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "first_name", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the cardholder
        /// </summary>
        /// <value>Last name of the cardholder</value>
        /*
        <example>Smith</example>
        */
        [DataMember(Name = "last_name", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCfarContractExerciseRequest {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Itinerary: ").Append(Itinerary).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PnrReference: ").Append(PnrReference).Append("\n");
            sb.Append("  AirlineRefundPenalty: ").Append(AirlineRefundPenalty).Append("\n");
            sb.Append("  AirlineRefundMethod: ").Append(AirlineRefundMethod).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExtAttributes: ").Append(ExtAttributes).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  RedirectbackUrl: ").Append(RedirectbackUrl).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
