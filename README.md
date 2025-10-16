# Ridefy - Motorcycle Rental

A .NET 8 application that simulates a service to rental motorcycles.

This repository is for study purposes. It aims to create a layered service with two instances to enable asynchronous communication.

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![Build Status](https://img.shields.io/badge/build-passing-brightgreen)

## Table of Content
- Features
- Technologies
- Project Structure
- Prerequisites
- How to run the project
- Running tests
- Running code coverage

### Features

- Motorcycle registration
- Motorcycle rental
- Rider registration
- Testable with BDD integration tests

### Tecnologies

- .NET 8
- C# 12
- RabbitMQ for messaging
- OpenTelemetry for structured logs
- Seq
- xUnit + FluentAssertions
- Reqnroll for BDD tests

### Project Structure

- docker-compose.yml
- .gitignore
- README.md
- global.json
- src/
  - Ridefy.WebApi/ (Web API project)
    - Controllers/
    - Program.cs
    - appsettings.json
  - Ridefy.Application/ (Commands, Queries, Validators and handlers)
    - Commands/
    - Queries/
    - Validators/
  - Ridefy.Domain/ (Entidades, Aggregates, Enums)
    - Entities/
  - Ridefy.Infrastructure/ (RabbitMQ, Storage)
    - Storage/ (FileStorage)
    - Messaging/ (RabbitMQ Publisher/Consumer)
  - Ridefy.Infrastructure.Persistence/ (EF Core, Repositories) 
    - Data/
      - RidefyDbContext.cs
    - Repositories/
- tests/
  - Ridefy.UnitTests/(unit tests)
  - Ridefy.IntegrationTests/ (tests com banco real + fila em Docker)

### Prerequisites

- .NET 8 SDK
    - https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet9&pivots=os-linux-ubuntu-2404

Check the .Net version. This will show the list of all available SDKs on your system.
```shell
dotnet --version
dotnet --info
```

### How to run the project

Clone this repo and execute the docker compose
```shel
docker compose down -v
docker compose up -d
```

### Running tests

#### User case:

#### Input

|   |  |  |
|:----------:|:---------:|:--------:|
|  |  |  |

#### Expected output

|     |
|:---:|
| 200 |

```shell
dotnet test tests/Ridefy.IntegrationTests/Ridefy.IntegrationTests.csproj
```

#### User case: 

```shell
dotnet run --project src/CapitalGains.ConsoleApp < input.json
```

#### Expected output

```json

```