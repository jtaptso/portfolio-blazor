using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly List<Category> _categories;

        public CategoryService()
        {
            _categories = SampleData.Categories;
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            return Task.FromResult(_categories);
        }
    }
}
