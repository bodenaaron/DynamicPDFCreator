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


        public string writePDF(PDF pdf)
        {
            


            string html = $@"
            <p style='font-size: 12px; ' >
                Eictronic GmbH, Gasse 25, 37339 Berlingerode
            </p>
            <p>
                {pdf.empfaenger.AnsprechpartnerVorname} {pdf.empfaenger.AnsprechpartnerName}
                </br>
                {pdf.empfaenger.Firma} 
                </br>    
                {pdf.empfaenger.Bereich}
                </br>
                {pdf.empfaenger.Straße}
                </br>
                {pdf.empfaenger.PLZ} {pdf.empfaenger.Ort}
            </p>
            
            <table>
                <tr>
                	<td>
                  	Aufragsnummer:
                  </td>
                  <td>
                  	{pdf.auftrag.SMNummer} (bei Rückfragen bitte immer angeben)
                  </td>
                </tr>
                  <tr>
                	<td>
                  	Ansprechpartner:    
                  </td>
                  <td>
                  	{pdf.ansprechpartner.BearbeiterVorname} {pdf.ansprechpartner.BearbeiterName}, {pdf.ansprechpartner.Telefon}, {pdf.ansprechpartner.Email}
                  </td>
                </tr>
                  <tr>
                	<td>
                  	Datum:
                  </td>
                  <td>
                  	{pdf.datum.ToString("dd.MM.YYYY")}
                  </td>
                </tr>
                  <tr>
                	<td>
                  	Betreff:
                  </td>
                  <td>
                  	Zustimmung des Trägers der Wegebaulast nach §68 Telekommunikationsgesetz (TKG)
                  </td>
                </tr>
            </table>
            <table>
                <tr>
                	<td>
                  	Bauvorhaben:
                  </td>
                  <td>
                  	{pdf.ortDerMaßnahme}
                  </td>
                </tr>
            </table>
            
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
            <table style='width: 100%; '>
                 <tr>
                	<td valign='top'>
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
                  	{pdf.wesiTeam.Bezeichnung}
                  </td>
                </tr>
                <tr>
                    <td>
                  	{pdf.wesiTeam.Bereich}
                  </td>
                </tr>
                <tr>
                    <td>
                  	{pdf.wesiTeam.Strasse} {pdf.wesiTeam.Hausnummer}
                  </td>
                </tr>
                <tr>
                    <td>
                  	{pdf.wesiTeam.PLZ} {pdf.wesiTeam.Stadt}
                  </td>
                </tr>
            </table>
            <p>
            Rechtzeitig vor Baubeginn wird Ihnen der genaue Ausführungszeitraum sowie die mit den Arbeiten beauftragte Firma schriftlich mitgeteilt (Baubeginnanzeige).
            </p>
            <p>
                Vorraussichtllicher Ausführungszeitraum: {pdf.ausfuehrungszeitraum.ToString("MMMM yyyy")}
            </p>
            <p>
                Falls bei der Bauausführung ihre Belange betroffen sind, bitten wir um deren Angabe und um Beifügung von Plänen der betroffenen Anlagen.</br>
                Für Rückfragen stehen wir Ihnen gern zur Verfügung
            </p>

            <div>
                <p>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    BILD UNTERSCHRIFT
                </p>
                <p>
                    i.A. Jörg Boden
                </p>
                <p>
                    Anlagen:
                </p>
            </div>
            ";

            PdfDocument pdfs = PdfGenerator.GeneratePdf(html, PageSize.A4);
            pdfs.Save(@"C:\Users\Boden_Aaron\Desktop\test.pdf");
            return "späterer Pfad";
        }
    }
}
