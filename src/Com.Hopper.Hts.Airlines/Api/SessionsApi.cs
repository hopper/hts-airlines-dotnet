/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Client.Auth;
using Com.Hopper.Hts.Airlines.Model;

namespace Com.Hopper.Hts.Airlines.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Session
        /// </summary>
        /// <remarks>
        /// Create a new session for which events will be collected.
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AirlineSession</returns>
        AirlineSession PostSessions(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0);

        /// <summary>
        /// Create a Session
        /// </summary>
        /// <remarks>
        /// Create a new session for which events will be collected.
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AirlineSession</returns>
        ApiResponse<AirlineSession> PostSessionsWithHttpInfo(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a Session
        /// </summary>
        /// <remarks>
        /// Create a new session for which events will be collected.
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AirlineSession</returns>
        System.Threading.Tasks.Task<AirlineSession> PostSessionsAsync(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Create a Session
        /// </summary>
        /// <remarks>
        /// Create a new session for which events will be collected.
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AirlineSession)</returns>
        System.Threading.Tasks.Task<ApiResponse<AirlineSession>> PostSessionsWithHttpInfoAsync(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISessionsApi : ISessionsApiSync, ISessionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SessionsApi : ISessionsApi
    {
        private Com.Hopper.Hts.Airlines.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SessionsApi(string basePath)
        {
            this.Configuration = Com.Hopper.Hts.Airlines.Client.Configuration.MergeConfigurations(
                Com.Hopper.Hts.Airlines.Client.GlobalConfiguration.Instance,
                new Com.Hopper.Hts.Airlines.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Hopper.Hts.Airlines.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Hopper.Hts.Airlines.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Hopper.Hts.Airlines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SessionsApi(Com.Hopper.Hts.Airlines.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Hopper.Hts.Airlines.Client.Configuration.MergeConfigurations(
                Com.Hopper.Hts.Airlines.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Hopper.Hts.Airlines.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Hopper.Hts.Airlines.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Hopper.Hts.Airlines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SessionsApi(Com.Hopper.Hts.Airlines.Client.ISynchronousClient client, Com.Hopper.Hts.Airlines.Client.IAsynchronousClient asyncClient, Com.Hopper.Hts.Airlines.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Hopper.Hts.Airlines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Hopper.Hts.Airlines.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Hopper.Hts.Airlines.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Hopper.Hts.Airlines.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Hopper.Hts.Airlines.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a Session Create a new session for which events will be collected.
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AirlineSession</returns>
        public AirlineSession PostSessions(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0)
        {
            Com.Hopper.Hts.Airlines.Client.ApiResponse<AirlineSession> localVarResponse = PostSessionsWithHttpInfo(createAirlineSessionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Session Create a new session for which events will be collected.
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AirlineSession</returns>
        public Com.Hopper.Hts.Airlines.Client.ApiResponse<AirlineSession> PostSessionsWithHttpInfo(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0)
        {
            // verify the required parameter 'createAirlineSessionRequest' is set
            if (createAirlineSessionRequest == null)
            {
                throw new Com.Hopper.Hts.Airlines.Client.ApiException(400, "Missing required parameter 'createAirlineSessionRequest' when calling SessionsApi->PostSessions");
            }

            Com.Hopper.Hts.Airlines.Client.RequestOptions localVarRequestOptions = new Com.Hopper.Hts.Airlines.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Hopper.Hts.Airlines.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Hopper.Hts.Airlines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = createAirlineSessionRequest;

            localVarRequestOptions.Operation = "SessionsApi.PostSessions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (PartnerAuth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AirlineSession>("/sessions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostSessions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a Session Create a new session for which events will be collected.
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AirlineSession</returns>
        public async System.Threading.Tasks.Task<AirlineSession> PostSessionsAsync(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Com.Hopper.Hts.Airlines.Client.ApiResponse<AirlineSession> localVarResponse = await PostSessionsWithHttpInfoAsync(createAirlineSessionRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Session Create a new session for which events will be collected.
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAirlineSessionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AirlineSession)</returns>
        public async System.Threading.Tasks.Task<Com.Hopper.Hts.Airlines.Client.ApiResponse<AirlineSession>> PostSessionsWithHttpInfoAsync(CreateAirlineSessionRequest createAirlineSessionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'createAirlineSessionRequest' is set
            if (createAirlineSessionRequest == null)
            {
                throw new Com.Hopper.Hts.Airlines.Client.ApiException(400, "Missing required parameter 'createAirlineSessionRequest' when calling SessionsApi->PostSessions");
            }


            Com.Hopper.Hts.Airlines.Client.RequestOptions localVarRequestOptions = new Com.Hopper.Hts.Airlines.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Hopper.Hts.Airlines.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Hopper.Hts.Airlines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = createAirlineSessionRequest;

            localVarRequestOptions.Operation = "SessionsApi.PostSessions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (PartnerAuth) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AirlineSession>("/sessions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostSessions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}