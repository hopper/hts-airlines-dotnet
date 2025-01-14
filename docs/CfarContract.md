# Com.Hopper.Hts.Airlines.Model.CfarContract
A CFAR contract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for a contract | 
**Reference** | **string** | Unique reference for a contract | 
**Offers** | [**List&lt;CfarOffer&gt;**](CfarOffer.md) | CFAR Offer(s) used to create the contract | 
**Itinerary** | [**CfarItinerary**](CfarItinerary.md) |  | 
**CoveragePercentage** | **string** | Percentage of the amount to be refunded to customer compared to flight tickets price | 
**Coverage** | **string** | Total amount to be refunded upon CFAR exercise | 
**Premium** | **string** | Total amount to be paid for CFAR | 
**Currency** | **string** | Currency of contract | 
**TaxesTotal** | **string** | Part of the premium which are taxes | 
**Taxes** | [**List&lt;CfarTax&gt;**](CfarTax.md) | List of applicable taxes | [optional] 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR contract was created | 
**ExpiryDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) A UTC RFC3339 datetime; the date and time at which the CFAR contract will expire once purchased | 
**Status** | **CfarStatus** |  | 
**PnrReference** | **string** | Reference of the PNR in the airline system | [optional] 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**ExerciseUrl** | **string** | URL to exercise the contract (if applicable) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

