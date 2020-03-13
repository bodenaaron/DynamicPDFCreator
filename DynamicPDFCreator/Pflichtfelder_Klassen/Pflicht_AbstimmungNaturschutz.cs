using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Pflichtfelder_Klassen
{
    class Pflicht_AbstimmungNaturschutz
    {

        //public const int ANSCHREIBEN_TYP = 2;
        public const int EMPFAENGER = 9;
        public const int ABSENDER = 1;
        public const int DATUM = 8;
        public const int AUSFUEHRUNGSZEITRAUM = 5;
        //public const int ANSPRECHPARTNER = 3;
        public const int ORT_DER_MASSNAHMEN = 11;
        //public const int BESCHREIBUNG_ABSPRACHEN = 6;
        public const int BESCHREIBUNG_DER_MASSNAHMEN = 7;
        //public const int WESI_TEAM = 14;
        //public const int ANSPRECHPARTNER_BAU = 4;
        //public const int PLANSAETZE = 12;
        //public const int LISTE_DER_BETEILIGTEN = 10;
        //public const int TECHNISCHE_BESCHREIBUNG = 13;
        //public const int ZUSATZ1 = 15;
        //public const int ZUSATZ2 = 16;
        //public const int ZUSATZ3 = 17;
        public static object[] PFLICHTFELDER = { EMPFAENGER, ORT_DER_MASSNAHMEN, ABSENDER, DATUM, AUSFUEHRUNGSZEITRAUM, BESCHREIBUNG_DER_MASSNAHMEN };
    }
}
