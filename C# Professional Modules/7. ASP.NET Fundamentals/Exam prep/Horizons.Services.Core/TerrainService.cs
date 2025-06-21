using Horizons.Data;
using Horizons.Services.Core.Contracts;
using Horizons.Web.ViewModels.Destination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizons.Services.Core
{
    public class TerrainService : ITerrainService
    {
        private readonly ApplicationDbContext context;

        public TerrainService(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public async Task<IEnumerable<AddDestinationTerrainDropDownModel>> GetTerrainsDropDownAsync()
        {
            var terrainsDropDown = await context.Terrains
                .AsNoTracking()
                .Select(t => new AddDestinationTerrainDropDownModel 
                {
                    Id = t.Id,
                    Name = t.Name
                }
                ) .ToListAsync();

            return terrainsDropDown;
        }
    }
}
