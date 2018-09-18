using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Truck
    { 
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets NumberPlate
        /// </summary>
        [Required]
        [DataMember(Name="numberPlate")]
        public string NumberPlate { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [Required]
        [DataMember(Name="latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [Required]
        [DataMember(Name="longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Radius
        /// </summary>
        [Required]
        [DataMember(Name="radius")]
        public decimal? Radius { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [Required]
        [DataMember(Name="duration")]
        public decimal? Duration { get; set; }
    }
}
