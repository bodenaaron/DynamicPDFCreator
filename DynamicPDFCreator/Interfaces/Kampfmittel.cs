using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using RtfPipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DynamicPDFCreator.Interfaces
{
    class Kampfmittel : IPDFWriter
    {
        PDF pdf = new PDF();

        PdfGenerateConfig config = new PdfGenerateConfig()
        {
            MarginBottom = 50,
            MarginLeft = 50,
            MarginRight = 30,
            MarginTop = 100,
            PageSize = PageSize.A4            
        };

        

        public string getHTML(PDF pdf)
        {
            this.pdf = pdf;
            string firma;
            if (pdf.empfaenger.firma == "" || pdf.empfaenger.firma == null)
            {
                firma = pdf.empfaenger.ansprechpartnerName;
            }
            else { firma = pdf.empfaenger.firma; }
            string html = "<html><body> <font size='10'>";
            html = $@"
            <p style='font-size: 12px; ' >
                {firma}<br/>{pdf.empfaenger.strasse} {pdf.empfaenger.plz} {pdf.empfaenger.ort}
            </p>
            <table>
                <tr>
                	<td valign= top>
                  	{pdf.wesiTeam.firma}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	{pdf.wesiTeam.niederlassung}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	{pdf.wesiTeam.bereich}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	{pdf.wesiTeam.strasse}
                  </td>
                </tr>
                <tr>
                	<td valign= top>
                  	{pdf.wesiTeam.plz} {pdf.wesiTeam.stadt}
                  </td>
                </tr>
            </table>
            <table style='margin-top: 30px; '>
                <tr>
                  <td>
                    Ihre Referenzen
                  </td>
                   <td>
                    <b> {pdf.auftrag.smNummer}</b>
                  </td>

                </tr>
                  <tr>
                	<td valign= top>
                  	Betrifft
                  </td>
                    <td valign= top>
                  	<b>Information für die Risikobewertung der Gefährdung durch Kampfmittel im angefragten 									Baufeld der Telekom.</b>
                  </td>
                </tr>
            </table>
            <table style='width:100%; margin-top:20px'>
                <tr>
                  <td>
                    Sehr geehrte Damen und Herren, <br/><br/>
                    Sie bitten um eine Rückmeldung/Stellungnahme zum Thema Kampfmittel für Ihre:<br/>
                    </td>
                </tr>
                <tr>
                 <td>
                   <table style='padding-left:40px'>
                    	<tr>
                       	<td>
                   			Baumaßnahme: 
                       	</td>
                       	<td>
                       		<b>{pdf.ortDerMassnahme}</b>
                       </td>
                     </tr>
                     <tr>
                       <td>
                   		SM-Auftrag Nr.:
                       </td>
                       <td>
                         <b>{pdf.auftrag.smNummer}</b>
                         </td>
                       </tr>
                     </table>
                    </td>		 
                </tr> 
                <tr>
                	<td style='padding-top:15px'>
                  	<b>Die Baumaßnahme befindet sich in:</b>
                  </td>
                </tr>
                <tr>
                  
  	                <td>
    	                <table style='width:100%'>
                            <tr>
                              <td></td>
                                <td style='width:20px; height:20px;border:1px solid #000; '></td>
                              <td style='width:10px'></td>
                                <td>    <b>keiner</b> Kampfmittelverdachtsfläche.</td>
                            </tr>
                            <tr>
                              <td></td>
                                <td style='width:20px; height:20px;border:1px solid #000; '></td>
                              <td style='width:10px'></td>
                                <td style=''><b>einer</b> Kampfmittelverdachtsfläche.</td>
                            </tr>
                            <tr>
                              <td></td><td></td>
                                <td>
                                </td>
                              
                                <td>
                                	<table style='width:100%'>
                                    <tr>  <td></td>
                                        <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                      <td style='width:10px'></td>
                                        <td style=''>Bei <u>Tiefbaumaßnahmen</u> im angefragten Baufeld wurden keine Kampfmittel gefunden</td>
                                    </tr>
                                    <tr><td></td>
                                        <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                      <td style='width:10px'></td>
                                        <td>Es gab bei eigenen/fremden Tiefbaumaßnahmen im</td>
                                    </tr>
                                    <tr><td></td><td></td>
                                        <td></td>
                                        <td>
                                    <table>
                                        <tr>  
                                            <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                          <td style='width:10px'></td>
                                            <td>angefragten Baufeld</td>
                                        </tr>
                                        <tr>
                                            <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                          <td style='width:10px'></td>
                                            <td>restlichen Zuständigkeitsbereich</td>
                                        </tr>
                                    </table>
                                </td>
                  </tr>
                  <tr><td></td><td></td>
                    <td></td>
                    <td>   Kampfmittelfunde (□ Munition, □ Granaten, □ Sonstiges)</td>
                  </tr>
<tr><td></td>
<td style='width:20px; height:20px;border:1px solid #000; '></td>
<td style='width:10px'></td>
<td>Erkenntnisse zu möglichen Kampfmitteln liegen nicht vor.</td>
</tr>

            </table>
            </td>
            </tr>
            </table>
            </td>
            </tr>
            </table>
            <table style='width:60%'>
              <tr>
                <td style='border-bottom: solid; height:50px'>
                </td>
              </tr>
              <tr>
              	<td>
                Ort, Datum
                </td>
              </tr>
                <tr>
                <td style='border-bottom: solid; height:60px'>
                </td>
              </tr>
              <tr>
                <td>
                	Stempel und Unterschrift(en) Eigentümer
                </td>
              </tr>
            </table>";
            return html;
        }

        public string writeHTMLtoPDF(string html, string pfad)
        {
            KampfmittelfreiheitText kampfmittelfreiheitText = new KampfmittelfreiheitText();
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(kampfmittelfreiheitText.getHTML(pdf.auftrag.smNummer, pdf?.ansprechpartner)+html, config);
            pfad = checkSlash(pfad);
            //PdfDocument pdf2 = PdfGenerator.GeneratePdf(kampfmittelfreiheitText.getHTML(pdf.auftrag.smNummer, pdf?.ansprechpartner), config);
            //pdf1.AddPage(pdf2.Pages[0]);
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
            KampfmittelfreiheitText kampfmittelfreiheitText = new KampfmittelfreiheitText();
            PdfDocument pdf1 = PdfGenerator.GeneratePdf(kampfmittelfreiheitText.getHTML(pdf.auftrag.smNummer, pdf?.ansprechpartner)+ getHTML(pdf), config);
            pfad = checkSlash(pfad);
            PdfDocument pdf2 = PdfGenerator.GeneratePdf(kampfmittelfreiheitText.getHTML(pdf.auftrag.smNummer, pdf?.ansprechpartner), config);
            //PdfDocument inputDocument = PdfReader.Open            
            //pdf1.AddPage(pdf2.Pages[0]);
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
