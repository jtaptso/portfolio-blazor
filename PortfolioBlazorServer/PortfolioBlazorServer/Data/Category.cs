namespace PortfolioBlazorServer.Data
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public List<Learning> Learnings { get; set; } = new();
        public List<Resource> Resources { get; set; } = new();
    }
}
