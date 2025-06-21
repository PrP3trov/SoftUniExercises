﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.ViewModels.Recipe
{
    public class RecipeDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Instructions { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public string Category { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public string? Author { get; set; } = null!;

        public bool IsAuthor { get; set; }

        public bool IsSaved { get; set; }
    }
}