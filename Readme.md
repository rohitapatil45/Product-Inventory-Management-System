# Product Inventory Management System

## Overview

This project is a Product Inventory Management System developed using ASP.NET Core Web API. It allows authenticated users to perform CRUD operations on products based on their assigned roles.

## Features

- User Login and Logout
- View Products
- Add Products
- Update Products
- Delete Products
- Product Search
- Product Count
- Role-based Authorization

## Roles

### Admin
- View Products
- Update Products

### SuperAdmin
- View Products
- Add Products
- Update Products
- Delete Products

## Product Details

Each product contains the following information:

- Id
- Name
- Category
- Price
- Quantity

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Cookie Authentication
- jQuery AJAX
- Bootstrap 5

## Database Setup

1. Open `appsettings.json`.
2. Update the SQL Server connection string if required.
3. Run the following commands:

```bash
dotnet ef database update
```

## Login Credentials

### Admin

**Username:** admin

**Password:** admin123

### SuperAdmin

**Username:** superadmin

**Password:** super123

## Running the Project

1. Clone or download the project.
2. Open the project in Visual Studio Code or Visual Studio.
3. Restore the NuGet packages.
4. Update the connection string if required.
5. Run the project using:

```bash
dotnet run
```

6. Open the application in your browser and log in using one of the above accounts.

## Project Structure

```
ProductManagement
│
├── Controllers
├── Data
├── Models
├── wwwroot
├── Program.cs
├── appsettings.json
└── README.md
```

## Author

Rohit Patil