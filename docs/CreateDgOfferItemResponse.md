# Com.Hopper.Hts.Airlines.Model.CreateDgOfferItemResponse
A created Dg offer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for an offer | 
**Premium** | **string** | Total amount to be paid for DG | 
**Coverage** | **string** | Total amount to be refunded upon DG exercise | 
**CoveragePercentage** | **string** | Percentage of the ticket’s value to be refunded upon DG exercise | 
**ServiceCap** | **string** |  | 
**Currency** | **string** | Currency of offer | 
**TaxesTotal** | **string** | Total of applicable taxes | 
**Taxes** | [**List&lt;DgTax&gt;**](DgTax.md) | List of applicable taxes | [optional] 
**RequestType** | **DgRequestType** |  | 
**MaxHoursBeforeDeparture** | **long** | The number of hours before each flight or slice departure from which a purchased contract would start to cover disruptions | 
**MinMinutesDelay** | **long** | The minimum flight or slice departure delay in minutes to be covered | 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a DG offer was created | 
**ContractExpiryDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which the DG contract will expire once purchased | 
**Itinerary** | [**DgItinerary**](DgItinerary.md) |  | 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**Contents** | [**Dictionary&lt;string, DgContents&gt;**](DgContents.md) |  | 
**MerchandisingUrl** | **string** | The url for rendering offer merchandising | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

