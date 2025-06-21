using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RecipeSharingPlatform.Data;
using RecipeSharingPlatform.Data.Models;
using RecipeSharingPlatform.Services.Core.Contracts;
using RecipeSharingPlatform.ViewModels.Recipe;
using System.Globalization;
using static RecipeSharingPlatform.GCommon.ValidationConstants.Recipe;

namespace RecipeSharingPlatform.Services.Core
{
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;
        public RecipeService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            dbContext = context;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<RecipeIndexViewModel>> GetAllRecipesAsync(string? userId)
        {
            var allRecipes = await dbContext.Recipes
                .AsNoTracking()
                .Include(r => r.Category)
                .Include(r => r.UsersRecipes)
                .Select(r => new RecipeIndexViewModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    ImageUrl = r.ImageUrl,
                    Category = r.Category.Name,
                    SavedCount = r.UsersRecipes.Count(),
                    IsAuthor = userId != null ? r.AuthorId.ToLower() == userId!.ToLower() : false,
                    IsSaved = userId != null ? r.UsersRecipes.Any(ur => ur.UserId.ToLower() == userId!.ToLower()) : false

                }).ToArrayAsync();

            return allRecipes;
        }

        public async Task<RecipeDetailsViewModel?> GetRecipeDetailsAsync(int? id, string? userId)
        {
            RecipeDetailsViewModel? detailsVm = null;

            if (id.HasValue)
            {
                Recipe? recipeModel = await dbContext.Recipes
                    .AsNoTracking()
                    .Include(r => r.Author)
                    .Include (r => r.Category)
                    .Include(r => r.UsersRecipes)
                    .SingleOrDefaultAsync(r => r.Id == id.Value);

                if (recipeModel != null)
                {
                    detailsVm = new RecipeDetailsViewModel
                    {
                        Id = recipeModel.Id,
                        Title = recipeModel.Title,
                        Instructions = recipeModel.Instructions,
                        ImageUrl = recipeModel.ImageUrl,
                        Category = recipeModel.Category.Name,
                        CreatedOn = recipeModel.CreatedOn.ToString(CreatedOnFormat),
                        Author = recipeModel.Author.UserName,
                        IsAuthor = userId != null ? recipeModel.AuthorId.ToLower() == userId!.ToLower() : false,
                        IsSaved =  userId != null ? recipeModel.UsersRecipes.Any(ur => ur.UserId.ToLower() == userId.ToLower()) : false,
                    };
                }
            }

            return detailsVm;
        }

        public async Task<bool> AddRecipeAsync(string userId, AddRecipeInputModel inputModel)
        {
            bool opResult = false;
            IdentityUser? user = await userManager.FindByIdAsync(userId);
            var categoryRef = await dbContext.Categories.FindAsync(inputModel.CategoryId);
            bool isCreatedDateValid = DateTime.TryParseExact(inputModel.CreatedOn, CreatedOnFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime createdOnDate);

            if ((user != null) && (categoryRef != null) && (isCreatedDateValid))
            {
                var newRecipe = new Recipe()
                {
                    Title = inputModel.Title,
                    Instructions = inputModel.Instructions,
                    ImageUrl = inputModel.ImageUrl,
                    CreatedOn = createdOnDate,
                    AuthorId = userId,
                    CategoryId = categoryRef.Id,
                };

                await dbContext.Recipes.AddAsync(newRecipe);
                await dbContext.SaveChangesAsync();

                opResult = true;
            }

            return opResult;
        }

        public async Task<EditRecipeInputModel?> GetRecipeForEditingAsync(string userId, int? recipeId)
        {
            EditRecipeInputModel? editModel = null;
            if(recipeId != null)
            {
                Recipe? editRecipeModel = await dbContext.Recipes
                    .AsNoTracking()
                    .SingleOrDefaultAsync(r => r.Id == recipeId);

                if((editRecipeModel != null) && (editRecipeModel.AuthorId.ToLower() == userId.ToLower()))
                {
                    editModel = new EditRecipeInputModel()
                    {
                        Id = editRecipeModel.Id,
                        Title = editRecipeModel.Title,
                        Instructions= editRecipeModel.Instructions,
                        ImageUrl = editRecipeModel.ImageUrl,
                        CreatedOn = editRecipeModel.CreatedOn.ToString(CreatedOnFormat),
                    };
                }
            }

            return editModel;
        }

        public async Task<bool> PersistUpdatedRecipeAsync(string userId, EditRecipeInputModel inputModel)
        {
            bool opResult = false;
            Recipe? updatedRecipe = await dbContext.Recipes.FindAsync(inputModel.Id);
            IdentityUser? user = await userManager.FindByIdAsync(userId);
            var categoryRef = await dbContext.Categories.FindAsync(inputModel.CategoryId);
            bool isCreatedDateValid = DateTime.TryParseExact(inputModel.CreatedOn, CreatedOnFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime createdOnDate);

            if ((user != null) && (categoryRef != null) && (isCreatedDateValid) && 
                (updatedRecipe != null) && (updatedRecipe.AuthorId.ToLower() == userId.ToLower()))
            {
                updatedRecipe.Title = inputModel.Title;
                updatedRecipe.Instructions = inputModel.Instructions;
                updatedRecipe.CreatedOn = createdOnDate;
                updatedRecipe.ImageUrl = inputModel.ImageUrl;
                updatedRecipe.CategoryId = inputModel.CategoryId; 

                await dbContext.SaveChangesAsync();

                opResult = true;
            }

            return opResult;
        }

        public async Task<DeleteRecipeInputModel?> GetDestinationForDeletingAsync(string userId, int? recipeId)
        {
            DeleteRecipeInputModel? deleteModel = null;
            if (recipeId != null)
            {
                Recipe? deleteRecipeModel = await dbContext.Recipes
                    .AsNoTracking()
                    .Include(r => r.Author)
                    .SingleOrDefaultAsync(r => r.Id == recipeId);

                if ((deleteRecipeModel != null) && (deleteRecipeModel.AuthorId.ToLower() == userId.ToLower()))
                {
                    deleteModel = new DeleteRecipeInputModel()
                    {
                        Id = deleteRecipeModel.Id,
                        Title = deleteRecipeModel.Title,
                        Author = deleteRecipeModel.Author.UserName,
                        AuthorId = deleteRecipeModel.AuthorId
                    };
                }
            }

            return deleteModel;
        }

        public async Task<bool> SoftDeleteRecipeAsync(string userId, DeleteRecipeInputModel inputModel)
        {
            bool opResult = false;
            Recipe? deletedRecipe = await dbContext.Recipes.FindAsync(inputModel.Id);
            IdentityUser? user = await userManager.FindByIdAsync(userId);


            if ((user != null) && (deletedRecipe != null) && (deletedRecipe.AuthorId.ToLower() == userId.ToLower()))
            {
                deletedRecipe.IsDeleted = true;
                await dbContext.SaveChangesAsync();

                opResult = true;
            }

            return opResult;
        }

        public async Task<IEnumerable<FavoriteRecipeViewModel>?> GetUserFavoriteRecipeAsync(string userId)
        {
            IEnumerable<FavoriteRecipeViewModel> favoriteRecipe = null;
            IdentityUser? user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                favoriteRecipe = await dbContext.UsersRecipes
                    .Include(ur => ur.Recipe)
                    .ThenInclude(r => r.Category)
                    .Where(ur => ur.UserId.ToLower() == userId.ToLower())
                    .Select(ur => new FavoriteRecipeViewModel
                    {
                        Id = ur.RecipeId,
                        Title = ur.Recipe.Title,
                        ImageUrl = ur.Recipe.ImageUrl,
                        Category = ur.Recipe.Category.Name
                    }).ToArrayAsync();
            }

            return favoriteRecipe;
        }

        public async Task<bool> AddRecipeToFavoritesAsync(string userId, int recipeId)
        {
            bool opResult = false;
            Recipe? favRecipe = await dbContext.Recipes.FindAsync(recipeId);
            IdentityUser? user = await userManager.FindByIdAsync(userId);

            if ((user != null) && (favRecipe != null) && (favRecipe.AuthorId.ToLower() != userId.ToLower()))
            {
                UserRecipe? userFavRecipe = await dbContext.UsersRecipes
                    .SingleOrDefaultAsync(ur => ur.UserId.ToLower() == userId && ur.RecipeId == recipeId);

                if (userFavRecipe == null)
                {
                    userFavRecipe = new UserRecipe
                    {
                        UserId = userId,
                        RecipeId = recipeId
                    };

                    await dbContext.UsersRecipes.AddAsync(userFavRecipe);
                    await dbContext.SaveChangesAsync();

                    opResult = true;

                }

            }

            return opResult;
        }
    }
}
