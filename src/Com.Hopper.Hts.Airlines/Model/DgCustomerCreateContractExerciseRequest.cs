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
    /// A create DG contract exercise request
    /// </summary>
    [DataContract(Name = "dg_customer_create_contract_exercise_request")]
    public partial class DgCustomerCreateContractExerciseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgCustomerCreateContractExerciseRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DgCustomerCreateContractExerciseRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgCustomerCreateContractExerciseRequest" /> class.
        /// </summary>
        /// <param name="contractId">A unique identifier for a DG contract (required).</param>
        /// <param name="disruptedSegmentId">A unique identifier for current disrupted segment (required).</param>
        public DgCustomerCreateContractExerciseRequest(string contractId = default(string), string disruptedSegmentId = default(string))
        {
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new ArgumentNullException("contractId is a required property for DgCustomerCreateContractExerciseRequest and cannot be null");
            }
            this.ContractId = contractId;
            // to ensure "disruptedSegmentId" is required (not null)
            if (disruptedSegmentId == null)
            {
                throw new ArgumentNullException("disruptedSegmentId is a required property for DgCustomerCreateContractExerciseRequest and cannot be null");
            }
            this.DisruptedSegmentId = disruptedSegmentId;
        }

        /// <summary>
        /// A unique identifier for a DG contract
        /// </summary>
        /// <value>A unique identifier for a DG contract</value>
        /*
        <example>1ec9ef29-be31-6ed3-beec-9f5ae0d164ee</example>
        */
        [DataMember(Name = "contract_id", IsRequired = true, EmitDefaultValue = true)]
        public string ContractId { get; set; }

        /// <summary>
        /// A unique identifier for current disrupted segment
        /// </summary>
        /// <value>A unique identifier for current disrupted segment</value>
        /*
        <example>1ec9ef29-be31-6ed3-beec-9f5ae0d164ef</example>
        */
        [DataMember(Name = "disrupted_segment_id", IsRequired = true, EmitDefaultValue = true)]
        public string DisruptedSegmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgCustomerCreateContractExerciseRequest {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  DisruptedSegmentId: ").Append(DisruptedSegmentId).Append("\n");
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
