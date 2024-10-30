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
    /// A CFAR contract
    /// </summary>
    [DataContract(Name = "cfar_contract")]
    public partial class CfarContract
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public CfarStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarContract() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarContract" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for a contract (required).</param>
        /// <param name="reference">Unique reference for a contract (required).</param>
        /// <param name="offers">CFAR Offer(s) used to create the contract (required).</param>
        /// <param name="itinerary">itinerary (required).</param>
        /// <param name="coveragePercentage">Percentage of the amount to be refunded to customer compared to flight tickets price (required).</param>
        /// <param name="coverage">Total amount to be refunded upon CFAR exercise (required).</param>
        /// <param name="premium">Total amount to be paid for CFAR (required).</param>
        /// <param name="currency">Currency of contract (required).</param>
        /// <param name="taxesTotal">Part of the premium which are taxes (required).</param>
        /// <param name="taxes">List of applicable taxes.</param>
        /// <param name="createdDateTime">A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR contract was created (required).</param>
        /// <param name="expiryDateTime">A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) A UTC RFC3339 datetime; the date and time at which the CFAR contract will expire once purchased (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="pnrReference">Reference of the PNR in the airline system.</param>
        /// <param name="extAttributes">extAttributes (required).</param>
        public CfarContract(string id = default(string), string reference = default(string), List<CfarOffer> offers = default(List<CfarOffer>), CfarItinerary itinerary = default(CfarItinerary), string coveragePercentage = default(string), string coverage = default(string), string premium = default(string), string currency = default(string), string taxesTotal = default(string), List<CfarTax> taxes = default(List<CfarTax>), DateTime createdDateTime = default(DateTime), DateTime expiryDateTime = default(DateTime), CfarStatus status = default(CfarStatus), string pnrReference = default(string), Dictionary<string, string> extAttributes = default(Dictionary<string, string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CfarContract and cannot be null");
            }
            this.Id = id;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for CfarContract and cannot be null");
            }
            this.Reference = reference;
            // to ensure "offers" is required (not null)
            if (offers == null)
            {
                throw new ArgumentNullException("offers is a required property for CfarContract and cannot be null");
            }
            this.Offers = offers;
            // to ensure "itinerary" is required (not null)
            if (itinerary == null)
            {
                throw new ArgumentNullException("itinerary is a required property for CfarContract and cannot be null");
            }
            this.Itinerary = itinerary;
            // to ensure "coveragePercentage" is required (not null)
            if (coveragePercentage == null)
            {
                throw new ArgumentNullException("coveragePercentage is a required property for CfarContract and cannot be null");
            }
            this.CoveragePercentage = coveragePercentage;
            // to ensure "coverage" is required (not null)
            if (coverage == null)
            {
                throw new ArgumentNullException("coverage is a required property for CfarContract and cannot be null");
            }
            this.Coverage = coverage;
            // to ensure "premium" is required (not null)
            if (premium == null)
            {
                throw new ArgumentNullException("premium is a required property for CfarContract and cannot be null");
            }
            this.Premium = premium;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for CfarContract and cannot be null");
            }
            this.Currency = currency;
            // to ensure "taxesTotal" is required (not null)
            if (taxesTotal == null)
            {
                throw new ArgumentNullException("taxesTotal is a required property for CfarContract and cannot be null");
            }
            this.TaxesTotal = taxesTotal;
            this.CreatedDateTime = createdDateTime;
            this.ExpiryDateTime = expiryDateTime;
            this.Status = status;
            // to ensure "extAttributes" is required (not null)
            if (extAttributes == null)
            {
                throw new ArgumentNullException("extAttributes is a required property for CfarContract and cannot be null");
            }
            this.ExtAttributes = extAttributes;
            this.Taxes = taxes;
            this.PnrReference = pnrReference;
        }

        /// <summary>
        /// Unique identifier for a contract
        /// </summary>
        /// <value>Unique identifier for a contract</value>
        /*
        <example>1ec9ef29-be31-6ed3-beec-9f5ae0d164ee</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Unique reference for a contract
        /// </summary>
        /// <value>Unique reference for a contract</value>
        /*
        <example>1FE5772642C77BAB</example>
        */
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// CFAR Offer(s) used to create the contract
        /// </summary>
        /// <value>CFAR Offer(s) used to create the contract</value>
        [DataMember(Name = "offers", IsRequired = true, EmitDefaultValue = true)]
        public List<CfarOffer> Offers { get; set; }

        /// <summary>
        /// Gets or Sets Itinerary
        /// </summary>
        [DataMember(Name = "itinerary", IsRequired = true, EmitDefaultValue = true)]
        public CfarItinerary Itinerary { get; set; }

        /// <summary>
        /// Percentage of the amount to be refunded to customer compared to flight tickets price
        /// </summary>
        /// <value>Percentage of the amount to be refunded to customer compared to flight tickets price</value>
        /*
        <example>80.00</example>
        */
        [DataMember(Name = "coverage_percentage", IsRequired = true, EmitDefaultValue = true)]
        public string CoveragePercentage { get; set; }

        /// <summary>
        /// Total amount to be refunded upon CFAR exercise
        /// </summary>
        /// <value>Total amount to be refunded upon CFAR exercise</value>
        /*
        <example>98.64</example>
        */
        [DataMember(Name = "coverage", IsRequired = true, EmitDefaultValue = true)]
        public string Coverage { get; set; }

        /// <summary>
        /// Total amount to be paid for CFAR
        /// </summary>
        /// <value>Total amount to be paid for CFAR</value>
        /*
        <example>80.00</example>
        */
        [DataMember(Name = "premium", IsRequired = true, EmitDefaultValue = true)]
        public string Premium { get; set; }

        /// <summary>
        /// Currency of contract
        /// </summary>
        /// <value>Currency of contract</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Part of the premium which are taxes
        /// </summary>
        /// <value>Part of the premium which are taxes</value>
        /*
        <example>3.90</example>
        */
        [DataMember(Name = "taxes_total", IsRequired = true, EmitDefaultValue = true)]
        public string TaxesTotal { get; set; }

        /// <summary>
        /// List of applicable taxes
        /// </summary>
        /// <value>List of applicable taxes</value>
        [DataMember(Name = "taxes", EmitDefaultValue = true)]
        public List<CfarTax> Taxes { get; set; }

        /// <summary>
        /// A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR contract was created
        /// </summary>
        /// <value>A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR contract was created</value>
        /*
        <example>2022-01-08T14:36:56Z</example>
        */
        [DataMember(Name = "created_date_time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) A UTC RFC3339 datetime; the date and time at which the CFAR contract will expire once purchased
        /// </summary>
        /// <value>A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) A UTC RFC3339 datetime; the date and time at which the CFAR contract will expire once purchased</value>
        /*
        <example>2022-06-01T15:00Z</example>
        */
        [DataMember(Name = "expiry_date_time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime ExpiryDateTime { get; set; }

        /// <summary>
        /// Reference of the PNR in the airline system
        /// </summary>
        /// <value>Reference of the PNR in the airline system</value>
        /*
        <example>ABC123</example>
        */
        [DataMember(Name = "pnr_reference", EmitDefaultValue = true)]
        public string PnrReference { get; set; }

        /// <summary>
        /// Gets or Sets ExtAttributes
        /// </summary>
        [DataMember(Name = "ext_attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ExtAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarContract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
            sb.Append("  Itinerary: ").Append(Itinerary).Append("\n");
            sb.Append("  CoveragePercentage: ").Append(CoveragePercentage).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxesTotal: ").Append(TaxesTotal).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  ExpiryDateTime: ").Append(ExpiryDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PnrReference: ").Append(PnrReference).Append("\n");
            sb.Append("  ExtAttributes: ").Append(ExtAttributes).Append("\n");
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
