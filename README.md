Welcome to the Travel Experience API take-home assignment! This project is a boilerplate designed to get you started quickly. Your task is to implement the core logic for **two AI-powered features** that use Microsoft's **Semantic Kernel**:

1.  **Generate an activity description** for a given destination.
2.  **Generate a summary of an itinerary** based on its activities and destinations.

## Project Structure

The solution follows a standard layered architecture:
- `TravelExperience.API`: The entry point with API controllers.
- `TravelExperience.Application`: Contains business logic, MediatR commands, and handlers.
- `TravelExperience.Domain`: Holds the core entities and interfaces.
- `TravelExperience.Infrastructure`: Contains data access logic (repositories) and external services.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express/LocalDB)
- Your favorite IDE (Visual Studio, VS Code, Rider)

## Setup Instructions

### 1. Database Setup

1.  Update the `DefaultConnection` string in `TravelExperience.API/appsettings.json` if needed. It's configured to use SQL Server LocalDB by default.
2.  Open a terminal in the `TravelExperience.API` directory.
3.  Run the Entity Framework Core migrations to create the database schema and seed the initial data:
    ```bash
    dotnet ef database update --project ..\TravelExperience.Infrastructure\TravelExperience.Infrastructure.csproj --startup-project .
    ```

### 2. AI Service Configuration

The project is set up to use a fake AI service. To use a real AI model, you will need to replace the `FakeAIService` class with your own implementation that uses Semantic Kernel.

A basic `IAIService` interface is provided for you to implement. Your implementation should:
- Take an AI API key (from `appsettings.json` or a secrets manager).
- Initialize the Semantic Kernel.
- Create prompts to generate the description and summary.
- Invoke the kernel to get the generated text.

### 3. Your Tasks

Your primary tasks are to implement the core AI logic within two command handlers:

1.  **Generate an Activity Description:**
    * **File to edit:** `TravelExperience.Application/Activities/Commands/GenerateActivityDescriptionCommandHandler.cs`
    * **Method to complete:** `Handle`
    * **Objective:** Use `IAIService` to generate a description for a new activity.

2.  **Generate an Itinerary Summary:**
    * **File to edit:** `TravelExperience.Application/Itineraries/Commands/GenerateItinerarySummaryCommandHandler.cs`
    * **Method to complete:** `Handle`
    * **Objective:** Use `IAIService` to generate a summary for an existing itinerary based on its activities.

### 4. Running the Application

1.  Open the `TravelExperience.sln` file in your IDE.
2.  Set `TravelExperience.API` as the startup project.
3.  Run the application. The Swagger UI will open automatically.

### 5. Testing the Endpoints

You can test your completed endpoints using Swagger UI, Postman, or `curl`.
