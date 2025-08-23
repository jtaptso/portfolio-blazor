using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services
{
    public interface IResourceService
    {
        Task<List<Resource>> GetResourcesAsync();
    }
}
