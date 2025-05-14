
using HtsfaModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using Com.Hopper.Hts.Airlines.Client;

namespace Example
{
    public class CfarFixtures
    {
        public static HtsfaModel.CreateCfarOfferRequest BuildCreateCfarOfferRequest() {
            return new HtsfaModel.CreateCfarOfferRequest(
                new List<HtsfaModel.CfarOfferItinerary> {
                    new HtsfaModel.CfarOfferItinerary(
                        new List<HtsfaModel.PassengerPricing> {
                            new HtsfaModel.PassengerPricing(new HtsfaModel.PassengerCount(1, HtsfaModel.PassengerType.Adult), "10.00")
                        },
                        currency: "USD",
                        slices: new List<HtsfaModel.CfarItinerarySlice> {
                            new HtsfaModel.CfarItinerarySlice(
                                segments: new List<HtsfaModel.CfarItinerarySliceSegment> {
                                    new HtsfaModel.CfarItinerarySliceSegment(
                                        originAirport: "LGA",
                                        destinationAirport: "DEN",
                                        departureDateTime: "2025-12-01T00:00",
                                        arrivalDateTime: "2025-12-01T02:00",
                                        flightNumber: "AA123",
                                        validatingCarrierCode: "AA",
                                        fareClass: HtsfaModel.FareClass.BasicEconomy
                                    )
                                }
                            )
                        },
                        ancillaries: new Option<List<HtsfaModel.Ancillary>?>(new List<HtsfaModel.Ancillary> {
                            new HtsfaModel.Ancillary("1.00", HtsfaModel.AncillaryType.CheckedBag),
                        })
                    )
                },
                HtsfaModel.RequestType.Fare,
                extAttributes: new Dictionary<string, string>()
            );
        }

        public static HtsfaModel.CreateCfarContractRequest BuildCreateCfarContractRequest(string offerId) {
            return new HtsfaModel.CreateCfarContractRequest(
                new List<string> { offerId },
                new HtsfaModel.CfarItinerary(
                    new List<HtsfaModel.PassengerPricing> {
                        new HtsfaModel.PassengerPricing(new HtsfaModel.PassengerCount(1, HtsfaModel.PassengerType.Adult), "10.00")
                    },
                    currency: "USD",
                    slices: new List<HtsfaModel.CfarItinerarySlice> {
                        new HtsfaModel.CfarItinerarySlice(
                            segments: new List<HtsfaModel.CfarItinerarySliceSegment> {
                                new HtsfaModel.CfarItinerarySliceSegment(
                                    originAirport: "LGA",
                                    destinationAirport: "DEN",
                                    departureDateTime: "2025-12-01T00:00",
                                    arrivalDateTime: "2025-12-01T02:00",
                                    flightNumber: "AA123",
                                    validatingCarrierCode: "AA",
                                    fareClass: HtsfaModel.FareClass.BasicEconomy
                                )
                            }
                        )
                    }
                ),
                extAttributes: new Dictionary<string, string>()
            );
        }
    }
}