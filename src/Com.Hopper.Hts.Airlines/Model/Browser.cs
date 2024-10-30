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
    /// Browser
    /// </summary>
    [JsonConverter(typeof(BrowserJsonConverter))]
    [DataContract(Name = "browser")]
    public partial class Browser : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="Chrome" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Chrome.</param>
        public Browser(Chrome actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="Edge" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Edge.</param>
        public Browser(Edge actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="Firefox" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Firefox.</param>
        public Browser(Firefox actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="InternetExplorer" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InternetExplorer.</param>
        public Browser(InternetExplorer actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="Opera" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Opera.</param>
        public Browser(Opera actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="OtherBrowser" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OtherBrowser.</param>
        public Browser(OtherBrowser actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class
        /// with the <see cref="Safari" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Safari.</param>
        public Browser(Safari actualInstance)
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
                if (value.GetType() == typeof(Chrome) || value is Chrome)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Edge) || value is Edge)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Firefox) || value is Firefox)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InternetExplorer) || value is InternetExplorer)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Opera) || value is Opera)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OtherBrowser) || value is OtherBrowser)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Safari) || value is Safari)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Chrome, Edge, Firefox, InternetExplorer, Opera, OtherBrowser, Safari");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Chrome`. If the actual instance is not `Chrome`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Chrome</returns>
        public Chrome GetChrome()
        {
            return (Chrome)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Edge`. If the actual instance is not `Edge`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Edge</returns>
        public Edge GetEdge()
        {
            return (Edge)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Firefox`. If the actual instance is not `Firefox`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Firefox</returns>
        public Firefox GetFirefox()
        {
            return (Firefox)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InternetExplorer`. If the actual instance is not `InternetExplorer`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InternetExplorer</returns>
        public InternetExplorer GetInternetExplorer()
        {
            return (InternetExplorer)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Opera`. If the actual instance is not `Opera`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Opera</returns>
        public Opera GetOpera()
        {
            return (Opera)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OtherBrowser`. If the actual instance is not `OtherBrowser`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OtherBrowser</returns>
        public OtherBrowser GetOtherBrowser()
        {
            return (OtherBrowser)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Safari`. If the actual instance is not `Safari`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Safari</returns>
        public Safari GetSafari()
        {
            return (Safari)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Browser {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Browser.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Browser
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Browser</returns>
        public static Browser FromJson(string jsonString)
        {
            Browser newBrowser = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBrowser;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Chrome).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Chrome>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Chrome>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Chrome");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Chrome: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Edge).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Edge>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Edge>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Edge");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Edge: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Firefox).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Firefox>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Firefox>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Firefox");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Firefox: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InternetExplorer).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<InternetExplorer>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<InternetExplorer>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InternetExplorer");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InternetExplorer: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Opera).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Opera>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Opera>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Opera");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Opera: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OtherBrowser).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<OtherBrowser>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<OtherBrowser>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("OtherBrowser");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OtherBrowser: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Safari).GetProperty("AdditionalProperties") == null)
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Safari>(jsonString, Browser.SerializerSettings));
                }
                else
                {
                    newBrowser = new Browser(JsonConvert.DeserializeObject<Safari>(jsonString, Browser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Safari");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Safari: {1}", jsonString, exception.ToString()));
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
            return newBrowser;
        }

    }

    /// <summary>
    /// Custom JSON converter for Browser
    /// </summary>
    public class BrowserJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Browser).GetMethod("ToJson").Invoke(value, null)));
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
                    return Browser.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Browser.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
