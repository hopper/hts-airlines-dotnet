# Org.OpenAPITools.Model.UpdateDgContractStatusRequest
A update DG contract status request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **DgStatus** |  | 
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
**Taxes** | [**List&lt;DgTax&gt;**](DgTax.md) | List of taxes that is associated with a contract | [optional] 
**FormsOfPayment** | [**List&lt;FormOfPayment&gt;**](FormOfPayment.md) | List of the forms of payment used to purchase the booking | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

