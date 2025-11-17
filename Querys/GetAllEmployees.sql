USE EmployeeDb;
GO

CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE IsDeleted = 0
END
GO
