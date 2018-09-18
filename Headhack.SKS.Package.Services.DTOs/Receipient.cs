using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Receipient
    { 
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [Required]
        [DataMember(Name="street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [Required]
        [DataMember(Name="postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [Required]
        [DataMember(Name="city")]
        public string City { get; set; }
    }
}
