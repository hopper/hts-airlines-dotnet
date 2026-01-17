# Com.Hopper.Hts.Airlines.Model.CreateExternalCfarOfferRequest
Create a CFAR offer with externally provided pricing and coverage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | External identifier for this offer | 
**CountryCode** | **string** | Two-character country code in ISO 3166-1 format | 
**Currency** | **string** | Currency of the offer | 
**ToUsdExchangeRate** | **string** | Exchange rate from offer currency to USD | 
**PremiumTotalAmount** | **string** | Total premium amount (including taxes) | 
**PremiumPercentage** | **string** | Premium as a percentage of ticket price | 
**PayoutTotalAmount** | **string** | Total payout amount upon exercise | 
**PayoutPercentage** | **string** | Payout as a percentage of ticket price | 
**TaxesTotal** | **string** | Total taxes on the premium | 
**ContractExpiryDateTime** | **DateTime** | A UTC RFC3339 datetime; expiry date and time of the contract once purchased | 
**Itinerary** | [**CfarOfferItinerary**](CfarOfferItinerary.md) |  | 
**MinMinutesDelay** | **long** | Minimum delay in minutes required for CFAR exercise eligibility | 
**BookingDateTime** | **DateTime** | A UTC RFC3339 datetime; the date and time at which the booking was made | [optional] 
**Session** | [**CreateAirlineCfarSessionRequest**](CreateAirlineCfarSessionRequest.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

