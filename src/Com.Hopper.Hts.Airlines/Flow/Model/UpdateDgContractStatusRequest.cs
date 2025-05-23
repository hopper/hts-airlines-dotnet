/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Collections.Generic;
using System.Text;
using Com.Hopper.Hts.Airlines.Client;

namespace Com.Hopper.Hts.Airlines.Flow.Model
{
    /// <summary>
    /// Request object related to the update of forms of payment for Dg contract
    /// </summary>
    public partial class UpdateDgContractStatusRequest
    {
                /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDgContractStatusRequest" /> class.
        /// </summary>
        /// <param name="status">status</param>
        /// <param name="pnrReference">Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="phoneNumber">Phone number of the customer</param>
        /// <param name="firstName">First name of the cardholder</param>
        /// <param name="lastName">Last name of the cardholder</param>
        /// <param name="addressLine1">Address of the cardholder (first line)</param>
        /// <param name="addressLine2">Address of the cardholder (second line)</param>
        /// <param name="city">City of the cardholder</param>
        /// <param name="stateOrProvince">State or province of the cardholder</param>
        /// <param name="postalCode">Postal code  of the cardholder</param>
        /// <param name="country">Country of the cardholder</param>
        /// <param name="taxesTotal">Total of taxes</param>
        /// <param name="taxes">List of taxes that is associated with a contract</param>
        /// <param name="formsOfPayment">List of the forms of payment used to purchase the booking</param>
        public UpdateDgContractStatusRequest(
            Airlines.Model.DgStatus status,
            Option<string?> pnrReference = default,
            Option<string?> emailAddress = default,
            Option<string?> phoneNumber = default,
            Option<string?> firstName = default,
            Option<string?> lastName = default,
            Option<string?> addressLine1 = default,
            Option<string?> addressLine2 = default,
            Option<string?> city = default,
            Option<string?> stateOrProvince = default,
            Option<string?> postalCode = default,
            Option<string?> country = default,
            Option<string?> taxesTotal = default,
            Option<List<Airlines.Model.DgTax>?> taxes = default,
            Option<List<FormOfPayment>?> formsOfPayment = default)
        {
            Status = status;
            PnrReferenceOption = pnrReference;
            EmailAddressOption = emailAddress;
            PhoneNumberOption = phoneNumber;
            FirstNameOption = firstName;
            LastNameOption = lastName;
            AddressLine1Option = addressLine1;
            AddressLine2Option = addressLine2;
            CityOption = city;
            StateOrProvinceOption = stateOrProvince;
            PostalCodeOption = postalCode;
            CountryOption = country;
            TaxesTotalOption = taxesTotal;
            TaxesOption = taxes;
            FormsOfPaymentOption = formsOfPayment;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        public Airlines.Model.DgStatus Status { get; set; }

        /// <summary>
        /// Used to track the state of PnrReference
        /// </summary>
        public Option<string?> PnrReferenceOption { get; private set; }

        /// <summary>
        /// Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;
        /// </summary>
        /// <value>Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot;</value>
        /* <example>ABC123</example> */
        public string? PnrReference { get { return this.PnrReferenceOption; } set { this.PnrReferenceOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of EmailAddress
        /// </summary>
        public Option<string?> EmailAddressOption { get; private set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        /// <value>Email address of the user</value>
        /* <example>john@doe.com</example> */
        public string? EmailAddress { get { return this.EmailAddressOption; } set { this.EmailAddressOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of PhoneNumber
        /// </summary>
        public Option<string?> PhoneNumberOption { get; private set; }

        /// <summary>
        /// Phone number of the customer
        /// </summary>
        /// <value>Phone number of the customer</value>
        /* <example>12345678900</example> */
        public string? PhoneNumber { get { return this.PhoneNumberOption; } set { this.PhoneNumberOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of FirstName
        /// </summary>
        public Option<string?> FirstNameOption { get; private set; }

        /// <summary>
        /// First name of the cardholder
        /// </summary>
        /// <value>First name of the cardholder</value>
        /* <example>John</example> */
        public string? FirstName { get { return this.FirstNameOption; } set { this.FirstNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of LastName
        /// </summary>
        public Option<string?> LastNameOption { get; private set; }

        /// <summary>
        /// Last name of the cardholder
        /// </summary>
        /// <value>Last name of the cardholder</value>
        /* <example>Smith</example> */
        public string? LastName { get { return this.LastNameOption; } set { this.LastNameOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AddressLine1
        /// </summary>
        public Option<string?> AddressLine1Option { get; private set; }

        /// <summary>
        /// Address of the cardholder (first line)
        /// </summary>
        /// <value>Address of the cardholder (first line)</value>
        /* <example>123 12th St</example> */
        public string? AddressLine1 { get { return this.AddressLine1Option; } set { this.AddressLine1Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of AddressLine2
        /// </summary>
        public Option<string?> AddressLine2Option { get; private set; }

        /// <summary>
        /// Address of the cardholder (second line)
        /// </summary>
        /// <value>Address of the cardholder (second line)</value>
        /* <example>Building B</example> */
        public string? AddressLine2 { get { return this.AddressLine2Option; } set { this.AddressLine2Option = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        public Option<string?> CityOption { get; private set; }

        /// <summary>
        /// City of the cardholder
        /// </summary>
        /// <value>City of the cardholder</value>
        /* <example>Quebec City</example> */
        public string? City { get { return this.CityOption; } set { this.CityOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of StateOrProvince
        /// </summary>
        public Option<string?> StateOrProvinceOption { get; private set; }

        /// <summary>
        /// State or province of the cardholder
        /// </summary>
        /// <value>State or province of the cardholder</value>
        /* <example>QC</example> */
        public string? StateOrProvince { get { return this.StateOrProvinceOption; } set { this.StateOrProvinceOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of PostalCode
        /// </summary>
        public Option<string?> PostalCodeOption { get; private set; }

        /// <summary>
        /// Postal code  of the cardholder
        /// </summary>
        /// <value>Postal code  of the cardholder</value>
        /* <example>G1R 4S9</example> */
        public string? PostalCode { get { return this.PostalCodeOption; } set { this.PostalCodeOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Country
        /// </summary>
        public Option<string?> CountryOption { get; private set; }

        /// <summary>
        /// Country of the cardholder
        /// </summary>
        /// <value>Country of the cardholder</value>
        /* <example>CA</example> */
        public string? Country { get { return this.CountryOption; } set { this.CountryOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of TaxesTotal
        /// </summary>
        public Option<string?> TaxesTotalOption { get; private set; }

        /// <summary>
        /// Total of taxes
        /// </summary>
        /// <value>Total of taxes</value>
        /* <example>20.00</example> */
        public string? TaxesTotal { get { return this.TaxesTotalOption; } set { this.TaxesTotalOption = new Option<string?>(value); } }

        /// <summary>
        /// Used to track the state of Taxes
        /// </summary>
        public Option<List<Airlines.Model.DgTax>?> TaxesOption { get; private set; }

        /// <summary>
        /// List of taxes that is associated with a contract
        /// </summary>
        /// <value>List of taxes that is associated with a contract</value>
        public List<Airlines.Model.DgTax>? Taxes { get { return this.TaxesOption; } set { this.TaxesOption = new Option<List<Airlines.Model.DgTax>?>(value); } }

        /// <summary>
        /// Used to track the state of FormsOfPayment
        /// </summary>
        public Option<List<FormOfPayment>?> FormsOfPaymentOption { get; private set; }

        /// <summary>
        /// List of the forms of payment used to purchase the booking
        /// </summary>
        /// <value>List of the forms of payment used to purchase the booking</value>
        public List<FormOfPayment>? FormsOfPayment { get { return this.FormsOfPaymentOption; } set { this.FormsOfPaymentOption = new Option<List<FormOfPayment>?>(value); } }

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
    }
}
