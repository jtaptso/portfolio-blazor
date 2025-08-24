namespace PortfolioBlazorServer.Data
{
    public static class SampleData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, Name = "Programming", Slug = "programming" },
            new Category { Id = 2, Name = "Business Analysis", Slug = "business-analysis" },
            new Category { Id = 3, Name = "Data & Analytics", Slug = "data-analytics" },
            new Category { Id = 4, Name = "ERP Systems", Slug = "erp-systems" }
        };

        public static List<Learning> Learnings = new List<Learning>
        {
            new Learning
            {
                Id = 1,
                Title = "Getting Started with C#",
                Slug = "getting-started-with-csharp",
                Summary = "Basics of C# programming, types, and syntax.",
                Content = "C# is a modern, object-oriented programming language...",
                DateCreated = DateTime.UtcNow.AddDays(-10),
                CategoryId = 1,
                Category = Categories.First(c => c.Id == 1)
            },
            new Learning
            {
                Id = 2,
                Title = "Introduction to SAP Business One",
                Slug = "intro-sap-business-one",
                Summary = "Overview of SAP B1 and basic navigation.",
                Content = "SAP Business One is an ERP solution designed for SMEs...",
                DateCreated = DateTime.UtcNow.AddDays(-7),
                CategoryId = 4,
                Category = Categories.First(c => c.Id == 4)
            }
        };

        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Name = "Personal Portfolio Website",
                Slug = "personal-portfolio-website",
                Description = "A Blazor Server website documenting my learnings and projects.",
                TechStack = ".NET 9, Blazor Server, Bootstrap",
                DemoLink = "#",
                GithubLink = "https://github.com/jtaptso/portfolio-blazor/",
                DateCreated = DateTime.UtcNow.AddDays(-5)
            },
            new Project
            {
                Id = 2,
                Name = "CXML API Integration",
                Slug = "cxml-api-integration",
                Description = "API to manage CXML transactions and integrate with SAP B1.",
                TechStack = ".NET 9, SAP Business One DI API, EF Core",
                DemoLink = "#",
                GithubLink = "https://github.com/username/cxml-api",
                DateCreated = DateTime.UtcNow.AddDays(-2)
            },
            new Project
            {
                Id = 3,
                Name = "IT Warehouse Managment System",
                Slug = "It-ws-mgnt-system",
                Description = "API to manage IT Warehouse.",
                TechStack = ".NET 9, EF Core, SQL Server",
                DemoLink = "#",
                GithubLink = "https://github.com/jtaptso/ITLagerVerwaltungSystem",
                DateCreated = DateTime.UtcNow.AddDays(-2)
            }
        };

        public static List<Resource> Resources = new List<Resource>
        {
            new Resource
            {
                Id = 1,
                Name = "Microsoft Docs - C# Guide",
                Url = "https://docs.microsoft.com/en-us/dotnet/csharp/",
                Description = "Official documentation for learning C#.",
                CategoryId = 1,
                Category = Categories.First(c => c.Id == 1)
            },
            new Resource
            {
                Id = 2,
                Name = "SAP Business One Academy",
                Url = "https://academy.sap.com/",
                Description = "Official SAP learning portal.",
                CategoryId = 4,
                Category = Categories.First(c => c.Id == 4)
            }
        };
    }

}
