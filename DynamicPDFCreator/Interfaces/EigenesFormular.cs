using PdfSharp;
using PdfSharp.Pdf;
using RtfPipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DynamicPDFCreator.Interfaces
{
    class EigenesFormular : IPDFWriter
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
                  	{pdf.absender.bearbeiterVorname} {pdf.absender.bearbeiterName}, {pdf.absender.telefon}, {pdf.absender.email}
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
            <table>
                <tr>
                    <td>                   
                     {htmlMassnahmen}
                  </td>
                </tr>            ";
           
                
            html += $@"
            
                <tr>
                    <td>
                <p style='margin-top:60px'>
                    Mit freundlichen Grüßen:
                </p>
                <p>
                    i.A. {pdf.absender.bearbeiterVorname} {pdf.absender.bearbeiterName}
                </p>
                </td>
                </tr>
                </table>
                <p>
                    Anlagen:
                </p>
            ";

            if (pdf.tblZusatzanlagen != null)
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

        public string checkSlash(string input)
        {
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

            html = html.Substring(eins, html.Length - eins - 6);
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
