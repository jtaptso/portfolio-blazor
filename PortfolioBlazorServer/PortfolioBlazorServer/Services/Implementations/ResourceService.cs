using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services.Implementations
{
    public class ResourceService : IResourceService
    {
        private readonly List<Resource> _resources;

        public ResourceService()
        {
            _resources = SampleData.Resources;
        }

        public Task<List<Resource>> GetResourcesAsync()
        {
            return Task.FromResult(_resources);
        }
    }
}
