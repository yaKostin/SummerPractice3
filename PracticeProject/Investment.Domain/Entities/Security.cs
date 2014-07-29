using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class Security
    {
        public virtual Int32 Id { get; set; }
        public virtual Decimal MinTransaction { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Decimal Revenue { get; set; }
        public virtual String Info { get; set; }
    }
}
