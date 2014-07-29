using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Automapping;
using Investment.Domain.Entities;

namespace Investment.Domain.Mappings
{
    public class ClientMapOverride : IAutoMappingOverride<Client>
    {
        public void Override(AutoMapping<Client> mapping)
        {
            mapping.References(x => x.Property)
                .Not.LazyLoad();

            mapping.HasMany(x => x.Investmenst)
                //.Table("InvestSecurity")
                .Not.LazyLoad();
        }
    }
}
