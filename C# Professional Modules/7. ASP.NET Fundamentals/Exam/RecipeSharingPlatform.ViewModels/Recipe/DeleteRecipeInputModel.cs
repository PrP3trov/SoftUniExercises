using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.ViewModels.Recipe
{
    public class DeleteRecipeInputModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Author { get; set; }

        [Required]
        public string AuthorId { get; set; } = null!;
    }
}
