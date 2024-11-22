
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Security.Cryptography;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{

    [DataContract(Name = "payment_method")]
    /// <summary>
    /// Represents a payment method with credit card details and encryption capabilities.
    /// </summary>
    public partial class PaymentMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod"/> class with the specified credit card.
        /// </summary>
        /// <param name="creditCard">The credit card details.</param>
        public PaymentMethod(CreditCard creditCard = default(CreditCard))
        {
            
            // to ensure "creditCard" is required (not null)
            if (creditCard == null)
            {
                throw new ArgumentNullException("creditCard is a required property for CreditCard and cannot be null");
            }
            this.CreditCard = creditCard;
        }


        [DataMember(Name = "credit_card", EmitDefaultValue = false)]
        public CreditCard? CreditCard { get; set; }


        [DataMember(Name = "encrypted_fields", EmitDefaultValue = false)]
        public string EncryptedFields { get; set; }

        [DataMember(Name = "encryption_certificate_token", EmitDefaultValue = false)]
        public string EncryptionCertificateToken { get; set; }

        /// <summary>
        /// Encrypts the credit card details using the provided encryption parameters.
        /// </summary>
        /// <param name="encryption">The encryption details.</param>
        public void Encrypt(Encryption encryption) {
            var rsa = RSA.Create();
            rsa.ImportFromPem(encryption.PublicKey);

            CreditCard.FirstName = _Encrypt(CreditCard.FirstName, rsa);
            CreditCard.LastName = _Encrypt(CreditCard.LastName, rsa);
            CreditCard.Number = _Encrypt(CreditCard.Number, rsa);
            CreditCard.Month = _Encrypt(CreditCard.Month, rsa);
            CreditCard.Year = _Encrypt(CreditCard.Year, rsa);

            this.EncryptedFields = "first_name,last_name,number,month,year";
            this.EncryptionCertificateToken = encryption.CertificateToken;
        }

        private string _Encrypt(string input, RSA rsa) {
            var dataToEncrypt = Encoding.UTF8.GetBytes(input);
            var encrypted = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);

            return Convert.ToBase64String(encrypted);
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

