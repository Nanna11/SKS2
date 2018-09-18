using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class HopArrival
    { 
        /// <summary>
        /// The code of the warehouse or truck.
        /// </summary>
        /// <value>The code of the warehouse or truck.</value>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// The date/time the parcel arrived at the hop.
        /// </summary>
        /// <value>The date/time the parcel arrived at the hop.</value>
        [Required]
        [DataMember(Name="dateTime")]
        public DateTime? DateTime { get; set; }
    }
}
