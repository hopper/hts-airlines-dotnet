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
    /// The product for which the session is opened.&lt;br/&gt;Required for sessions having flow_type \&quot;exercise\&quot;.
    /// </summary>
    /// <value>The product for which the session is opened.&lt;br/&gt;Required for sessions having flow_type \&quot;exercise\&quot;.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Product
    {
        /// <summary>
        /// Enum Cfar for value: cfar
        /// </summary>
        [EnumMember(Value = "cfar")]
        Cfar = 1,

        /// <summary>
        /// Enum Dg for value: dg
        /// </summary>
        [EnumMember(Value = "dg")]
        Dg = 2,

        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 3
    }

}
