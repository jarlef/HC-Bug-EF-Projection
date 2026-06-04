namespace Data;

public static class CompanySeeder
{
    public static async Task Seed(
        this CompanyContext companyContext,
        CancellationToken stoppingToken
    )
    {
        var created = await companyContext.Database.EnsureCreatedAsync(stoppingToken);

        if (!created)
        {
            return;
        }

        var sales = new Department { Id = Guid.NewGuid(), Name = "Sales" };
        var hr = new Department { Id = Guid.NewGuid(), Name = "Administration" };
        companyContext.Departments.Add(sales);
        companyContext.Departments.Add(hr);

        var karen = new Employee()
        {
            Id = Guid.NewGuid(),
            FirstName = "Karen",
            LastName = "Smith",
            Department = hr,
            Email = "karen@company.com",
            Password = "SuperSecretPassword",
        };

        var scott = new Employee()
        {
            Id = Guid.NewGuid(),
            FirstName = "Scott",
            LastName = "Hanson",
            Department = sales,
            Email = "scott@company.com",
            Password = "123",
        };

        companyContext.Employees.Add(scott);
        companyContext.Employees.Add(karen);

        companyContext.Customers.Add(
            new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Travis",
                LastName = "Smith",
            }
        );

        await companyContext.SaveChangesAsync(stoppingToken);
    }
}
