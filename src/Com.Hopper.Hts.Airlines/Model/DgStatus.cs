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
    /// Defines dg_status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DgStatus
    {
        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 1,

        /// <summary>
        /// Enum Confirmed for value: confirmed
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed = 2,

        /// <summary>
        /// Enum ChargedBack for value: charged_back
        /// </summary>
        [EnumMember(Value = "charged_back")]
        ChargedBack = 3,

        /// <summary>
        /// Enum Voided for value: voided
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided = 4,

        /// <summary>
        /// Enum Canceled for value: canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled = 5,

        /// <summary>
        /// Enum Queued for value: queued
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued = 6,

        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 7
    }

}
