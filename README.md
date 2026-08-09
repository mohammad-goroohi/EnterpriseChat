# Enterprise Chat

A real-world enterprise chat application built with **.NET MAUI Blazor Hybrid** and **ASP.NET Core**.

This project is primarily designed as a **learning project and practical exercise** for developers who want to experience building a complete application with a modern .NET stack.

The goal is not just to build a chat UI, but to explore how a real-world application can be designed, structured, developed, tested, and maintained.

---

## 🎯 Project Goals

The main goal of this project is to provide a practical environment for learning and experimenting with:

* .NET MAUI
* Blazor Hybrid
* ASP.NET Core
* REST APIs
* SignalR
* Real-time communication
* Authentication and authorization
* Clean Architecture
* Entity Framework Core
* SQL Server
* Dependency Injection
* Application and Domain layers
* File and media management
* Push notifications
* Logging and auditing
* Unit and integration testing
* Git and collaborative development

This project can be useful for developers who already know the basics of .NET and want to move toward building a **complete real-world application**.

---

## 🏗️ Architecture

The project follows a layered architecture with a clear separation between the client, server, domain, application, and infrastructure concerns.

```text
EnterpriseChat
│
├── Client
│   └── EnterpriseChat.App
│       │
│       ├── .NET MAUI
│       └── Blazor Hybrid
│
├── Server
│   └── EnterpriseChat.Api
│       │
│       └── ASP.NET Core
│
├── Domain
│   └── EnterpriseChat.Domain
│
├── Application
│   └── EnterpriseChat.Application
│
├── Infrastructure
│   └── EnterpriseChat.Infrastructure
│
└── Contracts
    └── EnterpriseChat.Contracts
```

The overall communication can be represented as:

```text
┌─────────────────────────────┐
│       MAUI Blazor App       │
│                             │
│  Blazor UI                  │
│  Client Services            │
│  SignalR Client             │
└──────────────┬──────────────┘
               │
        HTTP / SignalR
               │
               ▼
┌─────────────────────────────┐
│       ASP.NET Core API      │
│                             │
│  Controllers                │
│  SignalR Hubs               │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│        Application          │
│                             │
│  Use Cases                  │
│  Commands                   │
│  Queries                    │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│           Domain            │
│                             │
│  Entities                   │
│  Value Objects              │
│  Business Rules             │
└──────────────┬──────────────┘
               │
               ▼
┌─────────────────────────────┐
│       Infrastructure        │
│                             │
│  EF Core                    │
│  SQL Server                 │
│  File Storage               │
│  Notifications              │
└─────────────────────────────┘
```

---

## 📁 Repository Structure

```text
EnterpriseChat/
│
├── src/
│   │
│   ├── Client/
│   │   └── EnterpriseChat.App/
│   │
│   ├── Server/
│   │   └── EnterpriseChat.Api/
│   │
│   ├── Domain/
│   │   └── EnterpriseChat.Domain/
│   │
│   ├── Application/
│   │   └── EnterpriseChat.Application/
│   │
│   ├── Infrastructure/
│   │   └── EnterpriseChat.Infrastructure/
│   │
│   └── Contracts/
│       └── EnterpriseChat.Contracts/
│
├── tests/
│   ├── UnitTests/
│   ├── IntegrationTests/
│   └── ArchitectureTests/
│
├── docs/
│   ├── architecture/
│   ├── requirements/
│   └── api/
│
├── EnterpriseChat.sln
├── Directory.Build.props
├── Directory.Packages.props
├── .editorconfig
├── .gitignore
└── README.md
```

---

## 🚀 Technologies

### Client

* .NET MAUI
* Blazor Hybrid
* C#
* Razor Components
* SignalR Client

### Backend

* ASP.NET Core
* C#
* REST API
* SignalR
* Dependency Injection
* Entity Framework Core

### Database

* SQL Server
* Entity Framework Core

### Development

* Visual Studio
* Git
* GitHub / GitLab / Forgejo
* Unit Testing
* Integration Testing

---

## 💬 Planned Features

The application is intended to gradually evolve into a complete enterprise chat platform.

### Authentication

* User registration
* Login
* Logout
* Token-based authentication
* Refresh tokens
* Password management
* Session management

### Users

* User profile
* Profile picture
* Online/offline status
* Last seen
* User search
* User presence

### Conversations

* One-to-one conversations
* Group conversations
* Conversation creation
* Add/remove members
* Group administration
* Conversation settings

### Messaging

* Send messages
* Edit messages
* Delete messages
* Reply to messages
* Forward messages
* Message reactions
* Mentions
* Message search
* Message history

### Real-Time Communication

Using SignalR:

* Real-time message delivery
* Typing indicators
* Online/offline presence
* Message delivery status
* Read receipts
* Real-time notifications

### Files and Attachments

* Image sharing
* Document sharing
* File upload/download
* Message attachments
* File preview
* File metadata

### Notifications

* In-app notifications
* Push notifications
* New message notifications
* Mention notifications

### Administration

* User management
* Roles and permissions
* Organization management
* Audit logs
* System settings

---

## 🧪 Testing

Testing is considered an important part of the project.

The repository is intended to contain different types of tests:

```text
tests/
│
├── UnitTests/
│
├── IntegrationTests/
│
└── ArchitectureTests/
```

The goal is to demonstrate how different parts of a real application can be tested independently.

---

## 📚 Learning Objectives

This project is especially useful for developers who want to learn how different technologies work together in a real application.

Instead of learning each technology independently, the project tries to answer practical questions such as:

* How should a MAUI application communicate with a backend?
* How does Blazor Hybrid work inside MAUI?
* When should REST APIs be used?
* When should SignalR be used?
* How should real-time communication be designed?
* How should authentication work between the client and API?
* How should a large .NET solution be structured?
* How should Domain, Application, and Infrastructure be separated?
* How should shared contracts be managed?
* How should database access be organized?
* How should files and attachments be handled?
* How should offline and reconnect scenarios be handled?
* How should an application be tested?
* How should Git branches and pull requests be organized?

---

## 🛠️ Project Status

This project is currently under active development.

Features will be implemented incrementally.

The architecture and requirements may evolve as new requirements and real-world scenarios are discovered.

> The project is intentionally developed step by step rather than attempting to implement the entire system at once.

---

## 🤝 Contributing

Contributions, ideas, improvements, and discussions are welcome.

If you want to experiment with a specific technology or feature, feel free to open an issue or submit a pull request.

Possible areas for contribution include:

* New features
* Bug fixes
* Tests
* Documentation
* Architecture improvements
* Performance improvements
* UI/UX improvements

---

## ⚠️ Disclaimer

This project is primarily intended for **learning, experimentation, and educational purposes**.

Although the architecture and features are inspired by real-world enterprise applications, the project should not be considered production-ready software.

Security, scalability, performance, and operational requirements should be reviewed carefully before using any part of the project in a production environment.

---

## ⭐ Why This Project?

Building a small sample application is useful for learning individual technologies.

Building a complete application is a different experience.

This project is intended to provide an opportunity to practice the complete development lifecycle:

```text
Requirements
     ↓
Architecture
     ↓
Database Design
     ↓
API Design
     ↓
Implementation
     ↓
Testing
     ↓
Real-Time Communication
     ↓
Security
     ↓
Deployment
     ↓
Maintenance
```

The ultimate goal is to create a project that developers can use as a **practical exercise for experiencing how a real .NET application is designed and developed from the ground up.**

---

## 📄 License

This project is currently intended for educational purposes.

License information will be added as the project evolves.
