﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using RtfPipe;
using TheArtOfDev.HtmlRenderer.PdfSharp;


namespace DynamicPDFCreator.Interfaces
{
    class AbstimmungNaturschutz : IPDFWriter
    {

        PdfGenerateConfig config = new PdfGenerateConfig()
        {
            MarginBottom = 50,
            MarginLeft = 70,
            MarginRight = 40,
            MarginTop = 100,
            PageSize = PageSize.A4
        };

        public string getHTML(PDF pdf)
        {
            string htmlMassnahmen = Rtf.ToHtml(pdf.beschreibungMassnahme.Rtf);
            htmlMassnahmen = reduceRtfFormatting(htmlMassnahmen);
            
            string html="";
            html = $@"
            <div style='position: fixed; left: 150px; top: 810px; width:65% '>
            <p style='font-size: 8px; '>Eictronic GmbH -Sitz: 37339 Berlingerode - Amtsgericht Jena - HRB 513528 - Geschäftsführer: Jörg Boden Steuernummer: 157 / 208 / 08940  UST - ID - Nr.: DE 251137789 Finanzamt Mühlhausen</p>
            </div>         
            <p style='font-size: 12px; ' >
                Eictronic GmbH, Gasse 25, 37339 Berlingerode
            </p>
            <table>
                <tr>
                	<td valign: top>
                  	{pdf.empfaenger.AnsprechpartnerVorname} {pdf.empfaenger.AnsprechpartnerName}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.Firma}  
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.Bereich}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.Straße}
                  </td>
                </tr>
                <tr>
                	<td valign: top>
                  	{pdf.empfaenger.PLZ} {pdf.empfaenger.Ort}
                  </td>
                </tr>
            </table>
            <table style='margin-top: 30px; '>
                <tr>
                	<td valign: top>
                  	<b>Abstimmung zu einer geplanten Baumaßnahme in {pdf.ortDerMassnahme}</b>
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{htmlMassnahmen}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	<b>SM-Auftragsnummer: {pdf.auftrag.SMNummer} (bei Rückfragen bitte immer angeben)<b/>
                  </td>
                </tr>
                  <tr>
                	<td valign=top >
                  	Sehr geehrte Damen und Herren,<br/><br/>
                    die Deutsche Telekom Technik GmbH beabsichtigt im Auftrag der Telekom Deutschland GmbH eine Baumaßnahme durchzuführen.<br/>
                    Wir wurden mit den Planungsleistungen betraut.<br/><br/>
                    Die Arbeiten werden entsprechend der Schutzverordnung DIN 18920 ausgeführt. 
                    Dadurch sind der Schutz von Bäumen, Pflanzenbeständen und Vegetationsflächen gewährleistet.<br/><br/>
                    Falls bei der Bauausführung Ihre Belange betroffen sind, bitten wir um deren Angabe und um Beifügung von Plänen der betroffenen Anlagen.<br/><br/>
                  </td>
                </tr>
                <tr>
                    <td valign= top>
                  	Derzeit ist folgende Ausführungsfrist vorgesehen: {pdf.ausfuehrungszeitraum.ToString("MMMM yyyy")}";
            if (pdf.ausfuehrungszeitraum.Month != pdf.ausfuehrungszeitraumEnde.Month || pdf.ausfuehrungszeitraum.Year != pdf.ausfuehrungszeitraumEnde.Year)
            {
                html += $@" bis {pdf.ausfuehrungszeitraumEnde.ToString("MMMM yyyy")}";
            }

            html +=$@"
                    </td>
                </tr>
                </table>
                <p style='margin-top:40px'>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    i.A. {pdf.absender.BearbeiterVorname} {pdf.absender.BearbeiterName}<br/>
                        {pdf.absender.Telefon}<br/>{pdf.absender.Email}
                </p>
                </td>
                </tr>
                </table>
                <p>
                    Anlagen:
                </p>
            ";

            foreach (string s in pdf.Zusatzanlagen)
            {
                html += s+ "<br/>";
            }
            
           
           
            return html;
        }

        public string writeHTMLtoPDF(string html, string pfad)
        {
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(html, config);
            pfad = checkSlash(pfad);
            string alternativerPfad = pfad.Remove(pfad.Length-5,1);
            try
            {
                pdf1.Save(pfad);
                return checkSlash(pfad);
            }
            catch (Exception ef)
            {
            }
            try
            {
                pdf1.Save(alternativerPfad);
                return checkSlash(alternativerPfad);
            }

            catch (Exception e) {
            }
            

            return pfad;
        }

        public string checkSlash(string input) {
            try
            {
                return input.Remove(input.IndexOf("\\\\"),1);
            }
            catch (Exception e) { }
            return input;
        }

        public string reduceRtfFormatting(string html)
        {
            bool control = true;
            int eins = html.IndexOf("\">") + 2;
            int zwei = html.Length - 6;

            html = html.Substring(eins, html.Length-eins-6);
            while (control)
            {
                try
                {
                    string startTag = html.Substring(0, html.IndexOf("style=\""));
                    string endTag = html.Substring(html.IndexOf("\">") + 1);

                    html = startTag + endTag;
                }
                catch (Exception e) { control = false; }
            }
            return html;
        }
    }
}
