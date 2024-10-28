# Org.OpenAPITools.Model.CreateCfarOfferRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Itinerary** | [**List&lt;CfarOfferItinerary&gt;**](CfarOfferItinerary.md) | An object detailing the itinerary and fare used to create a CFAR offer | 
**RequestType** | **RequestType** |  | 
**BookingDateTime** | **DateTime** | A UTC RFC3339 datetime; the date and time at which the booking was made. To be used only with the request type \&quot;post_booking\&quot; | [optional] 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**Session** | [**CreateAirlineCfarSessionRequest**](CreateAirlineCfarSessionRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

