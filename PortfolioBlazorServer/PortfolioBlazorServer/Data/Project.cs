namespace PortfolioBlazorServer.Data
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string TechStack { get; set; } = string.Empty; // e.g., ".NET, EF Core, SQL"

        public string? DemoLink { get; set; } // optional live demo URL

        public string? GithubLink { get; set; } // optional

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public List<Learning>? RelatedLearnings { get; set; } // Optional connection
    }
}
