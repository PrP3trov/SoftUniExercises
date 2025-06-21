using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Horizons.GCommon.ValidationConstatnts.Destination;

namespace Horizons.Data.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        [Required]
        public string PublisherId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(PublisherId))]
        public virtual IdentityUser Publisher { get; set; } = null!;

        [Required]
        public DateTime PublishedOn { get; set; }

        [Required]
        public int TerrainId { get; set; }

        [Required]
        [ForeignKey(nameof(TerrainId))]
        public virtual Terrain Terrain { get; set; } = null!;

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserDestination> UsersDestinations { get; set; } = new HashSet<UserDestination>();

    }
}
