# 📌 Reservations Microservice
This project is a **RESTful microservice** designed to manage the full lifecycle of reservations:  
creation, retrieval, update, and deletion.  
It follows **Clean Architecture** principles, built with **ASP.NET Core**, **Entity Framework Core**, and **SQL Server** as the database.  
Each resource uses **GUID** identifiers to ensure global uniqueness and support distributed systems.

## Main Features
- ✅ Create, view, update, and delete reservations.
- ✅ Manage clients linked to reservations.
- ✅ **GUID** identifiers for unique traceability.
- ✅ Designed to run as an isolated microservice within a larger architecture.
- ✅ Implements **Clean Architecture** for clear separation of concerns.

## 🧱 System Layers
| Layer             | Description                                                   |
|-------------------|---------------------------------------------------------------|
| **API**           | Exposes RESTful endpoints for external systems.               |
| **Application**   | Contains use cases, DTOs, interfaces, and validators.         |
| **Domain**        | Defines domain entities and main business rules.              |
| **Infrastructure**| Implements repositories, DbContext, and external connections. |

## 🗃️ Database
- **Type:** Relational (**SQL Server**)
- **Models:**
  - **Client:** Name, phone, email, address, and linked reservations.
  - **Reservation:** Client reference, date, reservation type, and price.
- **Relationship:** One **Client** can have many **Reservations** (**1:N**).

## 📌 Main Endpoints
| Method | Endpoint                | Description                     |
|--------|-------------------------|---------------------------------|
| GET    | `/api/reservations`     | List all reservations           |
| POST   | `/api/reservations`     | Create a new reservation        |
| GET    | `/api/reservations/{id}`| Get a reservation by ID         |
| PUT    | `/api/reservations/{id}`| Update a reservation            |
| DELETE | `/api/reservations/{id}`| Delete a reservation            |

## 🔒 Security
- ✅ Planned **JWT** authentication for secure API access.
- ✅ Validation and error handling to ensure data integrity.

## 🛠️ Technologies Used
- **Language:** C# (.NET 8+)
- **Architecture:** Clean Architecture
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **API Documentation:** Swagger (OpenAPI)
- **Identifiers:** GUID

## 🚀 Deployment
Designed to run independently or as part of a cloud-based architecture.  
Optimized to be deployed on **Azure App Service**, **Render.com**, **Docker**, or Kubernetes environments.

## 👨‍💻 Author
Developed by: **Nicoll Sevillano**  
Project: **Reservations Microservice**  
Year: **2025**