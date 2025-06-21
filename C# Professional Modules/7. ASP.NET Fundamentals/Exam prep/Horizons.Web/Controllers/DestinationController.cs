using Horizons.Services.Core;
using Horizons.Services.Core.Contracts;
using Horizons.Web.ViewModels.Destination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using static Horizons.GCommon.ValidationConstatnts.Destination;

namespace Horizons.Web.Controllers
{
    public class DestinationController : BaseController
    {
        private readonly IDestinationService destinationService;
        private readonly ITerrainService terrainService;

        public DestinationController(IDestinationService destinationService, ITerrainService terrainService)
        {
            this.destinationService = destinationService;
            this.terrainService = terrainService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            try
            {
                string? userId = GetUserId();
                var allDestinations = await destinationService.GetAllDestiantionsAsync(userId);

                return View(allDestinations);
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
                DestinationDetailsViewModel? destinationDetails = await destinationService.GetDestinationDetailsAsync(id, userId);

                if(destinationDetails != null)
                {
                    RedirectToAction(nameof(Index));
                }

                return View(destinationDetails);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index), "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                AddDestinationViewModel inputModel = new AddDestinationViewModel()
                {
                    PublishedOn = DateTime.UtcNow.ToString(PublishedOnFormat),
                    Terrains = await terrainService.GetTerrainsDropDownAsync(),
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
        public async Task<IActionResult> Add(AddDestinationViewModel inputModel)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Add));
                }

                bool addResult = await destinationService.AddDestinationAsync(GetUserId()!, inputModel);

                if(addResult == false)
                {
                    return RedirectToAction(nameof(Add));
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
