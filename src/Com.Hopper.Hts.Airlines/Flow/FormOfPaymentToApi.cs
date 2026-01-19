using System;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Services;
using System.Threading.Tasks;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IFormOfPaymentToApi
    {
        public Task<ApiModel.FormOfPayment> ToApi(FormOfPayment p, bool shouldTokenize);
    }
    public partial class FormOfPaymentToApi: IFormOfPaymentToApi
    {
        internal ICardTokenizer _tokenizer;

        public FormOfPaymentToApi(ICardTokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        public async Task<ApiModel.FormOfPayment> ToApi(FormOfPayment p, bool shouldTokenize)
        {
            var instance = p.ActualInstance;
            if (instance.GetType() == typeof(Cash) || instance is Cash)
            {
                var cash = p.GetCash();
                return new ApiModel.FormOfPayment(new ApiModel.Cash(
                    cash.Amount,
                    cash.Currency,
                    ApiModel.Cash.TypeEnumFromString("cash")
                ));
            }
            else if (instance.GetType() == typeof(NonCash) || instance is NonCash)
            {
                var nonCash = p.GetNonCash();
                return new ApiModel.FormOfPayment(new ApiModel.NonCash(
                    nonCash.Amount,
                    nonCash.Currency,
                    ApiModel.NonCash.TypeEnumFromString("non_cash")
                ));
            }
            else if (instance.GetType() == typeof(TokenizedPaymentCard) || instance is TokenizedPaymentCard)
            {
                var card = p.GetTokenizedPaymentCard();
                return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                    card.Amount,
                    card.Currency,
                    ApiModel.PaymentCard.TypeEnumFromString("payment_card"),
                    token: card.Token,
                    lastFourDigits: new Option<string?>()
                ));
            }
            else if (instance.GetType() == typeof(PaymentCard) || instance is PaymentCard)
            {
                var card = p.GetPaymentCard();
                if (shouldTokenize)
                {
                    var token = await _tokenizer.Tokenize(new CreateCreditCard(
                        firstName: card.FirstName,
                        lastName: card.LastName,
                        number: card.Number,
                        verificationValue: card.VerificationValue,
                        month: card.Month,
                        year: card.Year
                    ));
                    return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                        card.Amount,
                        card.Currency,
                        ApiModel.PaymentCard.TypeEnumFromString("payment_card"),
                        token: token,
                        lastFourDigits: new Option<string?>()
                    ));
                }
                else
                {
                    return new ApiModel.FormOfPayment(new ApiModel.PaymentCard(
                        card.Amount,
                        card.Currency,
                        ApiModel.PaymentCard.TypeEnumFromString("payment_card"),
                        token: new Option<string?>(),
                        lastFourDigits: new Option<string?>("1234")
                    ));
                }
            }
            else if (instance.GetType() == typeof(Points) || instance is Points)
            {
                var points = p.GetPoints();
                return new ApiModel.FormOfPayment(new ApiModel.Points(
                    points.Amount,
                    ApiModel.Points.TypeEnumFromString("points")
                ));
            }
            else
            {
                throw new ArgumentException("Unsupported payment method type");
            }
        }
    }
}

