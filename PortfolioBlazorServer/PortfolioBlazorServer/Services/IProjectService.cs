using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjectsAsync();
        Task<Project?> GetProjectBySlugAsync(string slug);
    }
}
