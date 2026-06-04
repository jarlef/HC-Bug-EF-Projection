using Data;

namespace HC15.Types;

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
