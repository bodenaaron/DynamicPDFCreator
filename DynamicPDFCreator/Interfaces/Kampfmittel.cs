﻿using PdfSharp;
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
    class Kampfmittel : IPDFWriter
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
            <table style='margin-top: 40px; width:100%'>
                <tr>
                  <td>
                    Ihre Referenzen
                  </td>
                   <td>
                    {pdf.wesiTeam.bereich}
                  </td>
                </tr>
                  <tr>
                	<td valign= top>
                  	Betrifft
                  </td>
                    <td valign= top>
                  	<b>Information für die Risikobewertung der Gefährdung durch Kampfmittel im angefragten 									Baufeld der Telekom</b>
                  </td>
                </tr>
            </table>
            <table style='width:100%; margin-top:25px'>
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
                   			Baumaßnahme in: 
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
                	<td style='padding-top:20px'>
                  	Die Baumaßnahme befindet sich in:
                  </td>
                </tr>
                <tr>
  	                <td>
    	                <table style='width:100%'>
                            <tr>  
                                <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                <td>    keiner Kampfmittelverdachtsfläche</td>
                            </tr>
                            <tr>
                                <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                <td style='width:100%'>einer Kampfmittelverdachtsfläche</td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                	<table style='width:100%'>
                                    <tr>  
                                        <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                        <td style='width:100%'>Bei Tiefbaumaßnahmen im angefragten Baufeld wurden keine Kampfmittel gefunden</td>
                                    </tr>
                                    <tr>
                                        <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                        <td>Es gab im</td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>
                                    <table>
                                        <tr>  
                                            <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                            <td>angefragten Baufeld</td>
                                        </tr>
                                        <tr>
                                            <td style='width:20px; height:20px;border:1px solid #000; '></td>
                                            <td>restlichen Zuständigkeitsbereich</td>
                                        </tr>
                                    </table>
                                </td>
                  </tr>
                  <tr>
                    <td></td>
                    <td>Kampfmittelfunde (○Munition, ○Granaten, ○Sonstiges)</td>                    
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
            </table>
                ";
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
    }
    }
