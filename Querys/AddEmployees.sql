USE EmployeeDb;
GO

CREATE PROCEDURE AddEmployee
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @ContactNo NVARCHAR(20),
    @Position NVARCHAR(50),
    @Department NVARCHAR(50),
    @Address NVARCHAR(100),
    @AddedBy NVARCHAR(50)
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, Email, ContactNo, Position, Department, Address, AddedBy, AddedAt, IsDeleted)
    VALUES (@FirstName, @LastName, @Email, @ContactNo, @Position, @Department, @Address, @AddedBy, GETUTCDATE(), 0)
END
GO
