using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Parcel
    { 
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [Required]
        [DataMember(Name="weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Receipient
        /// </summary>
        [Required]
        [DataMember(Name="receipient")]
        public Receipient Receipient { get; set; }
    }
}
