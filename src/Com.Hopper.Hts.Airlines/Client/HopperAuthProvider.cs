#nullable enable

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Model;
using System.Text.Json;
using System.Net.Http.Headers;

namespace Com.Hopper.Hts.Airlines.Client
{
    /// <summary>
    /// Provides OAuth bearer tokens using client credentials flow.
    /// </summary>
    public class HopperAuthProvider: TokenProvider<BearerToken>
    {
        internal HopperCredentials Credentials;
        internal ILogger<object> _logger;
        internal IAuthenticationApi _api;
        internal JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// Instantiates a OAuthProvider. Tokens can be refreshed periodically.
        /// </summary>
        /// <param name="container"></param>
        public HopperAuthProvider(HopperCredentials credentials, TokenContainer<BearerToken> container, ILogger<object> logger, JsonSerializerOptionsProvider jsonSerializerOptionsProvider) : base(container.Tokens)
        {
            _logger = logger;
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Credentials = credentials;
        }

        internal async ValueTask<AuthResponse> RetrieveNewToken(System.Threading.CancellationToken cancellation = default)
        {
            var client = new HttpClient();

            var authRequest = new AuthRequest(clientId: Credentials.ClientId, clientSecret: Credentials.ClientSecret);

            using var req = new HttpRequestMessage(HttpMethod.Post, Credentials.Address);
            req.Content = new StringContent(JsonSerializer.Serialize(authRequest, options: null));
            var accepts = ClientUtils.SelectHeaderAccept(new string[] { "application/json" });
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType: accepts));

            try
            {
                using var raw = await client.SendAsync(req, cancellation);
                string message = await raw.Content.ReadAsStringAsync(cancellation).ConfigureAwait(false);
                AuthenticationApi.PostAuthApiResponse resp = new(logger: null, httpRequestMessage: req, raw, message, "", default, _jsonSerializerOptions);

                var response = resp.Created() ?? throw new Exception("Failed to create token");

                _logger.LogInformation("Obtained new token");

                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to obtain token");
                throw;
            }
            
        }

        internal override async ValueTask<BearerToken> GetAsync(string header = "", System.Threading.CancellationToken cancellation = default)
        {
            return new BearerToken((await RetrieveNewToken(cancellation)).AccessToken);
        }
    }
}
