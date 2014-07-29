using Investment.Config;
using Investment.Domain.Entities;
using System.Collections.Generic;

namespace Investment.Domain.LoadData
{
    public class DBLoader
    {
        public InvestmentDB LoadDB()
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                // Отобразить все магазины
                using (session.BeginTransaction())
                {
                    InvestmentDB db = new InvestmentDB();
                    db.clients = session.CreateCriteria(typeof(Client)).List<Client>();
                    db.securities = session.CreateCriteria(typeof(Security)).SetFetchMode("Rating", NHibernate.FetchMode.Eager).List<Security>();
                    //db.investSecurities = session.CreateCriteria(typeof(InvestSecurity)).SetFetchMode("Client", NHibernate.FetchMode.Eager)
                      //  .SetFetchMode("Security", NHibernate.FetchMode.Eager).List<InvestSecurity>();
                    db.investSecurities = session.CreateCriteria(typeof(InvestSecurity)).List<InvestSecurity>();
                    //var properties = session.CreateCriteria(typeof(PracticeProject.Entities.Property)).List<Entities.Property>();
                    //var ratings = session.CreateCriteria(typeof(Rating)).List<Rating>();
                    //var dep = session.CreateCriteria(typeof(Deposit)).List<Deposit>();
                    //ICriteria criteria = session.CreateCriteria(typeof(Entities.Property));
                    //var a = criteria.Add(Restrictions.Like("Name", "о", MatchMode.Anywhere)).List<Entities.Property>();

                    //var secs = session.CreateCriteria(typeof(Security)).List<Security>();
                    return db;
                }
            }
        }
    }
}
