using System.Runtime.Serialization;

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

    }

}
