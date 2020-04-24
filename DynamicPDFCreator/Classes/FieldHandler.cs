using DynamicPDFCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DynamicPDFCreator
{
    class EnableHandler
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

        public Color colorEnabled = Color.FromArgb(255, 255, 255, 192);
        public Color colorDisabled = Color.FromArgb(255, 225, 225, 225);

        public MainForm form;
        public EnableHandler(MainForm form)
        {
            this.form = form;
        }
        public EnableHandler()
        {

        }

        public void manageFields(object[] felder_typ)
        {                        
            //clearAll(false);
            disableAll(false);
            

            foreach (int s in felder_typ)
            {
                switch (s)
                {
                   
                    case Pflichtfelder_Klassen.Pflichtfelder.EMPFAENGER:
                        form.cmb_empfaenger.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ABSENDER:
                        form.cmb_absender.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.DATUM:
                        form.datePicker.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.AUSFUEHRUNGSZEITRAUM:
                        form.datePickerAusfuehrung.Enabled = true;
                        form.datePickerAusfuehrungEnde.Enabled = true;                                               
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER:
                        form.cmb_Ansprechpartner.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ORT_DER_MASSNAHMEN:
                        form.tb_ortMassnahme.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_ABSPRACHEN:
                        form.rtb_absprachen.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_DER_MASSNAHMEN:
                        form.rtb_BeschreibungMassnahme.Enabled = true;                       
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.WESI_TEAM:
                        form.cmb_wesie.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER_BAU:
                        form.cmb_ansprechpartnerBau.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.CHECKBOXEN:
                        form.cb_beteiligte.Enabled = true;
                        form.cb_plansaetze.Enabled = true;
                        form.cb_techBeschreibung.Enabled = true;
                        form.cb_untervollmacht.Enabled = true;                        
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ZUSATZ:
                        form.tb_zusatzanlage.Enabled = true;
                        form.listb_zusatzanlagen.Enabled = true;
                        break;
                    
                }
            }            
            clearColor(true);
            enabledColor(true);
        }

        public void manageFieldsEF(object[] felder_typ)
        {
            clearAll(false);
            disableAll(false);

            enableAll();
            clearColor(true);
            enabledColor(true);
        }

        public void manageFieldsSwitchTabs()
        {
            enableAll();
            clearColor(true);
            enabledColor(true);
        }
        private void enableAll()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(form.Controls);
            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ListBox)
                        (control as ListBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(form.Controls);
        }

        public void disableAll(bool fullDisable)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox && control.Name != "cmb_anschreibenTyp" && !control.Name.Contains("_EF_") || control is ComboBox && fullDisable && !control.Name.Contains("_EF_"))
                        (control as ComboBox).Enabled = false;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Name != "tb_smNummer" && !control.Name.Contains("_EF_"))
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };            
            func(form.Controls);            
            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox && !control.Name.Contains("_EF_"))
                        (control as RichTextBox).Enabled = false;
                    else
                        func(control.Controls);
            };

            func(form.Controls);            
        }

        private void clearAll(bool fullClear)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Name != "tb_smNummer")
                        (control as TextBox).Clear();                        
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox && control.Name != "cmb_anschreibenTyp")
                        (control as ComboBox).SelectedItem = null;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox )
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                try
                {
                    foreach (Control control in controls)
                        if (control is ListBox)
                            (control as ListBox).Items.Clear();
                        else
                            func(control.Controls);
                }
                catch (Exception)
                {
                    foreach (Control control in controls)
                        if (control is ListBox)
                            (control as ListBox).DataSource=null;
                        else
                            func(control.Controls);
                }
            };

            func(form.Controls);
        }

        public void clearColor(bool fullClear)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Name != "tb_smNummer" && !control.Enabled)
                        (control as TextBox).BackColor = colorDisabled;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox && !control.Enabled)
                        (control as ComboBox).BackColor = Color.White;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox && !control.Enabled)
                        (control as RichTextBox).BackColor = colorDisabled;
                    else
                        func(control.Controls);
            };

            func(form.Controls);
        }

        public void enabledColor(bool fullClear)
        {
            Action<Control.ControlCollection> func = null;
            List<string> felder = new List<string>() { "tb_smNummer", "tb_zusatzanlage", "rtb_EF_Anschreiben","listb_EF_Zusatz","tb_EF_zusatz"};
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Enabled && !felder.Contains(control.Name))
                        (control as TextBox).BackColor = colorEnabled;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox && control.Enabled)
                        (control as ComboBox).BackColor = colorEnabled;
                    else
                        func(control.Controls);
            };

            func(form.Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox && !felder.Contains(control.Name)&&control.Enabled)
                        (control as RichTextBox).BackColor = colorEnabled;
                    else
                        func(control.Controls);
            };

            func(form.Controls);
        }

        public List<Zusatzanlage> checkInput(object[] pflichtfelder_typ)
        {
            if (form.workingPDF.auftrag == null)
            {
                displayError(ERROR_SMNUMMER);
                return null;
            }

            if (pflichtfelder_typ == null)
            {
                displayError(ERROR_ANSCHREIBENTYP);
                return null;
            }
            foreach (int s in pflichtfelder_typ)
            {
                switch (s)
                {
                    case Pflichtfelder_Klassen.Pflichtfelder.ABSENDER:
                        if (form.cmb_absender.Text == "")
                        {
                            displayError(ERROR_ABSENDER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.EMPFAENGER:
                        if (form.cmb_empfaenger.Text == "")
                        {
                            displayError(ERROR_EMPFAENGER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER:
                        if (form.cmb_Ansprechpartner.Text == "")
                        {
                            displayError(ERROR_ANSPRECHPARTNER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ORT_DER_MASSNAHMEN:
                        if (form.tb_ortMassnahme.Text == "")
                        {
                            displayError(ERROR_ORTDERMASSNAHME);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_ABSPRACHEN:
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_DER_MASSNAHMEN:
                        if (form.rtb_BeschreibungMassnahme.Text == "")
                        {
                            displayError(ERROR_BESCHREIBUNGMASSNAHME);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.WESI_TEAM:
                        if (form.rtb_WesiAdresse.Text == "")
                        {
                            displayError(ERROR_WESI_TEAM_ADRESSE);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER_BAU:
                        break;
                }
            }
            List<Zusatzanlage> zusatzanlagen = new List<Zusatzanlage>();

            foreach (object i in form.listb_zusatzanlagen.Items)
            {
                zusatzanlagen.Add(new Zusatzanlage(i.ToString()));
            }

            return zusatzanlagen;
        }
        public void displayError(int error)
        {
            switch (error)
            {
                case 1:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_SMNUMMER;
                    //tb_smNummer.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ANSCHREIBENTYP;
                    break;
                case 3:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_EMPFAENGER;
                    //cmb_empfaenger.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ABSENDER;
                    //cmb_absender.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_DATUM;
                    break;
                case 6:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_AUSFUEHRUNGSZEITRAUM;
                    break;
                case 7:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ANSPRECHPARTNER;
                    //cmb_Ansprechpartner.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ORTDERMASSNAHME;
                    //tb_ortMassnahme.BackColor = System.Drawing.Color.Red;
                    break;
                case 9:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_BESCHREIBUNG_ABGESPROCHEN_MIT;
                    //rtb_absprachen.BackColor = System.Drawing.Color.Red;
                    break;
                case 10:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_BESCHREIBUNGMASSNAHME;
                    //rtb_BeschreibungMassnahme.BackColor = System.Drawing.Color.Red;
                    break;
                case 11:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ANSPRECHPARTNER_BAU;
                    break;
                case 12:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_WESI_TEAM_ADRESSE;
                    //rtb_WesiAdresse.BackColor = System.Drawing.Color.Red;
                    break;
                case 13:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_CHECKBOXEN;
                    break;
                case 14:
                    form.error_label.Text = Properties.ErrorCodes.ERROR_ZUSATZ;
                    break;


            }
        }
        public void clean(bool content, bool color, bool active)
        {
            if (content)
            {
                clearAll(true);
            }
            if (color){
                clearColor(true);
            }
            if (active)
            {
                disableAll(true);
            }
        }
    }
}
