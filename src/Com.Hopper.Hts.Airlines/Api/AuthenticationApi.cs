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
using Com.Hopper.Hts.Airlines.Model;

namespace Com.Hopper.Hts.Airlines.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an authentication token
        /// </summary>
        /// <remarks>
        /// Get an authentication token
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthResponse</returns>
        AuthResponse PostAuth(AuthRequest authRequest, int operationIndex = 0);

        /// <summary>
        /// Create an authentication token
        /// </summary>
        /// <remarks>
        /// Get an authentication token
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        ApiResponse<AuthResponse> PostAuthWithHttpInfo(AuthRequest authRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an authentication token
        /// </summary>
        /// <remarks>
        /// Get an authentication token
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthResponse</returns>
        System.Threading.Tasks.Task<AuthResponse> PostAuthAsync(AuthRequest authRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Create an authentication token
        /// </summary>
        /// <remarks>
        /// Get an authentication token
        /// </remarks>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthResponse>> PostAuthWithHttpInfoAsync(AuthRequest authRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IAuthenticationApiSync, IAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private Com.Hopper.Hts.Airlines.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Com.Hopper.Hts.Airlines.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticationApi(Com.Hopper.Hts.Airlines.Client.ISynchronousClient client, Com.Hopper.Hts.Airlines.Client.IAsynchronousClient asyncClient, Com.Hopper.Hts.Airlines.Client.IReadableConfiguration configuration)
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
        /// Create an authentication token Get an authentication token
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthResponse</returns>
        public AuthResponse PostAuth(AuthRequest authRequest, int operationIndex = 0)
        {
            Com.Hopper.Hts.Airlines.Client.ApiResponse<AuthResponse> localVarResponse = PostAuthWithHttpInfo(authRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an authentication token Get an authentication token
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        public Com.Hopper.Hts.Airlines.Client.ApiResponse<AuthResponse> PostAuthWithHttpInfo(AuthRequest authRequest, int operationIndex = 0)
        {
            // verify the required parameter 'authRequest' is set
            if (authRequest == null)
            {
                throw new Com.Hopper.Hts.Airlines.Client.ApiException(400, "Missing required parameter 'authRequest' when calling AuthenticationApi->PostAuth");
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
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Hopper.Hts.Airlines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = authRequest;

            localVarRequestOptions.Operation = "AuthenticationApi.PostAuth";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthResponse>("/auth", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAuth", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an authentication token Get an authentication token
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthResponse</returns>
        public async System.Threading.Tasks.Task<AuthResponse> PostAuthAsync(AuthRequest authRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Com.Hopper.Hts.Airlines.Client.ApiResponse<AuthResponse> localVarResponse = await PostAuthWithHttpInfoAsync(authRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an authentication token Get an authentication token
        /// </summary>
        /// <exception cref="Com.Hopper.Hts.Airlines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        public async System.Threading.Tasks.Task<Com.Hopper.Hts.Airlines.Client.ApiResponse<AuthResponse>> PostAuthWithHttpInfoAsync(AuthRequest authRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'authRequest' is set
            if (authRequest == null)
            {
                throw new Com.Hopper.Hts.Airlines.Client.ApiException(400, "Missing required parameter 'authRequest' when calling AuthenticationApi->PostAuth");
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

            localVarRequestOptions.Data = authRequest;

            localVarRequestOptions.Operation = "AuthenticationApi.PostAuth";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthResponse>("/auth", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAuth", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
