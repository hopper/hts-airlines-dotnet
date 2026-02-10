using System;
using System.Text;
using System.Security.Cryptography;
using Com.Hopper.Hts.Airlines.Model;

namespace Com.Hopper.Hts.Airlines.PiiEncryption.Model
{
    /// <summary>
    /// Provides PII (Personally Identifiable Information) field encryption for airline partners.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class encrypts sensitive passenger and payment data using RSA encryption with PKCS#1 v1.5 padding,
    /// matching the encryption scheme used by Spreedly and expected by the Airlines API.
    /// </para>
    /// <para>
    /// Encrypted fields are Base64-encoded and can be sent directly to the Airlines API endpoints.
    /// Partners configured with PII encryption enabled must encrypt all PII fields
    /// before sending them to the API.
    /// </para>
    /// <para>
    /// <b>Encryption Details:</b>
    /// <list type="bullet">
    /// <item><description>Algorithm: RSA with PKCS#1 v1.5 padding</description></item>
    /// <item><description>Key Size: RSA-3072 or RSA-4096 (depends on the public key provided)</description></item>
    /// <item><description>Encoding: Base64</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// <b>Encrypted Passenger Fields:</b>
    /// <list type="bullet">
    /// <item><description>firstName, lastName, passportNumber, dateOfBirth</description></item>
    /// <item><description>passportCountryIssuance, passportIssuanceDate, passportExpirationDate, nationality</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// <b>Encrypted Payment Fields:</b>
    /// <list type="bullet">
    /// <item><description>firstName, lastName, emailAddress, phoneNumber</description></item>
    /// <item><description>addressLine1, addressLine2, city, stateOrProvince, postalCode, country</description></item>
    /// </list>
    /// </para>
    /// </remarks>
    public partial class PiiEncryption
    {
        /// <summary>
        /// Gets or sets the RSA public key in PEM format.
        /// </summary>
        /// <remarks>
        /// The public key should be obtained from your partner and must be in PEM format:
        /// <code>
        /// -----BEGIN PUBLIC KEY-----
        /// MIICIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIICCgKCAgEA...
        /// -----END PUBLIC KEY-----
        /// </code>
        /// </remarks>
        public string PublicKeyPem { get; set; }

        /// <summary>
        /// Encrypts a single PII field value using RSA encryption with PKCS#1 v1.5 padding.
        /// </summary>
        /// <param name="plaintext">The plaintext value to encrypt. Can be null or empty.</param>
        /// <returns>
        /// A Base64-encoded encrypted string, or null if the input is null or empty.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This method:
        /// <list type="number">
        /// <item><description>Converts the plaintext to UTF-8 bytes</description></item>
        /// <item><description>Encrypts using RSA with PKCS#1 v1.5 padding</description></item>
        /// <item><description>Encodes the encrypted bytes to Base64</description></item>
        /// </list>
        /// </para>
        /// <para>
        /// The resulting Base64 string can be sent directly to the Airlines API in any PII field.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// var encryption = new PiiEncryption { PublicKeyPem = publicKeyPem };
        /// var encryptedFirstName = encryption.Encrypt("John");
        /// var encryptedEmail = encryption.Encrypt("john.doe@example.com");
        /// </code>
        /// </example>
        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
            {
                return null;
            }

            using var rsa = RSA.Create();
            rsa.ImportFromPem(PublicKeyPem.ToCharArray());

            var dataToEncrypt = Encoding.UTF8.GetBytes(plaintext);
            var encrypted = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);

            return Convert.ToBase64String(encrypted);
        }

        /// <summary>
        /// Encrypts all PII fields in a CreateDgContractRequest.
        /// </summary>
        /// <param name="request">The contract request containing passengers with PII fields.</param>
        /// <returns>The same request with all PII fields encrypted in-place.</returns>
        /// <remarks>
        /// This method automatically encrypts PII fields in all passengers within the request.
        /// Non-PII fields remain plaintext.
        /// </remarks>
        public CreateDgContractRequest EncryptPii(CreateDgContractRequest request)
        {
            if (request?.Itinerary?.Passengers != null)
            {
                foreach (var passenger in request.Itinerary.Passengers)
                {
                    EncryptPii(passenger);
                }
            }
            return request;
        }

        /// <summary>
        /// Encrypts all PII fields in a DgPassenger object.
        /// </summary>
        /// <param name="passenger">The passenger object containing PII fields to encrypt.</param>
        /// <returns>The same passenger object with encrypted PII fields.</returns>
        /// <remarks>
        /// Encrypts: firstName, lastName, passportNumber, dateOfBirth, passportCountryIssuance, nationality.
        /// Non-PII fields (passengerReference, passengerType, gender) remain plaintext.
        /// </remarks>
        private DgPassenger EncryptPii(DgPassenger passenger)
        {
            if (passenger == null)
                return passenger;

            // Encrypt string fields
            if (passenger.FirstName != null)
                passenger.FirstName = Encrypt(passenger.FirstName);

            if (passenger.LastName != null)
                passenger.LastName = Encrypt(passenger.LastName);

            if (passenger.PassportNumber != null)
                passenger.PassportNumber = Encrypt(passenger.PassportNumber);

            if (passenger.PassportCountryIssuance != null)
                passenger.PassportCountryIssuance = Encrypt(passenger.PassportCountryIssuance);

            if (passenger.Nationality != null)
                passenger.Nationality = Encrypt(passenger.Nationality);

            // Encrypt date of birth (now a string field that can hold encrypted value)
            if (passenger.DateOfBirth != null)
                passenger.DateOfBirth = Encrypt(passenger.DateOfBirth);

            return passenger;
        }

        /// <summary>
        /// Encrypts all PII fields in a ProcessDgPaymentRequest object.
        /// </summary>
        /// <param name="payment">The payment request object containing PII fields to encrypt.</param>
        /// <returns>The same payment request object with encrypted PII fields.</returns>
        /// <remarks>
        /// Encrypts: firstName, lastName, emailAddress, phoneNumber, addressLine1, addressLine2,
        /// city, stateOrProvince, postalCode, country.
        /// Non-PII fields (paymentToken, pnrReference) remain plaintext.
        /// </remarks>
        public ProcessDgPaymentRequest EncryptPii(ProcessDgPaymentRequest payment)
        {
            if (payment == null)
                return payment;

            // Encrypt cardholder name
            if (payment.FirstName != null)
                payment.FirstName = Encrypt(payment.FirstName);

            if (payment.LastName != null)
                payment.LastName = Encrypt(payment.LastName);

            // Encrypt contact information
            if (payment.EmailAddress != null)
                payment.EmailAddress = Encrypt(payment.EmailAddress);

            if (payment.PhoneNumber != null)
                payment.PhoneNumber = Encrypt(payment.PhoneNumber);

            // Encrypt address fields
            if (payment.AddressLine1 != null)
                payment.AddressLine1 = Encrypt(payment.AddressLine1);

            if (payment.AddressLine2 != null)
                payment.AddressLine2 = Encrypt(payment.AddressLine2);

            if (payment.City != null)
                payment.City = Encrypt(payment.City);

            if (payment.StateOrProvince != null)
                payment.StateOrProvince = Encrypt(payment.StateOrProvince);

            if (payment.PostalCode != null)
                payment.PostalCode = Encrypt(payment.PostalCode);

            if (payment.Country != null)
                payment.Country = Encrypt(payment.Country);

            return payment;
        }
    }
}
