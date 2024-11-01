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
    /// An object detailing the Passenger Information
    /// </summary>
    [DataContract(Name = "dg_passenger")]
    public partial class DgPassenger
    {

        /// <summary>
        /// Gets or Sets PassengerType
        /// </summary>
        [DataMember(Name = "passenger_type", IsRequired = true, EmitDefaultValue = true)]
        public DgPassengerType PassengerType { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public Gender? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgPassenger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DgPassenger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DgPassenger" /> class.
        /// </summary>
        /// <param name="passengerReference">Unique reference of the passenger (required).</param>
        /// <param name="passengerType">passengerType (required).</param>
        /// <param name="firstName">Ancillaries attached to the itinerary and their prices.</param>
        /// <param name="lastName">Ancillaries attached to the itinerary and their prices.</param>
        /// <param name="dateOfBirth">The birth date in ISO Local Date format.</param>
        /// <param name="gender">gender.</param>
        /// <param name="passportNumber">The passport number of the passenger.</param>
        /// <param name="passportCountryIssuance">The country of issuance of the passenger&#39;s passport.</param>
        /// <param name="passportIssuanceDate">The date of issuance of the passenger&#39;s passport.</param>
        /// <param name="passportExpirationDate">The passport expiration date of the passenger.</param>
        /// <param name="nationality">The nationality of the passenger (country code).</param>
        public DgPassenger(string passengerReference = default(string), DgPassengerType passengerType = default(DgPassengerType), string firstName = default(string), string lastName = default(string), DateOnly dateOfBirth = default(DateOnly), Gender? gender = default(Gender?), string passportNumber = default(string), string passportCountryIssuance = default(string), DateOnly passportIssuanceDate = default(DateOnly), DateOnly passportExpirationDate = default(DateOnly), string nationality = default(string))
        {
            // to ensure "passengerReference" is required (not null)
            if (passengerReference == null)
            {
                throw new ArgumentNullException("passengerReference is a required property for DgPassenger and cannot be null");
            }
            this.PassengerReference = passengerReference;
            this.PassengerType = passengerType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.PassportNumber = passportNumber;
            this.PassportCountryIssuance = passportCountryIssuance;
            this.PassportIssuanceDate = passportIssuanceDate;
            this.PassportExpirationDate = passportExpirationDate;
            this.Nationality = nationality;
        }

        /// <summary>
        /// Unique reference of the passenger
        /// </summary>
        /// <value>Unique reference of the passenger</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "passenger_reference", IsRequired = true, EmitDefaultValue = true)]
        public string PassengerReference { get; set; }

        /// <summary>
        /// Ancillaries attached to the itinerary and their prices
        /// </summary>
        /// <value>Ancillaries attached to the itinerary and their prices</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Ancillaries attached to the itinerary and their prices
        /// </summary>
        /// <value>Ancillaries attached to the itinerary and their prices</value>
        /*
        <example>Smith</example>
        */
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The birth date in ISO Local Date format
        /// </summary>
        /// <value>The birth date in ISO Local Date format</value>
        /*
        <example>Sun Apr 02 00:00:00 UTC 2000</example>
        */
        [DataMember(Name = "date_of_birth", EmitDefaultValue = false)]
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// The passport number of the passenger
        /// </summary>
        /// <value>The passport number of the passenger</value>
        /*
        <example>J12393496</example>
        */
        [DataMember(Name = "passport_number", EmitDefaultValue = false)]
        public string PassportNumber { get; set; }

        /// <summary>
        /// The country of issuance of the passenger&#39;s passport
        /// </summary>
        /// <value>The country of issuance of the passenger&#39;s passport</value>
        [DataMember(Name = "passport_country_issuance", EmitDefaultValue = false)]
        public string PassportCountryIssuance { get; set; }

        /// <summary>
        /// The date of issuance of the passenger&#39;s passport
        /// </summary>
        /// <value>The date of issuance of the passenger&#39;s passport</value>
        /*
        <example>Mon Apr 02 00:00:00 UTC 2018</example>
        */
        [DataMember(Name = "passport_issuance_date", EmitDefaultValue = false)]
        public DateOnly PassportIssuanceDate { get; set; }

        /// <summary>
        /// The passport expiration date of the passenger
        /// </summary>
        /// <value>The passport expiration date of the passenger</value>
        /*
        <example>Tue Apr 02 00:00:00 UTC 2030</example>
        */
        [DataMember(Name = "passport_expiration_date", EmitDefaultValue = false)]
        public DateOnly PassportExpirationDate { get; set; }

        /// <summary>
        /// The nationality of the passenger (country code)
        /// </summary>
        /// <value>The nationality of the passenger (country code)</value>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DgPassenger {\n");
            sb.Append("  PassengerReference: ").Append(PassengerReference).Append("\n");
            sb.Append("  PassengerType: ").Append(PassengerType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  PassportNumber: ").Append(PassportNumber).Append("\n");
            sb.Append("  PassportCountryIssuance: ").Append(PassportCountryIssuance).Append("\n");
            sb.Append("  PassportIssuanceDate: ").Append(PassportIssuanceDate).Append("\n");
            sb.Append("  PassportExpirationDate: ").Append(PassportExpirationDate).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
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
