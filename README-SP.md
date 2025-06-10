📌 Introducción
API de Reservas es un microservicio RESTful diseñado para gestionar el ciclo completo de reservas, 
incluyendo creación, consulta, modificación y eliminación de reservas. Utiliza identificadores 
únicos tipo GUID (UUID v4) para garantizar la unicidad entre microservicios y mejorar la trazabilidad. 
Está pensada para escalar y ser desplegada fácilmente en entornos como Azure y Render, siendo parte de 
una arquitectura moderna basada en microservicios.

🧱 Tecnologías
- Framework: ASP.NET Core
- Base de datos: SQL Server
- Identificadores: GUID como ID universal para recursos
- Autenticación: JWT 
- Despliegue: Azure App Service y Render.com

📋 Endpoints principales
- GET    /api/reservas            # Listar reservas
- POST   /api/reservas            # Crear nueva reserva
- GET    /api/reservas/{id}       # Obtener una reserva por ID
- PUT    /api/reservas/{id}       # Actualizar una reserva
- DELETE /api/reservas/{id}       # Eliminar una reserva


MIT ©NicollSevillano
