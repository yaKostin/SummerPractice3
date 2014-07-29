using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Investment.Domain.Mappings.Conventions
{
    public class PrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.GeneratedBy.Native();
            instance.Column("Id");
        }
    }
}
