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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Hopper.Hts.Airlines.Client.OpenAPIDateConverter;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// Service class of the segment
    /// </summary>
    /// <value>Service class of the segment</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Cabin
    {
        /// <summary>
        /// Enum Economy for value: economy
        /// </summary>
        [EnumMember(Value = "economy")]
        Economy = 1,

        /// <summary>
        /// Enum PremiumEconomy for value: premium_economy
        /// </summary>
        [EnumMember(Value = "premium_economy")]
        PremiumEconomy = 2,

        /// <summary>
        /// Enum Business for value: business
        /// </summary>
        [EnumMember(Value = "business")]
        Business = 3,

        /// <summary>
        /// Enum First for value: first
        /// </summary>
        [EnumMember(Value = "first")]
        First = 4
    }

}