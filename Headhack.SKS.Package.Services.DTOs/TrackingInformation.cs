using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class TrackingInformation
    {         /// <summary>
        /// State of the parcel.
        /// </summary>
        /// <value>State of the parcel.</value>
        public enum StateEnum
        { 
            /// <summary>
            /// Enum InTransportEnum for InTransport
            /// </summary>
            [EnumMember(Value = "InTransport")]
            InTransportEnum = 1,
            
            /// <summary>
            /// Enum InTruckDeliveryEnum for InTruckDelivery
            /// </summary>
            [EnumMember(Value = "InTruckDelivery")]
            InTruckDeliveryEnum = 2,
            
            /// <summary>
            /// Enum DeliveredEnum for Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            DeliveredEnum = 3
        }

        /// <summary>
        /// State of the parcel.
        /// </summary>
        /// <value>State of the parcel.</value>
        [Required]
        [DataMember(Name="state")]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Hops visited in the past - either warehouse or truck.
        /// </summary>
        /// <value>Hops visited in the past - either warehouse or truck.</value>
        [Required]
        [DataMember(Name="visitedHops")]
        public List<HopArrival> VisitedHops { get; set; }

        /// <summary>
        /// Hops coming up in the future - their times are estimations.
        /// </summary>
        /// <value>Hops coming up in the future - their times are estimations.</value>
        [Required]
        [DataMember(Name="futureHops")]
        public List<HopArrival> FutureHops { get; set; }
    }
}
