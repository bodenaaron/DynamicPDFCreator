using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    class PDF
    {
        public TblAuftraege auftrag { get; set; }
        public TblAnschreibenTyp anschreibenTyp { get; set; }
        public TblAnsprechpartner empfaenger { get; set; }
        public string absender { get; set; }
        public DateTime datum { get; set; }
        public DateTime ausfuehrungszeitraum { get; set; }
        public TblBearbeiter ansprechpartner { get; set; }
        public string ortDerMaßnahme { get; set; }
        public string abgesprochenMit { get; set; }
        public string beschreibungMassnahme { get; set; }
        public TblAnsprechpartner ansprechpartnerBau { get; set; }
        public TblWesiTeam wesiTeam { get; set; }
        public bool plansaetze { get; set; }
        public bool listeBeteiligte { get; set; }
        public bool techBeschreibung { get; set; }
        public string zusatzAnlage1 { get; set; }
        public string zusatzAnlage2 { get; set; }
        public string zusatzAnlage3 { get; set; }


    }
}
