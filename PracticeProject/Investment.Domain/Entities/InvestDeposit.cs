using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class InvestDeposit
    {
        public virtual Int32 Id { get; set; }
        public virtual IList<Deposit> Deposite { get; set; }
        public virtual Client Client { get; set; }
        public virtual Decimal Amount { get; set; }
        public virtual DateTime OpenDate { get; set; }
        public virtual DateTime CloseDate { get; set; }

    }
}
