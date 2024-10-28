# Com.Hopper.Hts.Airlines.Model.UpdateCfarContractRequest
Update CFAR contract request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **CfarStatus** |  | 
**PnrReference** | **string** | Reference of the PNR in the airline system.&lt;br/&gt;Mandatory only if new status is \&quot;confirmed\&quot; | [optional] 
**EmailAddress** | **string** | Email address of the user | [optional] 
**PhoneNumber** | **string** | Phone number of the customer | [optional] 
**FirstName** | **string** | First name of the cardholder | [optional] 
**LastName** | **string** | Last name of the cardholder | [optional] 
**AddressLine1** | **string** | Address of the cardholder (first line) | [optional] 
**AddressLine2** | **string** | Address of the cardholder (second line) | [optional] 
**City** | **string** | City of the cardholder | [optional] 
**StateOrProvince** | **string** | State or province of the cardholder | [optional] 
**PostalCode** | **string** | Postal code  of the cardholder | [optional] 
**Country** | **string** | Country of the cardholder | [optional] 
**TaxesTotal** | **string** | Total of taxes | [optional] 
**Taxes** | [**List&lt;CfarTax&gt;**](CfarTax.md) | List of taxes that is associated with a contract | [optional] 
**Currency** | **string** | Updated currency in case it has changed at payment time | [optional] 
**ExchangeRate** | **string** | Exchange rate applied provided by partner if currency has changed at payment time, for instance, if a contract is created in EUR and the customer chose to pay in CAD on the partner&#39;s website, the partner will send us their exchange rate value from EUR to CAD. | [optional] 
**TotalPrice** | **string** | Updated total price to be covered by CFAR in case it can change at payment time | [optional] 
**FormsOfPayment** | [**List&lt;FormOfPayment&gt;**](FormOfPayment.md) | List of the forms of payment used to purchase the booking | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

