# Step-by-Step Guide: Building Your Blazor Server Portfolio Website

---

## Step 1: Install Prerequisites

1. **Install .NET SDK**  
   Download and install the latest .NET SDK from:  
   https://dotnet.microsoft.com/download

2. **Install Visual Studio 2022 or later**  
   Make sure you include the “ASP.NET and web development” workload.

---

## Step 2: Create a New Blazor Server Project

1. Open Visual Studio.
2. Click “Create a new project”.
3. Search for “Blazor Server App” and select it.
4. Name your project (e.g., `PortfolioBlazor`), choose a location, and click “Create”.
5. Select “Blazor Server App” (not Blazor WebAssembly) and click “Create”.

---

## Step 3: Run the Default Project

1. Press `F5` or click “Start” to run the project.
2. Your browser should open with a default Blazor app.

---

## Step 4: Explore the Project Structure

- `Pages/` – Contains Razor pages (e.g., `Index.razor`, `Counter.razor`)
- `Shared/` – Shared components (e.g., `MainLayout.razor`, `NavMenu.razor`)
- `wwwroot/` – Static files (CSS, images, JS)
- `App.razor` – Root component
- `Program.cs` – App startup

---

## Step 5: Customize the Homepage

1. Open `Pages/Index.razor`.
2. Replace the default content with a simple welcome message.
3. Add a hero section and call-to-action buttons (we’ll improve styling later).

Example:
```razor
@page "/"

<h1>Welcome to My Portfolio!</h1>
<p>This is the homepage. Explore my learnings and projects.</p>
<button @onclick="GoToLearnings">Explore My Learnings</button>
<button @onclick="GoToProjects">See My Projects</button>

@code {
    void GoToLearnings() => NavigationManager.NavigateTo("/learnings");
    void GoToProjects() => NavigationManager.NavigateTo("/projects");

    [Inject] NavigationManager NavigationManager { get; set; }
}
```

---

## Step 6: Add New Pages

1. Right-click the `Pages` folder > Add > New Item > Razor Component.
2. Name it `Learnings.razor`.
3. Repeat for `Projects.razor`, `About.razor`, `Contact.razor`, and `Resources.razor`.

---

## Step 7: Update Navigation

1. Open `Shared/NavMenu.razor`.
2. Add links to your new pages.

Example:
```razor
<NavLink href="" Match="NavLinkMatch.All">Home</NavLink>
<NavLink href="learnings">Learnings</NavLink>
<NavLink href="projects">Projects</NavLink>
<NavLink href="about">About</NavLink>
<NavLink href="resources">Resources</NavLink>
<NavLink href="contact">Contact</NavLink>
```

---

## Step 8: Build Each Page

Start with simple content for each page. For example, in `Learnings.razor`:
```razor
@page "/learnings"
<h2>My Learnings</h2>
<p>Here you'll find my blog posts and documentation.</p>
```
Repeat for other pages.

---


---


## Step 9: Create Data Models

1. Define C# classes for your main entities: `Post`, `Project`, `Category`, `Tag`, etc.
2. Place these classes in a new folder (e.g., `Models`).

---


## Step 10: Add Sample Data

1. Store sample data in-memory (in a service class) or in JSON files.
2. Use this data to display posts, projects, etc., on your pages.

---


## Step 11: Build Data Services

1. Create service classes to provide data to your components (e.g., `PostService`).
2. Register these services for dependency injection in `Program.cs`.

---


## Step 12: Display Data on Pages

1. Update your pages to show lists of posts, projects, etc., using Razor syntax and components.
2. Inject your services into pages/components to access data.

---


## Step 13: Create Reusable Components

1. Build components like `PostCard`, `ProjectCard`, `CategoryTab`, etc., for a clean UI.
2. Use these components in your pages to display data consistently.

---

