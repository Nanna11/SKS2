using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Headhack.SKS.Package.Services.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Error
    { 
        /// <summary>
        /// The error message.
        /// </summary>
        /// <value>The error message.</value>
        [Required]
        [DataMember(Name="errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
