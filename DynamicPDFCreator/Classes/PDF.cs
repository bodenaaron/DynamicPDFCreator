using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPDFCreator
{
    public class PDF
    {
        private Ansprechpartner value1;
        private Bearbeiter value2;
        private DateTime value3;
        private string text;
        private string rtb;
        private List<Zusatzanlage> zusatzanlagen;

        public  PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string abgesprochenMit, string beschreibungMassnahme, Ansprechpartner ansprechpartnerBau, WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht,List<Zusatzanlage>zusatzanlagen)
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
            this.tblZusatzanlagen = zusatzanlagen;
        }
        /// <summary>
        /// WUPFL
        /// </summary>
        public  PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string beschreibungMassnahme,  WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.tblZusatzanlagen = zusatzanlagen;
        }

        /// <summary>
        /// EVU
        /// </summary>
        public PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.tblZusatzanlagen = zusatzanlagen;
        }

        public PDF()
        {
            
        }
        /// <summary>
        /// Zustimmungsbescheid
        /// </summary>
        public PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, string ortDerMassnahme,WesiTeam wesiTeam)
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
        public PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, string ortDerMassnahme, WesiTeam wesiTeam, DateTime datum)
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
        public PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, string ortDerMassnahme, string beschreibungMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.tblZusatzanlagen = zusatzanlagen;
        }

        public PDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, string ortDerMassnahme, string rtb, List<Zusatzanlage> zusatzanlagen)
        {
            this.auftrag = auftrag;
            this.anschreibenTyp = anschreibenTyp;
            this.empfaenger = empfaenger;
            this.absender = absender;
            this.datum = datum;            
            this.ortDerMassnahme = ortDerMassnahme;
            this.beschreibungMassnahme = rtb;
            this.zusatzanlagen = zusatzanlagen;
        }

        public virtual string id { get; set; } //= new TblAuftraege();
        public virtual Auftrag auftrag { get; set; } //= new TblAuftraege();
        public virtual AnschreibenTyp anschreibenTyp { get; set; } //= new TblAnschreibenTyp();
        public virtual Ansprechpartner empfaenger { get; set; } //= new TblAnsprechpartner();
        public virtual Bearbeiter absender { get; set; }
        public virtual DateTime datum { get; set; }
        public virtual DateTime ausfuehrungszeitraum { get; set; }
        public virtual DateTime ausfuehrungszeitraumEnde { get; set; }
        public virtual Bearbeiter ansprechpartner { get; set; }
        public virtual string ortDerMassnahme { get; set; }
        public virtual string abgesprochenMit { get; set; }
        public virtual string beschreibungMassnahme { get; set; }
        public virtual Ansprechpartner ansprechpartnerBau { get; set; }
        public virtual WesiTeam wesiTeam { get; set; } //= new TblWesiTeam();
        public virtual bool plansaetze { get; set; }
        public virtual bool untervollmacht { get; set; }
        public virtual bool listeBeteiligte { get; set; }
        public virtual bool techBeschreibung { get; set; }
        public virtual IList<Zusatzanlage> tblZusatzanlagen { get; set; }




    }
}
