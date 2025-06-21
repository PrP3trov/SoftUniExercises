using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeSharingPlatform.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.Data
{
    public class UserRecipeConfiguration : IEntityTypeConfiguration<UserRecipe>
    {

        public void Configure(EntityTypeBuilder<UserRecipe> builder)
        {
            builder.HasQueryFilter(ur => ur.Recipe.IsDeleted == false);
        }
    }
}
