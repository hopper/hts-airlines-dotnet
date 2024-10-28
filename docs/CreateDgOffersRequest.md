# Com.Hopper.Hts.Airlines.Model.CreateDgOffersRequest
A create DG offers request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Itinerary** | [**List&lt;DgItinerary&gt;**](DgItinerary.md) | An object detailing the itinerary and fare used to create a DG offer | 
**RequestType** | **DgRequestType** |  | 
**BookingDateTime** | **DateTime** | A UTC RFC3339 datetime; the date and time at which the booking was made. To be used only with the request type \&quot;post_booking\&quot; | [optional] 
**Session** | [**CreateAirlineDgSessionRequest**](CreateAirlineDgSessionRequest.md) |  | [optional] 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

