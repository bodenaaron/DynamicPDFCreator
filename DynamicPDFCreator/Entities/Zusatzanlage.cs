using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    public class Zusatzanlage
    {
        //public readonly string UNTERVOLLMACHT = "- Untervollmacht";
        //public readonly string PLANSATZ = " - Plansatz";
        //public readonly string LISTE_BETEILIGTE = "- Liste der Beteiligten";
        //public readonly string TECHNISCHE_BESCHREIBUNG = "- Technische Beschreibung";
        public virtual int id{get;set;}
        public virtual string idPDF { get; set; }
        public virtual string anlage { get; set; }

        public Zusatzanlage(string s)
        {
            this.anlage = s;
        }
        public Zusatzanlage()
        {

        }
    }
}
