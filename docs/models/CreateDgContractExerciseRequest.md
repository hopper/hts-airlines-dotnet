# Com.Hopper.Hts.Airlines.Model.CreateDgContractExerciseRequest
A create DG contract exercise request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractId** | **string** | A unique identifier for a DG contract | 
**Itinerary** | [**DgExerciseItinerary**](DgExerciseItinerary.md) |  | 
**PnrReference** | **string** | Reference of the PNR in the airline system. In case of a PNR created subsequently to a split, fill requesting PNR / parent PNR (e.g. DEF456/ABC123)  | 
**EmailAddress** | **string** | Email address of the user | [optional] 
**CallbackUrl** | **string** | URL on which the customer should be redirected after the exercise (if applicable) | [optional] 
**RedirectbackUrl** | **string** | URL on which the customer should be redirected if the exercise is aborted (if applicable) | [optional] 
**Session** | [**CreateAirlineDgSessionRequest**](CreateAirlineDgSessionRequest.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

