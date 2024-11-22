
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


namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{

    public partial class PaymentMethod
    {
        public PaymentMethod(CreditCard creditCard = default(CreditCard))
        {
            
            // to ensure "creditCard" is required (not null)
            if (creditCard == null)
            {
                throw new ArgumentNullException("creditCard is a required property for CreditCard and cannot be null");
            }
            this.CreditCard = creditCard;
        }


        [DataMember(Name = "credit_card", EmitDefaultValue = false)]
        public CreditCard? CreditCard { get; set; }

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

