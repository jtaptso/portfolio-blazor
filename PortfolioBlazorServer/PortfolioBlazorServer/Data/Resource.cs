namespace PortfolioBlazorServer.Data
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
