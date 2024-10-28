# Com.Hopper.Hts.Airlines.Model.CfarContractExercise
An object containing exercise information for a contract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for a CFAR exercise | 
**ContractId** | **string** | Unique identifier for a contract | 
**ExerciseInitiatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a contract exercise was initiated | 
**CashRefundAllowance** | **string** | Refundable amount allowed in cash | 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**FtcRefundAllowance** | **string** | Refundable amount allowed in future travel credit | [optional] 
**Currency** | **string** | The currency of the airline&#39;s refund allowance | [optional] 
**RedirectionToken** | **Guid** | Token used to authenticate the redirection after filling refund information in claims portal | 
**RedirectionUrl** | **string** | URL on which the customer should be redirected to exercise (if applicable) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

