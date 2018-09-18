using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Warehouse
    { 
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [Required]
        [DataMember(Name="duration")]
        public decimal? Duration { get; set; }

        /// <summary>
        /// Gets or Sets NextHops
        /// </summary>
        [DataMember(Name="nextHops")]
        public List<Warehouse> NextHops { get; set; }

        /// <summary>
        /// Gets or Sets Trucks
        /// </summary>
        [DataMember(Name="trucks")]
        public List<Truck> Trucks { get; set; }
    }
}
