using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    class PDF
    {

        public PDF(TblAuftraege auftrag, TblAnschreibenTyp anschreibenTyp, TblAnsprechpartner empfaenger, TblBearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, TblBearbeiter ansprechpartner, string ortDerMassnahme, string abgesprochenMit, string beschreibungMassnahme, TblAnsprechpartner ansprechpartnerBau, TblWesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, List<string>zusatzanlagen)
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
            this.Zusatzanlagen = zusatzanlagen;
        }

        public PDF(TblAuftraege auftrag, TblAnschreibenTyp anschreibenTyp, TblAnsprechpartner empfaenger, TblBearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, TblBearbeiter ansprechpartner, string ortDerMassnahme, string beschreibungMassnahme,  TblWesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, List<string> zusatzanlagen)
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
            this.Zusatzanlagen = zusatzanlagen;
        }
        public PDF()
        {

        }

        public TblAuftraege auftrag { get; set; } //= new TblAuftraege();
        public TblAnschreibenTyp anschreibenTyp { get; set; } //= new TblAnschreibenTyp();
        public TblAnsprechpartner empfaenger { get; set; } //= new TblAnsprechpartner();
        public TblBearbeiter absender { get; set; }
        public DateTime datum { get; set; }
        public DateTime ausfuehrungszeitraum { get; set; }
        public DateTime ausfuehrungszeitraumEnde { get; set; }
        public TblBearbeiter ansprechpartner { get; set; }
        public string ortDerMassnahme { get; set; }
        public string abgesprochenMit { get; set; }
        public string beschreibungMassnahme { get; set; }
        public TblAnsprechpartner ansprechpartnerBau { get; set; }
        public TblWesiTeam wesiTeam { get; set; } //= new TblWesiTeam();
        public bool plansaetze { get; set; }
        public bool listeBeteiligte { get; set; }
        public bool techBeschreibung { get; set; }
        public string zusatzAnlage1 { get; set; }
        public string zusatzAnlage2 { get; set; }
        public string zusatzAnlage3 { get; set; }
        public List<string> Zusatzanlagen { get; set; }


    }
}
