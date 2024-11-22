
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
using System.Security.Cryptography;
using System.Buffers.Text;
using System.Diagnostics;


namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{

    [DataContract(Name = "payment_method")]
    public partial class PaymentMethod
    {
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

