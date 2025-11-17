USE EmployeeDb;
GO

CREATE PROCEDURE UpdateEmployee
    @Id INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @ContactNo NVARCHAR(20),
    @Position NVARCHAR(50),
    @Department NVARCHAR(50),
    @Address NVARCHAR(100),
    @UpdatedBy NVARCHAR(50)
AS
BEGIN
    UPDATE Employees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        ContactNo = @ContactNo,
        Position = @Position,
        Department = @Department,
        Address = @Address,
        UpdatedBy = @UpdatedBy,
        UpdatedAt = GETUTCDATE()
    WHERE Id = @Id
END
GO
