﻿using System;
using System.Collections.Generic;

namespace DynamicPDFCreator
{
    public class WorkingPDF : PDF
    {
        public WorkingPDF(PDF pdf)
        {
            auftrag = pdf.auftrag;
            anschreibenTyp = pdf.anschreibenTyp;
            empfaenger = pdf.empfaenger;
            absender = pdf.absender;
            datum = pdf.datum;
            ausfuehrungszeitraum = pdf.ausfuehrungszeitraum;
            ausfuehrungszeitraumEnde = pdf.ausfuehrungszeitraumEnde;
            ansprechpartner = pdf.ansprechpartner;
            ortDerMassnahme = pdf.ortDerMassnahme;
            abgesprochenMit = pdf.abgesprochenMit;
            beschreibungMassnahme = pdf.beschreibungMassnahme;
            ansprechpartnerBau = pdf.ansprechpartnerBau;
            wesiTeam = pdf.wesiTeam;
            plansaetze = pdf.plansaetze;
            listeBeteiligte = pdf.listeBeteiligte;
            techBeschreibung = pdf.techBeschreibung;
            untervollmacht = pdf.untervollmacht;
            zusatzanlagen = pdf.tblZusatzanlagen;
        }

        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string abgesprochenMit, string beschreibungMassnahme, Ansprechpartner ansprechpartnerBau, WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.zusatzanlagen = zusatzanlagen;
        }
        /// <summary>
        /// WUPFL
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, string beschreibungMassnahme, WesiTeam wesiTeam, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.zusatzanlagen = zusatzanlagen;
        }

        /// <summary>
        /// EVU
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, Bearbeiter ansprechpartner, string ortDerMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.zusatzanlagen = zusatzanlagen;
        }

        public WorkingPDF()
        {

        }
        /// <summary>
        /// Zustimmungsbescheid
        /// </summary>
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, string ortDerMassnahme, WesiTeam wesiTeam)
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
        public WorkingPDF(Auftrag auftrag, AnschreibenTyp anschreibenTyp, Ansprechpartner empfaenger, Bearbeiter absender, DateTime datum, DateTime ausfuehrungszeitraum, DateTime ausfuehrungszeitraumEnde, string ortDerMassnahme, string beschreibungMassnahme, bool plansaetze, bool listeBeteiligte, bool techBeschreibung, bool untervollmacht, List<Zusatzanlage> zusatzanlagen)
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
            this.zusatzanlagen = zusatzanlagen;
        }

        public object[] pflichtfelder { get; set; }
        public Interfaces.IPDFWriter pdfWriter { get; set; }
        public IList<Zusatzanlage> zusatzanlagen { get; set; }                     
        public List<AnschreibenTyp> anschreiben { get; set; }
        public List<AnsprechpartnerTyp> ansprechpartnerTypen { get; set; }
        public List<Bearbeiter> bearbeiter { get; set; }
        public List<WesiTeam> wesiTeams { get; set; }
        public Dictionary<string, Bearbeiter> dic_Bearbeiter { get; set; }
        public Dictionary<string, AnschreibenTyp> dic_AnschreibenTyp { get; set; }
        public Dictionary<string, Ansprechpartner> dic_Ansprechpartner{ get; set; }
        public Dictionary<string, AnsprechpartnerTyp> dic_ansprechpartnerTypen { get; set; }
        public Dictionary<string, WesiTeam> dic_WesiTeam { get; set; }
        public Dictionary<string, PDF> dic_pdf { get; set; }
        public Dictionary<string, Ansprechpartner> dic_Ansprechpartner_mitTyp { get; set; }



    }
}