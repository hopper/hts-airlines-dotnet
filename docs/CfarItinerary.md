# Com.Hopper.Hts.Airlines.Model.CfarItinerary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerPricing** | [**List&lt;PassengerPricing&gt;**](PassengerPricing.md) | List of passengers type, count and pricing for the itinerary | 
**Currency** | **string** | Currency of pricing fields | 
**Slices** | [**List&lt;CfarItinerarySlice&gt;**](CfarItinerarySlice.md) | List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed | 
**Ancillaries** | [**List&lt;Ancillary&gt;**](Ancillary.md) | Ancillaries attached to the itinerary and their prices. Only ancillaries covered by CFAR must be filled | [optional] 
**TotalPrice** | **string** | Total price to be covered by CFAR (including ancillaries if applicable) | [optional] 
**Passengers** | [**List&lt;CfarPassenger&gt;**](CfarPassenger.md) | Details of the passengers | [optional] 
**FareRules** | [**List&lt;FareRule&gt;**](FareRule.md) | The fare rules associated to the itinerary. If different fare rules apply to different slices in the itinerary, indicate the most restrictive. | [optional] 
**Taxes** | [**List&lt;CfarPassengerTax&gt;**](CfarPassengerTax.md) | Taxes applicable to this itinerary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

