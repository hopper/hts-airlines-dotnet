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
    public class DgFlowTest: FlowTestsBase
    {
        private readonly IDgFlow _flow;
        private readonly IDisruptionGuaranteeDGApi _dgApi;
        private readonly ISessionsApi _sessionApi;

        public DgFlowTest() : base(Array.Empty<string>())
        {
            _flow = _host.Services.GetRequiredService<IDgFlow>();
            _dgApi = _host.Services.GetRequiredService<IDisruptionGuaranteeDGApi>();
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

            var offerId = _dgApi.PostDgOffersAsync(
                DgFixtures.BuildCreateOfferRequest(),
                hCSessionID: sessionId
            ).Result.Created()?[0].Id ?? throw new Exception("Offer creation failed");

            var contractId = (await _dgApi.PostDgContractsAsync(DgFixtures.BuildCreateContractRequest(offerId))).Created()?.Id ?? throw new Exception("Contract creation failed");

            var formsOfPayments = new List<FlowModel.FormOfPayment> {
                new(new FlowModel.Cash("10.00", "USD")),
                new(new FlowModel.NonCash("10.00", "USD")),
                new(new FlowModel.PaymentCard("10.00", "USD", "John", "Smith", "4111111111111111", "123", "01", "2028")),
                new(new FlowModel.Points("10.00")),
                new(new FlowModel.TokenizedPaymentCard("10.00", "USD", "token"))
            };
            var request = new FlowModel.UpdateDgContractStatusRequest(
                status: HtsfaModel.DgStatus.Confirmed,
                firstName: "John",
                lastName: "Smith",
                pnrReference: "ABCDEF",
                emailAddress: "someone@example.com",
                phoneNumber: "+1234567890",
                addressLine1: "123 Broadway",
                addressLine2: "Apt 1A",
                city: "New York",
                stateOrProvince: "New York",
                postalCode: "12345",
                country: "US",
                taxes: new(new List<HtsfaModel.DgTax>
                {
                    new(name: "tax 1", rate: "0.1", amount: "1.00")
                }),
                taxesTotal: "1.00",
                formsOfPayment: formsOfPayments
            );

            var updated = await _flow.UpdateDgContractStatus(
                contractId,
                request,
                shouldTokenize: true
            );
            Assert.IsNotNull(updated);
        }
    }
}
