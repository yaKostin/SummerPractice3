using FluentNHibernate.Automapping;
using System.Reflection;
using Investment.Domain.Entities;
using Investment.Domain.Mappings.Conventions;

namespace Investment.Domain.Mappings
{
    public class ModelGenerator
    {
        public AutoPersistenceModel Generate()
        {
            AutoPersistenceModel automap = new AutoPersistenceModel();
 
            automap.Conventions.AddFromAssemblyOf<ModelGenerator>();
            automap.UseOverridesFromAssemblyOf<ModelGenerator>();
            automap.AddEntityAssembly(Assembly.GetAssembly(typeof (Client)))
                .Where(x=>x.Namespace.EndsWith("Entities"));
            return automap;
         }
    }
}
