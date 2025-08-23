using PortfolioBlazorServer.Data;

namespace PortfolioBlazorServer.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        //private readonly HttpClient _http;

        //public ProjectService(HttpClient http)
        //{
        //    _http = http;
        //}

        //public async Task<List<Project>> GetProjectsAsync()
        //{
        //    var projects = await _http.GetFromJsonAsync<List<Project>>("Data/projects.json");
        //    return projects ?? new List<Project>();
        //}

        //public async Task<Project?> GetProjectBySlugAsync(string slug)
        //{
        //    var projects = await GetProjectsAsync();
        //    return projects.FirstOrDefault(p => p.Slug == slug);
        //}
        private readonly List<Project> _projects;

        public ProjectService()
        {
            _projects = SampleData.Projects;
        }

        public Task<List<Project>> GetProjectsAsync()
        {
            return Task.FromResult(_projects);
        }

        public Task<Project?> GetProjectBySlugAsync(string slug)
        {
            var project = _projects.FirstOrDefault(p => p.Slug == slug);
            return Task.FromResult(project);
        }
    }
}
