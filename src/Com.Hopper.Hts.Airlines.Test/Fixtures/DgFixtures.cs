
using Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;

namespace Com.Hopper.Hts.Airlines.Test.Fixtures
{
    public class DgFixtures
    {
        public static CreateDgOffersRequest BuildCreateOfferRequest() {
            return new(
                itinerary: new List<DgItinerary> {
                    new(
                        passengerPricing: new List<DgPassengerPricing> {
                            new(
                                passengerCount: new (count: 1, type: PassengerType.Adult),
                                individualPrice: "10.00"
                            ),
                            new(
                                passengerCount: new (count: 1, type: PassengerType.Child),
                                individualPrice: "10.00"
                            )
                        },
                        currency: "USD",
                        slices: BuildSlices(),
                        ancillaries: new List<DgAncillary> {
                            new(totalPrice: "1.00", type: DgAncillaryType.CheckedBag, passengerReference: "ABCDEF-1234"),
                            new(totalPrice: "1.00", type: DgAncillaryType.Bundle, passengerReference: "ABCDEF-5678"),
                        },
                        passengers: new List<DgPassenger> {
                            new(passengerReference: "ABCDEF-1234", passengerType: DgPassengerType.Adult),
                            new(passengerReference: "ABCDEF-5678", passengerType: DgPassengerType.Child),
                        }
                    )
                },
                requestType: DgRequestType.Fare,
                extAttributes: new Dictionary<string, string>(),
                session: new(new(
                    userInfo: new(new(airlineUserId: "1234567890")),
                    pointOfSale: "us",
                    language: "en"
                ))
            );
        }

        public static CreateDgContractRequest BuildCreateContractRequest(string offerId) {
            return new(
                offerIds: new List<string> { offerId },
                itinerary: new(
                    passengerPricing: new List<DgPassengerPricing> {
                        new (
                            passengerCount: new(count: 1, type: PassengerType.Adult),
                            individualPrice: "10.00"
                        ),
                        new (
                            passengerCount: new(count: 1, type: PassengerType.Child),
                            individualPrice: "10.00"
                        ),
                    },
                    currency: "USD",
                    slices: BuildSlices(),
                    passengers: new(new List<DgPassenger> {
                        new(passengerReference: "ABCDEF-1234", passengerType: DgPassengerType.Adult, firstName: "John", lastName: "Doe"),
                        new(passengerReference: "ABCDEF-5678", passengerType: DgPassengerType.Child, firstName: "Joanne", lastName: "Doe"),
                    })
                ),
                extAttributes: new Dictionary<string, string>(),
                pnrReference: "ABC123"
            );
        }

        public static List<DgItinerarySlice> BuildSlices() {
            return new List<DgItinerarySlice> {
                new (
                    segments: new List<DgItinerarySliceSegment> {
                        new(
                            originAirport: "LGA",
                            destinationAirport: "DEN",
                            departureDateTime: "2025-12-01T00:00",
                            arrivalDateTime: "2025-12-01T06:00",
                            flightNumber: "AA123",
                            validatingCarrierCode: "AA",
                            cabin: Cabin.Economy,
                            fareBrand: "basic"
                        )
                    }
                ),
                new(
                    segments: new List<DgItinerarySliceSegment> {
                        new(
                            originAirport: "DEN",
                            destinationAirport: "LGA",
                            departureDateTime: "2025-12-02T00:00",
                            arrivalDateTime: "2025-12-02T06:00",
                            flightNumber: "AA124",
                            validatingCarrierCode: "AA",
                            cabin: Cabin.Economy,
                            fareBrand: "basic"
                        )
                    }
                )
            };
        }
    }
}