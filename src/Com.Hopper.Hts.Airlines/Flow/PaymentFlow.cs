using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Com.Hopper.Hts.Airlines.Spreedly.Model;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IPaymentFlow
    {
        ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractId, UpdateCfarContractFormsOfPaymentRequest request, string? sessionId);
    }

    public partial class PaymentFlow : IPaymentFlow
    {
        public PaymentFlow(PaymentApi payment, CancelForAnyReasonCFARApi cfar)
        {
            this.PaymentApi = payment;
            this.CfarApi = cfar;
        }

        public PaymentApi PaymentApi { get; set; }
        public CancelForAnyReasonCFARApi CfarApi { get; set; }

        public ApiModel.CfarContract UpdateCfarContractWithFormsOfPayment(string contractId, UpdateCfarContractFormsOfPaymentRequest request, string? sessionId)
        {
            var fops = new List<ApiModel.FormOfPayment>();
            foreach (var p in request.FormsOfPayment) {
                var instance = p.ActualInstance;
                if (instance.GetType() == typeof(Cash) || instance is Cash)
                {
                    var cash = p.GetCash();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.Cash {
                        Amount = cash.Amount,
                        Currency = cash.Currency,
                        Type = cash.Type
                    }));
                }
                else if (instance.GetType() == typeof(NonCash) || instance is NonCash)
                {
                    var nonCash = p.GetNonCash();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.NonCash {
                        Amount = nonCash.Amount,
                        Currency = nonCash.Currency,
                        Type = nonCash.Type
                    }));
                }
                else if (instance.GetType() == typeof(TokenizedPaymentCard) || instance is TokenizedPaymentCard)
                {
                    var card = p.GetTokenizedPaymentCard();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard {
                        Amount = card.Amount,
                        Currency = card.Currency,
                        Token = card.Token,
                        Type = card.Type
                    }));
                }
                else if (instance.GetType() == typeof(PaymentCard) || instance is PaymentCard)
                {
                    var card = p.GetPaymentCard();
                    var tokenized = PaymentApi.PostCreditCard(new CreateCreditCardRequest(
                        new PaymentMethod(
                            new CreditCard(card.FirstName, card.LastName, card.Number, card.VerificationValue, card.Month, card.Year)
                        )
                    ));
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.PaymentCard {
                        Amount = card.Amount,
                        Currency = card.Currency,
                        Token = tokenized.Transaction.PaymentMethod.Token,
                        Type = card.Type
                    }));
                }
                else if (instance.GetType() == typeof(Points) || instance is Points)
                {
                    var points = p.GetPoints();
                    fops.Add(new ApiModel.FormOfPayment(new ApiModel.Points {
                        Amount = points.Amount,
                        Type = points.Type
                    }));
                }
            }
            var paymentRequest = new ApiModel.UpdateCfarFormOfPaymentRequest {
                FormsOfPayment = fops
            };
            return CfarApi.PutCfarContractsIdFormsOfPayment(contractId, paymentRequest, sessionId);
        }
    }
}