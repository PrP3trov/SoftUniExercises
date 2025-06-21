using RecipeSharingPlatform.ViewModels.Recipe;

namespace RecipeSharingPlatform.Services.Core.Contracts
{
    public interface IRecipeService
    {       
        Task<IEnumerable<RecipeIndexViewModel>> GetAllRecipesAsync(string? userId);

        Task<RecipeDetailsViewModel?> GetRecipeDetailsAsync(int? id, string? userId);

        Task<bool> AddRecipeAsync(string userId, AddRecipeInputModel inputModel);

        Task<EditRecipeInputModel?> GetRecipeForEditingAsync(string userId, int? recipeId);

        Task<bool> PersistUpdatedRecipeAsync(string userId, EditRecipeInputModel inputModel);

        Task<DeleteRecipeInputModel?> GetDestinationForDeletingAsync(string userId, int? recipeId);
        Task<bool> SoftDeleteRecipeAsync(string userId, DeleteRecipeInputModel inputModel);

        Task<IEnumerable<FavoriteRecipeViewModel>?> GetUserFavoriteRecipeAsync(string userId);

        Task<bool> AddRecipeToFavoritesAsync(string userId, int recipeId);
    }
}
