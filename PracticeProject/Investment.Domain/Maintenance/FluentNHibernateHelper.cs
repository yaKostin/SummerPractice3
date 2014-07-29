using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using FluentNHibernate.Automapping;
using Investment.Domain.Entities;
using Investment.Domain.Mappings;
using Investment.Domain.Mappings.Conventions;
namespace Investment.Config
{
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
          get
          {
            if(_sessionFactory == null)
            {
                var dbConfig = MySQLConfiguration.Standard.ConnectionString(
                    c => c.FromConnectionStringWithKey("ConnectionString")
                    );
                  //.ShowSql();
              try
              {
                  ModelGenerator modelGenerator = new ModelGenerator();
                  _sessionFactory = Fluently.Configure()
                    .Database(dbConfig)
                      //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Property>())
                      .Mappings(m => m.AutoMappings.Add(modelGenerator.Generate()))
                    .BuildSessionFactory();
              }
              catch (FluentConfigurationException e)
              { }
            }
            return _sessionFactory;
          }
        }

        public static ISession OpenSession()
        {
          return SessionFactory.OpenSession();
        }
    }
}

