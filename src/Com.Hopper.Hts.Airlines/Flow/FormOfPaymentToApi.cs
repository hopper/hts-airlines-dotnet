using System;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Api;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IFormOfPaymentToApi
    {
        public ApiModel.FormOfPayment ToApi(FormOfPayment p, bool shouldTokenize);
    }
    public partial class FormOfPaymentToApi: IFormOfPaymentToApi
    {
        internal Encryption Encryption;
        internal IPaymentApi PaymentApi;

        public FormOfPaymentToApi(Encryption encryption, IPaymentApi paymentApi)
        {
            Encryption = encryption;
            PaymentApi = paymentApi;
        }

        public ApiModel.FormOfPayment ToApi(FormOfPayment p, bool shouldTokenize)
        {
            var instance = p.ActualInstance;
            if (instance.GetType() == typeof(Cash) || instance is Cash)
            {
                var cash = p.GetCash();
                return new ApiModel.FormOfPayment(new ApiModel.Cash(
                    cash.Amount,
                    cash.Currency,
                    "cash"
                ));
            }
            else if (instance.GetType() == typeof(NonCash) || instance is NonCash)
            {
                var nonCash = p.GetNonCash();
                return new ApiModel.FormOfPayment(new ApiModel.NonCash(
                    nonCash.Amount,
                    nonCash.Currency,
                    "non_cash"
                ));
            }
            else if (instance.GetType() == typeof(TokenizedPaymentCard) || instance is TokenizedPaymentCard)
            {
                var card = p.GetTokenizedPaymentCard();
                return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                    card.Amount,
                    card.Currency,
                    token: card.Token,
                    lastFourDigits: new Option<string?>(),
                    type: "payment_card"
                ));
            }
            else if (instance.GetType() == typeof(PaymentCard) || instance is PaymentCard)
            {
                var card = p.GetPaymentCard();
                if (shouldTokenize)
                {
                    var method = new Spreedly.Model.CreatePaymentMethodRequest(new Spreedly.Model.CreatePaymentMethod(new Spreedly.Model.CreateCreditCard(
                        firstName: card.FirstName,
                        lastName: card.LastName,
                        number: card.Number,
                        verificationValue: card.VerificationValue,
                        month: card.Month,
                        year: card.Year
                    )));
                    var encrypted = Encryption.Encrypt(method);
                    var tokenized = PaymentApi.PostPaymentMethodAsync(encrypted).Result.Created();
                    return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                        card.Amount,
                        card.Currency,
                        token: tokenized?.Transaction.PaymentMethod.Token ?? throw new InvalidOperationException("Tokenized payment method creation failed."),
                        lastFourDigits: new Option<string?>(),
                        type: "payment_card"
                    ));
                }
                else
                {
                    return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                        card.Amount,
                        card.Currency,
                        token: new Option<string?>(),
                        lastFourDigits: "1234",
                        type: "payment_card"
                    ));
                }
            }
            else if (instance.GetType() == typeof(Points) || instance is Points)
            {
                var points = p.GetPoints();
                return new ApiModel.FormOfPayment(new ApiModel.Points(
                    points.Amount,
                    "points"
                ));
            }
            else
            {
                throw new ArgumentException("Unsupported payment method type");
            }
        }
    }
}

