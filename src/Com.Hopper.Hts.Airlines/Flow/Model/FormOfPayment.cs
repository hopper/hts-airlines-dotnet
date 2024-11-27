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
    /// FormOfPayment
    /// </summary>
public partial class FormOfPayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormOfPayment" /> class
        /// with the <see cref="Cash" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Cash.</param>
        public FormOfPayment(Cash actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormOfPayment" /> class
        /// with the <see cref="NonCash" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NonCash.</param>
        public FormOfPayment(NonCash actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormOfPayment" /> class
        /// with the <see cref="TokenizedPaymentCard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentCard.</param>
        public FormOfPayment(TokenizedPaymentCard actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormOfPayment" /> class
        /// with the <see cref="Points" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Points.</param>
        public FormOfPayment(Points actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Cash) || value is Cash)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NonCash) || value is NonCash)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TokenizedPaymentCard) || value is TokenizedPaymentCard)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentCard) || value is PaymentCard)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Points) || value is Points)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Cash, NonCash, PaymentCard, TokenizedPaymentCard, Points");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Cash`. If the actual instance is not `Cash`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Cash</returns>
        public Cash GetCash()
        {
            return (Cash)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NonCash`. If the actual instance is not `NonCash`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NonCash</returns>
        public NonCash GetNonCash()
        {
            return (NonCash)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentCard`. If the actual instance is not `PaymentCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentCard</returns>
        public PaymentCard GetPaymentCard()
        {
            return (PaymentCard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentCard`. If the actual instance is not `PaymentCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentCard</returns>
        public TokenizedPaymentCard GetTokenizedPaymentCard()
        {
            return (TokenizedPaymentCard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Points`. If the actual instance is not `Points`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Points</returns>
        public Points GetPoints()
        {
            return (Points)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormOfPayment {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
