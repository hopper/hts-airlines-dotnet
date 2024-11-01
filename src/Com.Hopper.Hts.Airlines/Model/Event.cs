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
using JsonSubTypes;
using OpenAPIDateConverter = Com.Hopper.Hts.Airlines.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Com.Hopper.Hts.Airlines.Model
{
    /// <summary>
    /// Event
    /// </summary>
    [JsonConverter(typeof(EventJsonConverter))]
    [DataContract(Name = "varEvent")]
    public partial class Event : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class
        /// with the <see cref="BookingConfirmed" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BookingConfirmed.</param>
        public Event(BookingConfirmed actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class
        /// with the <see cref="OffersDisplayed" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OffersDisplayed.</param>
        public Event(OffersDisplayed actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(BookingConfirmed) || value is BookingConfirmed)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OffersDisplayed) || value is OffersDisplayed)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BookingConfirmed, OffersDisplayed");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `BookingConfirmed`. If the actual instance is not `BookingConfirmed`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BookingConfirmed</returns>
        public BookingConfirmed GetBookingConfirmed()
        {
            return (BookingConfirmed)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OffersDisplayed`. If the actual instance is not `OffersDisplayed`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OffersDisplayed</returns>
        public OffersDisplayed GetOffersDisplayed()
        {
            return (OffersDisplayed)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, Event.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Event
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Event</returns>
        public static Event FromJson(string jsonString)
        {
            Event newEvent = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newEvent;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BookingConfirmed).GetProperty("AdditionalProperties") == null)
                {
                    newEvent = new Event(JsonConvert.DeserializeObject<BookingConfirmed>(jsonString, Event.SerializerSettings));
                }
                else
                {
                    newEvent = new Event(JsonConvert.DeserializeObject<BookingConfirmed>(jsonString, Event.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("BookingConfirmed");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BookingConfirmed: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OffersDisplayed).GetProperty("AdditionalProperties") == null)
                {
                    newEvent = new Event(JsonConvert.DeserializeObject<OffersDisplayed>(jsonString, Event.SerializerSettings));
                }
                else
                {
                    newEvent = new Event(JsonConvert.DeserializeObject<OffersDisplayed>(jsonString, Event.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("OffersDisplayed");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OffersDisplayed: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newEvent;
        }

    }

    /// <summary>
    /// Custom JSON converter for Event
    /// </summary>
    public class EventJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Event).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return Event.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Event.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
