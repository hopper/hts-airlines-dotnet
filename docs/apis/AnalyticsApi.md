# Com.Hopper.Hts.Airlines.Api.AnalyticsApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostEvents**](AnalyticsApi.md#postevents) | **POST** /events | Send a Backend Event |

<a id="postevents"></a>
# **PostEvents**
> void PostEvents (string hCSessionID, Event varEvent)

Send a Backend Event

Events can be send directly from partner backend using the same authentication as the other endpoints

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AnalyticsApi(config);
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string | The ID of the current airline session, see [Sessions](#tag/Sessions)
            var varEvent = new Event(); // Event | 

            try
            {
                // Send a Backend Event
                apiInstance.PostEvents(hCSessionID, varEvent);
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
    apiInstance.PostEventsWithHttpInfo(hCSessionID, varEvent);
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
| **hCSessionID** | **string** | The ID of the current airline session, see [Sessions](#tag/Sessions) |  |
| **varEvent** | [**Event**](Event.md) |  |  |

### Return type

void (empty response body)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

