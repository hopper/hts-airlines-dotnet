using System;
using System.Threading;
using System.Threading.Tasks;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Spreedly.Model;

namespace Com.Hopper.Hts.Airlines.Spreedly.Services
{
    /// <summary>
    /// Provides a method to tokenize credit card information.
    /// </summary>
    public interface ICardTokenizer
    {
        /// <summary>
        /// Tokenizes the specified credit card and returns a token string.
        /// </summary>
        /// <param name="card">The credit card to tokenize.</param>
        /// <param name="cancellation">A cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the token string.</returns>
        public Task<string> Tokenize(CreateCreditCard card, CancellationToken cancellation = default);
    }

    /// <summary>
    /// Provides functionality to tokenize credit card information using a payment API.
    /// </summary>
    public class CardTokenizer: ICardTokenizer
    {
        internal IPaymentApi _api;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTokenizer"/> class with the specified payment API.
        /// </summary>
        /// <param name="api">The payment API to use for tokenizing cards.</param>
        public CardTokenizer(IPaymentApi api)
        {
            _api = api;
        }

        /// <summary>
        /// Tokenizes the specified credit card and returns a token string.
        /// </summary>
        /// <param name="card">The credit card to tokenize.</param>
        /// <param name="cancellation">A cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the token string.</returns>
        public async Task<string> Tokenize(CreateCreditCard card, CancellationToken cancellation = default)
        {
            var method = new CreatePaymentMethodRequest(new CreatePaymentMethod(new CreateCreditCard(
                firstName: card.FirstName,
                lastName: card.LastName,
                number: card.Number,
                verificationValue: card.VerificationValue,
                month: card.Month,
                year: card.Year
            )));
            var tokenized = (await _api.PostPaymentMethodAsync(method, cancellation)).Created();
            return tokenized?.Transaction.PaymentMethod.Token ?? throw new InvalidOperationException("Tokenized payment method creation failed.");
        }
    }

    /// <summary>
    /// Provides functionality to tokenize and encrypt credit card information using a payment API.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <b>EncryptedCardTokenizer</b> is responsible for securely tokenizing credit card data by first encrypting the card information
    /// before sending it to the payment API. This ensures that sensitive card details are protected during transmission.
    /// </para>
    /// <para>
    /// The class requires an <see cref="Encryption"/> instance to perform encryption and an <see cref="IPaymentApi"/> instance to interact with the payment API.
    /// </para>
    /// </remarks>
    public class EncryptedCardTokenizer : ICardTokenizer
    {
        internal Encryption _encryption;
        internal IPaymentApi _api;

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedCardTokenizer"/> class with the specified encryption credentials and payment API.
        /// </summary>
        /// <param name="encryption">The encryption credentials used to encrypt card data.</param>
        /// <param name="api">The payment API used to tokenize the encrypted card data.</param>
        public EncryptedCardTokenizer(Encryption encryption, IPaymentApi api)
        {
            _encryption = encryption;
            _api = api;
        }

        /// <summary>
        /// Encrypts the provided credit card information, sends it to the payment API for tokenization,
        /// and returns the resulting payment method token.
        /// </summary>
        /// <param name="card">The credit card information to encrypt and tokenize.</param>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains the token string for the encrypted and tokenized card.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if tokenized payment method creation fails.
        /// </exception>
        public async Task<string> Tokenize(CreateCreditCard card, CancellationToken cancellationToken = default)
        {
            var method = new CreatePaymentMethodRequest(new CreatePaymentMethod(card));
            var encrypted = _encryption.Encrypt(method);
            var tokenized = (await _api.PostPaymentMethodAsync(encrypted, cancellationToken)).Created();
            return tokenized?.Transaction.PaymentMethod.Token ?? throw new InvalidOperationException("Tokenized payment method creation failed.");
        }
    }
}