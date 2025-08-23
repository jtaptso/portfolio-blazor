using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
    }
}
