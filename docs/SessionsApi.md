# Com.Hopper.Hts.Airlines.Api.SessionsApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostSessions**](SessionsApi.md#postsessions) | **POST** /sessions | Create a Session |

<a id="postsessions"></a>
# **PostSessions**
> AirlineSession PostSessions (CreateAirlineSessionRequest createAirlineSessionRequest)

Create a Session

Create a new session for which events will be collected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure OAuth2 access token for authorization: PartnerAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionsApi(config);
            var createAirlineSessionRequest = new CreateAirlineSessionRequest(); // CreateAirlineSessionRequest | 

            try
            {
                // Create a Session
                AirlineSession result = apiInstance.PostSessions(createAirlineSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.PostSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Session
    ApiResponse<AirlineSession> response = apiInstance.PostSessionsWithHttpInfo(createAirlineSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.PostSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAirlineSessionRequest** | [**CreateAirlineSessionRequest**](CreateAirlineSessionRequest.md) |  |  |

### Return type

[**AirlineSession**](AirlineSession.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created airline session |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The airline session creation request was not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

