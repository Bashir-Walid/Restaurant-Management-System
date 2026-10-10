```md
# Restaurant Management System

A full-stack restaurant management web application built with ASP.NET Core MVC, C#, Entity Framework Core, SQL Server, and ASP.NET Identity.

The system includes a public restaurant website and a complete administration dashboard for managing website content and user interactions.

## Features

### Public Website

- Restaurant home page
- About section
- Menu categories and menu items
- Services
- Opening hours
- Social media links
- Contact form
- Newsletter subscription
- Reservation functionality

### Admin Dashboard

- Secure authentication using ASP.NET Identity
- Manage menu categories and menu items
- Manage restaurant information
- Manage banners and sliders
- Manage services
- Manage social media links
- Manage opening hours
- Manage reservations
- Manage newsletter subscriptions
- Manage contact messages
- Reply to contact messages
- Activate and deactivate records
- Upload and manage images
- Dynamic content management

## Technologies Used

### Backend

- C#
- ASP.NET Core MVC
- Entity Framework Core
- LINQ
- ASP.NET Identity
- Repository Pattern
- ViewModels

### Database

- SQL Server
- SQL Server Management Studio

### Frontend

- HTML
- CSS
- JavaScript
- Bootstrap
- Razor Views

### Development Tools

- Visual Studio
- Git
- GitHub

## Project Structure

The project follows an ASP.NET Core MVC architecture and includes:

- Areas for administration functionality
- Controllers
- Models
- ViewModels
- Repository Pattern
- Mapping Extensions
- Helpers
- Entity Framework Core DbContext
- ASP.NET Identity authentication and authorization


### Public Website
Home Page

### Admin Dashboard
Dashboard

### Content Management
Menu Management

### Contact Messages
Contact Management

## Database Setup

Configure the connection string in `appsettings.json`.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=RestaurantDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Open Package Manager Console and create a migration:

```powershell
Add-Migration InitialCreate
```

Then update the database:

```powershell
Update-Database
```

## How to Run

Clone the repository:

```bash
git clone https://github.com/Bashir-Walid/Restaurant-Management-System.git
```

Then:

1. Open the solution in Visual Studio.
2. Configure the SQL Server connection string.
3. Apply Entity Framework Core migrations.
4. Run the project.

## What I Learned

Through this project, I gained practical experience with:

- Building backend functionality using ASP.NET Core MVC
- Connecting frontend templates with dynamic backend data
- Designing and managing SQL Server databases
- Working with Entity Framework Core and LINQ
- Authentication and authorization using ASP.NET Identity
- CRUD operations
- Repository Pattern
- ViewModels
- File and image uploads
- Email integration
- Debugging database and nullability issues
- Building and managing an administration dashboard

## Training

This project was developed during practical ASP.NET Core MVC (.NET 8) training at Step by Step for Training & Consulting.

## Author

**Bashir Walid Ebdah**

- LinkedIn: https://www.linkedin.com/in/bashir-walid/
- GitHub: https://github.com/Bashir-Walid
```
