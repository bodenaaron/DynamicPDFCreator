using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    public class DBpdf
    {
        public DBpdf()
        {

        }
        public DBpdf(PDF pdf)
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

        public virtual string id { get; set; }
        public virtual Auftrag auftrag { get; set; }
        public virtual AnschreibenTyp anschreibenTyp { get; set; } //= new TblAnschreibenTyp();
        public virtual Ansprechpartner empfaenger { get; set; } //= new TblAnsprechpartner();
        public virtual Bearbeiter absender { get; set; }
        public virtual Bearbeiter ansprechpartner { get; set; }
        public virtual Ansprechpartner ansprechpartnerBau { get; set; }
        public virtual WesiTeam wesiTeam { get; set; }
        public virtual DateTime datum { get; set; }
        public virtual DateTime ausfuehrungszeitraum { get; set; }
        public virtual DateTime ausfuehrungszeitraumEnde { get; set; }
        public virtual string ortDerMassnahme { get; set; }
        public virtual string abgesprochenMit { get; set; }
        public virtual string beschreibungMassnahme { get; set; }
        public virtual bool plansaetze { get; set; }
        public virtual bool untervollmacht { get; set; }
        public virtual bool listeBeteiligte { get; set; }
        public virtual bool techBeschreibung { get; set; }
        public virtual IList<Zusatzanlage> tblZusatzanlagen { get; set; }
        public virtual bool aktiv { get; set; }
    }
}
