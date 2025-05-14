using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Sdk;

namespace Example
{

    [TestClass]
    public class PaymentApiTest
    {
        [TestMethod]
        public void TokenizeTest()
        {
            var host = HostBuilderUtils.CreateSpreedlyHostBuilder().Build();
            var paymentApi = host.Services.GetRequiredService<IPaymentApi>();

            try
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
                var response = paymentApi.PostPaymentMethodAsync(request).Result.Created() ?? throw new Exception("Payment method tokenization failed");
                var transaction = response.Transaction ?? throw new Exception("Creation failed");
                Debug.Print("Transaction: " + transaction);

                Assert.IsNotNull(transaction?.PaymentMethod.Token);
            }
            catch (Com.Hopper.Hts.Airlines.Spreedly.Client.ApiException e)
            {
                Console.WriteLine("Uh oh: " + e);
            }
            // task.Dispose();
        }

        [TestMethod]
        public void TokenizeWithEncryptionTest()
        {
            var host = HostBuilderUtils.CreateSpreedlyHostBuilder().Build();
            var paymentApi = host.Services.GetRequiredService<IPaymentApi>();

            try
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
                var task = paymentApi.PostPaymentMethodAsync(encrypted);
                var response = task.Result.Created() ?? throw new Exception("Payment method tokenization failed");
                var transaction = response.Transaction ?? throw new Exception("Creation failed");
                Debug.Print("Transaction: " + transaction);

                Assert.IsNotNull(transaction?.PaymentMethod.Token);
            }
            catch (Com.Hopper.Hts.Airlines.Spreedly.Client.ApiException e)
            {
                Console.WriteLine("Uh oh: " + e);
            }
        }
    }
}

