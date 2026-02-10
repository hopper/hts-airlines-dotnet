using Com.Hopper.Hts.Airlines.Api;
using Com.Hopper.Hts.Airlines.Model;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Collections.Generic;
using PiiEncryptionModel = Com.Hopper.Hts.Airlines.PiiEncryption.Model;

namespace Com.Hopper.Hts.Airlines.Test.PiiEncryption
{
    [TestClass]
    public class PiiEncryptionTest : PiiEncryptionTestsBase
    {
        private readonly IDisruptionGuaranteeDGApi _dgApi;
        private readonly ISessionsApi _sessionApi;
        private readonly PiiEncryptionModel.PiiEncryption _piiEncryption;

        public PiiEncryptionTest() : base(Array.Empty<string>())
        {
            _dgApi = _host.Services.GetRequiredService<IDisruptionGuaranteeDGApi>();
            _sessionApi = _host.Services.GetRequiredService<ISessionsApi>();
            _piiEncryption = _host.Services.GetRequiredService<PiiEncryptionModel.PiiEncryption>();
        }

        [TestMethod]
        public async Task EncryptPassengerPiiFieldsTest()
        {
            // Create session
            var sessionId = (await _sessionApi.PostSessionsAsync(new CreateAirlineSessionRequest(
                FlowType.Purchase,
                pointOfSale: "us",
                language: "en"
            ))).Created()?.Id ?? throw new Exception("Session creation failed");

            // Create contract request with plaintext passenger PII
            var contractRequest = new CreateDgContractRequest(
                offerIds: new List<string> { "test-offer" },
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
                    passengerPricing: new List<DgPassengerPricing>(),
                    slices: new List<DgItinerarySlice>(),
                    currency: "USD"
                ),
                extAttributes: new Dictionary<string, string>(),
                pnrReference: "TEST123"
            );

            // Encrypt all passenger PII fields in the request
            _piiEncryption.EncryptPii(contractRequest);

            var passenger = contractRequest.Itinerary.Passengers[0];

            // Verify fields are encrypted (Base64 format)
            Assert.IsNotNull(passenger.FirstName);
            Assert.IsTrue(passenger.FirstName.Length > 100); // Encrypted value is much longer
            Assert.IsNotNull(passenger.DateOfBirth);
            Assert.IsTrue(passenger.DateOfBirth.Length > 100); // Encrypted value is much longer

            Debug.Print($"Encrypted FirstName: {passenger.FirstName}");
            Debug.Print($"Encrypted DateOfBirth: {passenger.DateOfBirth}");
        }

        [TestMethod]
        public async Task EncryptPaymentPiiFieldsTest()
        {
            // Create payment request with plaintext PII
            var payment = new ProcessDgPaymentRequest(
                paymentToken: "tok_test_123",
                pnrReference: "ABC123",
                emailAddress: "john.smith@example.com",
                phoneNumber: "+15145551234",
                firstName: "John",
                lastName: "Smith",
                city: "Toronto",
                country: "CA"
            );

            // Encrypt all PII fields
            _piiEncryption.EncryptPii(payment);

            // Verify fields are encrypted (Base64 format)
            Assert.IsNotNull(payment.EmailAddress);
            Assert.IsTrue(payment.EmailAddress.Length > 100); // Encrypted value is much longer
            Assert.AreEqual("tok_test_123", payment.PaymentToken); // Non-PII remains plaintext

            Debug.Print($"Encrypted EmailAddress: {payment.EmailAddress}");
            Debug.Print($"Encrypted PhoneNumber: {payment.PhoneNumber}");
            Debug.Print($"Plaintext PaymentToken: {payment.PaymentToken}");
        }

        [TestMethod]
        public async Task EndToEndEncryptedContractCreationTest()
        {
            // This test validates that the server can decrypt our encrypted PII
            // by creating a complete DG contract with encrypted passenger data

            // Step 1: Create a session
            var sessionId = (await _sessionApi.PostSessionsAsync(new CreateAirlineSessionRequest(
                FlowType.Purchase,
                pointOfSale: "us",
                language: "en"
            ))).Created()?.Id ?? throw new Exception("Session creation failed");

            Debug.Print($"Created session: {sessionId}");

            // Step 2: Create a DG offer
            var offerRequest = new CreateDgOffersRequest(
                itinerary: new List<DgItinerary> {
                    new(
                        passengerPricing: new List<DgPassengerPricing> {
                            new(
                                passengerCount: new(count: 2, type: PassengerType.Adult),
                                individualPrice: "430.18"
                            ),
                            new(
                                passengerCount: new(count: 1, type: PassengerType.LapInfant),
                                individualPrice: "10.00"
                            )
                        },
                        currency: "CAD",
                        slices: new List<DgItinerarySlice> {
                            new(
                                segments: new List<DgItinerarySliceSegment> {
                                    new(
                                        originAirport: "YTZ",
                                        destinationAirport: "EWR",
                                        departureDateTime: "2026-03-01T00:00:00",
                                        arrivalDateTime: "2026-03-01T02:00:00",
                                        flightNumber: "2135",
                                        validatingCarrierCode: "PD",
                                        cabin: Cabin.Economy,
                                        fareBrand: "classic"
                                    )
                                }
                            ),
                            new(
                                segments: new List<DgItinerarySliceSegment> {
                                    new(
                                        originAirport: "EWR",
                                        destinationAirport: "YTZ",
                                        departureDateTime: "2026-03-01T04:00:00",
                                        arrivalDateTime: "2026-03-01T06:00:00",
                                        flightNumber: "2136",
                                        validatingCarrierCode: "PD",
                                        cabin: Cabin.Economy,
                                        fareBrand: "classic"
                                    )
                                }
                            )
                        },
                        passengers: new List<DgPassenger> {
                            new(passengerReference: "4ed2e42a", passengerType: DgPassengerType.Adult),
                            new(passengerReference: "dbf81ef8", passengerType: DgPassengerType.Adult),
                            new(passengerReference: "44e2c64f", passengerType: DgPassengerType.LapInfant)
                        }
                    )
                },
                requestType: DgRequestType.Ancillary,
                extAttributes: new Dictionary<string, string>(),
                session: new(new(
                    userInfo: new(new(airlineUserId: "frequent-flyer-123456789")),
                    pointOfSale: "CA",
                    language: "EN"
                ))
            );

            var offerResponse = await _dgApi.PostDgOffersAsync(offerRequest, hCSessionID: sessionId);
            var offerId = offerResponse.Created()?[0].Id ?? throw new Exception("Offer creation failed");

            Debug.Print($"Created offer: {offerId}");

            // Step 3: Create passengers with PII
            var passenger1 = new DgPassenger(
                passengerReference: "4ed2e42a",
                passengerType: DgPassengerType.Adult,
                firstName: "Jane",
                lastName: "Doe",
                dateOfBirth: "1985-05-15",
                passportNumber: "US1234567",
                nationality: "US"
            );

            var passenger2 = new DgPassenger(
                passengerReference: "dbf81ef8",
                passengerType: DgPassengerType.Adult,
                firstName: "John",
                lastName: "Smith",
                dateOfBirth: "1990-08-20",
                passportNumber: "US7654321",
                nationality: "US"
            );

            var passenger3 = new DgPassenger(
                passengerReference: "44e2c64f",
                passengerType: DgPassengerType.LapInfant,
                firstName: "Baby",
                lastName: "Smith",
                dateOfBirth: "2025-01-10"
            );

            // Step 4: Create contract request with plaintext passengers
            var contractRequest = new CreateDgContractRequest(
                offerIds: new List<string> { offerId },
                itinerary: new DgItinerary(
                    passengerPricing: new List<DgPassengerPricing> {
                        new(
                            passengerCount: new(count: 2, type: PassengerType.Adult),
                            individualPrice: "430.18"
                        ),
                        new(
                            passengerCount: new(count: 1, type: PassengerType.LapInfant),
                            individualPrice: "10.00"
                        )
                    },
                    currency: "CAD",
                    slices: new List<DgItinerarySlice> {
                        new(
                            segments: new List<DgItinerarySliceSegment> {
                                new(
                                    originAirport: "YTZ",
                                    destinationAirport: "EWR",
                                    departureDateTime: "2026-03-01T00:00:00",
                                    arrivalDateTime: "2026-03-01T02:00:00",
                                    flightNumber: "2135",
                                    validatingCarrierCode: "PD",
                                    cabin: Cabin.Economy,
                                    fareBrand: "classic"
                                )
                            }
                        ),
                        new(
                            segments: new List<DgItinerarySliceSegment> {
                                new(
                                    originAirport: "EWR",
                                    destinationAirport: "YTZ",
                                    departureDateTime: "2026-03-01T04:00:00",
                                    arrivalDateTime: "2026-03-01T06:00:00",
                                    flightNumber: "2136",
                                    validatingCarrierCode: "PD",
                                    cabin: Cabin.Economy,
                                    fareBrand: "classic"
                                )
                            }
                        )
                    },
                    passengers: new List<DgPassenger> { passenger1, passenger2, passenger3 },
                    ancillaries: new List<DgAncillary> {
                        new(totalPrice: "15.00", type: DgAncillaryType.CheckedBag, passengerReference: "4ed2e42a"),
                        new(totalPrice: "5.00", type: DgAncillaryType.Seat, passengerReference: "4ed2e42a"),
                        new(totalPrice: "5.00", type: DgAncillaryType.Seat, passengerReference: "dbf81ef8")
                    }
                ),
                extAttributes: new Dictionary<string, string>(),
                pnrReference: "ABC123"
            );

            // Step 5: Encrypt all passenger PII in the contract request
            _piiEncryption.EncryptPii(contractRequest);

            Debug.Print($"Encrypted passenger 1 firstName: {contractRequest.Itinerary.Passengers[0].FirstName?.Substring(0, 50)}...");
            Debug.Print($"Encrypted passenger 2 firstName: {contractRequest.Itinerary.Passengers[1].FirstName?.Substring(0, 50)}...");

            // Step 6: Send encrypted data to server
            // If this succeeds, the server successfully decrypted our PII!
            var contractResponse = await _dgApi.PostDgContractsAsync(contractRequest);
            var contractId = contractResponse.Created()?.Id;

            // Assertions
            Assert.IsNotNull(contractId, "Contract creation failed - server may not have decrypted PII correctly");
            Debug.Print($"✅ SUCCESS! Created contract with encrypted PII: {contractId}");
            Debug.Print("Server successfully decrypted passenger data!");
        }
    }
}
