# Org.OpenAPITools.Model.CreateCfarContractExerciseRequest
A create CFAR contract exercise request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractId** | **string** | A unique identifier for a CFAR contract | [optional] 
**Itinerary** | [**CfarCreateExerciseItinerary**](CfarCreateExerciseItinerary.md) |  | 
**EmailAddress** | **string** | Email address of the user | [optional] 
**PnrReference** | **string** |  | 
**AirlineRefundPenalty** | **string** | The penalty fee applied by the airline when issuing a refund for the booking | [optional] 
**AirlineRefundMethod** | **AirlineRefundMethod** |  | [optional] 
**Currency** | **string** | The currency of the airline&#39;s refund allowance | [optional] 
**ExtAttributes** | **Dictionary&lt;string, string&gt;** |  | 
**Session** | [**CreateAirlineCfarSessionRequest**](CreateAirlineCfarSessionRequest.md) |  | [optional] 
**CallbackUrl** | **string** | URL on which the customer should be redirected after the exercise (if applicable) | [optional] 
**RedirectbackUrl** | **string** | URL on which the customer should be redirected if the exercise is aborted (if applicable) | [optional] 
**FirstName** | **string** | First name of the cardholder | [optional] 
**LastName** | **string** | Last name of the cardholder | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

