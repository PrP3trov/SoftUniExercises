using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RecipeSharingPlatform.GCommon.ValidationConstants.Recipe;

namespace RecipeSharingPlatform.ViewModels.Recipe
{
    public class AddRecipeInputModel
    {
        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(InstructionsMinLength)]
        [MaxLength(InstructionsMaxLength)]
        public string Instructions { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        [MinLength(CreatedOnLength)]
        [MaxLength(CreatedOnLength)]
        public string CreatedOn { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<AddRecipeCategoryDropDownMenu>? Categories { get; set; }
    }
}
