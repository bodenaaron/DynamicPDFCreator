using PdfSharp;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DynamicPDFCreator.Interfaces
{
    class ListeBeteiligte : IPDFWriter
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
            <p>Liste der Beteiligten</p>
                
            <table>
                <tr>
                	<td valign: top>
                  	SM Nummer: 
                  </td>
                    <td valign: top>
                    <b>{pdf.auftrag.smNummer}</b>
                    </td>
                </tr>
                
            </table>
            <table style='margin-top: 30px; '>
            <tr>
                <td>
                    Im Rahmen der Wegesicherung wurden benachrichtigt:
                </td>
            </tr>";
            foreach (Ansprechpartner a in pdf.beteiligte)
            {
                html += $@"
                <tr>
                    <td>
                    ------------------------------------------------
                    </td>
                </tr>
                <tr>
                    <td valign: top>
                        {a.ansprechpartnerVorname} {a.ansprechpartnerName}
                    </td>                    
                </tr>    
                <tr>
                    <td>
                        {a.firma}
                    </td>
                </tr>
                <tr>
                    <td>
                        {a.bereich}
                    </td>        
                </tr>
                <tr>
                    <td>
                        {a.strasse} 
                    </td>        
                </tr>
                <tr>
                    <td>
                        {a.plz} {a.ort} 
                    </td>        
                </tr>
                ";
                

            }
            html += "</table>";
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
                catch (Exception) { control = false; }
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
    }
}
