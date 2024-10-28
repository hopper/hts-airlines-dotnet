# Org.OpenAPITools.Model.DgExerciseItinerary
Itinerary of the user when the contract exercise was initiated (only active segments should be provided)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerCount** | [**List&lt;DgPassengerCount&gt;**](DgPassengerCount.md) | List of passengers type and count for the itinerary | 
**Slices** | [**List&lt;DgExerciseItinerarySlice&gt;**](DgExerciseItinerarySlice.md) | List of slices of the itinerary; 1 (one way),  2 (round trip) or up to 10 (multi-destination) slices are allowed | 
**Passengers** | [**List&lt;DgPassenger&gt;**](DgPassenger.md) | Details of the passengers | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

