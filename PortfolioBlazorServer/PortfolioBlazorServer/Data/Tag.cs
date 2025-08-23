namespace PortfolioBlazorServer.Data
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Learning> Learnings { get; set; } = new();
    }
}
