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
    class Zustimmungsbescheid : IPDFWriter
    {
        PdfGenerateConfig config = new PdfGenerateConfig()
        {
            MarginBottom = 50,
            MarginLeft = 70,
            MarginRight = 40,
            MarginTop = 110,
            PageSize = PageSize.A4
        };

        

        public string getHTML(PDF pdf)
        {
            string firma;
            if (pdf.empfaenger.firma == "" || pdf.empfaenger.firma == null)
            {
                firma = pdf.empfaenger.ansprechpartnerName;
            }
            else { firma = pdf.empfaenger.firma; }
            string html = "";
            html = $@"
            <p style='font-size: 12px; ' >
                {firma}<br/>{pdf.empfaenger.strasse} {pdf.empfaenger.plz} {pdf.empfaenger.ort}
            </p>
            <table>
                <tr>
                	<td valign: top>
                  	{pdf.wesiTeam.Firma}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.wesiTeam.Niederlassung}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.wesiTeam.Bereich}
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	{pdf.wesiTeam.Strasse}
                  </td>
                </tr>
                <tr>
                	<td valign: top>
                  	{pdf.wesiTeam.PLZ} {pdf.wesiTeam.Stadt}
                  </td>
                </tr>
            </table>
            <table style='margin-top: 40px; width:100%'>
                <tr>
                  <td>
                    <b>
                  	Zustimmung des Trägers der Wegebaulast nach TKG § 68 (3) für den
                    Antragsteller/Nutzungsberechtigten Telekom Deutschland GmbH.<br/><br/>
                    </b>
                  </td>
                </tr>
                  <tr>
                	<td valign: top>
                  	Sehr geehrte Damen und Herren,<br/><br/>
                    Ihrem Antrag auf Zustimmung für die Durchführung einer Baumaßnahme in:<br/>
                    {pdf.ortDerMassnahme} (SM-Auftragsnummer: {pdf.auftrag.smNummer})    
                  </td>
                </tr>
            </table>
            <table>
                <tr>  
                    <td style='width:20px; height:20px;border:1px solid #000; '></td>
                    <td>     stimmen wir zu</td>
                </tr>
                <tr>
                    <td style='width:20px; height:20px;border:1px solid #000; '></td>
                    <td>stimmen wir mit folgenden Nebenbestimmu8ngen im Sinne des § 68 TKG Abs. 3 zu:</td>
                </tr>
            </table>
            <table style='width:100%'>
              <tr>
              <td style='border-bottom: solid; height:30px'>
              </td>
              </tr>
              <tr>
              <td style='border-bottom: solid; height:30px'>
              </td>
              </tr>
              <tr>
              <td style='border-bottom: solid; height:30px'>
              </td>
              </tr>
              <tr>
              <td style='border-bottom: solid; height:30px'>
              </td>
              </tr>
              <tr>
              <td style='border-bottom: solid; height:30px'>
              </td>
              </tr>
            </table>
            <table style='width:100%; margin-top:70px'>
              <tr>
              <td style='border-bottom:solid'>
                </td>
              </tr>
              <tr>
              	<td>
                	Ort, Datum
                </td>
              </tr>
              <tr>
              <td style='border-bottom:solid;height:70px'>
                </td>
              </tr>
              <tr>
              	<td>
                	Stempel und Unterschrift(en) des Wegeunterhaltspflichtigen
                </td>
              </tr>
            </table>
                ";
            
            



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
