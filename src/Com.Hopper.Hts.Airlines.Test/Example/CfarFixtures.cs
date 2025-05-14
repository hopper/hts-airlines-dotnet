
using HtsfaModel = Com.Hopper.Hts.Airlines.Model;
using Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using Com.Hopper.Hts.Airlines.Client;

namespace Example
{
    public class CfarFixtures
    {
        public static HtsfaModel.CreateCfarOfferRequest BuildCreateCfarOfferRequest() {
            return new(
                itinerary: new List<HtsfaModel.CfarOfferItinerary> {
                    new(
                        passengerPricing: new List<PassengerPricing> {
                            new(
                                passengerCount: new (count: 1, type: HtsfaModel.PassengerType.Adult),
                                individualPrice: "10.00"
                            ),
                            new(
                                passengerCount: new (count: 1, type: HtsfaModel.PassengerType.Child),
                                individualPrice: "10.00"
                            )
                        },
                        currency: "USD",
                        slices: BuildSlices(),
                        ancillaries: new List<Ancillary> {
                            new(totalPrice: "1.00", type: HtsfaModel.AncillaryType.CheckedBag, passengerReference: "ABCDEF-1234"),
                            new(totalPrice: "1.00", type: HtsfaModel.AncillaryType.Bundle, passengerReference: "ABCDEF-5678"),
                        },
                        passengers: new List<CfarOfferPassenger> {
                            new(passengerReference: "ABCDEF-1234", passengerType: PassengerType.Adult),
                            new(passengerReference: "ABCDEF-5678", passengerType: PassengerType.Child),
                        }
                    )
                },
                requestType: HtsfaModel.RequestType.Fare,
                extAttributes: new Dictionary<string, string>(),
                session: new(new(
                    userInfo: new(new(airlineUserId: "1234567890")),
                    pointOfSale: "us",
                    language: "en"
                ))
            );
        }

        public static HtsfaModel.CreateCfarContractRequest BuildCreateCfarContractRequest(string offerId) {
            return new(
                offerIds: new List<string> { offerId },
                itinerary: new(
                    passengerPricing: new List<PassengerPricing> {
                        new (
                            passengerCount: new(count: 1, type: HtsfaModel.PassengerType.Adult),
                            individualPrice: "10.00"
                        ),
                        new (
                            passengerCount: new(count: 1, type: HtsfaModel.PassengerType.Child),
                            individualPrice: "10.00"
                        ),
                    },
                    currency: "USD",
                    slices: BuildSlices(),
                    passengers: new(new List<CfarPassenger> {
                        new(passengerReference: "ABCDEF-1234", passengerType: PassengerType.Adult, firstName: "John", lastName: "Doe"),
                        new(passengerReference: "ABCDEF-5678", passengerType: PassengerType.Child, firstName: "Joanne", lastName: "Doe"),
                    })
                ),
                extAttributes: new Dictionary<string, string>(),
                pnrReference: "ABC123"
            );
        }

        public static List<HtsfaModel.CfarItinerarySlice> BuildSlices() {
            return new List<CfarItinerarySlice> {
                new (
                    segments: new List<CfarItinerarySliceSegment> {
                        new(
                            originAirport: "LGA",
                            destinationAirport: "DEN",
                            departureDateTime: "2025-12-01T00:00",
                            arrivalDateTime: "2025-12-01T06:00",
                            flightNumber: "AA123",
                            validatingCarrierCode: "AA",
                            fareClass: HtsfaModel.FareClass.BasicEconomy,
                            fareBrand: "basic"
                        )
                    }
                ),
                new(
                    segments: new List<CfarItinerarySliceSegment> {
                        new(
                            originAirport: "DEN",
                            destinationAirport: "LGA",
                            departureDateTime: "2025-12-02T00:00",
                            arrivalDateTime: "2025-12-02T06:00",
                            flightNumber: "AA124",
                            validatingCarrierCode: "AA",
                            fareClass: HtsfaModel.FareClass.BasicEconomy,
                            fareBrand: "basic"
                        )
                    }
                )
            };
        }
    }
}