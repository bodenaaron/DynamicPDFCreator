using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    public partial class MainForm 
    {
        public readonly int ERROR_SMNUMMER = 1;
        public readonly int ERROR_ANSCHREIBENTYP = 2;
        public readonly int ERROR_EMPFAENGER = 3;
        public readonly int ERROR_ABSENDER = 4;
        public readonly int ERROR_DATUM = 5;
        public readonly int ERROR_AUSFUEHRUNGSZEITRAUM = 6;
        public readonly int ERROR_ANSPRECHPARTNER = 7;
        public readonly int ERROR_ORTDERMASSNAHME = 8;
        public readonly int ERROR_BESCHREIBUNG_ABGESPROCHEN_MIT = 9;
        public readonly int ERROR_BESCHREIBUNGMASSNAHME = 10;
        public readonly int ERROR_ANSPRECHPARTNER_BAU = 11;
        public readonly int ERROR_WESI_TEAM_ADRESSE = 12;
        public readonly int ERROR_CHECKBOXEN = 13;
        public readonly int ERROR_ZUSATZ = 14;

        private void displayError(int error)
        {
            switch (error)
            {
                case 1:
                    error_label.Text=Properties.ErrorCodes.ERROR_SMNUMMER;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;

            }
        }
    }


}

