# Com.Hopper.Hts.Airlines.Model.DgItinerarySliceSegment
An object detailing a segment of a fare slice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SegmentId** | **string** | A unique identifier for the segment | [optional] 
**OriginAirport** | **string** | IATA airport code of origin | 
**DestinationAirport** | **string** | IATA airport code of destination | 
**DepartureDateTime** | **string** | The local date and time of departure in ISO Local Date Time format | 
**ArrivalDateTime** | **string** | The local date and time of arrival in ISO Local Date Time format | 
**FlightNumber** | **string** | The number of the flight | 
**ValidatingCarrierCode** | **string** | The IATA airline code of the validating carrier for this segment | 
**Cabin** | **Cabin** |  | 
**FareBrand** | **string** | Name of the fare brand applied to the segment (if applicable) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

