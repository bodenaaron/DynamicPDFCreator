using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
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
                  	Aufragsnummer:
                  </td>
                  <td>
                  	{pdf.auftrag.SMNummer} (bei Rückfragen bitte immer angeben)
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	Ansprechpartner:    
                  </td>
                  <td>
                  	{pdf.ansprechpartner.BearbeiterVorname} {pdf.ansprechpartner.BearbeiterName}, {pdf.ansprechpartner.Telefon}, {pdf.ansprechpartner.Email}
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
            string ortDerMassnahme = $@"
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
            string html2=$@"
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
                      Baubeschreibung:
                  </td>
                  <td>
                  	{pdf.beschreibungMassnahme}
                  </td>
                </tr>
            </table>

            <p>
                Wir bitten Sie, die Zustimmung gemäß § 68 Abs. 3 Satz 1 TKG zugunsten der Telekom
                Deutschland GmbH (Reg-Nr.: 93/007 nach § 6 TKG) als Nutzungsberechtigte nach § 68 Abs. 1 i. V. m. § 69 Abs. 1 TKG zu erteilen.  Bitte senden Sie die Zustimmung unter Angabe der im Betreff 
                genannten SM-Nr. an:
            </p>
            <table>
                <tr>
                	<td>
                  	<b>{pdf.wesiTeam.Bezeichnung}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.Bereich}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.Strasse} {pdf.wesiTeam.Hausnummer}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	    <b>{pdf.wesiTeam.PLZ} {pdf.wesiTeam.Stadt}</b>
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
            </p>
            <p>
                Falls bei der Bauausführung ihre Belange betroffen sind, bitten wir um deren Angabe und um Beifügung von Plänen der betroffenen Anlagen.</br>
            </p>

            <p style='margin-top:30px'>
                Für Rückfragen stehen wir Ihnen gern zur Verfügung
            </p>


                <p style='margin-top:60px'>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    BILD UNTERSCHRIFT
                </p>
                <p>
                    i.A. Jörg Boden
                </p>
                </td>
                </tr>
                </table>
                <p>
                    Anlagen:
                </p>
            ";
            html += ortDerMassnahme += html2;

            foreach (string s in pdf.Zusatzanlagen)
            {
                html += s;
            }
            
           
           
            return html;
        }

        public void writeHTMLtoPDF(string html, string pfad)
        {
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(html, config);
            
            pdf1.Save(pfad);
        }
    }
}
