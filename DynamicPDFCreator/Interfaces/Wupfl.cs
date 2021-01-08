using System;
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
    class Wupfl : IPDFWriter
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
            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = pdf.beschreibungMassnahme;
            string htmlMassnahmen = Rtf.ToHtml(rtb.Rtf);
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
                  	{pdf.empfaenger.strasse} {pdf.empfaenger.hausnummer}
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
                  	Zustimmung des Trägers der Wegebaulast nach §68 Telekommunikationsgesetz (TKG)
                  </td>
                </tr>
                </table>
                ";
            //ort der Maßnahmen
                html += $@"
                <table style='width:100%; margin-top:15px'>
                <tr>
                	<td style='valign: top; width:20%'>
                  	Bauvorhaben:
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
                    </br>
                    </br>
                    die Telekom Deutschland GmbH beabsichtigt nach den beiliegenden Plänen ihre </br>
                    Telekommunikationslinien zu ändern/zu erweitern.</br>
                    Dazu hat sie uns, die Eictronic GmbH beauftragt und bevollmächtigt die Aufgaben der Planung</br>
                    und Wegesicherung wahrzunehmen.
                </p>
            </div>
            
            <table style='width: 100%; margin-top:30px'>
                 <tr>
                	<td  valign=top style=' width:20%'>
                      Baubeschreibung: {htmlMassnahmen}
                  </td>
                </tr>
            </table>
            <table style='page-break-inside: avoid'>
                <tr>
                	<td>
                            Wir bitten Sie, die Zustimmung gemäß § 68 Abs. 3 Satz 1 TKG zugunsten der Telekom
                            Deutschland GmbH (Reg-Nr.: 93/007 nach § 6 TKG) als Nutzungsberechtigte nach § 68 Abs. 1 i. V. m. § 69 Abs. 1 TKG zu erteilen.  Bitte senden Sie die Zustimmung unter Angabe der im Betreff 
                            genannten SM-Nr. an:</br></br></br>
                  </td>
                </tr>
                <tr>
                	<td>
                  	<b>{pdf.wesiTeam.firma}</b>
                  </td>
                </tr>
                <tr>
                	<td>
                  	<b>{pdf.wesiTeam.niederlassung}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.bereich}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.strasse}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	    <b>{pdf.wesiTeam.plz} {pdf.wesiTeam.stadt}</b>
                  </td>
                </tr>
                </table>
                <table style='width:100%; page-break-inside: avoid'>
                <tr>
                <td>
            <p>
                Rechtzeitig vor Baubeginn wird Ihnen der genaue Ausführungszeitraum sowie die mit den Arbeiten beauftragte Firma schriftlich mitgeteilt (Baubeginnanzeige).
            </p>
            <p>
            Vorraussichtllicher Ausführungszeitraum: {pdf.ausfuehrungszeitraum.ToString("MMMM yyyy")}
            ";
            if (pdf.ausfuehrungszeitraum.Month!=pdf.ausfuehrungszeitraumEnde.Month||pdf.ausfuehrungszeitraum.Year != pdf.ausfuehrungszeitraumEnde.Year)
            {
                html += $@" bis {pdf.ausfuehrungszeitraumEnde.ToString("MMMM yyyy")}";
            }
            html += $@"
            <p>
                Falls bei der Bauausführung Ihre Belange betroffen sind, bitten wir um deren Angabe und um Beifügung von Plänen der betroffenen Anlagen.</br>
            </p>

            <p style='margin-top:30px'>
                Für Rückfragen stehen wir Ihnen gern zur Verfügung
            </p>


                <p style='margin-top:60px'>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    i.A. {pdf.ansprechpartner.bearbeiterVorname} {pdf.ansprechpartner.bearbeiterName}
                </p>
                </td>
                </tr>
                </table>
                <p>
                    Anlagen:
                </p>
            ";
            if (pdf.listeBeteiligte)
            {
                html += "- Liste der Beteiligten<br/>";
            }
            if (pdf.untervollmacht)
            {
                html += "- Untervollmacht <br/>";
            }
            if (pdf.plansaetze)
            {
                html += "- Plansatz<br/>";
            }
            if (pdf.techBeschreibung)
            {
                html += "- Risikobewertung Kampfmittel<br/>";
            }
            if (pdf.zustimmungsbescheid)
            {
                html += "- Vorgefertigter Zustimmungsbescheid<br/>";
            }

            if (pdf.tblZusatzanlagen!=null)
            {
                foreach (Zusatzanlage s in pdf.tblZusatzanlagen)
                {
                    html += s.anlage + "<br/>";
                }
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
            catch (Exception )
            {
            }
            try
            {
                pdf1.Save(alternativerPfad);
                return checkSlash(alternativerPfad);
            }

            catch (Exception) {
            }
            

            return pfad;
        }

        public string writeHTMLtoPDF(PDF pdf, string pfad)
        {
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(getHTML(pdf), config);
            pfad = checkSlash(pfad);
            string alternativerPfad = pfad.Remove(pfad.Length - 5, 1);
            try
            {
                pdf1.Save(pfad);
                return checkSlash(pfad);
            }
            catch (Exception)
            {
            }
            try
            {
                pdf1.Save(alternativerPfad);
                return checkSlash(alternativerPfad);
            }

            catch (Exception)
            {
            }


            return pfad;
        }

        public string checkSlash(string input) {
            try
            {
                return input.Remove(input.IndexOf("\\\\"), 1);
            }
            catch (Exception) { }
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
                catch (Exception) { control = false; }
            }
            return html;
        }
    }
}
