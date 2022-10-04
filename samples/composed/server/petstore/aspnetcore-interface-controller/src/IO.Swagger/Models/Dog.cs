/*
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Dog : Pet, IEquatable<Dog>
    { 
        /// <summary>
        /// Gets or Sets Bark
        /// </summary>

        [DataMember(Name="bark")]
        public bool? Bark { get; set; }

        /// <summary>
        /// Gets or Sets Breed
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum BreedEnum
        {
            /// <summary>
            /// Enum DingoEnum for Dingo
            /// </summary>
            [EnumMember(Value = "Dingo")]
            DingoEnum = 0,
            /// <summary>
            /// Enum HuskyEnum for Husky
            /// </summary>
            [EnumMember(Value = "Husky")]
            HuskyEnum = 1,
            /// <summary>
            /// Enum RetrieverEnum for Retriever
            /// </summary>
            [EnumMember(Value = "Retriever")]
            RetrieverEnum = 2,
            /// <summary>
            /// Enum ShepherdEnum for Shepherd
            /// </summary>
            [EnumMember(Value = "Shepherd")]
            ShepherdEnum = 3        }

        /// <summary>
        /// Gets or Sets Breed
        /// </summary>

        [DataMember(Name="breed")]
        public BreedEnum? Breed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dog {\n");
            sb.Append("  Bark: ").Append(Bark).Append("\n");
            sb.Append("  Breed: ").Append(Breed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Dog)obj);
        }

        /// <summary>
        /// Returns true if Dog instances are equal
        /// </summary>
        /// <param name="other">Instance of Dog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Bark == other.Bark ||
                    Bark != null &&
                    Bark.Equals(other.Bark)
                ) && 
                (
                    Breed == other.Breed ||
                    Breed != null &&
                    Breed.Equals(other.Breed)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Bark != null)
                    hashCode = hashCode * 59 + Bark.GetHashCode();
                    if (Breed != null)
                    hashCode = hashCode * 59 + Breed.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Dog left, Dog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Dog left, Dog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
