using PortfolioBlazorServer.Services;
using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services.Implementations
{
    public class LearningService : ILearningService
    {
        //private readonly HttpClient _http;

        //public LearningService(HttpClient http)
        //{
        //    _http = http;
        //}

        //public async Task<List<Learning>> GetLearningsAsync()
        //{
        //    var learnings = await _http.GetFromJsonAsync<List<Learning>>("Data/learnings.json");
        //    return learnings ?? new List<Learning>();
        //}

        //public async Task<Learning?> GetLearningBySlugAsync(string slug)
        //{
        //    var learnings = await GetLearningsAsync();
        //    return learnings.FirstOrDefault(l => l.Slug == slug);
        //}

        private readonly List<Learning> _learnings;

        public LearningService()
        {
            _learnings = SampleData.Learnings;
        }

        public Task<List<Learning>> GetLearningsAsync()
        {
            return Task.FromResult(_learnings);
        }

        public Task<Learning?> GetLearningBySlugAsync(string slug)
        {
            var learning = _learnings.FirstOrDefault(l => l.Slug == slug);
            return Task.FromResult(learning);
        }
    }
}
