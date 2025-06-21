using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.ViewModels.Recipe
{
    public class FavoriteRecipeViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}
