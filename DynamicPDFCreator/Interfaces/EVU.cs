using PdfSharp;
using PdfSharp.Pdf;
using RtfPipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DynamicPDFCreator.Interfaces
{
    class EVU : IPDFWriter
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
            string html = "";
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
                  	{pdf.empfaenger.ansprechpartnerVorname} {pdf.empfaenger.ansprechpartnerName}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.firma}  
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.bereich}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.empfaenger.strasse}
                  </td>
                </tr>
                <tr>
                	<td valign: top>
                  	{pdf.empfaenger.plz} {pdf.empfaenger.ort}
                  </td>
                </tr>
            </table>
            <table style='margin-top: 30px; '>
                <tr>
                	<td valign: top>
                  	Aufragsnummer:
                  </td>
                  <td>
                  	<b>{pdf.auftrag.smNummer}</b> (bei Rückfragen bitte immer angeben)
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	Ansprechpartner:    
                  </td>
                  <td>
                  	{pdf.ansprechpartner.bearbeiterVorname} {pdf.ansprechpartner.bearbeiterName}, {pdf.ansprechpartner.telefon}, {pdf.ansprechpartner.email}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	Datum:
                  </td>
                  <td>
                  	{pdf.datum.ToString("dd.MM.yyyy")}
                  </td>
                </tr>
                  <tr>
                	<td valign=top >
                  	Betreff:
                  </td>
                  <td>
                  {pdf.ortDerMassnahme}
                  </td>
                </tr>
                </table>
                ";
            
            //anschreiben
            html += $@"
            <div id='anschreiben'>

                <p>
                    Sehr geehrte Damen und Herren,
                </p>
                <p>
                    die Telekom Deutschland GmbH beabsichtigt nach den beiliegenden Plänen ihre
                    Telekommunikationslinien zu ändern/zu erweitern.</br>
                    Dazu hat sie uns, die Eictronic GmbH beauftragt und bevollmächtigt die Aufgaben der Planung
                    und Wegesicherung wahrzunehmen.
                </p>
                <p>
                    Falls bei der Bauausführung Ihre Belange betroffen sind, bitten wir um deren Angabe
                    und um Beifügung von Plänen der betroffenen Anlagen.<br/>
                
               
                    Sollte zu diesem Bauvorhaben eine Koordinierung mit von Ihnen geplanten Maßnahmen in
                    Betracht kommen, bitten wir um konkrete Angaben, für welchen Bereich aus Ihrer Sicht
                    eine koordinierte Baudurchführung möglich ist.
                </p>               

            </div>           
            <table style='width:100%; page-break-inside: avoid'>
                <tr>
                    <td>
            Derzeit ist folgende Ausführungsfrist vorgesehen: {pdf.ausfuehrungszeitraum.ToString("MMMM yyyy")}
            ";
            if (pdf.ausfuehrungszeitraum.Month != pdf.ausfuehrungszeitraumEnde.Month || pdf.ausfuehrungszeitraum.Year != pdf.ausfuehrungszeitraumEnde.Year)
            {
                html += $@" bis {pdf.ausfuehrungszeitraumEnde.ToString("MMMM yyyy")}";
            }
            html += $@"
            <p style='margin-top:30px'>
                Für Rückfragen stehen wir Ihnen gern zur Verfügung.
            </p>


                <p style='margin-top:40px'>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    i.A. {pdf.ansprechpartner.bearbeiterVorname} {pdf.ansprechpartner.bearbeiterName}
                </p>
                </td>
                </tr>
                </table>
                    Anlagen:<br/>

            ";

            foreach (string s in pdf.Zusatzanlagen)
            {
                html += s + "<br/>";
            }



            return html;
        }

        public string reduceRtfFormatting(string html)
        {
            bool control = true;
            int eins = html.IndexOf("\">") + 2;
            int zwei = html.Length - 6;

            html = html.Substring(eins, html.Length - eins - 6);
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

        public string writeHTMLtoPDF(string html, string pfad)
        {
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(html, config);
            pfad = checkSlash(pfad);
            string alternativerPfad = pfad.Remove(pfad.Length - 5, 1);
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

            catch (Exception e)
            {
            }


            return pfad;
        }

        public string checkSlash(string input)
        {
            try
            {
                return input.Remove(input.IndexOf("\\\\"), 1);
            }
            catch (Exception e) { }
            return input;
        }
    }
}
