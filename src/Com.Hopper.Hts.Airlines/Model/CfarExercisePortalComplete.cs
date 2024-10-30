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
    /// CfarExercisePortalComplete
    /// </summary>
    [DataContract(Name = "cfar_exercise_portal_complete")]
    public partial class CfarExercisePortalComplete
    {

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public ExerciseStepResult Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarExercisePortalComplete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CfarExercisePortalComplete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CfarExercisePortalComplete" /> class.
        /// </summary>
        /// <param name="occurredDateTime">A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device (required).</param>
        /// <param name="cfarExerciseId">cfarExerciseId (required).</param>
        /// <param name="result">result (required).</param>
        /// <param name="type">type (required).</param>
        public CfarExercisePortalComplete(DateTime occurredDateTime = default(DateTime), string cfarExerciseId = default(string), ExerciseStepResult result = default(ExerciseStepResult), string type = default(string))
        {
            this.OccurredDateTime = occurredDateTime;
            // to ensure "cfarExerciseId" is required (not null)
            if (cfarExerciseId == null)
            {
                throw new ArgumentNullException("cfarExerciseId is a required property for CfarExercisePortalComplete and cannot be null");
            }
            this.CfarExerciseId = cfarExerciseId;
            this.Result = result;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CfarExercisePortalComplete and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device
        /// </summary>
        /// <value>A UTC [RFC3339](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14) datetime;  the date and time at which an event occurred on a client device</value>
        /*
        <example>2022-01-24T15:34:30Z</example>
        */
        [DataMember(Name = "occurred_date_time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime OccurredDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CfarExerciseId
        /// </summary>
        [DataMember(Name = "cfar_exercise_id", IsRequired = true, EmitDefaultValue = true)]
        public string CfarExerciseId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CfarExercisePortalComplete {\n");
            sb.Append("  OccurredDateTime: ").Append(OccurredDateTime).Append("\n");
            sb.Append("  CfarExerciseId: ").Append(CfarExerciseId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }

}
