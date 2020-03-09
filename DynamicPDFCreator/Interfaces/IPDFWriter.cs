using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Interfaces
{
    interface IPDFWriter
    {
        string writePDF(PDF pdf);
    }
}
