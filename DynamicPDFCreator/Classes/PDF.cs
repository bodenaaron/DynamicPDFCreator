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
        private List<Zusatzanlage> zusatzanlagen;

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
        public virtual bool aktiv { get; set; }

        public PDF(DBpdf pdf)
        {
            id = pdf.id;
            auftrag = pdf.auftrag;
            anschreibenTyp = pdf.anschreibenTyp;
            empfaenger = pdf.empfaenger;
            absender = pdf.absender;
            ansprechpartner = pdf.ansprechpartner;
            ansprechpartnerBau = pdf.ansprechpartnerBau;
            wesiTeam = pdf.wesiTeam;
            datum = pdf.datum;
            ausfuehrungszeitraum = pdf.ausfuehrungszeitraum;
            ausfuehrungszeitraumEnde = pdf.ausfuehrungszeitraumEnde;
            ortDerMassnahme = pdf.ortDerMassnahme;
            abgesprochenMit = pdf.abgesprochenMit;
            beschreibungMassnahme = pdf.beschreibungMassnahme;
            plansaetze = pdf.plansaetze;
            untervollmacht = pdf.untervollmacht;
            listeBeteiligte = pdf.listeBeteiligte;
            techBeschreibung = pdf.techBeschreibung;
            tblZusatzanlagen = pdf.tblZusatzanlagen;
            aktiv = pdf.aktiv;
        }
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
            aktiv = true;
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
            aktiv = true;
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
            aktiv = true;
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
            aktiv = true;
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
            aktiv = true;
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
            aktiv = true;
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

        




    }
}
