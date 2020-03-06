using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DynamicPDFCreator
{
    class DBManager
    {
        public void Main()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();

            var session = sessionFactory.OpenSession();
            var tx = session.BeginTransaction();

            TblAnschreibenTyp anschreiben = session.Get<TblAnschreibenTyp>(Convert.ToInt16(1));
            tx.Commit();

            Console.WriteLine(anschreiben.Bezeichnung);
        }

        private ISession getSession()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();
            return session;
        }

        public void getAuftrag(string smNummer)
        {
            TblAuftraege auftrag;
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<TblAuftraege>();
            crit.SetMaxResults(1);
            crit.Add(Restrictions.Like(nameof(TblAuftraege.SMNummer), smNummer));
            auftrag = crit.List<TblAuftraege>().FirstOrDefault();

        }
    }
}
