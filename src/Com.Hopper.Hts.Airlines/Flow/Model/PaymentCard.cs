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
    /// PaymentCard
    /// </summary>
    public partial class PaymentCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCard" /> class.
        /// </summary>
        protected PaymentCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCard" /> class.
        /// </summary>
        /// <param name="amount">Amount charged on the form of payment (required).</param>
        /// <param name="currency">Currency of the form of payment (required).</param>
        public PaymentCard(
            string amount = default(string),
            string currency = default(string),
            string firstName = default(string),
            string lastName = default(string),
            string number = default(string),
            string verificationValue = default(string),
            string month = default(string),
            string year = default(string)
        )
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

            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for CreditCard and cannot be null");
            }

            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for CreditCard and cannot be null");
            }

            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for CreditCard and cannot be null");
            }

            // to ensure "verificationValue" is required (not null)
            if (verificationValue == null)
            {
                throw new ArgumentNullException("verificationValue is a required property for CreditCard and cannot be null");
            }

            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new ArgumentNullException("month is a required property for CreditCard and cannot be null");
            }

            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new ArgumentNullException("year is a required property for CreditCard and cannot be null");
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.VerificationValue = verificationValue;
            this.Month = month;
            this.Year = year;
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

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Number { get; set; }

        public string VerificationValue { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

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
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
