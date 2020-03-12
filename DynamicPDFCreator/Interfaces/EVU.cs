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
            throw new NotImplementedException();
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
