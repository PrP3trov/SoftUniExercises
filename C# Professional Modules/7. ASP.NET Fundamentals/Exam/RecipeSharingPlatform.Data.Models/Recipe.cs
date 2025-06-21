using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RecipeSharingPlatform.GCommon.ValidationConstants.Recipe;

namespace RecipeSharingPlatform.Data.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(InstructionsMaxLength)]
        public string Instructions { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public string AuthorId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(AuthorId))]
        public virtual IdentityUser Author { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserRecipe> UsersRecipes { get; set; } = new HashSet<UserRecipe>();
    }
}

//•	Has Id – a unique integer, Primary Key
//•	Has Title – a string with min length 3 and max length 80 (required)
//•	Has Instructions – string with min length 10 and max length 250 (required)
//•	Has ImageUrl – nullable string (not required)
//•	Has AuthorId – string (required)
//•	Has Author – IdentityUser (required)
//•	Has CreatedOn – DateTime with format "dd-MM-yyyy" (required)
//o	The DateTime format is only recommended
//•	Has CategoryId – integer, foreign key (required)
//•	Has Category – Category (required)
//•	Has IsDeleted – bool (default value == false)
//•	Has UsersRecipes – a collection of type UserRecipe
