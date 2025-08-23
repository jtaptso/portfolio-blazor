namespace PortfolioBlazorServer.Data
{
    public class Learning
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty; // For URLs

        public string Summary { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty; // Full explanation / Markdown

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Tag> Tags { get; set; } = new(); // Many-to-many
    }
}
