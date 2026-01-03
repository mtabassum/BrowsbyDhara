Brows by Dhara – Salon Website

Overview

Brows by Dhara is a Blazor-based salon website designed to present salon services, collect appointment requests, and support essential business workflows such as customer communication and service management. The application emphasizes a clean user experience, clear separation of responsibilities, and maintainable backend logic suitable for a small-to-medium business environment.

The system is implemented as a single-project ASP.NET application, using Entity Framework Core for data persistence and a service-oriented design to isolate business logic from UI components.

Architecture

The application follows a layered monolithic architecture, where responsibilities are logically separated within a single project. This approach balances simplicity and structure while allowing future scalability if the application grows.

Presentation Layer (UI)

Built using Blazor components and Razor pages

Located under:

Components/

Pages/

Shared/

wwwroot/

Handles:

User interaction and navigation

Form validation and data binding

Invoking application services

This layer is focused solely on rendering the UI and responding to user actions, without embedding business or data access logic.

Application / Service Layer

Located under Services/

Contains service classes such as:

AppointmentService

EmailService

ServiceCatalog

Interfaces are defined to promote loose coupling and testability

This layer encapsulates business workflows, coordinates data access, and acts as the intermediary between the UI and the data layer.

Domain & Data Models

Located under Models/

Includes:

Core business entities (e.g., Appointment, Customer, Service)

Supporting entities such as Payment, Review, and Product

Data Transfer Objects (DTOs) for structured data exchange

These models represent both the business concepts of the salon and the persistence structure used by Entity Framework Core.

Data Access Layer

Located under Data/

Uses Entity Framework Core

SalonDbContext manages:

Database connections

Entity mappings

Migrations

This layer is responsible for interacting with the database and abstracting persistence details from the service layer.

Architectural Benefits

Simplicity: Single-project structure reduces complexity and setup overhead.

Maintainability: Clear folder-based separation keeps concerns isolated.

Scalability: Architecture can evolve into multi-project clean architecture if needed.

Testability: Business logic is centralized in services, enabling easier unit testing.

Real-world fit: Well-suited for a salon business application with room to grow.
