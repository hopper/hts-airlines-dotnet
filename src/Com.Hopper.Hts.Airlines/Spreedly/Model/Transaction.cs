using System.Runtime.Serialization;
using System.Text;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{
    /// <summary>
    /// A Spreedly Transaction
    /// </summary>
    [DataContract(Name = "transaction")]
    public partial class Transaction
    {

        /// <summary>
        /// Gets or Sets token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets payment method
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = false)]
        public CreatedPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
