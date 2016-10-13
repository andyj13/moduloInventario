using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace moduloInventario
{
    public class SessionNHibernate
    {
        private static ISessionFactory sessionFactory = null;
        private static ISession session = null;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                    sessionFactory = CreateSessionFactory();

                return sessionFactory;
            }
        }

        public static ISession Session
        {
            get { return session; }
        }

        public static ISession OpenSession()
        {
            session = SessionFactory.OpenSession();
            return session;
        }

        public static void CloseSession()
        {
            session.Close();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                string connection = "aki ba la kadena d konexion alv :V";
                var db = MySQLConfiguration.Standard.ConnectionString(connection);

                return Fluently.Configure().Database(db)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SessionNHibernate>())
                    .BuildSessionFactory();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
