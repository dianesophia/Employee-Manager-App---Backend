USE EmployeeDb;
GO

CREATE PROCEDURE DeleteEmployee
    @Id INT
AS
BEGIN
    UPDATE Employees
    SET IsDeleted = 1
    WHERE Id = @Id
END
GO
