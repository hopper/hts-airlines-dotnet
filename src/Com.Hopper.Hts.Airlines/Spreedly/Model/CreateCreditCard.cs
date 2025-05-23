// <auto-generated>
/*
 * Spreedly API
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
using Com.Hopper.Hts.Airlines.Spreedly.Client;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{
    /// <summary>
    /// CreateCreditCard
    /// </summary>
    public partial class CreateCreditCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCard" /> class.
        /// </summary>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="number">number</param>
        /// <param name="verificationValue">verificationValue</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        [JsonConstructor]
        public CreateCreditCard(string firstName, string lastName, string number, string verificationValue, string month, string year)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            VerificationValue = verificationValue;
            Month = month;
            Year = year;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets VerificationValue
        /// </summary>
        [JsonPropertyName("verification_value")]
        public string VerificationValue { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [JsonPropertyName("month")]
        public string Month { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [JsonPropertyName("year")]
        public string Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCreditCard {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  VerificationValue: ").Append(VerificationValue).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CreateCreditCard" />
    /// </summary>
    public class CreateCreditCardJsonConverter : JsonConverter<CreateCreditCard>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateCreditCard" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateCreditCard Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> firstName = default;
            Option<string?> lastName = default;
            Option<string?> number = default;
            Option<string?> verificationValue = default;
            Option<string?> month = default;
            Option<string?> year = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "first_name":
                            firstName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "last_name":
                            lastName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "number":
                            number = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "verification_value":
                            verificationValue = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "month":
                            month = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "year":
                            year = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!firstName.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(firstName));

            if (!lastName.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(lastName));

            if (!number.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(number));

            if (!verificationValue.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(verificationValue));

            if (!month.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(month));

            if (!year.IsSet)
                throw new ArgumentException("Property is required for class CreateCreditCard.", nameof(year));

            if (firstName.IsSet && firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName), "Property is not nullable for class CreateCreditCard.");

            if (lastName.IsSet && lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName), "Property is not nullable for class CreateCreditCard.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class CreateCreditCard.");

            if (verificationValue.IsSet && verificationValue.Value == null)
                throw new ArgumentNullException(nameof(verificationValue), "Property is not nullable for class CreateCreditCard.");

            if (month.IsSet && month.Value == null)
                throw new ArgumentNullException(nameof(month), "Property is not nullable for class CreateCreditCard.");

            if (year.IsSet && year.Value == null)
                throw new ArgumentNullException(nameof(year), "Property is not nullable for class CreateCreditCard.");

            return new CreateCreditCard(firstName.Value!, lastName.Value!, number.Value!, verificationValue.Value!, month.Value!, year.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CreateCreditCard" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCreditCard"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateCreditCard createCreditCard, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createCreditCard, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateCreditCard" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCreditCard"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateCreditCard createCreditCard, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createCreditCard.FirstName == null)
                throw new ArgumentNullException(nameof(createCreditCard.FirstName), "Property is required for class CreateCreditCard.");

            if (createCreditCard.LastName == null)
                throw new ArgumentNullException(nameof(createCreditCard.LastName), "Property is required for class CreateCreditCard.");

            if (createCreditCard.Number == null)
                throw new ArgumentNullException(nameof(createCreditCard.Number), "Property is required for class CreateCreditCard.");

            if (createCreditCard.VerificationValue == null)
                throw new ArgumentNullException(nameof(createCreditCard.VerificationValue), "Property is required for class CreateCreditCard.");

            if (createCreditCard.Month == null)
                throw new ArgumentNullException(nameof(createCreditCard.Month), "Property is required for class CreateCreditCard.");

            if (createCreditCard.Year == null)
                throw new ArgumentNullException(nameof(createCreditCard.Year), "Property is required for class CreateCreditCard.");

            writer.WriteString("first_name", createCreditCard.FirstName);

            writer.WriteString("last_name", createCreditCard.LastName);

            writer.WriteString("number", createCreditCard.Number);

            writer.WriteString("verification_value", createCreditCard.VerificationValue);

            writer.WriteString("month", createCreditCard.Month);

            writer.WriteString("year", createCreditCard.Year);
        }
    }
}
