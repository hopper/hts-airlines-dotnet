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
    /// PaymentCard
    /// </summary>
    [DataContract(Name = "payment_card")]
    public partial class PaymentCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCard" /> class.
        /// </summary>
        /// <param name="amount">Amount charged on the form of payment (required).</param>
        /// <param name="currency">Currency of the form of payment (required).</param>
        /// <param name="token">Token of the payment card generated by HTS Payment Gateway.</param>
        /// <param name="lastFourDigits">Last four digits of the payment card.</param>
        /// <param name="type">type (required).</param>
        public PaymentCard(string amount = default(string), string currency = default(string), string token = default(string), string lastFourDigits = default(string), string type = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for PaymentCard and cannot be null");
            }
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for PaymentCard and cannot be null");
            }
            this.Currency = currency;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for PaymentCard and cannot be null");
            }
            this.Type = type;
            this.Token = token;
            this.LastFourDigits = lastFourDigits;
        }

        /// <summary>
        /// Amount charged on the form of payment
        /// </summary>
        /// <value>Amount charged on the form of payment</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Currency of the form of payment
        /// </summary>
        /// <value>Currency of the form of payment</value>
        /*
        <example>CAD</example>
        */
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Token of the payment card generated by HTS Payment Gateway
        /// </summary>
        /// <value>Token of the payment card generated by HTS Payment Gateway</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Last four digits of the payment card
        /// </summary>
        /// <value>Last four digits of the payment card</value>
        [DataMember(Name = "last_four_digits", EmitDefaultValue = false)]
        public string LastFourDigits { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentCard {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  LastFourDigits: ").Append(LastFourDigits).Append("\n");
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
