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
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Com.Hopper.Hts.Airlines.Test.Api
{
    /// <summary>
    ///  Class for testing AnalyticsApi
    /// </summary>
    public sealed class AnalyticsApiTests : ApiTestsBase
    {
        private readonly IAnalyticsApi _instance;

        public AnalyticsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IAnalyticsApi>();
        }

        /// <summary>
        /// Test PostEvents
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task PostEventsAsyncTest()
        {
            string hCSessionID = default!;
            Event varEvent = default!;
            System.Threading.CancellationToken cancellationToken = default!;
            await _instance.PostEventsAsync(hCSessionID, varEvent, cancellationToken);
        }
    }
}
