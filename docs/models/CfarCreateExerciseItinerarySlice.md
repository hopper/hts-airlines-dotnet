# Com.Hopper.Hts.Airlines.Model.CfarCreateExerciseItinerarySlice
An object containing the list of flight segments for a fare slice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Segments** | [**List&lt;CfarCreateExerciseSliceSegment&gt;**](CfarCreateExerciseSliceSegment.md) | A list of segments which make up the slice | 
**PassengerPricing** | [**List&lt;PassengerPricing&gt;**](PassengerPricing.md) | List of passengers type, count and pricing for the slice | [optional] 
**TotalPrice** | **string** | The price of the slice for all the passengers | [optional] 
**FareBrand** | **string** | Name of the fare brand applied to the slice | [optional] 
**FareBasis** | **string** | Code of the fare basis applied to the slice | [optional] 
**FareRules** | [**List&lt;FareRule&gt;**](FareRule.md) | The fare rules associated to the slice | [optional] 
**OtherFares** | [**List&lt;Fare&gt;**](Fare.md) | Other available fares in the same cabin | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

