# Org.OpenAPITools.Model.DgContract
A DG contract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for a contract | 
**Reference** | **string** | Unique reference for a contract | 
**Status** | **DgStatus** |  | 
**Offers** | [**List&lt;DgOffer&gt;**](DgOffer.md) | DG Offer(s) used to create the contract | 
**CoveragePercentage** | **string** | Percentage of the ticket’s value to be refunded upon DG exercise | 
**Coverage** | **string** | Total amount to be refunded upon DG exercise | 
**Premium** | **string** | Total amount to be paid for DG | 
**ServiceCap** | **string** | Allowed amount per passenger to book a new flight in case of disruption | 
**Currency** | **string** | Currency of contract | 
**TaxesTotal** | **string** | Part of the premium which are taxes | 
**Taxes** | [**List&lt;DgTax&gt;**](DgTax.md) | List of applicable taxes | [optional] 
**MaxHoursBeforeDeparture** | **long** | The number of hours before each flight or slice departure from which a purchased contract would start to cover disruptions | 
**MinMinutesDelay** | **long** | The minimum flight or slice departure delay in minutes to be covered | 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a CFAR contract was created | 
**ExpiryDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) A UTC RFC3339 datetime; the date and time at which the CFAR contract will expire once purchased | 
**Language** | **string** | Language of the booking | [optional] 
**PnrReference** | **string** | Reference of the PNR in the airline system | [optional] 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

