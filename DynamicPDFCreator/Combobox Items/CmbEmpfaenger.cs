using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    class CmbEmpfaenger
    {
        public string text { get; set; }
        public Ansprechpartner value { get; set; }

        public override string ToString()
        {
            return text;
        }

        public CmbEmpfaenger(PDF pdf)
        {
            this.text = pdf.empfaenger.ansprechpartnerName;
            this.value = pdf.empfaenger;
        }
    }
}
