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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AuthResponse
    /// </summary>
    [DataContract(Name = "auth_response")]
    public partial class AuthResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResponse" /> class.
        /// </summary>
        /// <param name="accessToken">The authentication token (required).</param>
        /// <param name="scope">Token&#39;s scope (required).</param>
        /// <param name="expiresIn">Token&#39;s expiration (in seconds) (required).</param>
        /// <param name="tokenType">tokenType (required).</param>
        public AuthResponse(string accessToken = default(string), string scope = default(string), int expiresIn = default(int), string tokenType = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for AuthResponse and cannot be null");
            }
            this.AccessToken = accessToken;
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for AuthResponse and cannot be null");
            }
            this.Scope = scope;
            this.ExpiresIn = expiresIn;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for AuthResponse and cannot be null");
            }
            this.TokenType = tokenType;
        }

        /// <summary>
        /// The authentication token
        /// </summary>
        /// <value>The authentication token</value>
        /*
        <example>eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6ImtjN2FjWmV4bHBvZk1QY3V6UF9HTyJ9.eyJpc3MiOiJodHRwczovL2hvcHBlci1hcGkuYXV0aDAuY29tLyIsInN1YiI6IlhVdWpRSlRCODFPdkVTODh1VDlPNHhIUzVNUkpZV2tCQGNsaWVudHMiLCJhdWQiOiJodHRwczovL3N0YWdpbmcuYXBpLmhvcHBlci5jb20iLCJpYXQiOjE2NTI5ODQ2ODEsImV4cCI6MTY1MzA3MTA4MSwiYXpwIjoiWFV1alFKVEI4MU92RVM4OHVUOU80eEhTNU1SSllXa0IiLCJzY29wZSI6ImFsbDpwcmljZWZyZWV6ZSBhbGw6Z2VuZXJhbCBhbGw6Y2ZhciIsImd0eSI6ImNsaWVudC1jcmVkZW50aWFscyJ9.VlKuMHJkGpOA-L9oJn-UBEOD7VdzLXQSn2DiTrlROR521uHupkRnI-_tDjYD-sygmNmI0bIb0UEQ2ETOyalFZICge8-qWpxBccM_rfgPemZ6Rs9fZSY8XjZtaM9sQEJ4OqwXQiIU0tQDVMfegj-4wnKglHAKzJ7X7wb05nSCP_g2cXIXL9mapnLT8vf609CZIz2cRuWvww5E9qlJ6mUQxsYBv9xwJoyF3IK8TCWUFFvu2xSendMltvUlCHJHjWpddFDTdkl1ErHq_ta-3e1n2ZjU1HVVux9dwWoZQDYJFprtDYjPS-jVhEljGMASB74zf_xbcWCwoa_HJlxLlhBhoQ</example>
        */
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Token&#39;s scope
        /// </summary>
        /// <value>Token&#39;s scope</value>
        /*
        <example>all:general all:cfar</example>
        */
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Token&#39;s expiration (in seconds)
        /// </summary>
        /// <value>Token&#39;s expiration (in seconds)</value>
        /*
        <example>86400</example>
        */
        [DataMember(Name = "expires_in", IsRequired = true, EmitDefaultValue = true)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
