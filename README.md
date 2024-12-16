# Restaurant Reservation API
# Overview
<p>
  The Restaurant Reservation API is built with ASP.NET Core Web API to handle restaurant reservations, employees, customers, and menu items. This API provides endpoints for CRUD operations, reservation-specific features, and additional methods to streamline restaurant management.
</p>

# Features
CRUD operations for entities: Reservations, Customers, Employees, and Menu Items.<br>

Specific endpoints for reservation management:<br>

Retrieve reservations by customer ID.<br>

List menu items for a reservation.<br>

Authorization using JWT tokens.<br>

Validation and error handling for all input.<br>

Auto-generated API documentation with Swagger.<br>

Comprehensive testing using Postman.

# Getting Started

## Prerequisites
<p>
.NET SDK (version 7.0 or higher) <br>

Visual Studio, JetBrains Rider, or any preferred IDE.<br>

Postman for API testing.<br>

SQL Server for database.<br>
  
</p>

# Installation Steps
1.Clone the repository:<br>

git clone https://github.com/your-username/restaurant-reservation-api.git<br>

2.Navigate to the project directory:<br>

cd restaurant-reservation-api<br>

3.Restore NuGet packages:<br>

dotnet restore<br>

4.Build the project:<br>

dotnet build<br>

5.Update the connection string in appsettings.json to point to your SQL Server instance:<br>

"ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=RestaurantDB;Trusted_Connection=True;"
}<br>

6.Apply database migrations:<br>

dotnet ef database update<br>

7.Run the application:<br>
dotnet run <br>

# API Endpoints

## General Endpoints
Swagger Documentation: https://localhost:5000/swagger<br>

## Customer Endpoints
GET /api/GetReservationsByCustomer - Retrieve all customers.<br>

POST /api - Add a new customer.<br>

PUT /api/{id} - Update a customer.<br>

DELETE /api/{id} - Delete a customer.<br>

## Reservation Endpoints

GET /api/reservations/customer/{customerId} - Retrieve reservations by customer ID.<br>

GET /api/reservations/{reservationId}/menu-items - List ordered menu items for a reservation.<br>

## Employee Endpoints
GET /api/employees/managers - List all managers.<br>

GET /api/employees/{employeeId}/average-order-amount - Calculate average order amount for an employee.<br>

# Authorization
The API uses JWT tokens for authorization. To access secured endpoints:<br>

Authenticate using the login endpoint (e.g., POST /api/auth/login).<br>

Include the JWT token in the Authorization header for subsequent requests:<br>

Authorization: Bearer <your-token><br>

# Testing
## Manual Testing
Use Postman or Swagger UI to manually test all endpoints.
