using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Pflichtfelder_Klassen
{
    class Pflicht_EVU 
    {       
        public static object[] PFLICHTFELDER = { EMPFAENGER,ORT_DER_MASSNAHMEN,ABSENDER,ANSPRECHPARTNER};

        public const int EMPFAENGER = 1;
        public const int ABSENDER = 2;
        //public const int DATUM = 3;
        //public const int AUSFUEHRUNGSZEITRAUM = 4;
        public const int ANSPRECHPARTNER = 5;
        public const int ORT_DER_MASSNAHMEN = 6;
        //public const int BESCHREIBUNG_ABSPRACHEN = 7;
        //public const int BESCHREIBUNG_DER_MASSNAHMEN = 8;
        //public const int WESI_TEAM = 9;
        //public const int ANSPRECHPARTNER_BAU = 10;
        public const int CHECKBOXEN = 11;
        public const int ZUSATZ = 12;

        public static object[] FELDER = { EMPFAENGER, ORT_DER_MASSNAHMEN, ABSENDER, ANSPRECHPARTNER, CHECKBOXEN, ZUSATZ };
    }
}
