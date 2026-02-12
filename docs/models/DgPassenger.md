# Com.Hopper.Hts.Airlines.Model.DgPassenger
An object detailing the Passenger Information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerReference** | **string** | Unique reference of the passenger | 
**PassengerType** | **DgPassengerType** |  | 
**FirstName** | **string** | Ancillaries attached to the itinerary and their prices | [optional] 
**LastName** | **string** | Ancillaries attached to the itinerary and their prices | [optional] 
**DateOfBirth** | **string** | The birth date in ISO Local Date format (yyyy-MM-dd). For encrypted partners, this contains the encrypted Base64 string. | [optional] 
**Gender** | **Gender** |  | [optional] 
**PassportNumber** | **string** | The passport number of the passenger. For encrypted partners, this contains the encrypted Base64 string. | [optional] 
**PassportCountryIssuance** | **string** | The country of issuance of the passenger&#39;s passport. Must be a valid ISO 3166-1 alpha-2 country code (2 uppercase letters, e.g., &#39;US&#39;, &#39;JP&#39;, &#39;TH&#39;). For encrypted partners, this contains the encrypted Base64 string. | [optional] 
**PassportIssuanceDate** | **string** | The date of issuance of the passenger&#39;s passport in ISO Local Date format (yyyy-MM-dd). For encrypted partners, this contains the encrypted Base64 string. | [optional] 
**PassportExpirationDate** | **string** | The passport expiration date of the passenger in ISO Local Date format (yyyy-MM-dd). For encrypted partners, this contains the encrypted Base64 string. | [optional] 
**Nationality** | **string** | The nationality of the passenger. Must be a valid ISO 3166-1 alpha-2 country code (e.g., &#39;US&#39;, &#39;JP&#39;, &#39;TH&#39;). For encrypted partners, this contains the encrypted Base64 string. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

