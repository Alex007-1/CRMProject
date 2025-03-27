# CRMProject

CRMProject is a full‑stack CRM application built with .NET Core 8 and Blazor Server. It provides full CRUD (Create, Read, Update, Delete) operations for managing customer accounts using Domain‑Driven Design (DDD) principles. The application uses Entity Framework Core for data access with a SQL Server backend and features a minimal, responsive UI powered by Bootstrap 5.

## Table of Contents
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Architecture](#architecture)
- [Prerequisites](#prerequisites)
- [Installation and Setup](#installation-and-setup)
- [Running the Application](#running-the-application)

## Features
- **Customer Management:**  
  Create, read, update, and delete customer accounts.
- **Clean Architecture:**  
  Implements Domain‑Driven Design by separating concerns into Domain, Infrastructure, Application, and Presentation layers.
- **EF Core & SQL Server:**  
  Uses Entity Framework Core for data access and migrations with SQL Server as the database.
- **Responsive UI:**  
  Built with Blazor Server and styled minimally with Bootstrap 5.
- **Dependency Injection:**  
  The repository and service layers are managed via dependency injection.

## Tech Stack
- **Backend:** .NET Core 8, C#, Entity Framework Core
- **Frontend:** Blazor Server, Razor Components, Bootstrap 5
- **Database:** SQL Server
- **Design:** Domain‑Driven Design (DDD) & Dependency Injection

## Architecture
The project is organized into several layers:
- **Domain Layer:**  
  Contains core business entities (e.g., `Customer`) and repository interfaces (e.g., `ICustomerRepository`).
- **Infrastructure Layer:**  
  Implements data access with EF Core using `AppDbContext` and repository implementations.
- **Application Layer:**  
  Houses business logic and service classes (e.g., `CustomerService`).
- **Presentation Layer:**  
  Provides the UI built with Blazor Server (Razor components/pages) and includes minimal styling via Bootstrap and custom CSS.

## Prerequisites
- [.NET Core 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)
- Visual Studio 2022 (or later) or Visual Studio Code

## Installation and Setup

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Alex007-1/CRMProject.git
   cd CRMProject

2. **Update Connection String:**
   ```json
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER;Database=Arcadea;Trusted_Connection=True;MultipleActiveResultSets=true"
      },
   
3. **Restore Dependencies**
   ```bash
   dotnet restore

   
5. **Apply Database Migrations:**
   ```bash
   dotnet ef migrations add InitialCreate --project CRMProject.Infrastructure --startup-project CRMProject
   dotnet ef database update --project CRMProject.Infrastructure --startup-project CRMProject


## Running the Application
1. **From the Command Line:**
   ```bash
   dotnet run --project CRMProject

   
2. **Access the Application:**
Open your browser and navigate to your localhost.
