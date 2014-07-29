using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class QuoteHistory
    {
        public virtual Int32 Id { get; set; }
        public virtual Security Security { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual Decimal Quote { get; set; }
    }
}
