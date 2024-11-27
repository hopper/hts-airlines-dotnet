using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Flow;
using Com.Hopper.Hts.Airlines.Flow.Model;
using System.Collections.Generic;

namespace Example
{

    [TestClass]
    public class PaymentFlowTest
    {
        [TestMethod]
        public void Test()
        {
            Configuration config = new Configuration
            {
                BasePath = "???",
                Username = "???",
                Password = "???"
            };

            var paymentApi = new PaymentApi(config);

            var encryption = new Encryption
            {
                CertificateToken = "???",
                PublicKey = "???"
            };

            var cfarApi = new CancelForAnyReasonCFARApi(config);

            var paymentFlow = new PaymentFlow(paymentApi, cfarApi);

            var contractId = "contract-id";
            var sessionId = "session-id";

            var formsOfPayments = new List<FormOfPayment> {
                new FormOfPayment(new Cash("10.00", "USD")),
                new FormOfPayment(new NonCash("10.00", "USD")),
                new FormOfPayment(new PaymentCard("10.00", "USD", "John", "Smith", "4111111111111111", "123", "01", "2028")),
                new FormOfPayment(new Points("10.00")),
                new FormOfPayment(new TokenizedPaymentCard("10.00", "USD", "token"))
            };
            var request = new UpdateCfarContractFormsOfPaymentRequest(formsOfPayments);

            var updated = paymentFlow.UpdateCfarContractWithFormsOfPayment(
                contractId,
                request,
                sessionId
            );
            Assert.IsNotNull(updated);
        }
    }
}

