# Com.Hopper.Hts.Airlines.Model.DgExerciseItinerarySlice
An object containing the list of flight segments for a fare slice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Segments** | [**List&lt;DgExerciseItinerarySliceSegment&gt;**](DgExerciseItinerarySliceSegment.md) | A list of segments which make up the slice | 
**Irop** | **bool** | Is the slice impacted by an unplanned short-term Irregularity. It includes delays and cancellations that occur on the day of departure of the first impacted flight. Also known as: Flight Irregularity, IROP or IREG. | [optional] 
**Invol** | **bool** | Is the slice resulting from a rebooking following an unplanned short-term Irregularity. It includes delays and cancellations that occur on the day of departure of the first impacted flight. Also known as: Flight Irregularity, IROP or IREG. | [optional] 
**PreviousSlice** | [**DgExerciseItinerarySlice**](DgExerciseItinerarySlice.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

