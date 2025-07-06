# 📌 Reservation Microservice
This project is a **RESTful microservice** designed to manage the complete lifecycle of reservations:  
creation, retrieval, update, and deletion.  
It follows **Clean Architecture** principles, using **ASP.NET Core**, **Entity Framework Core**, and **SQL Server** for data persistence.  
Each resource uses **GUID** identifiers to ensure global uniqueness and distributed systems support.

## Main Features
- Create, view, update, and delete reservations.
- Manage clients linked to reservations.
- Use **GUID** identifiers for unique traceability.
- Designed to run as an isolated microservice within a larger system.
- Follows **Clean Architecture** principles for clear separation of concerns.

## 🧱 System Layers
| Layer         | Description                                                  |
|---------------|--------------------------------------------------------------|
| **API**       | Exposes RESTful endpoints for external systems.              |
| **Application** | Contains use cases, DTOs, interfaces, and validators.        |
| **Domain**    | Defines domain entities and core business rules.             |
| **Infrastructure** | Implements repositories, DbContext, and external integrations. |

## 🗃️ Database
- **Type:** Relational database (**SQL Server**)
- **Models:**  
  - **Client:** Name, phone, email, address, and related reservations.
  - **Reservation:** Client reference, date, reservation type, and price.
- **Relationship:** One **Client** can have many **Reservations** (**1:N**).

## 📌 Main Endpoints
| Method | Endpoint               | Description                     |
|--------|------------------------|---------------------------------|
| GET    | `/api/reservas`        | List all reservations           |
| POST   | `/api/reservas`        | Create a new reservation        |
| GET    | `/api/reservas/{id}`   | Get a reservation by ID         |
| PUT    | `/api/reservas/{id}`   | Update a reservation            |
| DELETE | `/api/reservas/{id}`   | Delete a reservation            |

## 🔒 Security
- Planned **JWT** authentication for secure access.
- Validation and error handling to ensure data integrity.

## 🛠️ Technologies Used
- **Language:** C# (.NET Core 8+)
- **Architecture:** Clean Architecture
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **API Documentation:** Swagger (OpenAPI)
- **Identifiers:** GUID

## 🚀 Deployment
Designed to run independently or as part of a larger cloud system.  
Optimized for deployment on **Azure App Service**, **Render.com**, or container-based environments.

## 👨‍💻 Author
Developed by: **Nicoll Sevillano**  
Project: **Reservation Microservice**  
Year: **2025**
