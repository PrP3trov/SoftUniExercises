using Microsoft.EntityFrameworkCore;
using RecipeSharingPlatform.Data;
using RecipeSharingPlatform.Services.Core.Contracts;
using RecipeSharingPlatform.ViewModels.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.Services.Core
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryService(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public async Task<IEnumerable<AddRecipeCategoryDropDownMenu>> GetCategoryDropDownDataAsync()
        {
            IEnumerable<AddRecipeCategoryDropDownMenu> categoryAsDropDown = await dbContext.Categories
                .AsNoTracking()
                .Select(c => new AddRecipeCategoryDropDownMenu
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToArrayAsync();

            return categoryAsDropDown;
        }
    }
}
