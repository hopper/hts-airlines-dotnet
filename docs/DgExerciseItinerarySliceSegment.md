# Com.Hopper.Hts.Airlines.Model.DgExerciseItinerarySliceSegment
An object detailing a segment of a fare slice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginAirport** | **string** | IATA airport code of origin | 
**DestinationAirport** | **string** | IATA airport code of destination | 
**DepartureDateTime** | **string** | The local date and time of departure in ISO Local Date Time format | 
**ArrivalDateTime** | **string** | The local date and time of arrival in ISO Local Date Time format | 
**EstimatedDepartureDateTime** | **string** | The local date and time of estimated time of departure in ISO Local Date Time format | 
**EstimatedArrivalDateTime** | **string** | The local date and time of estimated time of arrival in ISO Local Date Time format | 
**FlightNumber** | **string** | The number of the flight | 
**ValidatingCarrierCode** | **string** | The IATA airline code of the validating carrier for this segment | 
**Cabin** | **Cabin** |  | 
**FlightStatus** | **FlightStatus** |  | 
**CheckedIn** | **bool** | Is there at least one checked-in passenger on this flight | [optional] 
**CheckedInBags** | **bool** | Is there at least one checked-in bag on this flight | [optional] 
**CheckedBagAllowance** | **bool** | Is there a checked bag allowance on this flight | [optional] 
**Boarded** | **bool** | Is there at least one passenger boarded on this flight | [optional] 
**Flown** | **bool** | Is this segment flown already | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

