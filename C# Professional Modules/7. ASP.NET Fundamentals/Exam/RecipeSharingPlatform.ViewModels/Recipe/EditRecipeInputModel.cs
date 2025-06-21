using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.ViewModels.Recipe
{
    public class EditRecipeInputModel : AddRecipeInputModel
    {
        [Required]
        public int Id { get; set; }
    }
}
