# Com.Hopper.Hts.Airlines.Model.DgOffer
A Dg offer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for a DG offer | 
**Premium** | **string** | Total amount to be paid for DG | 
**Coverage** | **string** | Total amount to be refunded upon DG exercise | 
**CoveragePercentage** | **string** | Percentage of the amount to be refunded to customer compared to flight tickets price | 
**ServiceCap** | **string** | Allowed amount per passenger to book a new flight in case of disruption | 
**Currency** | **string** | Currency of offer | 
**TaxesTotal** | **string** | Total of applicable taxes | 
**RequestType** | **DgRequestType** |  | 
**MaxHoursBeforeDeparture** | **long** | The number of hours before each flight or slice departure from which a purchased contract would start to cover disruptions | 
**MinMinutesDelay** | **long** | The minimum flight or slice departure delay in hours to be covered | 
**ContractExpiryDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which the DG contract will expire once purchased | 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a DG offer was created | 
**Itinerary** | [**DgItinerary**](DgItinerary.md) |  | 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**Contents** | [**Dictionary&lt;string, DgContents&gt;**](DgContents.md) |  | 
**Taxes** | [**List&lt;DgTax&gt;**](DgTax.md) | List of applicable taxes | [optional] 
**TermsConditionsUrl** | **string** | The terms and conditions for this offer | [optional] 
**FaqUrl** | **string** | The faq url for this offer | [optional] 
**MerchandisingUrl** | **string** | The url for rendering offer merchandising | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

