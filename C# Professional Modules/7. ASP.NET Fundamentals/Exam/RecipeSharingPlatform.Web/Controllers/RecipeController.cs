using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipeSharingPlatform.Data;
using RecipeSharingPlatform.Services.Core.Contracts;
using RecipeSharingPlatform.ViewModels.Recipe;
using System.Threading.Tasks;
using static RecipeSharingPlatform.GCommon.ValidationConstants.Recipe;

namespace RecipeSharingPlatform.Web.Controllers
{
    public class RecipeController : BaseController
    {
        private readonly IRecipeService recipeService;
        private readonly ICategoryService categoryService;

        public RecipeController(IRecipeService recipeService, ICategoryService categoryService)
        {
            this.recipeService = recipeService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            try
            {
                string? userId = GetUserId();
                var allRecipes = await recipeService.GetAllRecipesAsync(userId);

                return View(allRecipes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index), "Home");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                string? userId = GetUserId();
                RecipeDetailsViewModel? recipeDetails = await recipeService.GetRecipeDetailsAsync(id, userId);

                if (recipeDetails == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View(recipeDetails);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index), "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                AddRecipeInputModel inputModel = new AddRecipeInputModel()
                {
                    CreatedOn = DateTime.UtcNow.ToString(CreatedOnFormat),
                    Categories = await categoryService.GetCategoryDropDownDataAsync(),
                };

                return View(inputModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddRecipeInputModel inputModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(inputModel);
                }

                bool addResult = await recipeService.AddRecipeAsync(GetUserId()!, inputModel);

                if (addResult == false)
                {
                    ModelState.AddModelError(string.Empty, "Fatal error occured while adding a recipe!");
                    return View(inputModel);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                string userId = GetUserId()!;

                EditRecipeInputModel? editInputModel = await recipeService.GetRecipeForEditingAsync(userId, id);

                if (editInputModel == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                editInputModel.Categories = await categoryService.GetCategoryDropDownDataAsync();

                return View(editInputModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditRecipeInputModel inputModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(inputModel);
                }

                bool editResult = await recipeService.PersistUpdatedRecipeAsync(GetUserId()!, inputModel);

                if (editResult == false)
                {
                    ModelState.AddModelError(string.Empty, "Fatal error occured while updating the recipe!");
                    return View(inputModel);
                }

                return RedirectToAction(nameof(Details), new { id = inputModel.Id});
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                string userId = GetUserId()!;

                DeleteRecipeInputModel? deleteInputModel = await recipeService.GetDestinationForDeletingAsync(userId, id);

                if (deleteInputModel == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View(deleteInputModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(DeleteRecipeInputModel inputModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError(string.Empty, "Do not modify the page!");
                    return View(inputModel);
                }

                bool deleteResult = await recipeService.SoftDeleteRecipeAsync(GetUserId()!, inputModel);

                if (deleteResult == false)
                {
                    ModelState.AddModelError(string.Empty, "Fatal error occured while deleting the recipe!");
                    return View(inputModel);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            try
            {
                string userId = GetUserId()!;

                IEnumerable<FavoriteRecipeViewModel>?  favoriteRecipes = await recipeService.GetUserFavoriteRecipeAsync(userId);
                if(favoriteRecipes == null)
                {
                    return RedirectToAction(nameof(Index));

                }

               return View(favoriteRecipes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(int? id)
        {
            try
            {
                if(id == null)
                {
                    return RedirectToAction(nameof(Index));

                }
                string userId = GetUserId()!;
                bool favAddResult =  await recipeService.AddRecipeToFavoritesAsync(userId, id.Value);

                if(favAddResult == false)
                {
                    return RedirectToAction(nameof(Index));

                }

                return RedirectToAction(nameof(Favorites));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
