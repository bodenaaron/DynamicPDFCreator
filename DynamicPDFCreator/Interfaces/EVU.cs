using RtfPipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Interfaces
{
    class EVU : IPDFWriter
    {
        public string checkSlash(string input)
        {
            throw new NotImplementedException();
        }

        public string getHTML(PDF pdf)
        {
            string htmlMassnahmen = Rtf.ToHtml(pdf.beschreibungMassnahme.Rtf);
            htmlMassnahmen = reduceRtfFormatting(htmlMassnahmen);

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
                      Baubeschreibung:
                  </td>
                </tr>
                <tr>
                  <td valign=top>
                  	{htmlMassnahmen}
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
                  	<b>{pdf.wesiTeam.Firma}</b>
                  </td>
                </tr>
                <tr>
                	<td>
                  	<b>{pdf.wesiTeam.Niederlassung}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.Bereich}</b>
                  </td>
                </tr>
                <tr>
                    <td>
                  	<b>{pdf.wesiTeam.Strasse}</b>
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
            ";
            if (pdf.ausfuehrungszeitraum.Month != pdf.ausfuehrungszeitraumEnde.Month || pdf.ausfuehrungszeitraum.Year != pdf.ausfuehrungszeitraumEnde.Year)
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
                    i.A. {pdf.ansprechpartner.BearbeiterVorname} {pdf.ansprechpartner.BearbeiterName}
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
                html += "<p>" + s + "</p>";
            }



            return html;
        }

        public string reduceRtfFormatting(string html)
        {
            throw new NotImplementedException();
        }

        public string writeHTMLtoPDF(string html, string pfad)
        {
            throw new NotImplementedException();
        }
    }
}
