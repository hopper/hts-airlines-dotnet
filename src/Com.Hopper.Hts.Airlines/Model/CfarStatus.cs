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
    /// Defines cfar_status
    /// </summary>
    public enum CfarStatus
    {
        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        Created = 1,

        /// <summary>
        /// Enum Confirmed for value: confirmed
        /// </summary>
        Confirmed = 2,

        /// <summary>
        /// Enum ChargedBack for value: charged_back
        /// </summary>
        ChargedBack = 3,

        /// <summary>
        /// Enum Voided for value: voided
        /// </summary>
        Voided = 4,

        /// <summary>
        /// Enum Canceled for value: canceled
        /// </summary>
        Canceled = 5
    }

    /// <summary>
    /// Converts <see cref="CfarStatus"/> to and from the JSON value
    /// </summary>
    public static class CfarStatusValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="CfarStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CfarStatus FromString(string value)
        {
            if (value.Equals("created"))
                return CfarStatus.Created;

            if (value.Equals("confirmed"))
                return CfarStatus.Confirmed;

            if (value.Equals("charged_back"))
                return CfarStatus.ChargedBack;

            if (value.Equals("voided"))
                return CfarStatus.Voided;

            if (value.Equals("canceled"))
                return CfarStatus.Canceled;

            throw new NotImplementedException($"Could not convert value to type CfarStatus: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="CfarStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CfarStatus? FromStringOrDefault(string value)
        {
            if (value.Equals("created"))
                return CfarStatus.Created;

            if (value.Equals("confirmed"))
                return CfarStatus.Confirmed;

            if (value.Equals("charged_back"))
                return CfarStatus.ChargedBack;

            if (value.Equals("voided"))
                return CfarStatus.Voided;

            if (value.Equals("canceled"))
                return CfarStatus.Canceled;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CfarStatus"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(CfarStatus value)
        {
            if (value == CfarStatus.Created)
                return "created";

            if (value == CfarStatus.Confirmed)
                return "confirmed";

            if (value == CfarStatus.ChargedBack)
                return "charged_back";

            if (value == CfarStatus.Voided)
                return "voided";

            if (value == CfarStatus.Canceled)
                return "canceled";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CfarStatus"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class CfarStatusJsonConverter : JsonConverter<CfarStatus>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CfarStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            CfarStatus? result = rawValue == null
                ? null
                : CfarStatusValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the CfarStatus to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarStatus"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CfarStatus cfarStatus, JsonSerializerOptions options)
        {
            writer.WriteStringValue(cfarStatus.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CfarStatus"/>
    /// </summary>
    public class CfarStatusNullableJsonConverter : JsonConverter<CfarStatus?>
    {
        /// <summary>
        /// Returns a CfarStatus from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CfarStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            CfarStatus? result = rawValue == null
                ? null
                : CfarStatusValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cfarStatus"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, CfarStatus? cfarStatus, JsonSerializerOptions options)
        {
            writer.WriteStringValue(cfarStatus?.ToString() ?? "null");
        }
    }
}
