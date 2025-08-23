using System.Text.Json;

namespace PortfolioBlazorServer.Data
{
    public class DataService
    {
        public async Task<List<Learning>> GetLearningsAsync()
        {
            using var stream = File.OpenRead("Data/learnings.json");
            var learnings = await JsonSerializer.DeserializeAsync<List<Learning>>(stream);
            return learnings ?? new List<Learning>();
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            using var stream = File.OpenRead("Data/projects.json");
            var projects = await JsonSerializer.DeserializeAsync<List<Project>>(stream);
            return projects ?? new List<Project>();
        }
    }
}
