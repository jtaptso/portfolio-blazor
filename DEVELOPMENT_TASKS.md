# Portfolio Website Development Tasks (Blazor Server)

---

## 1. Project Setup
- Create a new Blazor Server project.
- Configure solution structure (folders for Pages, Components, Models, Services, wwwroot).
- Set up global styles and layout (Header, Footer, Navigation).

## 2. Homepage
- Implement Hero Section with introductory text and image.
- Add Call-to-action buttons:
  - “Explore My Learnings” → Link to Learnings Page.
  - “See My Projects” → Link to Projects Page.
- Add About Preview section with “Read More” button → About Page.
- Display Learning Areas Overview with links to each category.
- Show Latest Posts Preview (fetch recent blog posts).
- Show Featured Projects Preview (fetch highlighted projects).
- Implement Footer with global navigation and contact links.

## 3. About Page
- Add Personal Story section.
- Add Mission & Goals section.
- Display Skills & Tools (icons/logos, optional link to Resources).
- Add Fun Facts / Personal Touch section.
- Add CTA button: “See What I’m Learning” → Learnings Page.

## 4. Learnings (Blog) Page
- Implement Category View (cards/tabs for Programming, ERP, Data, Business Analysis).
- Display filtered list of posts per category.
- Implement Post Page:
  - Title, Date
  - Summary (“What I Learned”)
  - Detailed Explanation
  - Code snippets/diagrams
  - Key Takeaways
  - Tags (link to tag archive)
  - Navigation back to Category

## 5. Projects Page
- Display Project Grid (cards with thumbnail, name, tech stack).
- Implement Project Detail Page:
  - Overview (problem solved)
  - Tech Stack Used (icons/logos)
  - Screenshots / Demo / GitHub link
  - Reflection (“What I Learned”)
  - Link back to related Learnings posts

## 6. Resources Page (Optional)
- List Learning Resources (external links).
- List Tools & Frameworks (icons, descriptions).
- List Recommended Books/Blogs.
- Link resources to relevant Learnings posts.

## 7. Contact Page
- Implement Contact Form (send email notification).
- Display Social Links (GitHub, LinkedIn, YouTube).
- Add CTA: “Let’s Collaborate”.

## 8. Global Navigation
- Implement Header (Logo/Name, navigation links).
- Implement Footer (quick links, social icons, copyright).

## 9. Data Models & Services
- Define models for Posts, Projects, Categories, Tags, Resources.
- Implement data services (in-memory, JSON, or database).
- Set up dependency injection for services.

## 10. UI Components
- Create reusable components (Card, Button, Tag, CategoryTab, ProjectGrid, PostPreview, etc.).

## 11. Routing & Navigation
- Configure routing for all pages and detail views.
- Ensure smooth navigation and back links.

## 12. Responsive Design & Accessibility
- Ensure mobile-friendly layout.
- Add accessibility features (ARIA, keyboard navigation).

## 13. Testing & Deployment
- Test all pages and components.
- Set up deployment (e.g., Azure, IIS, or other hosting).

---

This template provides a clear roadmap for building your Blazor Server portfolio site.
