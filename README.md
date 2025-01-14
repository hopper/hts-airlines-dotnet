# Com.Hopper.Hts.Airlines - the C# library for the Airline API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1.1
- SDK version: 0.1.7
- Generator version: 7.11.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.Hopper.Hts.Airlines.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Client;
using Com.Hopper.Hts.Airlines.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://airlines-api.hopper.com/airline/v1.1";
            // Configure API key authorization: SessionAuth
            config.ApiKey.Add("HC-Session-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("HC-Session-ID", "Bearer");

            var apiInstance = new AnalyticsApi(config);
            var cfarEvent = new CfarEvent(); // CfarEvent | 

            try
            {
                // Send a Frontend Event
                apiInstance.PostCustomerEvents(cfarEvent);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostCustomerEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://airlines-api.hopper.com/airline/v1.1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnalyticsApi* | [**PostCustomerEvents**](docs/AnalyticsApi.md#postcustomerevents) | **POST** /customer/events | Send a Frontend Event
*AnalyticsApi* | [**PostEvents**](docs/AnalyticsApi.md#postevents) | **POST** /events | Send a Backend Event
*AuthenticationApi* | [**PostAuth**](docs/AuthenticationApi.md#postauth) | **POST** /auth | Create an authentication token
*CancelForAnyReasonCFARApi* | [**GetCfarContractsId**](docs/CancelForAnyReasonCFARApi.md#getcfarcontractsid) | **GET** /cfar_contracts/{id} | Get a CFAR Contract
*CancelForAnyReasonCFARApi* | [**GetCustomerCfarOffers**](docs/CancelForAnyReasonCFARApi.md#getcustomercfaroffers) | **GET** /customer/cfar_offers | Get CFAR Offers
*CancelForAnyReasonCFARApi* | [**PostCfarContractExercises**](docs/CancelForAnyReasonCFARApi.md#postcfarcontractexercises) | **POST** /cfar_contract_exercises | Create CFAR Exercise
*CancelForAnyReasonCFARApi* | [**PostCfarContracts**](docs/CancelForAnyReasonCFARApi.md#postcfarcontracts) | **POST** /cfar_contracts | Create a CFAR Contract
*CancelForAnyReasonCFARApi* | [**PostCfarContractsIdPayment**](docs/CancelForAnyReasonCFARApi.md#postcfarcontractsidpayment) | **POST** /cfar_contracts/{id}/payment | Process CFAR Payment
*CancelForAnyReasonCFARApi* | [**PostCfarOffers**](docs/CancelForAnyReasonCFARApi.md#postcfaroffers) | **POST** /cfar_offers | Create CFAR Offers
*CancelForAnyReasonCFARApi* | [**PutCfarContractExercisesIdMarkCompleted**](docs/CancelForAnyReasonCFARApi.md#putcfarcontractexercisesidmarkcompleted) | **PUT** /cfar_contract_exercises/{id}/mark_completed | Complete CFAR Exercise
*CancelForAnyReasonCFARApi* | [**PutCfarContractsIdFormsOfPayment**](docs/CancelForAnyReasonCFARApi.md#putcfarcontractsidformsofpayment) | **PUT** /cfar_contracts/{id}/forms_of_payment | Update forms of payment of a CFAR Contract
*CancelForAnyReasonCFARApi* | [**PutCfarContractsIdUpdateStatus**](docs/CancelForAnyReasonCFARApi.md#putcfarcontractsidupdatestatus) | **PUT** /cfar_contracts/{id}/update_status | Update CFAR Contract Status
*DisruptionGuaranteeDGApi* | [**GetDgContractsId**](docs/DisruptionGuaranteeDGApi.md#getdgcontractsid) | **GET** /dg_contracts/{id} | Get a DG contract
*DisruptionGuaranteeDGApi* | [**PostCustomerDgContractExercises**](docs/DisruptionGuaranteeDGApi.md#postcustomerdgcontractexercises) | **POST** /customer/dg_contract_exercises | Create DG Exercise
*DisruptionGuaranteeDGApi* | [**PostCustomerDgEvents**](docs/DisruptionGuaranteeDGApi.md#postcustomerdgevents) | **POST** /customer/dg/events | Create an Event
*DisruptionGuaranteeDGApi* | [**PostDgContractExercises**](docs/DisruptionGuaranteeDGApi.md#postdgcontractexercises) | **POST** /dg_contract_exercises | Create DG Exercise
*DisruptionGuaranteeDGApi* | [**PostDgContracts**](docs/DisruptionGuaranteeDGApi.md#postdgcontracts) | **POST** /dg_contracts | Create a DG Contract
*DisruptionGuaranteeDGApi* | [**PostDgContractsIdPayment**](docs/DisruptionGuaranteeDGApi.md#postdgcontractsidpayment) | **POST** /dg_contracts/{id}/payment | Process DG payment
*DisruptionGuaranteeDGApi* | [**PostDgOffers**](docs/DisruptionGuaranteeDGApi.md#postdgoffers) | **POST** /dg_offers | Create DG Offers
*DisruptionGuaranteeDGApi* | [**PutDgContractsIdItinerarySlices**](docs/DisruptionGuaranteeDGApi.md#putdgcontractsiditineraryslices) | **PUT** /dg_contracts/{id}/itinerary_slices | Update DG Contract Itinerary Slices
*DisruptionGuaranteeDGApi* | [**PutDgContractsIdUpdateStatus**](docs/DisruptionGuaranteeDGApi.md#putdgcontractsidupdatestatus) | **PUT** /dg_contracts/{id}/update_status | Update DG Contract Status
*SessionsApi* | [**PostSessions**](docs/SessionsApi.md#postsessions) | **POST** /sessions | Create a Session


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AirlineRefundMethod](docs/AirlineRefundMethod.md)
 - [Model.AirlineSession](docs/AirlineSession.md)
 - [Model.Ancillary](docs/Ancillary.md)
 - [Model.AncillaryType](docs/AncillaryType.md)
 - [Model.Android](docs/Android.md)
 - [Model.App](docs/App.md)
 - [Model.AuthRequest](docs/AuthRequest.md)
 - [Model.AuthResponse](docs/AuthResponse.md)
 - [Model.BadRequest](docs/BadRequest.md)
 - [Model.BookingConfirmed](docs/BookingConfirmed.md)
 - [Model.BookingConfirmed1](docs/BookingConfirmed1.md)
 - [Model.BookingConfirmed2](docs/BookingConfirmed2.md)
 - [Model.Browser](docs/Browser.md)
 - [Model.Cabin](docs/Cabin.md)
 - [Model.Cash](docs/Cash.md)
 - [Model.CfarContents](docs/CfarContents.md)
 - [Model.CfarContract](docs/CfarContract.md)
 - [Model.CfarContractExercise](docs/CfarContractExercise.md)
 - [Model.CfarCreateExerciseItinerary](docs/CfarCreateExerciseItinerary.md)
 - [Model.CfarCreateExerciseItinerarySlice](docs/CfarCreateExerciseItinerarySlice.md)
 - [Model.CfarCreateExercisePassengerPricing](docs/CfarCreateExercisePassengerPricing.md)
 - [Model.CfarCreateExerciseSliceSegment](docs/CfarCreateExerciseSliceSegment.md)
 - [Model.CfarDenyPurchase](docs/CfarDenyPurchase.md)
 - [Model.CfarEvent](docs/CfarEvent.md)
 - [Model.CfarEventWithContract](docs/CfarEventWithContract.md)
 - [Model.CfarExerciseCallbackLaunched](docs/CfarExerciseCallbackLaunched.md)
 - [Model.CfarExerciseCustomerDataComplete](docs/CfarExerciseCustomerDataComplete.md)
 - [Model.CfarExercisePortalComplete](docs/CfarExercisePortalComplete.md)
 - [Model.CfarExercisePortalDisplay](docs/CfarExercisePortalDisplay.md)
 - [Model.CfarExerciseVerificationComplete](docs/CfarExerciseVerificationComplete.md)
 - [Model.CfarExerciseVerificationSent](docs/CfarExerciseVerificationSent.md)
 - [Model.CfarForcedChoiceWarning](docs/CfarForcedChoiceWarning.md)
 - [Model.CfarItinerary](docs/CfarItinerary.md)
 - [Model.CfarItinerarySlice](docs/CfarItinerarySlice.md)
 - [Model.CfarItinerarySliceSegment](docs/CfarItinerarySliceSegment.md)
 - [Model.CfarOffer](docs/CfarOffer.md)
 - [Model.CfarOfferItinerary](docs/CfarOfferItinerary.md)
 - [Model.CfarOfferLight](docs/CfarOfferLight.md)
 - [Model.CfarOfferPassenger](docs/CfarOfferPassenger.md)
 - [Model.CfarOffersBannerDisplay](docs/CfarOffersBannerDisplay.md)
 - [Model.CfarOffersTakeoverDisplay](docs/CfarOffersTakeoverDisplay.md)
 - [Model.CfarPassenger](docs/CfarPassenger.md)
 - [Model.CfarPassengerTax](docs/CfarPassengerTax.md)
 - [Model.CfarPayment](docs/CfarPayment.md)
 - [Model.CfarStatus](docs/CfarStatus.md)
 - [Model.CfarTax](docs/CfarTax.md)
 - [Model.CfarViewInfo](docs/CfarViewInfo.md)
 - [Model.Chrome](docs/Chrome.md)
 - [Model.ChromeOs](docs/ChromeOs.md)
 - [Model.CreateAirlineCfarSessionRequest](docs/CreateAirlineCfarSessionRequest.md)
 - [Model.CreateAirlineDgSessionRequest](docs/CreateAirlineDgSessionRequest.md)
 - [Model.CreateAirlineSessionRequest](docs/CreateAirlineSessionRequest.md)
 - [Model.CreateCfarContractExerciseRequest](docs/CreateCfarContractExerciseRequest.md)
 - [Model.CreateCfarContractRequest](docs/CreateCfarContractRequest.md)
 - [Model.CreateCfarOfferRequest](docs/CreateCfarOfferRequest.md)
 - [Model.CreateDgContractExerciseRequest](docs/CreateDgContractExerciseRequest.md)
 - [Model.CreateDgContractExerciseResponse](docs/CreateDgContractExerciseResponse.md)
 - [Model.CreateDgContractRequest](docs/CreateDgContractRequest.md)
 - [Model.CreateDgOfferItemResponse](docs/CreateDgOfferItemResponse.md)
 - [Model.CreateDgOffersRequest](docs/CreateDgOffersRequest.md)
 - [Model.Desktop](docs/Desktop.md)
 - [Model.Device](docs/Device.md)
 - [Model.DgAncillary](docs/DgAncillary.md)
 - [Model.DgAncillaryType](docs/DgAncillaryType.md)
 - [Model.DgContents](docs/DgContents.md)
 - [Model.DgContract](docs/DgContract.md)
 - [Model.DgCustomerCreateContractExerciseRequest](docs/DgCustomerCreateContractExerciseRequest.md)
 - [Model.DgCustomerCreateContractExerciseResponse](docs/DgCustomerCreateContractExerciseResponse.md)
 - [Model.DgEvent](docs/DgEvent.md)
 - [Model.DgExerciseCallbackLaunched](docs/DgExerciseCallbackLaunched.md)
 - [Model.DgExerciseCustomerDataComplete](docs/DgExerciseCustomerDataComplete.md)
 - [Model.DgExerciseItinerary](docs/DgExerciseItinerary.md)
 - [Model.DgExerciseItinerarySlice](docs/DgExerciseItinerarySlice.md)
 - [Model.DgExerciseItinerarySliceSegment](docs/DgExerciseItinerarySliceSegment.md)
 - [Model.DgExercisePortalComplete](docs/DgExercisePortalComplete.md)
 - [Model.DgExerciseVerificationComplete](docs/DgExerciseVerificationComplete.md)
 - [Model.DgItinerary](docs/DgItinerary.md)
 - [Model.DgItinerarySlice](docs/DgItinerarySlice.md)
 - [Model.DgItinerarySliceSegment](docs/DgItinerarySliceSegment.md)
 - [Model.DgOffer](docs/DgOffer.md)
 - [Model.DgPassenger](docs/DgPassenger.md)
 - [Model.DgPassengerCount](docs/DgPassengerCount.md)
 - [Model.DgPassengerPricing](docs/DgPassengerPricing.md)
 - [Model.DgPassengerTax](docs/DgPassengerTax.md)
 - [Model.DgPassengerType](docs/DgPassengerType.md)
 - [Model.DgPayment](docs/DgPayment.md)
 - [Model.DgRequestType](docs/DgRequestType.md)
 - [Model.DgStatus](docs/DgStatus.md)
 - [Model.DgTax](docs/DgTax.md)
 - [Model.Edge](docs/Edge.md)
 - [Model.Error](docs/Error.md)
 - [Model.Event](docs/Event.md)
 - [Model.ExerciseStepResult](docs/ExerciseStepResult.md)
 - [Model.Fare](docs/Fare.md)
 - [Model.FareClass](docs/FareClass.md)
 - [Model.FareRule](docs/FareRule.md)
 - [Model.Firefox](docs/Firefox.md)
 - [Model.FlightStatus](docs/FlightStatus.md)
 - [Model.FlowType](docs/FlowType.md)
 - [Model.FormOfPayment](docs/FormOfPayment.md)
 - [Model.Gender](docs/Gender.md)
 - [Model.GetCfarOfferResponse](docs/GetCfarOfferResponse.md)
 - [Model.IOs](docs/IOs.md)
 - [Model.InternetExplorer](docs/InternetExplorer.md)
 - [Model.Linux](docs/Linux.md)
 - [Model.MacOs](docs/MacOs.md)
 - [Model.MarkCfarContractExerciseCompleteRequest](docs/MarkCfarContractExerciseCompleteRequest.md)
 - [Model.Mobile](docs/Mobile.md)
 - [Model.ModelOperatingSystem](docs/ModelOperatingSystem.md)
 - [Model.ModificationTime](docs/ModificationTime.md)
 - [Model.ModificationType](docs/ModificationType.md)
 - [Model.NonCash](docs/NonCash.md)
 - [Model.OffersDisplayed](docs/OffersDisplayed.md)
 - [Model.OffersDisplayed1](docs/OffersDisplayed1.md)
 - [Model.Opera](docs/Opera.md)
 - [Model.OtherBrowser](docs/OtherBrowser.md)
 - [Model.OtherOs](docs/OtherOs.md)
 - [Model.PassengerCount](docs/PassengerCount.md)
 - [Model.PassengerPricing](docs/PassengerPricing.md)
 - [Model.PassengerType](docs/PassengerType.md)
 - [Model.PaymentCard](docs/PaymentCard.md)
 - [Model.Platform](docs/Platform.md)
 - [Model.Points](docs/Points.md)
 - [Model.ProcessCfarPaymentRequest](docs/ProcessCfarPaymentRequest.md)
 - [Model.ProcessDgPaymentRequest](docs/ProcessDgPaymentRequest.md)
 - [Model.Product](docs/Product.md)
 - [Model.RequestType](docs/RequestType.md)
 - [Model.Safari](docs/Safari.md)
 - [Model.Tablet](docs/Tablet.md)
 - [Model.TokenType](docs/TokenType.md)
 - [Model.UiSource](docs/UiSource.md)
 - [Model.UiVariant](docs/UiVariant.md)
 - [Model.UnprocessableEntity](docs/UnprocessableEntity.md)
 - [Model.UpdateCfarContractRequest](docs/UpdateCfarContractRequest.md)
 - [Model.UpdateCfarFormOfPaymentRequest](docs/UpdateCfarFormOfPaymentRequest.md)
 - [Model.UpdateDgContractStatusRequest](docs/UpdateDgContractStatusRequest.md)
 - [Model.UserInfo](docs/UserInfo.md)
 - [Model.Web](docs/Web.md)
 - [Model.Windows](docs/Windows.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="PartnerAuth"></a>
### PartnerAuth

- **Type**: Bearer Authentication

<a id="SessionAuth"></a>
### SessionAuth

- **Type**: API key
- **API key parameter name**: HC-Session-ID
- **Location**: HTTP header

## Development

You can regenerate the client using this command:

```bash
VERSION=0.1.2 docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i https://airlines-api.hopper.com/airline/v1.1/docs/docs.yaml \
    -g csharp \
    -o /local \
    --package-name Com.Hopper.Hts.Airlines \
    --additional-properties=optionalEmitDefaultValues=true,nullableReferenceTypes=true,validatable=false,licenseId=MIT,packageVersion=$VERSION
```

Please be mindful of the README.md getting overwritten.
Please manually restore these instructions before committing.

## Publishing

Create the package

```bash
dotnet pack src/Com.Hopper.Hts.Airlines
```

Example run:

```bash
➜  htsfa-airlines-dotnet git:(main) dotnet pack src/Com.Hopper.Hts.Airlines
  Determining projects to restore...
  Restored /Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Com.Hopper.Hts.Airlines.csproj (in 506 ms).
/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Client/ApiClient.cs(457,17): warning CS0618: 'RestClientOptions.MaxTimeout' is obsolete: 'Use Timeout instead.' [/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Com.Hopper.Hts.Airlines.csproj]
  Com.Hopper.Hts.Airlines -> /Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/bin/Release/net8.0/Com.Hopper.Hts.Airlines.dll
  The package Com.Hopper.Hts.Airlines.0.1.2 is missing a readme. Go to https://aka.ms/nuget/authoring-best-practices/readme to learn why package readmes are important.
  Successfully created package '/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/bin/Release/Com.Hopper.Hts.Airlines.0.1.2.nupkg'.
```

Go to [NuGet](https://www.nuget.org/packages/manage/upload) and upload the package artifact created.
In the example above, it is `Com.Hopper.Hts.Airlines.0.1.2.nupkg`.
After submission, the package will be ready for consumption usually within 10-15 minutes.

You will need to obtain an Azure account to access NuGet. Contact IT to do so.
