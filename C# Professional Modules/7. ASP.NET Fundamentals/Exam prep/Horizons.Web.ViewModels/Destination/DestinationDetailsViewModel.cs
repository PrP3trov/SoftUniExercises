using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Horizons.Web.ViewModels.Destination
{
    public class DestinationDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Terrain { get; set; } = string.Empty;

        public string? Publisher { get; set; } = string.Empty;

        public string PublishedOn { get; set; } = string.Empty;

        public bool IsPublisher { get; set; }

        public bool IsFavorite { get; set; }
    }
}
