using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Sdk;
using System.Threading.Tasks;

namespace Com.Hopper.Hts.Airlines.Test.Spreedly.Api
{

    [TestClass]
    public class PaymentApiTest: ApiTestsBase
    {
        private readonly IPaymentApi _api;
        public PaymentApiTest() : base(Array.Empty<string>())
        {
            _api = _host.Services.GetRequiredService<IPaymentApi>();
        }

        [TestMethod]
        public void TokenizeTest()
        {

            var request = new CreatePaymentMethodRequest(
                new CreatePaymentMethod(
                    new CreateCreditCard(
                        "John",
                        "Smith",
                        "4111111111111111",
                        "123",
                        "01",
                        "2028"
                    )
                )
            );
            var response = _api.PostPaymentMethodAsync(request).Result.Created() ?? throw new Exception("Payment method tokenization failed");
            var transaction = response.Transaction ?? throw new Exception("Creation failed");
            Debug.Print("Transaction: " + transaction);

            Assert.IsNotNull(transaction?.PaymentMethod.Token);
        }

        [TestMethod]
        public async Task TokenizeWithEncryptionTest()
        {
            var request = new CreatePaymentMethodRequest(
                new CreatePaymentMethod(
                    new CreateCreditCard(
                        "John",
                        "Smith",
                        "4111111111111111",
                        "123",
                        "01",
                        "2028"
                    )
                )
            );
            var encrypted = TestSecrets.Encryption.Encrypt(request);
            var response = (await _api.PostPaymentMethodAsync(encrypted)).Created() ?? throw new Exception("Payment method tokenization failed");
            var transaction = response.Transaction;
            Debug.Print("Transaction: " + transaction);

            Assert.IsNotNull(transaction.PaymentMethod.Token);
        }
    }
}

