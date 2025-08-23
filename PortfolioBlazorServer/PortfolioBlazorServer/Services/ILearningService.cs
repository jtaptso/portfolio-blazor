using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services
{
    public interface ILearningService
    {
        Task<List<Learning>> GetLearningsAsync();
        Task<Learning?> GetLearningBySlugAsync(string slug);
    }
}
