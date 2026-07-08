# Com.Hopper.Hts.Airlines.Model.BookingConfirmed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OccurredDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device | 
**Type** | **string** |  | 
**CfarContractId** | **string** | The purchased CFAR contract, if one is present | [optional] 
**DgContractId** | **string** | The purchased DG contract, if one is present | [optional] 
**CfarOfferIds** | **List&lt;string&gt;** | CFAR offer IDs shown to the customer during the session. Used to recover the session (and enrich the event) when no HC-Session-ID header is sent. | [optional] 
**DgOfferIds** | **List&lt;string&gt;** | DG offer IDs shown to the customer during the session. Used to recover the session (and enrich the event) when no HC-Session-ID header is sent. | [optional] 
**BookingReferences** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

