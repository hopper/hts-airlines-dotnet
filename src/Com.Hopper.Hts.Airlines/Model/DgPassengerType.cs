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
    /// Defines dg_passenger_type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DgPassengerType
    {
        /// <summary>
        /// Enum Adult for value: adult
        /// </summary>
        [EnumMember(Value = "adult")]
        Adult = 1,

        /// <summary>
        /// Enum Child for value: child
        /// </summary>
        [EnumMember(Value = "child")]
        Child = 2,

        /// <summary>
        /// Enum SeatedInfant for value: seated_infant
        /// </summary>
        [EnumMember(Value = "seated_infant")]
        SeatedInfant = 3,

        /// <summary>
        /// Enum LapInfant for value: lap_infant
        /// </summary>
        [EnumMember(Value = "lap_infant")]
        LapInfant = 4
    }

}
