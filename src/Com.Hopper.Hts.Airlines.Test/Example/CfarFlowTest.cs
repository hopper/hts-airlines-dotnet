using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Flow;
using HtsfaModel = Com.Hopper.Hts.Airlines.Model;
using FlowModel = Com.Hopper.Hts.Airlines.Flow.Model;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using Com.Hopper.Hts.Airlines.Client;
using System.Threading.Tasks;
namespace Example
{
    [TestClass]
    public class PaymentFlowTest
    {
        [TestMethod]
        public async Task Test()
        {
            var spreedlyHost = HostBuilderUtils.CreateSpreedlyHostBuilder().Build();
            var htsfaHost = HostBuilderUtils.CreateHtsfaHostBuilder().Build();

            var paymentApi = spreedlyHost.Services.GetRequiredService<IPaymentApi>() ?? throw new Exception("Payment service not found");
            var cfarApi = htsfaHost.Services.GetRequiredService<ICancelForAnyReasonCFARApi>() ?? throw new Exception("CFAR service not found");
            var sessionApi = htsfaHost.Services.GetRequiredService<ISessionsApi>() ?? throw new Exception("Session service not found");

            var oAuthProvider = htsfaHost.Services.GetRequiredService<OAuthProvider>();

            var paymentFlow = new CfarFlow(paymentApi, TestSecrets.Encryption, cfarApi);

            var sessionId = (await sessionApi.PostSessionsAsync(new HtsfaModel.CreateAirlineSessionRequest(
                HtsfaModel.FlowType.Purchase,
                pointOfSale: "us",
                language: "en"
            ))).Created()?.Id ?? throw new Exception("Session creation failed");

            var offerId = (await cfarApi.PostCfarOffersAsync(
                CfarFixtures.BuildCreateCfarOfferRequest(),
                hCSessionID: sessionId
            )).Created()?[0].Id ?? throw new Exception("Offer creation failed");

            await oAuthProvider.RefreshToken();

            var contractReference = (await cfarApi.PostCfarContractsAsync(CfarFixtures.BuildCreateCfarContractRequest(offerId)))?.Created()?.Reference ?? throw new Exception("Contract creation failed");

            var formsOfPayments = new List<FlowModel.FormOfPayment> {
                new(new FlowModel.Cash("10.00", "USD")),
                new(new FlowModel.NonCash("10.00", "USD")),
                new(new FlowModel.PaymentCard("10.00", "USD", "John", "Smith", "4111111111111111", "123", "01", "2028")),
                new(new FlowModel.Points("10.00")),
                new(new FlowModel.TokenizedPaymentCard("10.00", "USD", "token"))
            };
            var request = new FlowModel.UpdateCfarContractFormsOfPaymentRequest(formsOfPayments);

            var updated = paymentFlow.UpdateCfarContractWithFormsOfPayment(
                contractReference,
                request,
                false,
                sessionId
            );
            Assert.IsNotNull(updated);
        }
    }
}
