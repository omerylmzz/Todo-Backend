# Todo Back-End

![Image](https://github.com/user-attachments/assets/4213c814-111b-46da-8b59-ff47c5e27ad6)


This project aims to develop a fast, scalable, and easy-to-manage Todo Application Backend API using modern software development tools. Built with .NET 8 and integrated with PostgreSQL through the Marten library, this API is easily deployable and runnable thanks to Docker and Docker Compose. It provides a practical solution for developers looking to learn basic CRUD operations or seeking a starting point for similar projects.

## Used Technologies

**Back-End:** .NET 8

**Database:** PostgreSQL & Marten

**Container:** Docker & Docker Compose

## Features

- CRUD (Create, Read, Update, Delete) operations for RESTful API.
- PostgreSQL database management using the Marten library.
- Easy setup and deployment with Docker and Docker Compose.
- A modern and scalable backend architecture.

## Libraries

- [Marten](https://martendb.io) to use PostgreSQL as both a database and a document store.
- [Entity Framework](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) to perform design-time development tasks.
- [Microsoft Code Analysis Workspaces Common](https://www.nuget.org/packages/Microsoft.CodeAnalysis.Workspaces.Common) for the development of Roslyn-based code analysis, editing, transformation and refactoring tools.
- [Microsoft Code Analysis Workspaces MSBuild](https://www.nuget.org/packages/Microsoft.CodeAnalysis.Workspaces.MSBuild) for analyze, manage and process MSBuild based projects.

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)

## Installation

Clone this repository

```bash
git clone https://github.com/omerylmzz/Todo-Backend.git
```

Install the dependencies

```bash
dotnet restore
```

## Run on your computer

Open appsettings.Development file and organise it as follows

```env
# Database Connection
Host=
Port=
Database=
Username=
Password=
```

Build images of all services

```bash
docker-compose build
```

Launch PostgreSQL with Docker and Docker Compose

```bash
docker-compose up -d
```

## API Usage

The REST API to the example app is described below.

| Endpoint         | Method   | Description                 |
| ---------------- | -------- | --------------------------- |
| `/api/task`      | `POST`   | Create a new task           |
| `/api/task`      | `GET`    | Display a list of all tasks |
| `/api/task/{id}` | `GET`    | Display a specific task     |
| `/api/task/{id}` | `PATCH` | Update a specific task      |
| `/api/task/{id}` | `DELETE` | Delete a specific task      |

### Create a Task

#### Body

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "title": "Title",
  "content": "Task"
}
```

#### Request

`POST`

```bash
http://localhost:8080/api/task
```

#### Response

```json
{
  "CODE": "200",
  "DESCRIPTION": "OK"
}
```

### All Tasks

#### Request

`GET`

```bash
http://localhost:8080/api/task
```

#### Response

```json
{
  "CODE": "200",
  "DESCRIPTION": "OK"
}
```

### Specific Task

#### Request

`GET`

```bash
http://localhost:8080/api/task/id
```

#### Response

```json
{
  "CODE": "200",
  "DESCRIPTION": "OK"
}
```

### Update Task

#### Request

`PATCH`

```bash
http://localhost:8080/api/task/id
```

#### Response

```json
{
  "CODE": "200",
  "DESCRIPTION": "OK"
}
```

### Delete Task

#### Request

`DELETE`

```bash
http://localhost:8080/api/task/id
```

#### Response

```json
{
  "CODE": "200",
  "DESCRIPTION": "OK"
}
```

## Preview




https://github.com/user-attachments/assets/497bab27-fa55-496d-86a7-ffac43f2a9b2




