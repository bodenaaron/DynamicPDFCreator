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
        public WorkingPDF dbPDF;    

        public DBManager()
        {
            dbPDF = new WorkingPDF();
            getMetaDaten();

            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var logger = (Logger)hierarchy.GetLogger("NHibernate.SQL");
            logger.AddAppender(new TraceAppender { Layout = new SimpleLayout() });
            hierarchy.Configured = true;
            logger.Level = Level.Debug;
        }
        public DBManager(string smNummer)
        {
            dbPDF = new WorkingPDF();
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var logger = (Logger)hierarchy.GetLogger("NHibernate.SQL");
            logger.AddAppender(new TraceAppender { Layout = new SimpleLayout() });
            hierarchy.Configured = true;
            logger.Level = Level.Debug;
            try
            {
                getMetaDaten();
                getAuftrag(smNummer);
            }
            catch (Exception e) { Debug.WriteLine("\n\n\n"+smNummer+ "\n\n\n"); }
        }

        //braucht SMNummer
        public void getAuftrag(string smNummer)
        {   
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<Auftrag>();            
            crit.Add(Expression.Like(nameof(Auftrag.smNummer), "%"+smNummer+"%"));
            dbPDF.auftrag = crit.List<Auftrag>().FirstOrDefault();
            tx.Commit();
            dbPDF.dic_Ansprechpartner = new Dictionary<string, Ansprechpartner>();
            //Object in String umwandeln
            foreach (Ansprechpartner an in dbPDF.auftrag.projekt.ansprechpartner)
            {
                if (an.ansprechpartnerVorname == null && an.ansprechpartnerName == null || an.ansprechpartnerVorname == "" && an.ansprechpartnerName == "")
                {
                    if (an.firma != "")
                    {
                       dbPDF.dic_Ansprechpartner.Add(an.firma,an);
                    }
                }
                else
                {
                   dbPDF.dic_Ansprechpartner.Add(an.ansprechpartnerVorname + " " + an.ansprechpartnerName,an);
                }

            }
            
            getAnsprechpartnerTyp();
            getPDFs();
            closeSession(session, tx);
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
            pdf.ansprechpartnerStringList = ansprTyp.Cast<object>().ToArray();

            closeSession(session, tx);

        }
        public void sqlSchema()
        {
            
            new SchemaExport(new Configuration().Configure()).SetOutputFile(@"C:\Users\Boden_Aaron\source\repos\DynamicPDFCreator\DynamicPDFCreator\schema.sql").Execute(true, false, false);
            
        }
        */
        #endregion
        //immer verfügbar
        private void getAnschreibenTyp()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<AnschreibenTyp>();
           
            dbPDF.anschreiben = (List<AnschreibenTyp>) crit.List<AnschreibenTyp>();
            dbPDF.dic_AnschreibenTyp = new Dictionary<string, AnschreibenTyp>();
            //Object in String umwandeln
            foreach (AnschreibenTyp an in dbPDF.anschreiben)
            {
               dbPDF.dic_AnschreibenTyp.Add(an.bezeichnung,an);
            }
            

            closeSession(session, tx);

        }

        //immer verfügbar
        private void getBearbeiter()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Bearbeiter>();
            crit.Add(Restrictions.IsNotNull("bearbeiterVorname"));
            dbPDF.bearbeiter = (List<Bearbeiter>)crit.List<Bearbeiter>();
            dbPDF.dic_Bearbeiter = new Dictionary<string, Bearbeiter>();
            //Object in String umwandeln
            foreach (Bearbeiter an in dbPDF.bearbeiter)
            {
                   dbPDF.dic_Bearbeiter.Add(an.bearbeiterVorname + " " + an.bearbeiterName,an);
            }
            

            closeSession(session, tx);
        }

        //immer verfügbar
        private void getWesiTeam()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<WesiTeam>();
            dbPDF.wesiTeams = (List<WesiTeam>)crit.List<WesiTeam>();
            dbPDF.dic_WesiTeam = new Dictionary<string, WesiTeam>();
            foreach (WesiTeam an in dbPDF.wesiTeams)
            {
                dbPDF.dic_WesiTeam.Add($"{an.firma} {an.niederlassung}",an);
            }
            


            closeSession(session, tx);
        }

        public void savePDF(PDF a)
        {
            a.id =a.anschreibenTyp.id.ToString()+ a.empfaenger.id.ToString();
            foreach (Zusatzanlage z in a.tblZusatzanlagen)
            {
                z.idPDF = a.id;
            }
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

        /// <summary>
        /// Methode, welche Daten von der Datenbank ausließt, die SMNummer unabhängig sind
        /// getAnschreibenTyp()
        /// getBearbeiter()
        /// getWesiTeam()
        /// </summary>
        private void getMetaDaten()
        {
            getAnschreibenTyp();
            getBearbeiter();
            getWesiTeam();
        }


        private void getAnsprechpartnerTyp()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            Debug.WriteLine("\n\n\n\n"+session.Connection.ConnectionString);
            ICriteria crit = session.CreateCriteria<AnsprechpartnerTyp>();
            dbPDF.ansprechpartnerTypen = (List<AnsprechpartnerTyp>)session.CreateCriteria<AnsprechpartnerTyp>().List<AnsprechpartnerTyp>();
            dbPDF.dic_ansprechpartnerTypen = new Dictionary<string, AnsprechpartnerTyp>();
            //Object in String umwandeln
            foreach (AnsprechpartnerTyp an in dbPDF.ansprechpartnerTypen)
            {
               dbPDF.dic_ansprechpartnerTypen.Add(an.id.ToString(),an);
            }
           

            closeSession(session, tx);

        }

        private void getPDFs()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            dbPDF.dic_pdf = new Dictionary<string, PDF>();
            //Object in String umwandeln
            foreach (PDF pdf in dbPDF.auftrag.pdfs)
            {
                dbPDF.dic_pdf.Add($@"{pdf.anschreibenTyp.bezeichnung} {pdf.empfaenger.ansprechpartnerName} {pdf.empfaenger.firma}",pdf);
            }



            closeSession(session, tx);
        }
    }
}
