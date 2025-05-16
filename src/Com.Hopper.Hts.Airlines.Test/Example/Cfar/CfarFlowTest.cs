using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Flow;
using HtsfaModel = Com.Hopper.Hts.Airlines.Model;
using FlowModel = Com.Hopper.Hts.Airlines.Flow.Model;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Example.Cfar
{
    [TestClass]
    public class PaymentFlowTest
    {
        [TestMethod]
        public async Task Test()
        {
            var host = HostBuilderUtils.CreateHostBuilder().Build();

            var cfarApi = host.Services.GetRequiredService<ICancelForAnyReasonCFARApi>() ?? throw new Exception("CFAR service not found");
            var sessionApi = host.Services.GetRequiredService<ISessionsApi>() ?? throw new Exception("Session service not found");
            var paymentFlow = host.Services.GetRequiredService<CfarFlow>(); 

            var sessionId = (await sessionApi.PostSessionsAsync(new HtsfaModel.CreateAirlineSessionRequest(
                HtsfaModel.FlowType.Purchase,
                pointOfSale: "us",
                language: "en"
            ))).Created()?.Id ?? throw new Exception("Session creation failed");

            var offerId = cfarApi.PostCfarOffersAsync(
                CfarFixtures.BuildCreateCfarOfferRequest(),
                hCSessionID: sessionId
            ).Result.Created()?[0].Id ?? throw new Exception("Offer creation failed");

            var contractReference = (await cfarApi.PostCfarContractsAsync(CfarFixtures.BuildCreateCfarContractRequest(offerId))).Created()?.Reference ?? throw new Exception("Contract creation failed");

            var formsOfPayments = new List<FlowModel.FormOfPayment> {
                new(new FlowModel.Cash("10.00", "USD")),
                new(new FlowModel.NonCash("10.00", "USD")),
                new(new FlowModel.PaymentCard("10.00", "USD", "John", "Smith", "4111111111111111", "123", "01", "2028")),
                new(new FlowModel.Points("10.00")),
                new(new FlowModel.TokenizedPaymentCard("10.00", "USD", "token"))
            };
            var request = new FlowModel.UpdateCfarContractFormsOfPaymentRequest(formsOfPayments);

            var updated = await paymentFlow.UpdateCfarContractWithFormsOfPayment(
                contractReference,
                request,
                false,
                sessionId
            );
            Assert.IsNotNull(updated);
        }
    }
}
