# Org.OpenAPITools.Api.AnalyticsApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCustomerEvents**](AnalyticsApi.md#postcustomerevents) | **POST** /customer/events | Send a Frontend Event |
| [**PostEvents**](AnalyticsApi.md#postevents) | **POST** /events | Send a Backend Event |

<a id="postcustomerevents"></a>
# **PostCustomerEvents**
> void PostCustomerEvents (CfarEvent cfarEvent)

Send a Frontend Event

Events can also be sent directly from a frontend running on end customer's device using the session ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostCustomerEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure API key authorization: SessionAuth
            config.AddApiKey("HC-Session-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("HC-Session-ID", "Bearer");

            var apiInstance = new AnalyticsApi(config);
            var cfarEvent = new CfarEvent(); // CfarEvent | 

            try
            {
                // Send a Frontend Event
                apiInstance.PostCustomerEvents(cfarEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostCustomerEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCustomerEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a Frontend Event
    apiInstance.PostCustomerEventsWithHttpInfo(cfarEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyticsApi.PostCustomerEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cfarEvent** | [**CfarEvent**](CfarEvent.md) |  |  |

### Return type

void (empty response body)

### Authorization

[SessionAuth](../README.md#SessionAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The event has been successfully created |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postevents"></a>
# **PostEvents**
> void PostEvents (Event varEvent)

Send a Backend Event

Events can be send directly from partner backend using the same authentication as the other endpoints

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure API key authorization: SessionAuth
            config.AddApiKey("HC-Session-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("HC-Session-ID", "Bearer");
            // Configure OAuth2 access token for authorization: PartnerAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var varEvent = new Event(); // Event | 

            try
            {
                // Send a Backend Event
                apiInstance.PostEvents(varEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a Backend Event
    apiInstance.PostEventsWithHttpInfo(varEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyticsApi.PostEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varEvent** | [**Event**](Event.md) |  |  |

### Return type

void (empty response body)

### Authorization

[SessionAuth](../README.md#SessionAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The event has been successfully created |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

