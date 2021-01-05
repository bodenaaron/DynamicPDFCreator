namespace DynamicPDFCreator.Pflichtfelder_Klassen
{
    internal class Pflicht_AbstimmungDenkmalschutz
    {
        //Pflichtfelder
        public const int EMPFAENGER = 1;
        public const int ABSENDER = 2;
        public const int DATUM = 3;
        public const int AUSFUEHRUNGSZEITRAUM = 4;
        public const int ANSPRECHPARTNER = 5;
        //public const int ORT_DER_MASSNAHMEN = 6;
        //public const int BESCHREIBUNG_ABSPRACHEN = 7;
        public const int BESCHREIBUNG_DER_MASSNAHMEN = 8;
        //public const int WESI_TEAM = 9;
        //public const int ANSPRECHPARTNER_BAU = 10;
        public const int ORT = 13;

        //Optional
        public const int CHECKBOXEN = 11;
        public const int ZUSATZ = 12;

        public static object[] FELDER = { EMPFAENGER, ABSENDER, DATUM, AUSFUEHRUNGSZEITRAUM, ANSPRECHPARTNER, ORT, BESCHREIBUNG_DER_MASSNAHMEN, CHECKBOXEN, ZUSATZ };
        public static object[] PFLICHTFELDER = { EMPFAENGER, ORT, ABSENDER, DATUM, AUSFUEHRUNGSZEITRAUM, BESCHREIBUNG_DER_MASSNAHMEN };
    }
}