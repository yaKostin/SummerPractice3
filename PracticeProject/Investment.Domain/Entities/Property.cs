using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Testing;

namespace Investment.Domain.Entities
{
    public class Property
    {
        public virtual Int32 Id { get; protected set; }
        public virtual String Name { get; set; }
        public virtual IList<Client> ClientsWithProperty { get; set; }

        public Property()
        {
            ClientsWithProperty = new List<Client>();
        }

        public virtual void AddClient(Client client)
        {
            client.Property  = this;
            ClientsWithProperty.Add(client);
        }
    }
}
