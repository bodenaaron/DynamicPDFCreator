using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPDFCreator
{
    public class WorkingPDF
    {

        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string abgesprochenMit, string beschreibungMassnahme, Ansprechpartner ansprechpartnerBau, WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht,List<string>zusatzanlagen)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.absender = absender;
            this.datum = datum;
            this.ausfuehrungszeitraum = ausfuehrungszeitraum;
            this.ausfuehrungszeitraumEnde = ausfuehrungszeitraumEnde;
            this.ansprechpartner = ansprechpartner;
            this.ortDerMassnahme = ortDerMassnahme;
            this.abgesprochenMit = abgesprochenMit;
            this.beschreibungMassnahme = beschreibungMassnahme;
            this.ansprechpartnerBau = ansprechpartnerBau;
            this.wesiTeam = wesiTeam;
            this.plansaetze = plansaetze;
            this.listeBeteiligte = listeBeteiligte;
            this.techBeschreibung = techBeschreibung;
            this.untervollmacht = untervollmacht;
            this.Zusatzanlagen = zusatzanlagen;
        }
        /// <summary>
        /// WUPFL
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string beschreibungMassnahme,  WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<string> zusatzanlagen)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.absender = absender;
            this.datum = datum;
            this.ausfuehrungszeitraum = ausfuehrungszeitraum;
            this.ausfuehrungszeitraumEnde = ausfuehrungszeitraumEnde;
            this.ansprechpartner = ansprechpartner;
            this.ortDerMassnahme = ortDerMassnahme;
            this.beschreibungMassnahme = beschreibungMassnahme;
            this.wesiTeam = wesiTeam;
            this.plansaetze = plansaetze;
            this.listeBeteiligte = listeBeteiligte;
            this.techBeschreibung = techBeschreibung;
            this.untervollmacht = untervollmacht;
            this.Zusatzanlagen = zusatzanlagen;
        }

        /// <summary>
        /// EVU
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<string> zusatzanlagen)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.absender = absender;
            this.datum = datum;
            this.ausfuehrungszeitraum = ausfuehrungszeitraum;
            this.ausfuehrungszeitraumEnde = ausfuehrungszeitraumEnde;
            this.ansprechpartner = ansprechpartner;
            this.ortDerMassnahme = ortDerMassnahme;
            this.plansaetze = plansaetze;
            this.listeBeteiligte = listeBeteiligte;
            this.techBeschreibung = techBeschreibung;
            this.untervollmacht = untervollmacht;
            this.Zusatzanlagen = zusatzanlagen;
        }

        public WorkingPDF()
        {
            
        }
        /// <summary>
        /// Zustimmungsbescheid
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, string ortDerMassnahme,WesiTeam wesiTeam)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.ortDerMassnahme = ortDerMassnahme;
            this.wesiTeam = wesiTeam;

        }

        /// <summary>
        /// Kampfmittel
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, string ortDerMassnahme, WesiTeam wesiTeam, DateTime datum)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.ortDerMassnahme = ortDerMassnahme;
            this.wesiTeam = wesiTeam;
            this.datum = datum;

        }

        /// <summary>
        /// Abstimmung Naturschutz
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, string ortDerMassnahme, string beschreibungMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<string> zusatzanlagen)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.absender = absender;
            this.datum = datum;
            this.ausfuehrungszeitraum = ausfuehrungszeitraum;
            this.ausfuehrungszeitraumEnde = ausfuehrungszeitraumEnde;
            this.ortDerMassnahme = ortDerMassnahme;
            this.beschreibungMassnahme = beschreibungMassnahme;
            this.plansaetze = plansaetze;
            this.listeBeteiligte = listeBeteiligte;
            this.techBeschreibung = techBeschreibung;
            this.untervollmacht = untervollmacht;
            this.Zusatzanlagen = zusatzanlagen;
        }
        public string id { get; set; } 
        public Auftrag auftrag { get; set; } 
        public AnschreibenTyp anschreibenTyp { get; set; } 
        public Ansprechpartner empfaenger { get; set; } 
        public Bearbeiter absender { get; set; }
        public DateTime datum { get; set; }
        public DateTime ausfuehrungszeitraum { get; set; }
        public DateTime ausfuehrungszeitraumEnde { get; set; }
        public Bearbeiter ansprechpartner { get; set; }
        public string ortDerMassnahme { get; set; }
        public string abgesprochenMit { get; set; }
        public string beschreibungMassnahme { get; set; }
        public Ansprechpartner ansprechpartnerBau { get; set; }
        public WesiTeam wesiTeam { get; set; } 
        public bool plansaetze { get; set; }
        public bool untervollmacht { get; set; }
        public bool listeBeteiligte { get; set; }
        public bool techBeschreibung { get; set; }
        public  string zusatzAnlage1 { get; set; }
        public string zusatzAnlage2 { get; set; }
        public string zusatzAnlage3 { get; set; }
        public List<string> Zusatzanlagen { get; set; }
        public object[] ansprechpartnerStringList { get; set; }
        public object[] anschreibenStringList { get; set; }
        public object[] bearbeiterStringList { get; set; }
        public object[] wesiTeamStringList { get; set; }
        public object[] ansprechpartnerTypStringList { get; set; }
        public List<AnschreibenTyp> anschreiben { get; set; }
        public List<AnsprechpartnerTyp> ansprechpartnerTypen { get; set; }
        public List<Bearbeiter> bearbeiter { get; set; }
        public List<WesiTeam> wesiTeams { get; set; }
        public object[] pdfsTitel { get; set; }




    }
}
