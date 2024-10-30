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
    /// The end-user&#39;s device
    /// </summary>
    [JsonConverter(typeof(DeviceJsonConverter))]
    [DataContract(Name = "device")]
    public partial class Device : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class
        /// with the <see cref="Desktop" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Desktop.</param>
        public Device(Desktop actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class
        /// with the <see cref="Mobile" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Mobile.</param>
        public Device(Mobile actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class
        /// with the <see cref="Tablet" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Tablet.</param>
        public Device(Tablet actualInstance)
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
                if (value.GetType() == typeof(Desktop) || value is Desktop)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Mobile) || value is Mobile)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Tablet) || value is Tablet)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Desktop, Mobile, Tablet");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Desktop`. If the actual instance is not `Desktop`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Desktop</returns>
        public Desktop GetDesktop()
        {
            return (Desktop)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Mobile`. If the actual instance is not `Mobile`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Mobile</returns>
        public Mobile GetMobile()
        {
            return (Mobile)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Tablet`. If the actual instance is not `Tablet`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Tablet</returns>
        public Tablet GetTablet()
        {
            return (Tablet)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Device {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Device.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Device
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Device</returns>
        public static Device FromJson(string jsonString)
        {
            Device newDevice = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDevice;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Desktop).GetProperty("AdditionalProperties") == null)
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Desktop>(jsonString, Device.SerializerSettings));
                }
                else
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Desktop>(jsonString, Device.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Desktop");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Desktop: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Mobile).GetProperty("AdditionalProperties") == null)
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Mobile>(jsonString, Device.SerializerSettings));
                }
                else
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Mobile>(jsonString, Device.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Mobile");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Mobile: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Tablet).GetProperty("AdditionalProperties") == null)
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Tablet>(jsonString, Device.SerializerSettings));
                }
                else
                {
                    newDevice = new Device(JsonConvert.DeserializeObject<Tablet>(jsonString, Device.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Tablet");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Tablet: {1}", jsonString, exception.ToString()));
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
            return newDevice;
        }

    }

    /// <summary>
    /// Custom JSON converter for Device
    /// </summary>
    public class DeviceJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Device).GetMethod("ToJson").Invoke(value, null)));
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
                    return Device.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Device.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
