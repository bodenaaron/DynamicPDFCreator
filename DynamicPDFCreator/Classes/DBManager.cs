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
        public Auftrag auftrag;
        public Projekt projekt;
        public List<Ansprechpartner> ansprechpartner;
        public object[] ansprechpartnerNamen;
        public List<AnschreibenTyp> anschreiben;
        public object[] anschreibenNamen;
        public List<Bearbeiter> bearbeiter;
        public object[] bearbeiterNamen;
        public List<WesiTeam> wesiTeam;
        public object[] wesiTeamNamen;
        public List<AnsprechpartnerTyp> ansprechpartnerTyp;
        public object[] ansprechpartnerTypNamen;

        public DBManager()
        {
            getAnschreibenTyp();
            getAnsprechpartnerTyp();
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
                    getAnsprechpartnerTyp();
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
            auftrag = new Auftrag();
            projekt = new Projekt();
            ansprechpartner = new List<Ansprechpartner>();;
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<Auftrag>();
            crit.SetMaxResults(1);
            crit.Add(Restrictions.Like(nameof(Auftrag.SMNummer), smNummer));
            auftrag = crit.List<Auftrag>().FirstOrDefault();
            tx.Commit();
            closeSession(session,tx);
        }

        //braucht Auftrag
        private void getProjekt()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            projekt = session.Get<Projekt>(auftrag.IdProjekt);
            closeSession(session, tx);
        }

        //braucht Projekt
        private void getAnsprechpartner()
        {
            //session holen
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            //Datensätze mit der Projekt ID
            ICriteria crit = session.CreateCriteria<Ansprechpartner2Projekt>();
            crit.Add(Restrictions.Like(nameof(Ansprechpartner2Projekt.IdProjekt), auftrag.IdProjekt));
            var a2ps = crit.List<Ansprechpartner2Projekt>();

            List<int> i=new List<int>();
            foreach (Ansprechpartner2Projekt a2p in a2ps)
            {
                i.Add(a2p.IdAnsprechpartner);
            }
            crit = null;

            crit = session.CreateCriteria<Ansprechpartner>();
            crit.Add(Restrictions.In(nameof(Ansprechpartner.IdAnsprechpartner), i));
            ansprechpartner = (List<Ansprechpartner>)crit.List<Ansprechpartner>();

            List<string> ansp = new List<string>();
            //Object in String umwandeln
            foreach (Ansprechpartner an in ansprechpartner)
            {
                if (an.AnsprechpartnerVorname == null && an.AnsprechpartnerName == null|| an.AnsprechpartnerVorname == "" && an.AnsprechpartnerName == "")
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

            ICriteria crit = session.CreateCriteria<AnschreibenTyp>();
           
            anschreiben = (List<AnschreibenTyp>) crit.List<AnschreibenTyp>();
            
            List<string> anschr = new List<string>();
            //Object in String umwandeln
            foreach (AnschreibenTyp an in anschreiben)
            {
                anschr.Add(an.bezeichnung);
            }
            anschreibenNamen = anschr.Cast<object>().ToArray();

            closeSession(session, tx);

        }
        private void getAnsprechpartnerTyp()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<AnsprechpartnerTyp>();

            ansprechpartnerTyp = (List<AnsprechpartnerTyp>)crit.List<AnsprechpartnerTyp>();

            List<string> ansprTyp = new List<string>();
            //Object in String umwandeln
            foreach (AnsprechpartnerTyp an in ansprechpartnerTyp)
            {
                ansprTyp.Add(an.Typ);
            }
            ansprechpartnerTypNamen = ansprTyp.Cast<object>().ToArray();

            closeSession(session, tx);

        }

        //immer verfügbar
        private void getBearbeiter()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Bearbeiter>();
            crit.Add(Restrictions.IsNotNull("BearbeiterVorname"));
            bearbeiter = (List<Bearbeiter>)crit.List<Bearbeiter>();

            List<string> bearb = new List<string>();
            //Object in String umwandeln
            foreach (Bearbeiter an in bearbeiter)
            {
                    bearb.Add(an.bearbeiterVorname + " " + an.bearbeiterName);
            }
            bearbeiterNamen = bearb.Cast<object>().ToArray();

            closeSession(session, tx);
        }

        //immer verfügbar
        private void getWesiTeam()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<WesiTeam>();
            wesiTeam = (List<WesiTeam>)crit.List<WesiTeam>();

            List<string> wesi = new List<string>();
            //Object in String umwandeln
            foreach (WesiTeam an in wesiTeam)
            {
                wesi.Add($"{an.Firma} {an.Niederlassung}");
            }
            wesiTeamNamen = wesi.Cast<object>().ToArray();


            closeSession(session, tx);
        }

        public void testSave(PDF a)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(a);
            tx.Commit();
            closeSession(session, tx);
        }
        public void set(Ansprechpartner a)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(a);
            tx.Commit();
            closeSession(session, tx);
        }
        public void set(WesiTeam a)
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
