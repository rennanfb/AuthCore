
# AuthCore

### Centralized Authentication and Identity Management API

**AuthCore** is a study and development project focused on building a centralized API for authentication, user management, and access control.

The goal is to develop a reusable infrastructure that allows different applications to consume authentication and identity management features through an API.

The project is being developed with ASP.NET Core and uses tools from the .NET ecosystem for identity management, data persistence, and token-based authentication.

## Objectives

- Develop a centralized authentication API.
- Implement user and profile management.
- Work with JWT-based authentication.
- Implement authorization and access control mechanisms.
- Explore software architecture concepts and separation of concerns.
- Build a reusable foundation for future applications.

## Features

- Initial API structure.
- User management with ASP.NET Core Identity.
- Data persistence with Entity Framework Core.
- SQLite database integration.
- JWT-based authentication.
- User management service.
- Token generation service.
- Initial authorization structure.

## Technologies

| Technology | Purpose |
|---|---|
| C# | Main programming language |
| ASP.NET Core | API development |
| ASP.NET Core Identity | Identity management |
| Entity Framework Core | ORM and data persistence |
| SQLite | Database |
| JWT Bearer | Token-based authentication |
| AutoMapper | Object mapping |

## Project Structure

```text
AuthCore/
├── Authorization/
├── Controllers/
├── Data/
├── Handlers/
├── Migrations/
├── Models/
├── Profiles/
├── Requirements/
├── Services/
├── Program.cs
└── appsettings.json
```

The project structure aims to separate application responsibilities while keeping components related to authentication, data persistence, user management, and authorization organized.

## Getting Started

### Prerequisites

- .NET SDK compatible with the project version.
- Git.

### Cloning the Repository

```bash
git clone REPOSITORY_URL
cd AuthCore
```

### Restoring Dependencies

```bash
dotnet restore
```

### Applying Migrations

```bash
dotnet ef database update
```

### Running the Application

```bash
dotnet run
```

Check the `appsettings.json` file to verify the required configuration before running the application.

## Architecture and Future Development

AuthCore is initially being developed as a centralized application, with responsibilities organized into different components.

The intention is to evolve its architecture to allow different applications to use identity and authentication features without having to implement these mechanisms individually.

Some of the concepts I intend to explore throughout this evolution include:

- Modular architecture.
- Separation of concerns.
- Inter-service communication.
- OAuth 2.0 and OpenID Connect.
- Application-level access control.
- Security and session management.

## Learning Outcomes

This project is part of my learning process and ongoing development of backend skills with .NET.

Its development involves the practical application of concepts such as authentication, authorization, data persistence, REST APIs, identity management, and software architecture.

The implementation also serves as a foundation for exploring new approaches and continuously improving code quality.

## Roadmap

The project is still under development and may receive new features, architectural improvements, and security enhancements as it evolves.

---

**Status:** In Development.

**Purpose:** Learning, practical experience, and growth in backend architecture with .NET.