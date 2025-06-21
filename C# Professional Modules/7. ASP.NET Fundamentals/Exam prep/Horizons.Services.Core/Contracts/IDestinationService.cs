using Horizons.Web.ViewModels.Destination;

namespace Horizons.Services.Core.Contracts
{
    public interface IDestinationService
    {
        Task<IEnumerable<DestinationIndexViewModel>> GetAllDestiantionsAsync(string? userId);

        Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int? id, string? userId);

        Task<bool> AddDestinationAsync(string userId, AddDestinationViewModel inputModel);
    }
}
