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
        public List<TblAnschreibenTyp> anschreiben;
        public object[] anschreibenNamen;
        public List<TblBearbeiter> bearbeiter;
        public object[] bearbeiterNamen;
        public List<TblWesiTeam> wesiTeam;
        public object[] wesiTeamNamen;

        public DBManager()
        {
            getAnschreibenTyp();
            getBearbeiter();
            getWesiTeam();
        }
        public DBManager(string smNummer)
        {
            try
            {
                getAuftrag(smNummer);
                if (auftrag!=null)
                {
                    getProjekt();
                    getAnsprechpartner();
                    getAnschreibenTyp();
                    getBearbeiter();
                    getWesiTeam();
                }
            }
            catch (Exception e) { }
        }

        //braucht SMNummer
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
        }

        //braucht Auftrag
        private void getProjekt()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            projekt = session.Get<TblProjekte>(auftrag.IdProjekt);
            closeSession(session, tx);
        }

        //braucht Projekt
        private void getAnsprechpartner()
        {
            //session holen
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            //Datensätze mit der Projekt ID
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
                if (an.AnsprechpartnerVorname == null && an.AnsprechpartnerName == null)
                {
                    if (an.Firma != "")
                    {
                        ansp.Add(an.Firma);
                    }
                }
                else
                {
                    ansp.Add(an.AnsprechpartnerVorname + " " + an.AnsprechpartnerName);
                }
                
            }
            ansprechpartnerNamen = ansp.Cast<object>().ToArray();
            closeSession(session, tx);
        }

        //immer verfügbar
        private void getAnschreibenTyp()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<TblAnschreibenTyp>();
           
            anschreiben = (List<TblAnschreibenTyp>) crit.List<TblAnschreibenTyp>();
            
            List<string> anschr = new List<string>();
            //Object in String umwandeln
            foreach (TblAnschreibenTyp an in anschreiben)
            {
                anschr.Add(an.Bezeichnung);
            }
            anschreibenNamen = anschr.Cast<object>().ToArray();

            closeSession(session, tx);

        }

        //immer verfügbar
        private void getBearbeiter()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<TblBearbeiter>();
            crit.Add(Restrictions.IsNotNull("BearbeiterVorname"));
            bearbeiter = (List<TblBearbeiter>)crit.List<TblBearbeiter>();

            List<string> bearb = new List<string>();
            //Object in String umwandeln
            foreach (TblBearbeiter an in bearbeiter)
            {
                    bearb.Add(an.BearbeiterVorname + " " + an.BearbeiterName);
            }
            bearbeiterNamen = bearb.Cast<object>().ToArray();

            closeSession(session, tx);
        }

        //immer verfügbar
        private void getWesiTeam()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<TblWesiTeam>();
            wesiTeam = (List<TblWesiTeam>)crit.List<TblWesiTeam>();

            List<string> wesi = new List<string>();
            //Object in String umwandeln
            foreach (TblWesiTeam an in wesiTeam)
            {
                wesi.Add($"{an.Firma} {an.Niederlassung}");
            }
            wesiTeamNamen = wesi.Cast<object>().ToArray();


            closeSession(session, tx);
        }

        public void set(TblAnsprechpartner a)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(a);
            tx.Commit();
            closeSession(session, tx);
        }
        public void set(TblWesiTeam a)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(a);
            tx.Commit();
            closeSession(session, tx);
        }
        #region Session
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
        #endregion
    }
}
