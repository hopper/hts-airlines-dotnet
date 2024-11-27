using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System.Diagnostics;
using System;

Configuration config = new Configuration
{
    BasePath = "https://core.spreedly.com",
    Username = "???",
    Password = "???"
};

var paymentApi = new PaymentApi(config);

var encryption = new Encryption { 
    CertificateToken = "???",
    PublicKey = "???"
};

try
{
    var paymentMethod = new PaymentMethod(
        new CreditCard(
            "John",
            "Smith",
            "4111111111111111",
            "123",
            "01",
            "2028"
        )
    );
    paymentMethod.Encrypt(encryption);

    var request = new CreateCreditCardRequest(paymentMethod);
    var response = paymentApi.PostCreditCard(request);
    Debug.Print("Got token: " + response.Transaction.Token);
}
catch (ApiException e)
{
    Console.WriteLine("Uh oh: " + e);
}
