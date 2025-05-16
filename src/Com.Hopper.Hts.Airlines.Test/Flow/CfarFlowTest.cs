using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Flow;
using HtsfaModel = Com.Hopper.Hts.Airlines.Model;
using FlowModel = Com.Hopper.Hts.Airlines.Flow.Model;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Com.Hopper.Hts.Airlines.Test.Fixtures;

namespace Com.Hopper.Hts.Airlines.Test.Flow
{
    [TestClass]
    public class CfarFlowTest: FlowTestsBase
    {
        private readonly ICfarFlow _flow;
        private readonly ICancelForAnyReasonCFARApi _cfarApi;
        private readonly ISessionsApi _sessionApi;

        public CfarFlowTest() : base(Array.Empty<string>())
        {
            _flow = _host.Services.GetRequiredService<ICfarFlow>();
            _cfarApi = _host.Services.GetRequiredService<ICancelForAnyReasonCFARApi>();
            _sessionApi = _host.Services.GetRequiredService<ISessionsApi>();
        }

        [TestMethod]
        public async Task Test()
        {
            var sessionId = (await _sessionApi.PostSessionsAsync(new HtsfaModel.CreateAirlineSessionRequest(
                HtsfaModel.FlowType.Purchase,
                pointOfSale: "us",
                language: "en"
            ))).Created()?.Id ?? throw new Exception("Session creation failed");

            var offerId = _cfarApi.PostCfarOffersAsync(
                CfarFixtures.BuildCreateCfarOfferRequest(),
                hCSessionID: sessionId
            ).Result.Created()?[0].Id ?? throw new Exception("Offer creation failed");

            var contractReference = (await _cfarApi.PostCfarContractsAsync(CfarFixtures.BuildCreateCfarContractRequest(offerId))).Created()?.Reference ?? throw new Exception("Contract creation failed");

            var formsOfPayments = new List<FlowModel.FormOfPayment> {
                new(new FlowModel.Cash("10.00", "USD")),
                new(new FlowModel.NonCash("10.00", "USD")),
                new(new FlowModel.PaymentCard("10.00", "USD", "John", "Smith", "4111111111111111", "123", "01", "2028")),
                new(new FlowModel.Points("10.00")),
                new(new FlowModel.TokenizedPaymentCard("10.00", "USD", "token"))
            };
            var request = new FlowModel.UpdateCfarContractFormsOfPaymentRequest(formsOfPayments);

            var updated = await _flow.UpdateCfarContractWithFormsOfPayment(
                contractReference,
                request,
                shouldTokenize: true,
                sessionId
            );
            Assert.IsNotNull(updated);
        }
    }
}
