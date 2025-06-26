# Com.Hopper.Hts.Airlines.Api.DisruptionGuaranteeDGApi

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDgContractsId**](DisruptionGuaranteeDGApi.md#getdgcontractsid) | **GET** /dg_contracts/{id} | Get a DG contract |
| [**PostDgContractExercises**](DisruptionGuaranteeDGApi.md#postdgcontractexercises) | **POST** /dg_contract_exercises | Create DG Exercise |
| [**PostDgContracts**](DisruptionGuaranteeDGApi.md#postdgcontracts) | **POST** /dg_contracts | Create a DG Contract |
| [**PostDgContractsIdPayment**](DisruptionGuaranteeDGApi.md#postdgcontractsidpayment) | **POST** /dg_contracts/{id}/payment | Process DG payment |
| [**PostDgOffers**](DisruptionGuaranteeDGApi.md#postdgoffers) | **POST** /dg_offers | Create DG Offers |
| [**PutDgContractsIdItinerarySlices**](DisruptionGuaranteeDGApi.md#putdgcontractsiditineraryslices) | **PUT** /dg_contracts/{id}/itinerary_slices | Update DG Contract Itinerary Slices |
| [**PutDgContractsIdUpdateStatus**](DisruptionGuaranteeDGApi.md#putdgcontractsidupdatestatus) | **PUT** /dg_contracts/{id}/update_status | Update DG Contract Status |

<a id="getdgcontractsid"></a>
# **GetDgContractsId**
> DgContract GetDgContractsId (string id)

Get a DG contract

Get a DG contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class GetDgContractsIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var id = "id_example";  // string | A unique identifier for a contract

            try
            {
                // Get a DG contract
                DgContract result = apiInstance.GetDgContractsId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.GetDgContractsId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDgContractsIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a DG contract
    ApiResponse<DgContract> response = apiInstance.GetDgContractsIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.GetDgContractsIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |

### Return type

[**DgContract**](DgContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested DG contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postdgcontractexercises"></a>
# **PostDgContractExercises**
> CreateDgContractExerciseResponse PostDgContractExercises (CreateDgContractExerciseRequest createDgContractExerciseRequest, string hCSessionID = null)

Create DG Exercise

Record that a request to exercise a DG contract has occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostDgContractExercisesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var createDgContractExerciseRequest = new CreateDgContractExerciseRequest(); // CreateDgContractExerciseRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Create DG Exercise
                CreateDgContractExerciseResponse result = apiInstance.PostDgContractExercises(createDgContractExerciseRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContractExercises: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDgContractExercisesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create DG Exercise
    ApiResponse<CreateDgContractExerciseResponse> response = apiInstance.PostDgContractExercisesWithHttpInfo(createDgContractExerciseRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContractExercisesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDgContractExerciseRequest** | [**CreateDgContractExerciseRequest**](CreateDgContractExerciseRequest.md) |  |  |
| **hCSessionID** | **string** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**CreateDgContractExerciseResponse**](CreateDgContractExerciseResponse.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created DG contract exercise |  * Expires -  <br>  * Cache-Control -  <br>  * HTS-Session-ID - The ID of the current session, see [Sessions](#tag/Sessions) <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postdgcontracts"></a>
# **PostDgContracts**
> DgContract PostDgContracts (CreateDgContractRequest createDgContractRequest)

Create a DG Contract

Create a DG contract from selected DG offer(s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostDgContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var createDgContractRequest = new CreateDgContractRequest(); // CreateDgContractRequest | 

            try
            {
                // Create a DG Contract
                DgContract result = apiInstance.PostDgContracts(createDgContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDgContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a DG Contract
    ApiResponse<DgContract> response = apiInstance.PostDgContractsWithHttpInfo(createDgContractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDgContractRequest** | [**CreateDgContractRequest**](CreateDgContractRequest.md) |  |  |

### Return type

[**DgContract**](DgContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created DG contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The DG contract creation request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postdgcontractsidpayment"></a>
# **PostDgContractsIdPayment**
> DgPayment PostDgContractsIdPayment (string id, ProcessDgPaymentRequest processDgPaymentRequest)

Process DG payment

When HTS is the Merchant of Record (MoR), the customer's credit card is charged by HTS for the DG fee.  HTS is relying on an external payment gateway to process the payments, it allows the partner airline to tokenize the customer's credit card details and then pass the generated token in HTS Ancillaries for Airlines API payment endpoints in order to process the payment and confirm the contract related to the purchased product.  **Token URL**: https://core.spreedly.com/v1/payment_methods.json    **Example Token Request**:      ```   curl - -request POST - -url https://core.spreedly.com/v1/payment_methods.json - -header 'content-type: application/json' -u  \"login:password\" - -data '{  \"payment_method\": {   \"email\": \"aaa@bbb.ccc\",   \"credit_card\": {    \"number\": \"4111111111111111\",    \"month\": \"09\",    \"year\": \"2029\",    \"first_name\": \"John\",    \"last_name\": \"Smith\",    \"address1\": \"123 12th St\",    \"address2\": \"Building B\",    \"city\": \"Quebec City\",    \"state\": \"QC\",    \"zip\": \"G1R 4S9\",    \"country\": \"CA\",    \"verification_value\": \"123\"   }  } }' ``` **Example Token Response**:   ```   {  \"transaction\":  {   \"token\":  \"KtToV20m9qT1Yi8pbTeLNz0Ypns\",   \"created_at\":  \"2023-11-29T13:31:56Z\",   \"updated_at\":  \"2023-11-29T13:31:56Z\",   \"succeeded\":  true,   \"transaction_type\":  \"AddPaymentMethod\",   \"retained\":  false,   \"state\":  \"succeeded\",   \"message_key\":  \"messages.transaction_succeeded\",   \"message\":  \"Succeeded!\",   \"payment_method\":  {    \"token\":  \"MxyYEhDK12CUAA18bJDkAq0ab3y\",    \"created_at\":  \"2023-11-29T13:31:56Z\",    \"updated_at\":  \"2023-11-29T13:31:56Z\",    \"email\":  \"aaa@bbb.ccc\",    \"data\":  null,    \"storage_state\":  \"cached\",    \"test\":  true,    \"metadata\":  null,    \"callback_url\":  null,    \"last_four_digits\":  \"1111\",    \"first_six_digits\":  \"411111\",    \"card_type\":  \"visa\",    \"first_name\":  \"John\",    \"last_name\":  \"Smith\",    \"month\":  9,    \"year\":  2029,    \"address1\":  \"123 12th St\",    \"address2\":  \"Building B\",    \"city\":  \"Quebec City\",    \"state\":  \"QC\",    \"zip\":  \"G1R 4S9\",    \"country\":  \"CA\",    \"phone_number\":  null,    \"company\":  null,    \"full_name\":  \"John Smith\",    \"eligible_for_card_updater\":  true,    \"shipping_address1\":  null,    \"shipping_address2\":  null,    \"shipping_city\":  null,    \"shipping_state\":  null,    \"shipping_zip\":  null,    \"shipping_country\":  null,    \"shipping_phone_number\":  null,    \"issuer_identification_number\":  \"41111111\",    \"click_to_pay\":  false,    \"managed\":  true,    \"payment_method_type\":  \"credit_card\",    \"errors\":  [],    \"bin_metadata\":  {     \"message\":  \"BIN Metadata is available only to Advanced Vault enrolled customers and payment methods. Reach out to your account representative for more details.\"    },    \"fingerprint\":  \"7ccffcf38900f224fc946cf2a9c8e260072b\",    \"verification_value\":  \"XXX\",    \"number\":  \"XXXX-XXXX-XXXX-1111\"   }  } } ``` Here the returned payment method token **MxyYEhDK12CUAA18bJDkAq0ab3y** has to be used in the Process DG Payment request below.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostDgContractsIdPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var processDgPaymentRequest = new ProcessDgPaymentRequest(); // ProcessDgPaymentRequest | 

            try
            {
                // Process DG payment
                DgPayment result = apiInstance.PostDgContractsIdPayment(id, processDgPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContractsIdPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDgContractsIdPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process DG payment
    ApiResponse<DgPayment> response = apiInstance.PostDgContractsIdPaymentWithHttpInfo(id, processDgPaymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgContractsIdPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **processDgPaymentRequest** | [**ProcessDgPaymentRequest**](ProcessDgPaymentRequest.md) |  |  |

### Return type

[**DgPayment**](DgPayment.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The contract has been paid |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postdgoffers"></a>
# **PostDgOffers**
> List&lt;CreateDgOfferItemResponse&gt; PostDgOffers (CreateDgOffersRequest createDgOffersRequest, string hCSessionID = null)

Create DG Offers

Create DG offers for a user's trip

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PostDgOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var createDgOffersRequest = new CreateDgOffersRequest(); // CreateDgOffersRequest | 
            var hCSessionID = 9fd3f2f9-e5aa-4128-ace9-3c4ee37b685f;  // string | The ID of the current airline session, see [Sessions](#tag/Sessions) (optional) 

            try
            {
                // Create DG Offers
                List<CreateDgOfferItemResponse> result = apiInstance.PostDgOffers(createDgOffersRequest, hCSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgOffers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDgOffersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create DG Offers
    ApiResponse<List<CreateDgOfferItemResponse>> response = apiInstance.PostDgOffersWithHttpInfo(createDgOffersRequest, hCSessionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PostDgOffersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDgOffersRequest** | [**CreateDgOffersRequest**](CreateDgOffersRequest.md) |  |  |
| **hCSessionID** | **string** | The ID of the current airline session, see [Sessions](#tag/Sessions) | [optional]  |

### Return type

[**List&lt;CreateDgOfferItemResponse&gt;**](CreateDgOfferItemResponse.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created DG offers |  * Expires -  <br>  * Cache-Control -  <br>  * HTS-Session-ID - The ID of the current session, see [Sessions](#tag/Sessions) <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putdgcontractsiditineraryslices"></a>
# **PutDgContractsIdItinerarySlices**
> DgContract PutDgContractsIdItinerarySlices (string id, List<DgItinerarySlice> dgItinerarySlice)

Update DG Contract Itinerary Slices

Update itinerary slices of a DG contract.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PutDgContractsIdItinerarySlicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var dgItinerarySlice = new List<DgItinerarySlice>(); // List<DgItinerarySlice> | 

            try
            {
                // Update DG Contract Itinerary Slices
                DgContract result = apiInstance.PutDgContractsIdItinerarySlices(id, dgItinerarySlice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PutDgContractsIdItinerarySlices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutDgContractsIdItinerarySlicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DG Contract Itinerary Slices
    ApiResponse<DgContract> response = apiInstance.PutDgContractsIdItinerarySlicesWithHttpInfo(id, dgItinerarySlice);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PutDgContractsIdItinerarySlicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **dgItinerarySlice** | [**List&lt;DgItinerarySlice&gt;**](DgItinerarySlice.md) |  |  |

### Return type

[**DgContract**](DgContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Updated DG contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The DG Contract Itinerary Slices update request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putdgcontractsidupdatestatus"></a>
# **PutDgContractsIdUpdateStatus**
> DgContract PutDgContractsIdUpdateStatus (string id, UpdateDgContractStatusRequest updateDgContractStatusRequest)

Update DG Contract Status

Update DG Contract Status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class PutDgContractsIdUpdateStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure Bearer token for authorization: PartnerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisruptionGuaranteeDGApi(config);
            var id = "id_example";  // string | A unique identifier for a contract
            var updateDgContractStatusRequest = new UpdateDgContractStatusRequest(); // UpdateDgContractStatusRequest | 

            try
            {
                // Update DG Contract Status
                DgContract result = apiInstance.PutDgContractsIdUpdateStatus(id, updateDgContractStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PutDgContractsIdUpdateStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutDgContractsIdUpdateStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DG Contract Status
    ApiResponse<DgContract> response = apiInstance.PutDgContractsIdUpdateStatusWithHttpInfo(id, updateDgContractStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisruptionGuaranteeDGApi.PutDgContractsIdUpdateStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A unique identifier for a contract |  |
| **updateDgContractStatusRequest** | [**UpdateDgContractStatusRequest**](UpdateDgContractStatusRequest.md) |  |  |

### Return type

[**DgContract**](DgContract.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Updated DG contract |  * Expires -  <br>  * Cache-Control -  <br>  |
| **204** | The DG contract status update request was successfully validated but not performed |  * Expires -  <br>  * Cache-Control -  <br>  |
| **400** | Syntactic errors were encountered while handling the request |  -  |
| **401** | The client could not be authenticated |  -  |
| **403** | The authenticated client does not have permission to call this endpoint |  -  |
| **404** | The requested resource could not be found |  -  |
| **422** | Semantic errors were encountered while handling the request |  -  |
| **500** | The server encountered an internal error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

