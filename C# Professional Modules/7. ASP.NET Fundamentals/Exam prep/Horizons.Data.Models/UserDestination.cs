using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Horizons.Data.Models
{
    public class UserDestination
    {
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; } = null!;

        [Required]
        public int DestinationId { get; set; }

        [ForeignKey(nameof(DestinationId))]
        public virtual Destination Destination { get; set; } = null!;
    }
}
