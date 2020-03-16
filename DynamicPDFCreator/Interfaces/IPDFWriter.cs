using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using RtfPipe;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DynamicPDFCreator.Interfaces
{
    interface IPDFWriter
    {
        string getHTML(PDF pdf);

        string writeHTMLtoPDF(string html, string pfad);

        string checkSlash(string input);

        string reduceRtfFormatting(string html);
    }
}
