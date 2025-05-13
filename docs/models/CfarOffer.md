# Com.Hopper.Hts.Airlines.Model.CfarOffer
A successful CFAR offer response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for an offer | 
**Premium** | **string** | Total amount to be paid for CFAR | 
**Coverage** | **string** | Total amount to be refunded upon CFAR exercise | 
**CoveragePercentage** | **string** | Percentage of the amount to be refunded to customer compared to flight tickets price | 
**Currency** | **string** | Currency of offer | 
**TaxesTotal** | **string** | Part of the premium which are taxes  | 
**RequestType** | **RequestType** |  | 
**ContractExpiryDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which the CFAR contract will expire once purchased | 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR offer was created | 
**Itinerary** | [**CfarItinerary**](CfarItinerary.md) |  | 
**Contents** | [**Dictionary&lt;string, CfarContents&gt;**](CfarContents.md) | One or more contents describing the offer and its conditions in the available languages | 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**CoverageExtension** | **string** | Maximum amount added on top of the coverage to cover ancillaries | [optional] 
**Taxes** | [**List&lt;CfarTax&gt;**](CfarTax.md) | List of applicable taxes | [optional] 
**TermsConditionsUrl** | **string** | The terms and conditions for this offer | [optional] 
**FaqUrl** | **string** | The faq url for this offer | [optional] 
**MerchandisingUrl** | **string** | The url for rendering offer merchandising | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

