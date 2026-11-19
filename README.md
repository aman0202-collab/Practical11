# Practical 11 - Smart Campus Service Portal

**Aim:** Develop Smart Campus Service Portal - Feature Extension (Integrate MVC + Database + API). Students can create campus service requests (IT Support, Library, Maintenance, Transport), view all requests, and update their status. The same data is also exposed through a Web API.

## Technology

- ASP.NET MVC 5 (.NET Framework 4.8)
- ASP.NET Web API 2 (integrated in the same project)
- ADO.NET (SqlConnection, SqlCommand, SqlDataReader) through a DAL class
- SQL Server LocalDB - database `SmartCampusDB`, table `ServiceRequests`

## How It Fits Together

- **Models/ServiceRequest.cs** - the request model (matches the table)
- **DAL/ServiceRequestDAL.cs** - all database operations: GetAll, Insert, UpdateStatus
- **Controllers/ServiceRequestController.cs** - MVC pages: Index, Create, UpdateStatus
- **Controllers/ServiceApiController.cs** - Web API: GET and POST `api/ServiceApi`, PUT `api/ServiceApi/UpdateStatus/{id}`

## Steps to Run

1. Run `SmartCampusDB.sql` in SQL Server Management Studio (SSMS) to create the database, table and sample data.
2. Open `Practical11/Practical11.sln` in Visual Studio 2022.
3. Right-click the solution and choose **Restore NuGet Packages** (first time only).
4. Press **F5** - the portal opens on the service request list.
