# Com.Hopper.Hts.Airlines.Model.DgPassenger
An object detailing the Passenger Information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerReference** | **string** | Unique reference of the passenger | 
**PassengerType** | **DgPassengerType** |  | 
**FirstName** | **string** | Ancillaries attached to the itinerary and their prices | [optional] 
**LastName** | **string** | Ancillaries attached to the itinerary and their prices | [optional] 
**DateOfBirth** | **DateOnly** | The birth date in ISO Local Date format | [optional] 
**Gender** | **Gender** |  | [optional] 
**PassportNumber** | **string** | The passport number of the passenger | [optional] 
**PassportCountryIssuance** | **string** | The country of issuance of the passenger&#39;s passport. Must be a valid ISO 3166-1 alpha-2 country code (2 uppercase letters, e.g., &#39;US&#39;, &#39;JP&#39;, &#39;TH&#39;) | [optional] 
**PassportIssuanceDate** | **DateOnly** | The date of issuance of the passenger&#39;s passport | [optional] 
**PassportExpirationDate** | **DateOnly** | The passport expiration date of the passenger | [optional] 
**Nationality** | **string** | The nationality of the passenger. Must be a valid ISO 3166-1 alpha-2 country code (e.g., &#39;US&#39;, &#39;JP&#39;, &#39;TH&#39;) | [optional] 
**DateOfBirthEncrypted** | **string** | Encrypted date of birth (Base64 encoded). Used only when PII encryption is enabled. If provided, this takes precedence over dateOfBirth. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

