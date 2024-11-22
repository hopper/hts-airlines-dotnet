using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{
    /// <summary>
    /// CreateCreditCardRequest
    /// </summary>
    [DataContract(Name = "create_credit_card_request")]
    public partial class CreateCreditCardRequest
    {
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod? PaymentMethod { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCreditCardRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardRequest" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        public CreateCreditCardRequest(PaymentMethod paymentMethod = default(PaymentMethod))
        {
            
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for CreateCreditCardRequest and cannot be null");
            }
            this.PaymentMethod = paymentMethod;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCreditCardRequest {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
