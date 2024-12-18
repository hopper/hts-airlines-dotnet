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
    /// A update DG contract status request
    /// </summary>
    [DataContract(Name = "update_dg_contract_status_request")]
    public partial class UpdateDgContractStatusRequest
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public DgStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDgContractStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateDgContractStatusRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDgContractStatusRequest" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="pnrReference">Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;.</param>
        /// <param name="emailAddress">Email address of the user.</param>
        /// <param name="phoneNumber">Phone number of the customer.</param>
        /// <param name="firstName">First name of the cardholder.</param>
        /// <param name="lastName">Last name of the cardholder.</param>
        /// <param name="addressLine1">Address of the cardholder (first line).</param>
        /// <param name="addressLine2">Address of the cardholder (second line).</param>
        /// <param name="city">City of the cardholder.</param>
        /// <param name="stateOrProvince">State or province of the cardholder.</param>
        /// <param name="postalCode">Postal code  of the cardholder.</param>
        /// <param name="country">Country of the cardholder.</param>
        /// <param name="taxesTotal">Total of taxes.</param>
        /// <param name="taxes">List of taxes that is associated with a contract.</param>
        /// <param name="formsOfPayment">List of the forms of payment used to purchase the booking.</param>
        public UpdateDgContractStatusRequest(DgStatus status = default(DgStatus), string pnrReference = default(string), string emailAddress = default(string), string phoneNumber = default(string), string firstName = default(string), string lastName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string city = default(string), string stateOrProvince = default(string), string postalCode = default(string), string country = default(string), string taxesTotal = default(string), List<DgTax> taxes = default(List<DgTax>), List<FormOfPayment> formsOfPayment = default(List<FormOfPayment>))
        {
            this.Status = status;
            this.PnrReference = pnrReference;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.StateOrProvince = stateOrProvince;
            this.PostalCode = postalCode;
            this.Country = country;
            this.TaxesTotal = taxesTotal;
            this.Taxes = taxes;
            this.FormsOfPayment = formsOfPayment;
        }

        /// <summary>
        /// Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;
        /// </summary>
        /// <value>Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;</value>
        /*
        <example>ABC123</example>
        */
        [DataMember(Name = "pnr_reference", EmitDefaultValue = false)]
        public string PnrReference { get; set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        /// <value>Email address of the user</value>
        /*
        <example>john@doe.com</example>
        */
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Phone number of the customer
        /// </summary>
        /// <value>Phone number of the customer</value>
        /*
        <example>12345678900</example>
        */
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// First name of the cardholder
        /// </summary>
        /// <value>First name of the cardholder</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the cardholder
        /// </summary>
        /// <value>Last name of the cardholder</value>
        /*
        <example>Smith</example>
        */
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Address of the cardholder (first line)
        /// </summary>
        /// <value>Address of the cardholder (first line)</value>
        /*
        <example>123 12th St</example>
        */
        [DataMember(Name = "address_line1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address of the cardholder (second line)
        /// </summary>
        /// <value>Address of the cardholder (second line)</value>
        /*
        <example>Building B</example>
        */
        [DataMember(Name = "address_line2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City of the cardholder
        /// </summary>
        /// <value>City of the cardholder</value>
        /*
        <example>Quebec City</example>
        */
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State or province of the cardholder
        /// </summary>
        /// <value>State or province of the cardholder</value>
        /*
        <example>QC</example>
        */
        [DataMember(Name = "state_or_province", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Postal code  of the cardholder
        /// </summary>
        /// <value>Postal code  of the cardholder</value>
        /*
        <example>G1R 4S9</example>
        */
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the cardholder
        /// </summary>
        /// <value>Country of the cardholder</value>
        /*
        <example>CA</example>
        */
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Total of taxes
        /// </summary>
        /// <value>Total of taxes</value>
        /*
        <example>20.00</example>
        */
        [DataMember(Name = "taxes_total", EmitDefaultValue = false)]
        public string TaxesTotal { get; set; }

        /// <summary>
        /// List of taxes that is associated with a contract
        /// </summary>
        /// <value>List of taxes that is associated with a contract</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<DgTax> Taxes { get; set; }

        /// <summary>
        /// List of the forms of payment used to purchase the booking
        /// </summary>
        /// <value>List of the forms of payment used to purchase the booking</value>
        [DataMember(Name = "forms_of_payment", EmitDefaultValue = false)]
        public List<FormOfPayment> FormsOfPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateDgContractStatusRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PnrReference: ").Append(PnrReference).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  TaxesTotal: ").Append(TaxesTotal).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  FormsOfPayment: ").Append(FormsOfPayment).Append("\n");
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
