using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class Client
    {
        public virtual Int32 Id { get; set; }
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual Property Property { get; set; }
        public virtual String Address { get; set; }
        public virtual String TelNum { get; set; }

        public virtual IList<InvestSecurity> Investmenst { get; set; }
    }
}
