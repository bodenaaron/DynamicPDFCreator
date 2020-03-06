using NHibernate.Cfg;
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
    }
}
