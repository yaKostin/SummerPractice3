using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class InvestSecurity
    {
        public virtual Int32 Id { get; set; }
        public virtual Security Security { get; set; }
        //public virtual IList<Security> Security { get; set; }
        public virtual Client Client { get; set; }
        public virtual Decimal Quote { get; set; }
        public virtual DateTime PurchaseTime { get; set; }
        public virtual DateTime SaleTime { get; set; }
    }
}
