using RecipeSharingPlatform.ViewModels.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSharingPlatform.Services.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<AddRecipeCategoryDropDownMenu>> GetCategoryDropDownDataAsync();
    }
}
