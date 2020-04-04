using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    public partial class Auftrag
    {
        public virtual int id
        {
            get;
            set;
        }
        public virtual string smNummer
        {
            get;
            set;
        }

        public virtual Projekt projekt
        {
            get;
            set;
        }

        public virtual ISet<DBpdf> pdfs
        {
            get;
            set;
        }
    }
}
