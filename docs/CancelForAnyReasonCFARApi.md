# Com.Hopper.Hts.Airlines.Api.CancelForAnyReasonCFARApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCfarContractsId**](CancelForAnyReasonCFARApi.md#getcfarcontractsid) | **GET** /cfar_contracts/{id} | Get a CFAR Contract |
| [**GetCustomerCfarOffers**](CancelForAnyReasonCFARApi.md#getcustomercfaroffers) | **GET** /customer/cfar_offers | Get CFAR Offers |
| [**PostCfarContractExercises**](CancelForAnyReasonCFARApi.md#postcfarcontractexercises) | **POST** /cfar_contract_exercises | Create CFAR Exercise |
| [**PostCfarContracts**](CancelForAnyReasonCFARApi.md#postcfarcontracts) | **POST** /cfar_contracts | Create a CFAR Contract |
| [**PostCfarContractsIdPayment**](CancelForAnyReasonCFARApi.md#postcfarcontractsidpayment) | **POST** /cfar_contracts/{id}/payment | Process CFAR Payment |
| [**PostCfarOffers**](CancelForAnyReasonCFARApi.md#postcfaroffers) | **POST** /cfar_offers | Create CFAR Offers |
| [**PutCfarContractExercisesIdMarkCompleted**](CancelForAnyReasonCFARApi.md#putcfarcontractexercisesidmarkcompleted) | **PUT** /cfar_contract_exercises/{id}/mark_completed | Complete CFAR Exercise |
| [**PutCfarContractsIdFormsOfPayment**](CancelForAnyReasonCFARApi.md#putcfarcontractsidformsofpayment) | **PUT** /cfar_contracts/{id}/forms_of_payment | Update forms of payment of a CFAR Contract |
| [**PutCfarContractsIdUpdateStatus**](CancelForAnyReasonCFARApi.md#putcfarcontractsidupdatestatus) | **PUT** /cfar_contracts/{id}/update_status | Update CFAR Contract Status |

<a id="getcfarcontractsid"></a>
# **GetCfarContractsId**
> CfarContract GetCfarContractsId (string id)

Get a CFAR Contract

Get a CFAR contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class GetCfarContractsIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure API key authorization: SessionAuth
            config.AddApiKey("HC-Session-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("HC-Session-ID", "Bearer");
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var id = "id_example";  // string | A unique identifier for a contract

            try
            {
                // Get a CFAR Contract
                CfarContract result = apiInstance.GetCfarContractsId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.GetCfarContractsId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCfarContractsIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a CFAR Contract
    ApiResponse<CfarContract> response = apiInstance.GetCfarContractsIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.GetCfarContractsIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |

### Return type

[**CfarContract**](CfarContract.md)

### Authorization

[SessionAuth](../README.md#SessionAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested CFAR contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomercfaroffers"></a>
# **GetCustomerCfarOffers**
> GetCfarOfferResponse GetCustomerCfarOffers (string hCSessionID, List<string>? offerId = null)

Get CFAR Offers

Get CFAR offers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class GetCustomerCfarOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string | The ID of the current airline session, see [Sessions](#tag/Sessions)
            var offerId = new List<string>?(); // List<string>? | List of unique identifier for an offer (optional) 

            try
            {
                // Get CFAR Offers
                GetCfarOfferResponse result = apiInstance.GetCustomerCfarOffers(hCSessionID, offerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.GetCustomerCfarOffers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerCfarOffersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CFAR Offers
    ApiResponse<GetCfarOfferResponse> response = apiInstance.GetCustomerCfarOffersWithHttpInfo(hCSessionID, offerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.GetCustomerCfarOffersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hCSessionID** | **string** | The ID of the current airline session, see [Sessions](#tag/Sessions) |  |
| **offerId** | [**List&lt;string&gt;?**](string.md) | List of unique identifier for an offer | [optional]  |

### Return type

[**GetCfarOfferResponse**](GetCfarOfferResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested CFAR offers |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **404** | The requested resource could not be found |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcfarcontractexercises"></a>
# **PostCfarContractExercises**
> CfarContractExercise PostCfarContractExercises (CreateCfarContractExerciseRequest createCfarContractExerciseRequest, string? hCSessionID = null)

Create CFAR Exercise

Record that a request to exercise a CFAR contract has occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostCfarContractExercisesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var createCfarContractExerciseRequest = new CreateCfarContractExerciseRequest(); // CreateCfarContractExerciseRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Create CFAR Exercise
                CfarContractExercise result = apiInstance.PostCfarContractExercises(createCfarContractExerciseRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContractExercises: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCfarContractExercisesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create CFAR Exercise
    ApiResponse<CfarContractExercise> response = apiInstance.PostCfarContractExercisesWithHttpInfo(createCfarContractExerciseRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContractExercisesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCfarContractExerciseRequest** | [**CreateCfarContractExerciseRequest**](CreateCfarContractExerciseRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CfarContractExercise**](CfarContractExercise.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created CFAR contract exercise |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcfarcontracts"></a>
# **PostCfarContracts**
> CfarContract PostCfarContracts (CreateCfarContractRequest createCfarContractRequest)

Create a CFAR Contract

Create a CFAR contract from selected CFAR offer(s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostCfarContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var createCfarContractRequest = new CreateCfarContractRequest(); // CreateCfarContractRequest | 

            try
            {
                // Create a CFAR Contract
                CfarContract result = apiInstance.PostCfarContracts(createCfarContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCfarContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a CFAR Contract
    ApiResponse<CfarContract> response = apiInstance.PostCfarContractsWithHttpInfo(createCfarContractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCfarContractRequest** | [**CreateCfarContractRequest**](CreateCfarContractRequest.md) |  |  |

### Return type

[**CfarContract**](CfarContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created CFAR contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The CFAR contract creation request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcfarcontractsidpayment"></a>
# **PostCfarContractsIdPayment**
> CfarPayment PostCfarContractsIdPayment (string id, ProcessCfarPaymentRequest processCfarPaymentRequest, string? hCSessionID = null)

Process CFAR Payment

When HTS is the Merchant of Record (MoR), the customer's credit card is charged by HTS for the CFAR fee.  HTS is relying on an external payment gateway to process the payments, it allows the partner airline to tokenize the customer's credit card details and then pass the generated token in HTS Ancillaries for Airlines API payment endpoints in order to process the payment and confirm the contract related to the purchased product.  **Token URL**: https://core.spreedly.com/v1/payment_methods.json    **Example Token Request**:      ```   curl - -request POST - -url https://core.spreedly.com/v1/payment_methods.json - -header 'content-type: application/json' -u  \"login:password\" - -data '{  \"payment_method\": {   \"email\": \"aaa@bbb.ccc\",   \"credit_card\": {    \"number\": \"4111111111111111\",    \"month\": \"09\",    \"year\": \"2029\",    \"first_name\": \"John\",    \"last_name\": \"Smith\",    \"address1\": \"123 12th St\",    \"address2\": \"Building B\",    \"city\": \"Quebec City\",    \"state\": \"QC\",    \"zip\": \"G1R 4S9\",    \"country\": \"CA\",    \"verification_value\": \"123\"   }  } }' ``` **Example Token Response**:   ```   {  \"transaction\":  {   \"token\":  \"KtToV20m9qT1Yi8pbTeLNz0Ypns\",   \"created_at\":  \"2023-11-29T13:31:56Z\",   \"updated_at\":  \"2023-11-29T13:31:56Z\",   \"succeeded\":  true,   \"transaction_type\":  \"AddPaymentMethod\",   \"retained\":  false,   \"state\":  \"succeeded\",   \"message_key\":  \"messages.transaction_succeeded\",   \"message\":  \"Succeeded!\",   \"payment_method\":  {    \"token\":  \"MxyYEhDK12CUAA18bJDkAq0ab3y\",    \"created_at\":  \"2023-11-29T13:31:56Z\",    \"updated_at\":  \"2023-11-29T13:31:56Z\",    \"email\":  \"aaa@bbb.ccc\",    \"data\":  null,    \"storage_state\":  \"cached\",    \"test\":  true,    \"metadata\":  null,    \"callback_url\":  null,    \"last_four_digits\":  \"1111\",    \"first_six_digits\":  \"411111\",    \"card_type\":  \"visa\",    \"first_name\":  \"John\",    \"last_name\":  \"Smith\",    \"month\":  9,    \"year\":  2029,    \"address1\":  \"123 12th St\",    \"address2\":  \"Building B\",    \"city\":  \"Quebec City\",    \"state\":  \"QC\",    \"zip\":  \"G1R 4S9\",    \"country\":  \"CA\",    \"phone_number\":  null,    \"company\":  null,    \"full_name\":  \"John Smith\",    \"eligible_for_card_updater\":  true,    \"shipping_address1\":  null,    \"shipping_address2\":  null,    \"shipping_city\":  null,    \"shipping_state\":  null,    \"shipping_zip\":  null,    \"shipping_country\":  null,    \"shipping_phone_number\":  null,    \"issuer_identification_number\":  \"41111111\",    \"click_to_pay\":  false,    \"managed\":  true,    \"payment_method_type\":  \"credit_card\",    \"errors\":  [],    \"bin_metadata\":  {     \"message\":  \"BIN Metadata is available only to Advanced Vault enrolled customers and payment methods. Reach out to your account representative for more details.\"    },    \"fingerprint\":  \"7ccffcf38900f224fc946cf2a9c8e260072b\",    \"verification_value\":  \"XXX\",    \"number\":  \"XXXX-XXXX-XXXX-1111\"   }  } } ``` Here the returned payment method token **MxyYEhDK12CUAA18bJDkAq0ab3y** has to be used in the Process CFAR Payment request below.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostCfarContractsIdPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var processCfarPaymentRequest = new ProcessCfarPaymentRequest(); // ProcessCfarPaymentRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Process CFAR Payment
                CfarPayment result = apiInstance.PostCfarContractsIdPayment(id, processCfarPaymentRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContractsIdPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCfarContractsIdPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process CFAR Payment
    ApiResponse<CfarPayment> response = apiInstance.PostCfarContractsIdPaymentWithHttpInfo(id, processCfarPaymentRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarContractsIdPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **processCfarPaymentRequest** | [**ProcessCfarPaymentRequest**](ProcessCfarPaymentRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CfarPayment**](CfarPayment.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of the transaction |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcfaroffers"></a>
# **PostCfarOffers**
> List&lt;CfarOffer&gt; PostCfarOffers (CreateCfarOfferRequest createCfarOfferRequest, string? hCSessionID = null)

Create CFAR Offers

Create CFAR offers for a user's trip

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostCfarOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var createCfarOfferRequest = new CreateCfarOfferRequest(); // CreateCfarOfferRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Create CFAR Offers
                List<CfarOffer> result = apiInstance.PostCfarOffers(createCfarOfferRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarOffers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCfarOffersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create CFAR Offers
    ApiResponse<List<CfarOffer>> response = apiInstance.PostCfarOffersWithHttpInfo(createCfarOfferRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PostCfarOffersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCfarOfferRequest** | [**CreateCfarOfferRequest**](CreateCfarOfferRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**List&lt;CfarOffer&gt;**](CfarOffer.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created CFAR offers |  * Expires -  <br>  * Cache-Control -  <br>  * HTS-Session-ID - The ID of the current session, see [Sessions](#tag/Sessions) <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcfarcontractexercisesidmarkcompleted"></a>
# **PutCfarContractExercisesIdMarkCompleted**
> CfarContractExercise PutCfarContractExercisesIdMarkCompleted (string id, MarkCfarContractExerciseCompleteRequest markCfarContractExerciseCompleteRequest, string? hCSessionID = null)

Complete CFAR Exercise

Record that a request to exercise a CFAR contract has been completed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PutCfarContractExercisesIdMarkCompletedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var id = "id_example";  // string | A unique identifier for a exercise
            var markCfarContractExerciseCompleteRequest = new MarkCfarContractExerciseCompleteRequest(); // MarkCfarContractExerciseCompleteRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Complete CFAR Exercise
                CfarContractExercise result = apiInstance.PutCfarContractExercisesIdMarkCompleted(id, markCfarContractExerciseCompleteRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractExercisesIdMarkCompleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCfarContractExercisesIdMarkCompletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete CFAR Exercise
    ApiResponse<CfarContractExercise> response = apiInstance.PutCfarContractExercisesIdMarkCompletedWithHttpInfo(id, markCfarContractExerciseCompleteRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractExercisesIdMarkCompletedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a exercise |  |
| **markCfarContractExerciseCompleteRequest** | [**MarkCfarContractExerciseCompleteRequest**](MarkCfarContractExerciseCompleteRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CfarContractExercise**](CfarContractExercise.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated CFAR contract exercise |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcfarcontractsidformsofpayment"></a>
# **PutCfarContractsIdFormsOfPayment**
> CfarContract PutCfarContractsIdFormsOfPayment (string id, UpdateCfarFormOfPaymentRequest updateCfarFormOfPaymentRequest, string? hCSessionID = null)

Update forms of payment of a CFAR Contract

Update forms of payment linked with a CFAR contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PutCfarContractsIdFormsOfPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var updateCfarFormOfPaymentRequest = new UpdateCfarFormOfPaymentRequest(); // UpdateCfarFormOfPaymentRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Update forms of payment of a CFAR Contract
                CfarContract result = apiInstance.PutCfarContractsIdFormsOfPayment(id, updateCfarFormOfPaymentRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractsIdFormsOfPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCfarContractsIdFormsOfPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update forms of payment of a CFAR Contract
    ApiResponse<CfarContract> response = apiInstance.PutCfarContractsIdFormsOfPaymentWithHttpInfo(id, updateCfarFormOfPaymentRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractsIdFormsOfPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **updateCfarFormOfPaymentRequest** | [**UpdateCfarFormOfPaymentRequest**](UpdateCfarFormOfPaymentRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CfarContract**](CfarContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated CFAR contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | Forms of payment update request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcfarcontractsidupdatestatus"></a>
# **PutCfarContractsIdUpdateStatus**
> CfarContract PutCfarContractsIdUpdateStatus (string id, UpdateCfarContractRequest updateCfarContractRequest, string? hCSessionID = null)

Update CFAR Contract Status

Update the CFAR contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PutCfarContractsIdUpdateStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CancelForAnyReasonCFARApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var updateCfarContractRequest = new UpdateCfarContractRequest(); // UpdateCfarContractRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string? | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Update CFAR Contract Status
                CfarContract result = apiInstance.PutCfarContractsIdUpdateStatus(id, updateCfarContractRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractsIdUpdateStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCfarContractsIdUpdateStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update CFAR Contract Status
    ApiResponse<CfarContract> response = apiInstance.PutCfarContractsIdUpdateStatusWithHttpInfo(id, updateCfarContractRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CancelForAnyReasonCFARApi.PutCfarContractsIdUpdateStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **updateCfarContractRequest** | [**UpdateCfarContractRequest**](UpdateCfarContractRequest.md) |  |  |
| **hCSessionID** | **string?** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CfarContract**](CfarContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated CFAR contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The CFAR contract status update request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

