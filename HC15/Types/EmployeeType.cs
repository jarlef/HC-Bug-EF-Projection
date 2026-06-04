using Data;

namespace HC15.Types;

public class EmployeeType : ObjectType<Employee>
{
    protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
    {
        descriptor.Implements<PersonType>();
        descriptor.Field(x => x.Email);
    }
}
