using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Horizons.GCommon.ValidationConstatnts.Destination;

namespace Horizons.Web.ViewModels.Destination
{
    public class AddDestinationViewModel
    {
        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public int TerrainId { get; set; }

        public IEnumerable<AddDestinationTerrainDropDownModel>? Terrains { get; set; }

        [Required]
        public string PublishedOn { get; set; } = null!;
    }
}
