using System;
using System.Runtime.Serialization;
using System.Text;

namespace Com.Hopper.Hts.Airlines.Spreedly.Model
{
    /// <summary>
    /// CreditCard
    /// </summary>
    [DataContract(Name = "credit_card")]
    public partial class CreditCard
    {
        public CreditCard(
            string firstName = default(string),
            string lastName = default(string),
            string number = default(string),
            string verificationValue = default(string),
            string month = default(string),
            string year = default(string)
        )
        {

            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for CreditCard and cannot be null");
            }

            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for CreditCard and cannot be null");
            }

            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for CreditCard and cannot be null");
            }

            // to ensure "verificationValue" is required (not null)
            if (verificationValue == null)
            {
                throw new ArgumentNullException("verificationValue is a required property for CreditCard and cannot be null");
            }

            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new ArgumentNullException("month is a required property for CreditCard and cannot be null");
            }

            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new ArgumentNullException("year is a required property for CreditCard and cannot be null");
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.VerificationValue = verificationValue;
            this.Month = month;
            this.Year = year;
        }


        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        [DataMember(Name = "verification_value", EmitDefaultValue = false)]
        public string VerificationValue { get; set; }

        [DataMember(Name = "month", EmitDefaultValue = false)]
        public string Month { get; set; }

        [DataMember(Name = "year", EmitDefaultValue = false)]
        public string Year { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditCard {\n");
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
}