# Org.OpenAPITools.Model.UserInfo
An object containing information related to the airline's user. Should be included if known, but not if the user is anonymous.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AirlineUserId** | **string** | The airline&#39;s unique identifier for a user; can be an arbitrary string | 
**CreatedDateTime** | **DateTime** | A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime; the date and time at which a user&#39;s account was created | [optional] 
**PreviousBookings** | **int** | Number of prior bookings a user has made | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

