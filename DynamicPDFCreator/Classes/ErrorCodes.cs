using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator
{
    partial class MainForm
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
                    error_label.Text = Properties.ErrorCodes.ERROR_SMNUMMER;
                    //tb_smNummer.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    error_label.Text = Properties.ErrorCodes.ERROR_ANSCHREIBENTYP;
                    break;
                case 3:
                    error_label.Text = Properties.ErrorCodes.ERROR_EMPFAENGER;
                    //cmb_empfaenger.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    error_label.Text = Properties.ErrorCodes.ERROR_ABSENDER;
                    //cmb_absender.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    error_label.Text = Properties.ErrorCodes.ERROR_DATUM;
                    break;
                case 6:
                    error_label.Text = Properties.ErrorCodes.ERROR_AUSFUEHRUNGSZEITRAUM;
                    break;
                case 7:
                    error_label.Text = Properties.ErrorCodes.ERROR_ANSPRECHPARTNER;
                    //cmb_Ansprechpartner.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    error_label.Text = Properties.ErrorCodes.ERROR_ORTDERMASSNAHME;
                    //tb_ortMassnahme.BackColor = System.Drawing.Color.Red;
                    break;
                case 9:
                    error_label.Text = Properties.ErrorCodes.ERROR_BESCHREIBUNG_ABGESPROCHEN_MIT;
                    //rtb_absprachen.BackColor = System.Drawing.Color.Red;
                    break;
                case 10:
                    error_label.Text = Properties.ErrorCodes.ERROR_BESCHREIBUNGMASSNAHME;
                    //rtb_BeschreibungMassnahme.BackColor = System.Drawing.Color.Red;
                    break;
                case 11:
                    error_label.Text = Properties.ErrorCodes.ERROR_ANSPRECHPARTNER_BAU;
                    break;
                case 12:
                    error_label.Text = Properties.ErrorCodes.ERROR_WESI_TEAM_ADRESSE;
                    //rtb_WesiAdresse.BackColor = System.Drawing.Color.Red;
                    break;
                case 13:
                    error_label.Text = Properties.ErrorCodes.ERROR_CHECKBOXEN;
                    break;
                case 14:
                    error_label.Text = Properties.ErrorCodes.ERROR_ZUSATZ;
                    break;


            }
        }
    }
}
