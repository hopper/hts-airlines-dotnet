/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Text;

namespace Com.Hopper.Hts.Airlines.Flow.Model
{
    /// <summary>
    /// Cash
    /// </summary>
    public partial class Cash
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cash" /> class.
        /// </summary>
        protected Cash() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cash" /> class.
        /// </summary>
        /// <param name="amount">Amount charged on the form of payment (required).</param>
        /// <param name="currency">Currency of the form of payment (required).</param>
        public Cash(string amount = default(string), string currency = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for Cash and cannot be null");
            }
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for Cash and cannot be null");
            }
            this.Currency = currency;
        }

        /// <summary>
        /// Amount charged on the form of payment
        /// </summary>
        /// <value>Amount charged on the form of payment</value>
        public string Amount { get; set; }

        /// <summary>
        /// Currency of the form of payment
        /// </summary>
        /// <value>Currency of the form of payment</value>
        /*
        <example>CAD</example>
        */
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Cash {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
