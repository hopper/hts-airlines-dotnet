#nullable enable

using System;
using System.Threading.Channels;
using System.Net.Http;
using Duende.IdentityModel.Client;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Com.Hopper.Hts.Airlines.Client
{
    public class OAuthProvider: TokenProvider<BearerToken>
    {
        internal ClientCredentialsTokenRequest Credentials;
        internal Channel<BearerToken> AvailableTokens;
        internal ILogger<object> _logger;

        /// <summary>
        /// Instantiates a ThrottledTokenProvider. Your tokens will be rate limited based on the token's timeout.
        /// </summary>
        /// <param name="container"></param>
        public OAuthProvider(ClientCredentialsTokenRequest credentials, TokenContainer<BearerToken> container, ILogger<object> logger) : base(container.Tokens)
        {
            _logger = logger;
            Credentials = credentials;
            AvailableTokens = Channel.CreateBounded<BearerToken>(new BoundedChannelOptions(container.Tokens.Count)
            {
                FullMode = BoundedChannelFullMode.DropOldest
            });

            foreach (BearerToken token in _tokens)
                token.StartTimer(token.Timeout ?? TimeSpan.FromMilliseconds(40));

            for (int i = 0; i < _tokens.Length; i++)
            {
                _tokens[i].TokenBecameAvailable += (sender) => AvailableTokens.Writer.TryWrite((BearerToken)sender);
            }
        }

        internal async ValueTask<BearerToken> RetrieveNewToken()
        {
            var client = new HttpClient();
            var response = client.RequestTokenAsync(Credentials);
            _logger.LogInformation("Obtained new token");

            var jwt = response.Result ?? throw new Exception("Failed to obtain token");
            string accessToken = jwt.AccessToken ?? throw new Exception("Access token missing");

            BearerToken bearer = new BearerToken(accessToken);
            return bearer;
        }

        internal override async ValueTask<BearerToken> GetAsync(string header = "", System.Threading.CancellationToken cancellation = default)
        {
            var token = await AvailableTokens.Reader.ReadAsync(cancellation).ConfigureAwait(false);
            await AvailableTokens.Writer.WriteAsync(token);
            return token;
        }

        /// <summary>
        /// Retrieves and refreshes a new OAuth bearer token and registers it with the TokenProvider.
        /// </summary>
        /// <returns>True if the token was refreshed successfully.</returns>
        public async Task<bool> RefreshToken()
        {
            _logger.LogTrace("Retrieving new token...");
            var token = await RetrieveNewToken();
            _logger.LogInformation("Retrieved new token successfully");

            token.TokenBecameAvailable += (sender) => AvailableTokens.Writer.TryWrite(token);
            return true;
        }
    }
}
