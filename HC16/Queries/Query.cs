using Data;

namespace HC16.Types;

[QueryType]
public static partial class Query
{
    [UseProjection]
    public static IQueryable<Employee> GetEmployees(CompanyContext companyContext)
    {
        return companyContext.Employees;
    }

    [UseProjection]
    public static IQueryable<Customer> GetCustomers(CompanyContext companyContext)
    {
        return companyContext.Customers;
    }
}
