using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface ICfarFlow
    {
        ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractId, UpdateCfarContractFormsOfPaymentRequest request, Boolean paymentCardTokenized, string? sessionId);
    }

    public partial class CfarFlow : ICfarFlow
    {
        public CfarFlow(PaymentApi payment, Encryption encryption, CancelForAnyReasonCFARApi cfar)
        {
            this.PaymentApi = payment;
            this.Encryption = encryption;
            this.CfarApi = cfar;
        }

        public PaymentApi PaymentApi { get; set; }
        public Encryption Encryption { get; set; }
        public CancelForAnyReasonCFARApi CfarApi { get; set; }

        public ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractId, UpdateCfarContractFormsOfPaymentRequest request, Boolean paymentCardTokenized, string? sessionId)
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
                        card.Token,
                        "payment_card"
                    )));
                }
                else if (instance.GetType() == typeof(PaymentCard) || instance is PaymentCard)
                {
                    var card = p.GetPaymentCard();
                    if (paymentCardTokenized) {
                        var method = new PaymentMethod(new CreditCard(card.FirstName, card.LastName, card.Number, card.VerificationValue, card.Month, card.Year));
                        method.Encrypt(this.Encryption);
                        var tokenized = PaymentApi.PostCreditCard(new CreateCreditCardRequest(method));
                        fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                            card.Amount,
                            card.Currency,
                            tokenized.Transaction.PaymentMethod.Token,
                            null,
                            "payment_card"
                        )));
                    } else {
                        fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                            card.Amount,
                            card.Currency,
                            null,
                            "1234",
                            "payment_card"
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
            return CfarApi.PutCfarContractsIdFormsOfPayment(contractId, paymentRequest, sessionId);
        }
    }
}