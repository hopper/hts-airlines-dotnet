using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Com.Hopper.Hts.Airlines.Flow.Extensions;
using SpreedlyClient = Com.Hopper.Hts.Airlines.Spreedly.Client;
using Microsoft.Extensions.Logging;
using Com.Hopper.Hts.Airlines.Spreedly.Services;

namespace Com.Hopper.Hts.Airlines.Test.Flow
{
  public class FlowTestsBase
  {
    protected readonly IHost _host;

    public FlowTestsBase(string[] args)
    {
      _host = CreateHostBuilder(args).Build();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
      var builder = Host.CreateDefaultBuilder(args);
      builder.ConfigureFlows(
        configureApi: (context, collection, options) =>
        {
          options.AddApiHttpClients(builder: builder => builder.ConfigureHttpClient(configureClient: client =>
            client.BaseAddress = new Uri("https://airlines-api.staging.hopper.com/airline/v1.1/")
          ));
          collection.AddTransient<ICardTokenizer, CardTokenizer>();
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