using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Services.Core.Contracts;
using Horizons.Web.ViewModels.Destination;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static Horizons.GCommon.ValidationConstatnts.Destination;
namespace Horizons.Services.Core
{
    public class DestinationService : IDestinationService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public DestinationService(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager )
        {
           this.context = dbContext;
           this.userManager = userManager;
        }

        public async Task<IEnumerable<DestinationIndexViewModel>> GetAllDestiantionsAsync(string? userId)
        {

            var allDestinations = await context.Destinations
                .Select(d => new DestinationIndexViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ImageUrl = d.ImageUrl,
                    TerrainName = d.Terrain.Name,
                    FavoritesCount = d.UsersDestinations.Count,
                    IsPublisher = String.IsNullOrEmpty(userId) == false ? d.PublisherId.ToLower() == userId!.ToLower() : false,
                    IsFavorite = String.IsNullOrEmpty(userId) == false ? d.UsersDestinations.Any(ud => ud.UserId.ToLower() == userId!.ToLower()) : false,

                }).ToListAsync();

            return allDestinations;
        }

        public async Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int? id, string? userId)
        {
            DestinationDetailsViewModel? detailsVm = null;

            if(id.HasValue)
            {
                Destination? destination = await context.Destinations
                    .AsNoTracking()
                    .Include(d => d.Terrain)
                    .Include(d => d.Publisher)
                    .Include (d => d.UsersDestinations)
                    .SingleOrDefaultAsync(d => d.Id == id.Value);

                if (destination != null)
                {
                    detailsVm = new DestinationDetailsViewModel
                    {
                        Id = destination.Id,
                        Name = destination.Name,
                        ImageUrl = destination.ImageUrl,
                        Description = destination.Description,
                        Terrain = destination.Terrain.Name,
                        Publisher = destination.Publisher.UserName,
                        PublishedOn = destination.PublishedOn.ToString(PublishedOnFormat),
                        IsPublisher = userId != null ? destination.PublisherId.ToLower() == userId.ToLower() : false,
                        IsFavorite = userId != null ? destination.UsersDestinations.Any(ud => ud.UserId.ToLower() == userId.ToLower()) : false,
                    };
                }
            }

            return detailsVm;
        }

        public async Task<bool> AddDestinationAsync(string userId, AddDestinationViewModel inputModel)
        {
            bool opResult = false;
            var user =  await userManager.FindByIdAsync(userId);
            var terrainRef = await context.Terrains.FindAsync(inputModel.TerrainId);
            bool isPublishedDateValid = DateTime.TryParseExact(inputModel.PublishedOn, PublishedOnFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime publishedOnDate);

            if ((user != null) && (terrainRef != null) && (isPublishedDateValid))
            {
                var newDestination = new Destination()
                {
                    Name = inputModel.Name,
                    Description = inputModel.Description,
                    ImageUrl = inputModel.ImageUrl,
                    PublishedOn = publishedOnDate,
                    PublisherId = userId,
                    TerrainId = terrainRef.Id,
                };

                await context.Destinations.AddAsync(newDestination);
                await context.SaveChangesAsync();

                opResult = true;
            }

            return opResult;
        }
    }
}
