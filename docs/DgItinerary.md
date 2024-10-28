# Com.Hopper.Hts.Airlines.Model.DgItinerary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerPricing** | [**List&lt;DgPassengerPricing&gt;**](DgPassengerPricing.md) | List of passengers type, count and pricing for the itinerary | 
**Currency** | **string** | Currency of pricing fields | 
**Slices** | [**List&lt;DgItinerarySlice&gt;**](DgItinerarySlice.md) | List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed | 
**Ancillaries** | [**List&lt;DgAncillary&gt;**](DgAncillary.md) | Ancillaries attached to the itinerary and their prices | [optional] 
**TotalPrice** | **string** | Total price of the itinerary | [optional] 
**Passengers** | [**List&lt;DgPassenger&gt;**](DgPassenger.md) | Details of the passengers | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

