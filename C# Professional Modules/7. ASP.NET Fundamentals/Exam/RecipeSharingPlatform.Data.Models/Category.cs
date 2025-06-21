using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RecipeSharingPlatform.GCommon.ValidationConstants.Category;

namespace RecipeSharingPlatform.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}

//•	Has Id – a unique integer, Primary Key
//•	Has Name – a string with min length 3 and max length 20 (required)
//•	Has Recipes – a collection of type Recipe
