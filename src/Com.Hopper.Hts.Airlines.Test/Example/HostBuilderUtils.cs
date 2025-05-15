using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SpreedlyClient = Com.Hopper.Hts.Airlines.Spreedly.Client;
using SpreedlyExtensions = Com.Hopper.Hts.Airlines.Spreedly.Extensions;
using HtsfaClient = Com.Hopper.Hts.Airlines.Client;
using HtsfaExtensions = Com.Hopper.Hts.Airlines.Extensions;
using Microsoft.Extensions.Logging;
using Com.Hopper.Hts.Airlines.Client;


namespace Example
{
    public class HostBuilderUtils
    {
        public static IHostBuilder CreateSpreedlyHostBuilder() => SpreedlyExtensions.IHostBuilderExtensions.ConfigureApi(
          Host.CreateDefaultBuilder(Array.Empty<string>()),
          (context, collection, options) => {
            options.AddTokens(new SpreedlyClient.BasicToken(TestSecrets.SpreedlyEnvironmentKey, TestSecrets.SpreedlyAccessToken));
            collection.AddLogging(config => config.SetMinimumLevel(LogLevel.Trace));
          });

        public static IHostBuilder CreateHtsfaHostBuilder() => HtsfaExtensions.IHostBuilderExtensions.ConfigureApi(
          Host.CreateDefaultBuilder(Array.Empty<string>()),
          (context, collection, options) => {
            collection.AddLogging(config => config.SetMinimumLevel(LogLevel.Trace));
            collection.AddSingleton(TestSecrets.CredentialsRequest);

            // Unfortunate side effect of the default BearerToken setup, we need to feed in a value to start.
            options.AddTokens(new HtsfaClient.BearerToken(TestSecrets.HtsfaAccessToken));

            // This is not used, but simply needs to be populated so that the dependency injection step is able to resolve a ApiKey provider
            options.AddTokens(new HtsfaClient.ApiKeyToken("???", HtsfaClient.ClientUtils.ApiKeyHeader.HC_Session_ID));
            options.UseProvider<OAuthProvider, BearerToken>();

            options.AddApiHttpClients(builder: builder => builder.ConfigureHttpClient(configureClient: client => 
              client.BaseAddress = new Uri("https://airlines-api.staging.hopper.com/airline/v1.1/")
            ));
          });
    }
}