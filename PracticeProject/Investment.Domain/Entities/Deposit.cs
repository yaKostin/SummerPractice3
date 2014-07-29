using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class Deposit
    {
        public virtual Int32 Id { get; set; }
        public virtual Decimal Rate { get; set; }
        public virtual Int32 Duration { get; set; }
        public virtual Decimal MinBet { get; set; }
    }
}
