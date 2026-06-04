# Issue

EF Projections doesn't work when using interface types

E.g EmployeeType and CustomerType both implements the PersonType which binds the
properties of the common IPerson interface of the Employee and Customer entity
type. The schema contains the fields on both Customer and Employee but HC
returns `null` values in the fields defined in PersonType. This works in Hot
Chocolate 15, but not in version 16

```csharp
public class PersonType : InterfaceType<IPerson>
{
    protected override void Configure(IInterfaceTypeDescriptor<IPerson> descriptor)
    {
        descriptor.Name("Person");
        descriptor.Field(x => x.Id);
        descriptor.Field(x => x.FirstName);
        descriptor.Field(x => x.LastName);
    }
}

public class EmployeeType : ObjectType<Employee>
{
    protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
    {
        descriptor.Implements<PersonType>();
        descriptor.Field(x => x.Email);
    }
}
```

Works in HC 15, not HC 16

```graphql
{
  employees {
    id
    firstName
    lastName
    email
  }
}
```
