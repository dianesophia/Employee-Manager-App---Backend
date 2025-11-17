using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Employee_Manager_System_App.Model;

namespace Employee_Manager_System_App.Services
{
    public class EmployeeService
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeService(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get all employees
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _dbContext.Employees
                .FromSqlRaw("EXEC GetAllEmployees")
                .ToListAsync();
        }

        // Add new employee
        public async Task AddEmployeeAsync(Employee employee)
        {
            var parameters = new[]
            {
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@Email", employee.Email ?? string.Empty),
                new SqlParameter("@ContactNo", employee.ContactNo),
                new SqlParameter("@Position", employee.Position ?? string.Empty),
                new SqlParameter("@Department", employee.Department ?? string.Empty),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@AddedBy", employee.AddedBy ?? "Admin")
            };

            await _dbContext.Database.ExecuteSqlRawAsync(
                "EXEC AddEmployee @FirstName, @LastName, @Email, @ContactNo, @Position, @Department, @Address, @AddedBy",
                parameters
            );
        }

        // Update employee
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            var parameters = new[]
            {
                new SqlParameter("@Id", employee.Id),
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@Email", employee.Email ?? string.Empty),
                new SqlParameter("@ContactNo", employee.ContactNo),
                new SqlParameter("@Position", employee.Position ?? string.Empty),
                new SqlParameter("@Department", employee.Department ?? string.Empty),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@UpdatedBy", employee.UpdatedBy ?? "Admin")
            };

            await _dbContext.Database.ExecuteSqlRawAsync(
                "EXEC UpdateEmployee @Id, @FirstName, @LastName, @Email, @ContactNo, @Position, @Department, @Address, @UpdatedBy",
                parameters
            );
        }

        // Delete employee
        public async Task DeleteEmployeeAsync(int id)
        {
            var param = new SqlParameter("@Id", id);
            await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteEmployee @Id", param);
        }
    }
}
