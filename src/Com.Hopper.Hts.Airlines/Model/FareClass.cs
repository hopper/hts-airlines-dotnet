// <auto-generated>
/*
 * Airline API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using Com.Hopper.Hts.Airlines.Client;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// Fare class of the segment
    /// </summary>
    /// <value>Fare class of the segment</value>
    public enum FareClass
    {
        /// <summary>
        /// Enum BasicEconomy for value: basic_economy
        /// </summary>
        BasicEconomy = 1,

        /// <summary>
        /// Enum Economy for value: economy
        /// </summary>
        Economy = 2,

        /// <summary>
        /// Enum PremiumEconomy for value: premium_economy
        /// </summary>
        PremiumEconomy = 3,

        /// <summary>
        /// Enum Business for value: business
        /// </summary>
        Business = 4,

        /// <summary>
        /// Enum First for value: first
        /// </summary>
        First = 5
    }

    /// <summary>
    /// Converts <see cref="FareClass"/> to and from the JSON value
    /// </summary>
    public static class FareClassValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="FareClass"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FareClass FromString(string value)
        {
            if (value.Equals("basic_economy"))
                return FareClass.BasicEconomy;

            if (value.Equals("economy"))
                return FareClass.Economy;

            if (value.Equals("premium_economy"))
                return FareClass.PremiumEconomy;

            if (value.Equals("business"))
                return FareClass.Business;

            if (value.Equals("first"))
                return FareClass.First;

            throw new NotImplementedException($"Could not convert value to type FareClass: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="FareClass"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FareClass? FromStringOrDefault(string value)
        {
            if (value.Equals("basic_economy"))
                return FareClass.BasicEconomy;

            if (value.Equals("economy"))
                return FareClass.Economy;

            if (value.Equals("premium_economy"))
                return FareClass.PremiumEconomy;

            if (value.Equals("business"))
                return FareClass.Business;

            if (value.Equals("first"))
                return FareClass.First;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="FareClass"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(FareClass value)
        {
            if (value == FareClass.BasicEconomy)
                return "basic_economy";

            if (value == FareClass.Economy)
                return "economy";

            if (value == FareClass.PremiumEconomy)
                return "premium_economy";

            if (value == FareClass.Business)
                return "business";

            if (value == FareClass.First)
                return "first";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FareClass"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class FareClassJsonConverter : JsonConverter<FareClass>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FareClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FareClass? result = rawValue == null
                ? null
                : FareClassValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the FareClass to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fareClass"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FareClass fareClass, JsonSerializerOptions options)
        {
            writer.WriteStringValue(fareClass.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FareClass"/>
    /// </summary>
    public class FareClassNullableJsonConverter : JsonConverter<FareClass?>
    {
        /// <summary>
        /// Returns a FareClass from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FareClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FareClass? result = rawValue == null
                ? null
                : FareClassValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fareClass"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FareClass? fareClass, JsonSerializerOptions options)
        {
            writer.WriteStringValue(fareClass?.ToString() ?? "null");
        }
    }
}
