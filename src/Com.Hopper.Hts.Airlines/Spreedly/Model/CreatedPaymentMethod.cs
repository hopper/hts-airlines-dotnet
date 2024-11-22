
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Security.Cryptography;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{

    [DataContract(Name = "created_payment_method")]
    /// <summary>
    /// Represents a payment method with credit card details and encryption capabilities.
    /// </summary>
    public partial class CreatedPaymentMethod
    {

        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatedPaymentMethod {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}

