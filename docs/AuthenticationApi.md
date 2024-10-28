# Com.Hopper.Hts.Airlines.Api.AuthenticationApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostAuth**](AuthenticationApi.md#postauth) | **POST** /auth | Create an authentication token |

<a id="postauth"></a>
# **PostAuth**
> AuthResponse PostAuth (AuthRequest authRequest)

Create an authentication token

Get an authentication token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            var apiInstance = new AuthenticationApi(config);
            var authRequest = new AuthRequest(); // AuthRequest | 

            try
            {
                // Create an authentication token
                AuthResponse result = apiInstance.PostAuth(authRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.PostAuth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAuthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an authentication token
    ApiResponse<AuthResponse> response = apiInstance.PostAuthWithHttpInfo(authRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.PostAuthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRequest** | [**AuthRequest**](AuthRequest.md) |  |  |

### Return type

[**AuthResponse**](AuthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The authentication response |  -  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

