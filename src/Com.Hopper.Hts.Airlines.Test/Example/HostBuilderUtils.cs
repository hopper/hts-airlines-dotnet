using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SpreedlyClient = Com.Hopper.Hts.Airlines.Spreedly.Client;
using SpreedlyExtensions = Com.Hopper.Hts.Airlines.Spreedly.Extensions;
using HtsfaClient = Com.Hopper.Hts.Airlines.Client;
using HtsfaExtensions = Com.Hopper.Hts.Airlines.Extensions;
using Microsoft.Extensions.Logging;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Flow;
using Com.Hopper.Hts.Airlines.Spreedly.Model;


namespace Example
{
  public class HostBuilderUtils
  {
    public static IHostBuilder CreateHostBuilder()
    {
      var builder = Host.CreateDefaultBuilder(Array.Empty<string>());

      builder = HtsfaExtensions.IHostBuilderExtensions.ConfigureApi(
        builder,
        (context, collection, options) =>
        {
          collection.AddLogging(config => config.SetMinimumLevel(LogLevel.Trace));
          collection.AddSingleton(TestSecrets.Credentials);
          collection.AddTransient<IFormOfPaymentToApi, FormOfPaymentToApi>();
          collection.AddTransient<ICfarFlow, CfarFlow>();
          collection.AddTransient<IDgFlow, DgFlow>();
          collection.AddSingleton(TestSecrets.Encryption);

          // Unfortunate side effect of the default BearerToken setup, we need to feed in a value to start.
          options.AddTokens(new HtsfaClient.BearerToken(TestSecrets.HtsfaAccessTokenThrowaway));

          // This is not used, but simply needs to be populated so that the dependency injection step is able to resolve a ApiKey provider
          options.AddTokens(new HtsfaClient.ApiKeyToken("???", HtsfaClient.ClientUtils.ApiKeyHeader.HC_Session_ID));
          options.UseProvider<HopperAuthProvider, BearerToken>();

          options.AddApiHttpClients(builder: builder => builder.ConfigureHttpClient(configureClient: client =>
            client.BaseAddress = new Uri("https://airlines-api.staging.hopper.com/airline/v1.1/")
          ));
        });
      builder = SpreedlyExtensions.IHostBuilderExtensions.ConfigureApi(
        builder,
        (context, collection, options) =>
        {
          collection.AddLogging(config => config.SetMinimumLevel(LogLevel.Trace));
          options.AddTokens(new SpreedlyClient.BasicToken(
            username: TestSecrets.SpreedlyEnvironmentKey,
            password: TestSecrets.SpreedlyAccessToken
          ));
        }
      );
      return builder;
    }
  }
}