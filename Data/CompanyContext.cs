using Microsoft.EntityFrameworkCore;

namespace Data;

public class CompanyContext(DbContextOptions<CompanyContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
