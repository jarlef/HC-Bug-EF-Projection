using Data;

namespace HC16.Types;

public class EmployeeType : ObjectType<Employee>
{
    protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
    {
        descriptor.Implements<PersonType>();
        descriptor.Field(x => x.Email);
    }
}
