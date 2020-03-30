using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Pflichtfelder_Klassen
{
    class Pflicht_EigenesFormular
    {        
        public const int EMPFAENGER = 1;
        public const int ABSENDER = 2;
        public const int DATUM = 3;                
        public const int ORT_DER_MASSNAHMEN = 6;        
        public const int BESCHREIBUNG_DER_MASSNAHMEN = 8;                        
        public const int ZUSATZ = 12;
        public static object[] FELDER = { EMPFAENGER, ORT_DER_MASSNAHMEN, ABSENDER, ZUSATZ };
        public static object[] PFLICHTFELDER = { EMPFAENGER, ORT_DER_MASSNAHMEN, ABSENDER};


    }
}
