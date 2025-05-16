using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Com.Hopper.Hts.Airlines.Flow.Extensions;
using SpreedlyClient = Com.Hopper.Hts.Airlines.Spreedly.Client;
using Microsoft.Extensions.Logging;
using Com.Hopper.Hts.Airlines.Spreedly.Services;


namespace Example
{
  public class HostBuilderUtils
  {
    public static IHostBuilder CreateHostBuilder()
    {
      var builder = Host.CreateDefaultBuilder(Array.Empty<string>());
      builder.ConfigureFlows(
        configureApi: (context, collection, options) =>
        {
          options.AddApiHttpClients(builder: builder => builder.ConfigureHttpClient(configureClient: client =>
            client.BaseAddress = new Uri("https://airlines-api.staging.hopper.com/airline/v1.1/")
          ));
          collection.AddTransient<ICardTokenizer, EncryptedCardTokenizer>();
          collection.AddLogging(config => config.SetMinimumLevel(LogLevel.Trace));
          collection.AddSingleton(TestSecrets.Credentials);
          collection.AddSingleton(TestSecrets.Encryption);
        },
        spreedlyToken: new SpreedlyClient.BasicToken(
          username: TestSecrets.SpreedlyEnvironmentKey,
          password: TestSecrets.SpreedlyAccessToken
        )
      );
      return builder;
    }
  }
}