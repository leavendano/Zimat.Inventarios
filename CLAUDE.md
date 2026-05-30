# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is **Zimat.Inventarios**, a comprehensive inventory management system built with .NET 8 following Clean Architecture principles. The application manages products, suppliers, documents (orders/invoices), and inventory tracking for Mexican businesses (includes SAT tax codes, RFC fields).

## Architecture

Clean Architecture solution with four main projects:
- **Zimat.Inventarios.Core** - Domain entities, aggregates, value objects, specifications
- **Zimat.Inventarios.UseCases** - CQRS commands/queries using MediatR
- **Zimat.Inventarios.Infrastructure** - Entity Framework Core with PostgreSQL, repositories
- **Zimat.Inventarios.Web** - Blazor Server application with FastEndpoints API

Key patterns: Clean Architecture, DDD, CQRS, Repository with Specifications, Domain Events.

## Technology Stack

- **.NET 10.0** with nullable reference types
- **Blazor Server** with Interactive Server Components
- **Radzen Blazor Components** for UI (DataGrid, Forms)
- **Entity Framework Core 10.0** with PostgreSQL (snake_case naming)
- **MediatR** for CQRS implementation
- **FastEndpoints** for API endpoints
- **OpenID Connect** authentication

## Development Commands

### Running the Application
```bash
# From the Web project directory
dotnet run --launch-profile https
```
Application runs on https://localhost:57679

### Database Operations
```bash
# Update database (run from Web project directory)
dotnet ef database update -c AppDbContext -p ../Zimat.Inventarios.Infrastructure/Zimat.Inventarios.Infrastructure.csproj -s Zimat.Inventarios.Web.csproj

# Add new migration
dotnet ef migrations add MIGRATIONNAME -c AppDbContext -p ../Zimat.Inventarios.Infrastructure/Zimat.Inventarios.Infrastructure.csproj -s Zimat.Inventarios.Web.csproj -o Migrations
```

### Build Commands
```bash
# Build entire solution
dotnet build Zimat.Inventarios.sln

# Restore packages
dotnet restore
```

## Business Domain

Inventory management system with core entities:
- **Articulos** (Products) - Catalog items with pricing, stock levels, categorization
- **Proveedores** (Suppliers) - Vendor management with RFC (Mexican tax ID)
- **Documentos** (Documents) - Purchase orders, invoices with line items
- **Categorias/Familias/Lineas** - Hierarchical product categorization
- **Unidades** (Units) - Measurement units with SAT compliance
- **Departamentos** (Departments) - Organizational structure

All entities include audit fields (`created_at`, `updated_at`, `usuario`, `estatus`).

## Code Conventions

### Database
- PostgreSQL with snake_case naming convention
- Entity Framework migrations in Infrastructure project
- Connection string: PostgreSQL on localhost:5432, database 'zimat'

### Blazor Components
- Server-side rendering with Interactive Server components
- Radzen components for data grids and forms
- Authorization required (`[Authorize]` attribute)
- Spanish language interface

### CQRS Structure  
- Commands in `UseCases/[Entity]/[Action]/` (e.g., `UseCases/Articulos/Create/`)
- Query handlers for read operations
- DTOs for data transfer between layers

## Project Structure Notes

### Missing Components
- **No test projects** - This is a significant gap that should be addressed
- No API documentation (Swagger) configured
- Limited error handling in UI components

### Key Features
- Automatic database seeding on startup
- Comprehensive logging with Serilog
- Multi-currency support with exchange rates
- File upload support for documents
- Real-time UI updates with Blazor Server

## Development Database Configuration

Default connection uses PostgreSQL. Database seeding occurs automatically on application startup. The application includes comprehensive business logic for Mexican inventory management including tax calculations and regulatory compliance.