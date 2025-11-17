# Employee Manager Backend

This is the backend for the **Employee Manager** application. It provides a RESTful API to **create**, **update**, **view**, and **delete** employees using **stored procedures** in SQL Server. Built with **.NET 8**, **C#**, and **Entity Framework Core**, it connects to a SQL Server database to execute all data operations through stored procedures instead of direct table queries.

---


## Features

- Create a new employee  
- Update existing employee information  
- View employee details  
- Delete employees (soft delete)  
- View all employees  

---

## Technologies

- **Backend:** .NET 8, C#, Entity Framework Core  
- **Database:** SQL Server / MSSQL  

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
- SQL Server (LocalDB or full version)  
- Visual Studio 2022 or VS Code  

---

## Setup Instructions

1. **Clone the repository**

```bash
git clone https://github.com/dianesophia/Employee-Manager-App---Backend.git
cd Employee-Manager-App---Backend
```

---

2. **Configure Database**
Edit the `appsettings.json` file to match your SQL Server setup:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EmployeeDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
---
3. **Create the Database**

Using Package Manager Console in Visual Studio:

```bash
Add-Migration InitialCreate
Update-Database
```

---
4. **Run the Backend**

Run the Backend
```bash
dotnet run
```
## The API will be available at:
The API will be available at:
```bash
https://localhost:7175/api/Employee
```


## Notes

Stored Procedures: All CRUD operations are executed via stored procedures for security and maintainability.

Do Not Run EF Core Migrations if you deleted the Migrations folder or rely solely on stored procedures, as it may overwrite tables or break procedures.

Ensure SQL Server is running before starting the backend.

Include any SQL scripts required to create tables and stored procedures when sharing the project.
