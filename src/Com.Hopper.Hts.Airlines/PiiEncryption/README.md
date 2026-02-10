# PII Encryption for Airlines API

Client-side PII (Personally Identifiable Information) encryption for partners with PII encryption enabled.

## Quick Start

### 1. Obtain Your Public Key

Contact your partner to obtain the RSA public key in PEM format:

```
-----BEGIN PUBLIC KEY-----
MIICIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIICCgKCAgEA...
-----END PUBLIC KEY-----
```

### 2. Initialize Encryption

```csharp
using Com.Hopper.Hts.Airlines.PiiEncryption.Model;

var encryption = new PiiEncryption
{
    PublicKeyPem = publicKeyPem
};
```

### 3. Encrypt PII Data

#### Encrypt Contracts (Passengers)

```csharp
using Com.Hopper.Hts.Airlines.Model;

// Create contract request with plaintext passenger PII
var contractRequest = new CreateDgContractRequest(
    offerIds: new List<string> { offerId },
    itinerary: new DgItinerary(
        passengers: new List<DgPassenger> {
            new DgPassenger(
                passengerReference: "1",
                passengerType: DgPassengerType.Adult,
                firstName: "John",
                lastName: "Smith",
                dateOfBirth: "1990-01-01",
                passportNumber: "AB1234567",
                nationality: "US"
            )
        },
        ...
    )
);

// Encrypt all passenger PII fields
encryption.EncryptPii(contractRequest);

// Send to API - all passenger PII is now encrypted
var contract = await dgApi.PostDgContractsAsync(contractRequest);
```

#### Encrypt Payments

```csharp
// Create payment request with plaintext PII
var payment = new ProcessDgPaymentRequest(
    paymentToken: "tok_123456",
    pnrReference: "ABC123",
    emailAddress: "john.smith@example.com",
    phoneNumber: "+15145551234",
    firstName: "John",
    lastName: "Smith",
    city: "Toronto",
    country: "CA"
);

// Encrypt all payment PII fields
encryption.EncryptPii(payment);

// Send to API - all payment PII is now encrypted
var result = await dgApi.PostDgContractsIdPaymentAsync(contractId, payment);
```

## Encrypted Fields

**Passenger Fields:**
- firstName, lastName, passportNumber, dateOfBirth
- passportCountryIssuance, passportIssuanceDate, passportExpirationDate, nationality

**Payment Fields:**
- firstName, lastName, emailAddress, phoneNumber
- addressLine1, addressLine2, city, stateOrProvince, postalCode, country

**Note:** Non-PII fields like `payment_token` and `pnr_reference` are NOT encrypted.

## Security Notes

- **Public Key Only**: Client uses public key for encryption only (private key stays on server)
- **One-Way**: Client can encrypt but cannot decrypt
- **Key Rotation**: Ensure you have the latest public key from your partner
- **Never Log Plaintext**: Do not log PII values after encryption

## Support

For questions or issues:
- Contact your partner for public key access
- Report SDK bugs at: https://github.com/hopper-org/hts-airlines-dotnet/issues
