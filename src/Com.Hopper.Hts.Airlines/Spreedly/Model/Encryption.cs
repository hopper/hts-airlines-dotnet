using System;
using System.Text;
using System.Security.Cryptography;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model {
    /// <summary>
    /// Encryption parameters.
    /// </summary>
    public partial class Encryption {
        /// <summary>
        /// Gets or sets the certificate token.
        /// </summary>
        public string CertificateToken { get; set; }

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        public string PublicKey { get; set; }

        public CreatePaymentMethodRequest Encrypt(CreatePaymentMethodRequest request) {
            var rsa = RSA.Create();
            rsa.ImportFromPem(PublicKey.ToCharArray());

            var method = request.PaymentMethod;
            method.EncryptedFields = "first_name,last_name,number,month,year";
            method.EncryptionCertificateToken = CertificateToken;

            var card = method.CreditCard;
            card.FirstName = _Encrypt(card.FirstName, rsa);
            card.LastName = _Encrypt(card.LastName, rsa);
            card.Number = _Encrypt(card.Number, rsa);
            card.Month = _Encrypt(card.Month, rsa);
            card.Year = _Encrypt(card.Year, rsa);

            return request;
        }

        private string _Encrypt(string input, RSA rsa) {
            var dataToEncrypt = Encoding.UTF8.GetBytes(input);
            var encrypted = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);

            return Convert.ToBase64String(encrypted);
        }
    }
}