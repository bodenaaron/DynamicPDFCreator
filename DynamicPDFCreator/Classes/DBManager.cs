using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DynamicPDFCreator
{
    class DBManager
    {
        public Auftrag auftrag;        
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

            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var logger = (Logger)hierarchy.GetLogger("NHibernate.SQL");
            logger.AddAppender(new TraceAppender { Layout = new SimpleLayout() });
            hierarchy.Configured = true;
            logger.Level = Level.Debug;
        }
        public DBManager(string smNummer)
        {
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var logger = (Logger)hierarchy.GetLogger("NHibernate.SQL");
            logger.AddAppender(new TraceAppender { Layout = new SimpleLayout() });
            hierarchy.Configured = true;
            logger.Level = Level.Debug;
            try
            {
                getAuftrag(smNummer);
                if (auftrag!=null)
                {
                    getAnsprechpartnerTyp();
                    //getProjekt();
                    //getAnsprechpartner();
                    getAnschreibenTyp();
                    getBearbeiter();
                    getWesiTeam();
                }
            }
            catch (Exception e) { Debug.WriteLine("\n\n\n"+smNummer+ "\n\n\n"); }
        }

        //braucht SMNummer
        public void getAuftrag(string smNummer)
        {
            auftrag = new Auftrag();
            ansprechpartner = new List<Ansprechpartner>();;
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<Auftrag>();            
            crit.Add(Expression.Like(nameof(Auftrag.smNummer), "%"+smNummer+"%"));
            auftrag = crit.List<Auftrag>().FirstOrDefault();
            Debug.WriteLine(session.Connection.ConnectionString);
            Debug.WriteLine("\n\n\n"+smNummer +" JA "+auftrag.smNummer+ "\n\n\n");
            tx.Commit();
            //closeSession(session,tx);
        }

        #region altlasten
        //braucht Auftrag
        /*private void getProjekt()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            projekt = session.Get<Projekt>(auftrag.projekt.id);
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
            crit.Add(Restrictions.Like(nameof(Ansprechpartner2Projekt.IdProjekt), auftrag.projekt.id));
            var a2ps = crit.List<Ansprechpartner2Projekt>();

            List<int> i=new List<int>();
            foreach (Ansprechpartner2Projekt a2p in a2ps)
            {
                i.Add(a2p.IdAnsprechpartner);
            }
            crit = null;

            crit = session.CreateCriteria<Ansprechpartner>();
            crit.Add(Restrictions.In(nameof(Ansprechpartner.id), i));
            ansprechpartner = (List<Ansprechpartner>)crit.List<Ansprechpartner>();

            List<string> ansp = new List<string>();
            //Object in String umwandeln
            foreach (Ansprechpartner an in ansprechpartner)
            {
                if (an.ansprechpartnerVorname == null && an.ansprechpartnerName == null|| an.ansprechpartnerVorname == "" && an.ansprechpartnerName == "")
                {
                    if (an.firma != "")
                    {
                        ansp.Add(an.firma);
                    }
                }
                else
                {
                    ansp.Add(an.ansprechpartnerVorname + " " + an.ansprechpartnerName);
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

        }*/
        #endregion


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
            //crit.Add(Restrictions.IsNotNull("Bearbeiter_Vorname"));
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

        public void sqlSchema()
        {
            
            new SchemaExport(new Configuration().Configure()).SetOutputFile(@"C:\Users\Boden_Aaron\source\repos\DynamicPDFCreator\DynamicPDFCreator\schema.sql").Execute(true, false, false);
            
        }
    }
}
