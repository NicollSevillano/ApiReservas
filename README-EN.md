📌 Introduction
Reservation API is a RESTful microservice designed to manage the full reservation lifecycle, 
including creation, retrieval, update, and deletion of bookings. It uses INT as 
unique identifiers to ensure consistency across microservices and improve traceability. 
Built with scalability in mind, this service is optimized for deployment in cloud environments 
such as Azure and Render, as part of a modern microservices architecture.

🧱 Technologies
- Framework: ASP.NET Core
- Database: SQL Server
- Identifiers: INT as universal resource IDs
- Authentication: JWT
- Deployment: Azure App Service & Render.com

📋 Main Endpoints
- GET    /api/reservas            # List all reservations  
- POST   /api/reservas            # Create a new reservation  
- GET    /api/reservas/{id}       # Get a reservation by ID  
- PUT    /api/reservas/{id}       # Update a reservation  
- DELETE /api/reservas/{id}       # Delete a reservation  

MIT © NicollSevillano

