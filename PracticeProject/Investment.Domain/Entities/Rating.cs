using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Domain.Entities
{
    public class Rating
    {
        public virtual Int32 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual IList<Security> SecurityWithRating { get; set; }

        public Rating()
        {
            SecurityWithRating = new List<Security>();
        }

        public virtual void AddSecurity(Security security)
        {
            security.Rating  = this;
            SecurityWithRating.Add(security);
        }
    }
}
