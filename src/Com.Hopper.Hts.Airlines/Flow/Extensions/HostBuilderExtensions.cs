using System;
using Com.Hopper.Hts.Airlines.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HtsfaExtensions = Com.Hopper.Hts.Airlines.Extensions;
using SpreedlyExtensions = Com.Hopper.Hts.Airlines.Spreedly.Extensions;

namespace Com.Hopper.Hts.Airlines.Flow.Extensions
{
    /// <summary>
    /// Provides extension methods for configuring flows on the host builder.
    /// </summary>
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// Configures the flows for the host builder, including API and Spreedly integration.
        /// </summary>
        /// <param name="builder">The host builder to configure.</param>
        /// <param name="spreedlyToken">The Spreedly basic token to use for authentication.</param>
        /// <param name="configureApi">An action to configure the API with host context, service collection, and host configuration.</param>
        /// <returns>The configured <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder ConfigureFlows(
            this IHostBuilder builder,
            Spreedly.Client.BasicToken spreedlyToken,
            Action<HostBuilderContext, IServiceCollection, HostConfiguration> configureApi
        ) {
            builder = HtsfaExtensions.IHostBuilderExtensions.ConfigureApi(
                builder,
                (context, collection, options) =>
                {
                    configureApi.Invoke(context, collection, options);
                    collection.AddTransient<IFormOfPaymentToApi, FormOfPaymentToApi>();
                    collection.AddTransient<ICfarFlow, CfarFlow>();
                    collection.AddTransient<IDgFlow, DgFlow>();

                    // Unfortunate side effect of the default BearerToken setup, we need to feed in a value to start.
                    options.AddTokens(new BearerToken("throwaway"));

                    // This is not used, but simply needs to be populated so that the dependency injection step is able to resolve a ApiKey provider
                    options.AddTokens(new ApiKeyToken("throwaway", ClientUtils.ApiKeyHeader.HC_Session_ID));
                    options.UseProvider<HopperAuthProvider, BearerToken>();
                });
            builder = SpreedlyExtensions.IHostBuilderExtensions.ConfigureApi(
                builder,
                (context, collection, options) =>
                {
                    options.AddTokens(spreedlyToken);
                }
            );
            return builder;
        }
    }
}