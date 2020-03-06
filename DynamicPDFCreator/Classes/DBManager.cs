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
        public TblAuftraege auftrag;
        public TblProjekte projekt;
        public List<TblAnsprechpartner> ansprechpartner;
        public object[] ansprechpartnerNamen;
        List<TblAnschreibenTyp> anschreiben;
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
            sessionFactory.Close();
            return session;
        }

        private void closeSession(ISession session, ITransaction tx)
        {
            session.Clear();
            tx.Dispose();
        }

        public void getAuftrag(string smNummer)
        {
            auftrag = new TblAuftraege();
            projekt = new TblProjekte();
            ansprechpartner = new List<TblAnsprechpartner>();;
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<TblAuftraege>();
            crit.SetMaxResults(1);
            crit.Add(Restrictions.Like(nameof(TblAuftraege.SMNummer), smNummer));
            auftrag = crit.List<TblAuftraege>().FirstOrDefault();
            tx.Commit();
            closeSession(session,tx);
            if (auftrag!=null)
            {
                getAnsprechpartner();
            }
            
        }

        private void getProjekt()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            projekt = session.Get<TblProjekte>(auftrag.IdProjekt);
            closeSession(session, tx);
        }

        private void getAnsprechpartner()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<TblAnsprechpartner2Projekt>();
            crit.Add(Restrictions.Like(nameof(TblAnsprechpartner2Projekt.IdProjekt), auftrag.IdProjekt));
            var a2ps = crit.List<TblAnsprechpartner2Projekt>();
            List<int> i=new List<int>();
            foreach (TblAnsprechpartner2Projekt a2p in a2ps)
            {
                i.Add(a2p.IdAnsprechpartner);
            }
            crit = null;
            crit = session.CreateCriteria<TblAnsprechpartner>();
            crit.Add(Restrictions.In(nameof(TblAnsprechpartner.IdAnsprechpartner), i));
            ansprechpartner = (List<TblAnsprechpartner>)crit.List<TblAnsprechpartner>();
            List<string> ansp = new List<string>();
            //Object in String umwandeln
            foreach (TblAnsprechpartner an in ansprechpartner)
            {
                ansp.Add(an.AnsprechpartnerVorname+" "+an.AnsprechpartnerName);
            }
            ansprechpartnerNamen = ansp.Cast<object>().ToArray();
            closeSession(session, tx);
        }

        private void getAnschreibenTyp()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<TblAnschreibenTyp>();
           
            List<TblAnschreibenTyp> anschreiben = (List<TblAnschreibenTyp>) crit.List<TblAnschreibenTyp>();

            closeSession(session, tx);

        }
    }
}
