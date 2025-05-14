using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System;
using Com.Hopper.Hts.Airlines.Client;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface ICfarFlow
    {
        ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractReference, UpdateCfarContractFormsOfPaymentRequest request, Boolean paymentCardTokenized, string? sessionId);
    }

    public partial class CfarFlow : ICfarFlow
    {
        public CfarFlow(IPaymentApi payment, Encryption encryption, ICancelForAnyReasonCFARApi cfar)
        {
            this.PaymentApi = payment;
            this.Encryption = encryption;
            this.CfarApi = cfar;
        }

        public IPaymentApi PaymentApi { get; set; }
        public Encryption Encryption { get; set; }
        public ICancelForAnyReasonCFARApi CfarApi { get; set; }

        public ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractReference, UpdateCfarContractFormsOfPaymentRequest request, Boolean paymentCardTokenized, string? sessionId)
        {
            var fops = new List<ApiModel.FormOfPayment>();
            foreach (var p in request.FormsOfPayment)
            {
                var instance = p.ActualInstance;
                if (instance.GetType() == typeof(Cash) || instance is Cash)
                {
                    var cash = p.GetCash();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.Cash(
                        cash.Amount,
                        cash.Currency,
                        "cash"
                    )));
                }
                else if (instance.GetType() == typeof(NonCash) || instance is NonCash)
                {
                    var nonCash = p.GetNonCash();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.NonCash(
                        nonCash.Amount,
                        nonCash.Currency,
                        "non_cash"
                    )));
                }
                else if (instance.GetType() == typeof(TokenizedPaymentCard) || instance is TokenizedPaymentCard)
                {
                    var card = p.GetTokenizedPaymentCard();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                        card.Amount,
                        card.Currency,
                        token: card.Token,
                        lastFourDigits: new Option<string?>(),
                        type: "payment_card"
                    )));
                }
                else if (instance.GetType() == typeof(PaymentCard) || instance is PaymentCard)
                {
                    var card = p.GetPaymentCard();
                    if (paymentCardTokenized) {
                        var method = new CreatePaymentMethodRequest(new CreatePaymentMethod(new CreateCreditCard(card.FirstName, card.LastName, card.Number, card.VerificationValue, card.Month, card.Year)));
                        var encrypted = Encryption.Encrypt(method);
                        var tokenized = PaymentApi.PostPaymentMethodAsync(encrypted).Result.Created();
                        fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                            card.Amount,
                            card.Currency,
                            token: tokenized?.Transaction.PaymentMethod.Token ?? throw new InvalidOperationException("Tokenized payment method creation failed."),
                            lastFourDigits: new Option<string?>(),
                            type: "payment_card"
                        )));
                    } else {
                        fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                            card.Amount,
                            card.Currency,
                            token: new Option<string?>(),
                            lastFourDigits: "1234",
                            type: "payment_card"
                        )));
                    }
                }
                else if (instance.GetType() == typeof(Points) || instance is Points)
                {
                    var points = p.GetPoints();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.Points(
                        points.Amount,
                        "points"
                    )));
                }
            }
            var paymentRequest = new ApiModel.UpdateCfarFormOfPaymentRequest(fops);

            var task = CfarApi.PutCfarContractsIdFormsOfPaymentAsync(contractReference, paymentRequest, sessionId ?? new Option<string>());
            var result = task.Result;
            return result ?.Ok() ?? throw new InvalidOperationException("CFAR API response is null or invalid.");
        }
    }
}