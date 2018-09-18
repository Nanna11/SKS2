using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NewParcelInfo
    { 
        /// <summary>
        /// The tracking ID of the parcel. 
        /// </summary>
        /// <value>The tracking ID of the parcel. </value>
        [DataMember(Name="trackingId")]
        public string TrackingId { get; set; }
    }
}
