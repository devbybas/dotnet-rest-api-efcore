# dotnet-rest-api-efcore

REST API built with **ASP.NET Core** and **Entity Framework Core** using **SQLite**.  
Includes **CRUD endpoints** and **Swagger/OpenAPI**.

## Features
- CRUD for `Contact`
- EF Core with SQLite database
- Swagger UI for testing endpoints
- Clean project structure

## Tech Stack
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger / OpenAPI

## Run locally (Visual Studio)
1. Open the solution in Visual Studio
2. Run the project (F5)
3. Open Swagger UI and test the endpoints

## API Endpoints
- `GET /api/contacts`
- `GET /api/contacts/{id}`
- `POST /api/contacts`
- `DELETE /api/contacts/{id}`

## Notes
- Database file (`*.db`) is ignored via `.gitignore`
