using System.Collections.Generic;
using Investment.Domain.Entities;

namespace Investment.Domain.LoadData
{
    public class InvestmentDB
    {
        public IList<Client> clients { get; set; }
        public IList<Security> securities { get; set; }
        public IList<Rating> ratings { get; set; }
        public IList<Property> properties { get; set; }
        public IList<InvestSecurity> investSecurities { get; set; }
    }
}
