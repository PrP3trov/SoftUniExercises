using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Horizons.Web.ViewModels.Destination
{
    public class DestinationIndexViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string TerrainName { get; set; } = string.Empty;

        public long FavoritesCount { get; set; }

        public bool IsPublisher { get; set; }

        public bool IsFavorite { get; set; }
    }
}
