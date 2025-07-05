# 📌 Microservicio de Reservas
Este proyecto es un **microservicio RESTful** diseñado para gestionar todo el ciclo de vida de las reservas:  
creación, consulta, actualización y eliminación.  
Sigue principios de **Clean Architecture**, utilizando **ASP.NET Core**, **Entity Framework Core** y **SQL Server** como base de datos.  
Cada recurso utiliza identificadores **GUID** para garantizar unicidad global y soporte para sistemas distribuidos.

## ⚽ Funcionalidades Principales
- Crear, ver, actualizar y eliminar reservas.
- Gestionar clientes vinculados a las reservas.
- Identificadores **GUID** para trazabilidad única.
- Diseñado para ejecutarse como microservicio aislado dentro de una arquitectura mayor.
- Principios de **Clean Architecture** para separación clara de responsabilidades.

## 🧱 Capas del Sistema
| Capa             | Descripción                                                |
|------------------|------------------------------------------------------------|
| **API**          | Expone endpoints RESTful para sistemas externos.           |
| **Application**  | Contiene casos de uso, DTOs, interfaces y validadores.     |
| **Domain**       | Define entidades del dominio y reglas de negocio principales. |
| **Infrastructure** | Implementa repositorios, DbContext y conexiones externas.  |

## 🗃️ Base de Datos
- **Tipo:** Base de datos relacional (**SQL Server**)
- **Modelos:**  
  - **Cliente:** Nombre, teléfono, email, dirección y reservas relacionadas.
  - **Reserva:** Referencia de cliente, fecha, tipo de reserva y precio.
- **Relación:** Un **Cliente** puede tener muchas **Reservas** (**1:N**).

## 📌 Endpoints Principales
| Método | Endpoint               | Descripción                        |
|--------|------------------------|------------------------------------|
| GET    | `/api/reservas`        | Listar todas las reservas          |
| POST   | `/api/reservas`        | Crear una nueva reserva            |
| GET    | `/api/reservas/{id}`   | Obtener una reserva por ID         |
| PUT    | `/api/reservas/{id}`   | Actualizar una reserva             |
| DELETE | `/api/reservas/{id}`   | Eliminar una reserva               |

## 🔒 Seguridad
- Autenticación **JWT** planificada para acceso seguro a la API.
- Validación y manejo de errores para garantizar la integridad de datos.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C# (.NET Core 8+)
- **Arquitectura:** Clean Architecture
- **ORM:** Entity Framework Core
- **Base de Datos:** SQL Server
- **Documentación API:** Swagger (OpenAPI)
- **Identificadores:** GUID

## 🚀 Despliegue
Diseñado para ejecutarse de forma independiente o como parte de una arquitectura cloud mayor.  
Optimizado para desplegarse en **Azure App Service**, **Render.com** o entornos basados en contenedores.

## 👨‍💻 Autor
Desarrollado por: **Nicoll Sevillano**  
Proyecto: **Microservicio de Reservas**  
Año: **2025**