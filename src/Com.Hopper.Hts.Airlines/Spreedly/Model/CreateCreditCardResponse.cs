using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{
    /// <summary>
    /// A created credit card
    /// </summary>
    [DataContract(Name = "create_credit_card_response")]
    public partial class CreateCreditCardResponse
    {

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", IsRequired = true, EmitDefaultValue = true)]
        public Transaction? Transaction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCreditCardResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardResponse" /> class.
        /// </summary>

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCreditCardResponse {\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
