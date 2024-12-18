/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Com.Hopper.Hts.Airlines.Client.OpenAPIDateConverter;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// The type of ancillary
    /// </summary>
    /// <value>The type of ancillary</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DgAncillaryType
    {
        /// <summary>
        /// Enum TravelInsurance for value: travel_insurance
        /// </summary>
        [EnumMember(Value = "travel_insurance")]
        TravelInsurance = 1,

        /// <summary>
        /// Enum BagInsurance for value: bag_insurance
        /// </summary>
        [EnumMember(Value = "bag_insurance")]
        BagInsurance = 2,

        /// <summary>
        /// Enum CabinBag for value: cabin_bag
        /// </summary>
        [EnumMember(Value = "cabin_bag")]
        CabinBag = 3,

        /// <summary>
        /// Enum CheckedBag for value: checked_bag
        /// </summary>
        [EnumMember(Value = "checked_bag")]
        CheckedBag = 4,

        /// <summary>
        /// Enum Seat for value: seat
        /// </summary>
        [EnumMember(Value = "seat")]
        Seat = 5,

        /// <summary>
        /// Enum Lounge for value: lounge
        /// </summary>
        [EnumMember(Value = "lounge")]
        Lounge = 6,

        /// <summary>
        /// Enum Meal for value: meal
        /// </summary>
        [EnumMember(Value = "meal")]
        Meal = 7,

        /// <summary>
        /// Enum FastTrack for value: fast_track
        /// </summary>
        [EnumMember(Value = "fast_track")]
        FastTrack = 8,

        /// <summary>
        /// Enum Pet for value: pet
        /// </summary>
        [EnumMember(Value = "pet")]
        Pet = 9,

        /// <summary>
        /// Enum Change for value: change
        /// </summary>
        [EnumMember(Value = "change")]
        Change = 10,

        /// <summary>
        /// Enum Bundle for value: bundle
        /// </summary>
        [EnumMember(Value = "bundle")]
        Bundle = 11,

        /// <summary>
        /// Enum PaymentFee for value: payment_fee
        /// </summary>
        [EnumMember(Value = "payment_fee")]
        PaymentFee = 12,

        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 13
    }

}
