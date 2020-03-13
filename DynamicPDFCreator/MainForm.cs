using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MainForm : Form
    {
        private object[] pflichtfelder_typ;
        Interfaces.IPDFWriter pdfWriter;
        DBManager DBm = new DBManager();
        PDF pdf = new PDF();
        public MainForm()
        {
            InitializeComponent();
            ReinitializeComponents();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_smNummer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBm = new DBManager(tb_smNummer.Text);
                cmb_Ansprechpartner.Items.Clear();
                cmb_Ansprechpartner.Items.AddRange(DBm.bearbeiterNamen);
                cmb_Ansprechpartner.SelectedIndex = 0;
                cmb_ansprechpartnerBau.Items.Clear();
                cmb_ansprechpartnerBau.Items.AddRange(DBm.ansprechpartnerNamen);
                cmb_empfaenger.Items.Clear();
                cmb_empfaenger.Items.AddRange(DBm.ansprechpartnerNamen);
                cmb_absender.Items.Clear();
                cmb_absender.Items.AddRange(DBm.bearbeiterNamen);
                cmb_wesie.Items.Clear();
                cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);
                pdf.auftrag = DBm.auftrag;
                //btn_hinzufuegen.Enabled = true;
            }
            catch (Exception fe) { }
        }

        private void ReinitializeComponents()
        {
            this.WindowState = FormWindowState.Maximized;
            //Combobox Anschreiben Typ
            cmb_anschreibenTyp.Items.Clear();
            cmb_anschreibenTyp.Items.AddRange(DBm.anschreibenNamen);
            cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);
            //cmb_anschreibenTyp.SelectedIndex = 2;
            cmb_Ansprechpartner.Items.Clear();
            cmb_Ansprechpartner.Items.AddRange(DBm.bearbeiterNamen);
            cmb_absender.Items.Clear();
            cmb_absender.Items.AddRange(DBm.bearbeiterNamen);
            //Datepicker custom form

            datePickerAusfuehrung.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrung.CustomFormat = "MMMM-yyyy";

            datePickerAusfuehrungEnde.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrungEnde.CustomFormat = "MMMM-yyyy";
            //enableAll();
            btn_bearbeiten.Enabled = false;
            //btn_hinzufuegen.Enabled = false;

        }

        private void Cmb_anschreibenTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblAnschreibenTyp anschreiben = new TblAnschreibenTyp();

            if (pdf.auftrag!=null)
            {
                anschreiben = DBm.anschreiben.ElementAt<TblAnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex);
            }

            switch (anschreiben.Id - 1)
            {
                case 0:
                    //EVU
                    enableAll();
                    pdfWriter = new Interfaces.EVU();
                    rtb_absprachen.Enabled = false;
                    rtb_BeschreibungMassnahme.Enabled = false;
                    cmb_wesie.Enabled = false;
                    cmb_ansprechpartnerBau.Enabled = false;
                    pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_EVU.PFLICHTFELDER;
                    break;
                case 1:
                    break;
                case 2:
                    //WUPFL
                    enableAll();
                    rtb_absprachen.Enabled = false;
                    cmb_ansprechpartnerBau.Enabled = false;
                    pdfWriter = new Interfaces.Wupfl();
                    pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_EVU.PFLICHTFELDER;
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
            }


            pdf.anschreibenTyp = anschreiben;
        }

        private void Cmb_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.empfaenger = DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_empfaenger.SelectedIndex);
            btn_bearbeiten.Enabled = true;


        }

        private void Cmb_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.absender = DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_absender.SelectedIndex);
            cmb_Ansprechpartner.SelectedIndex = cmb_absender.SelectedIndex;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            pdf.datum = datePicker.Value;
        }

        private void DatePickerAusfuehrung_ValueChanged(object sender, EventArgs e)
        {
            pdf.ausfuehrungszeitraum = datePickerAusfuehrung.Value;
            datePickerAusfuehrungEnde.Value = datePickerAusfuehrung.Value;
        }

        private void Cmb_Ansprechpartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.ansprechpartner = DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_Ansprechpartner.SelectedIndex);
        }

        private void Rtb_absprachen_TextChanged(object sender, EventArgs e)
        {
            pdf.abgesprochenMit = rtb_absprachen.Text;
        }

        private void Rtb_BeschreibungMassnahme_TextChanged(object sender, EventArgs e)
        {
            pdf.beschreibungMassnahme.Text = rtb_BeschreibungMassnahme.Rtf;
        }

        private void Cmb_ansprechpartnerBau_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.ansprechpartnerBau = DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_ansprechpartnerBau.SelectedIndex);
        }

        private void Rtb_WesiAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_wesie_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.wesiTeam = DBm.wesiTeam.ElementAt<TblWesiTeam>(cmb_wesie.SelectedIndex);
            TblWesiTeam wesi = DBm.wesiTeam.ElementAt<TblWesiTeam>(cmb_wesie.SelectedIndex);
            rtb_WesiAdresse.Text = $"{wesi.Firma} {wesi.Niederlassung}" + Environment.NewLine + wesi.Bereich + Environment.NewLine + wesi.Strasse + Environment.NewLine + wesi.PLZ + " " + wesi.Stadt;
            tb_WesiMail.Text = wesi.Email;
        }

        private void Cb_plansaetze_CheckedChanged(object sender, EventArgs e)
        {
            pdf.plansaetze = cb_plansaetze.Checked;
        }

        private void Cb_beteiligte_CheckedChanged(object sender, EventArgs e)
        {
            pdf.listeBeteiligte = cb_beteiligte.Checked;
        }

        private void Cb_techBeschreibung_CheckedChanged(object sender, EventArgs e)
        {
            pdf.techBeschreibung = cb_techBeschreibung.Checked;
        }

        private void Tb_ZusatzAnlage1_TextChanged(object sender, EventArgs e)
        {
            pdf.zusatzAnlage1 = tb_ZusatzAnlage1.Text;
        }

        private void Tb_ZusatzAnlage2_TextChanged(object sender, EventArgs e)
        {
            pdf.zusatzAnlage2 = tb_ZusatzAnlage2.Text;
        }

        private void Tb_ZusatzAnlage3_TextChanged(object sender, EventArgs e)
        {
            pdf.zusatzAnlage3 = tb_ZusatzAnlage3.Text;
        }

        private void Tb_ortMassnahme_TextChanged(object sender, EventArgs e)
        {
            pdf.ortDerMassnahme = tb_ortMassnahme.Text;
        }

        private void Btn_saveDocument_Click(object sender, EventArgs e)
        {
            error_label.Text = "";
            List<string> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.Title = "PDF Speichern";
                saveFileDialog.ShowDialog();
                string html = pdfWriter.getHTML(FinalPDF);
                pdfWriter.writeHTMLtoPDF(html, saveFileDialog.FileName);
            }
            catch (Exception q) { }
        }

        private void Btn_vorschau_Click(object sender, EventArgs e)
        {
            error_label.Text = "";
            List<string> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen,rtb);


                string html = pdfWriter.getHTML(FinalPDF);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                this.pdfPreview.Navigate("www.google.de");

                pdfPreview.Navigate(pdfWriter.writeHTMLtoPDF(html, hiddenPath));
            }
            catch (Exception ef) { }

        }

        private void Btn_bearbeiten_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_empfaenger.SelectedIndex));
            this.Enabled = false;
            editDataset.ShowDialog();
            this.Enabled = true;
        }

        //noch falsche reihenfolge beim checken
        private List<string> checkInput()
        {
            if (pdf.auftrag == null)
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
                        if (cmb_absender.Text == "")
                        {
                            displayError(ERROR_ABSENDER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.EMPFAENGER:
                        if (cmb_empfaenger.Text == "")
                        {
                            displayError(ERROR_EMPFAENGER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER:
                        if (cmb_Ansprechpartner.Text == "")
                        {
                            displayError(ERROR_ANSPRECHPARTNER);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ORT_DER_MASSNAHMEN:
                        if (tb_ortMassnahme.Text == "")
                        {
                            displayError(ERROR_ORTDERMASSNAHME);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_ABSPRACHEN:
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.BESCHREIBUNG_DER_MASSNAHMEN:
                        if (rtb_BeschreibungMassnahme.Text == "")
                        {
                            displayError(ERROR_BESCHREIBUNGMASSNAHME);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.WESI_TEAM:
                        if (rtb_WesiAdresse.Text == "")
                        {
                            displayError(ERROR_WESI_TEAM_ADRESSE);
                            return null;
                        }
                        break;
                    case Pflichtfelder_Klassen.Pflichtfelder.ANSPRECHPARTNER_BAU:
                        break;
                }
            }
            List<string> zusatzanlagen = new List<string>();
            if (cb_plansaetze.Checked)
            {
                zusatzanlagen.Add("- Plansatz");
            }
            if (cb_beteiligte.Checked)
            {
                zusatzanlagen.Add("- Liste der Beteiligten");
            }
            if (cb_techBeschreibung.Checked)
            {
                zusatzanlagen.Add("- Technische Beschreibung");
            }
            if (tb_ZusatzAnlage1.Text != "")
            {
                zusatzanlagen.Add("- " + tb_ZusatzAnlage1.Text);
            }
            if (tb_ZusatzAnlage2.Text != "")
            {
                zusatzanlagen.Add("- " + tb_ZusatzAnlage2.Text);
            }
            if (tb_ZusatzAnlage3.Text != "")
            {
                zusatzanlagen.Add("- " + tb_ZusatzAnlage3.Text);
            }

            return zusatzanlagen;
        }
        private void Btn_bearbeiten_wesi_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(DBm.wesiTeam.ElementAt<TblWesiTeam>(cmb_wesie.SelectedIndex));
            this.Enabled = false;
            editDataset.ShowDialog();
            tb_WesiMail.Clear();
            rtb_WesiAdresse.Clear();
            cmb_wesie.Items.Clear();
            cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);
            this.Enabled = true;
        }

        private PDF createPDF(List<string>zusatzanlagen, RichTextBox rtb)
        {
            PDF FinalPDF = new PDF();

             switch (pdfWriter.GetType().Name)
            {
                case "EVU":
                   FinalPDF = new PDF(
                   DBm.auftrag,
                   DBm.anschreiben.ElementAt<TblAnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                   DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_empfaenger.SelectedIndex),
                   DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_absender.SelectedIndex),
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_Ansprechpartner.SelectedIndex),
                   tb_ortMassnahme.Text,
                   //rtb_absprachen.Text,
                   //rtb,
                   //DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_ansprechpartnerBau.SelectedIndex),
                   //DBm.wesiTeam.ElementAt<TblWesiTeam>(cmb_wesie.SelectedIndex),
                   cb_plansaetze.Checked,
                   cb_beteiligte.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
                case "Wupfl":
                   FinalPDF = new PDF(
                   DBm.auftrag,
                   DBm.anschreiben.ElementAt<TblAnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                   DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_empfaenger.SelectedIndex),
                   DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_absender.SelectedIndex),
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_Ansprechpartner.SelectedIndex),
                   tb_ortMassnahme.Text,
                   //rtb_absprachen.Text,
                   rtb,
                   //DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_ansprechpartnerBau.SelectedIndex),
                   DBm.wesiTeam.ElementAt<TblWesiTeam>(cmb_wesie.SelectedIndex),
                   cb_plansaetze.Checked,
                   cb_beteiligte.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
            }

            

            return FinalPDF;
        }
        private void clearAll(bool fullClear)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Name!= "tb_smNummer")
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void enableAll()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).Enabled=true;
                    else
                        func(control.Controls);
            };

            func(Controls);

            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox&&control.Name!= "tb_smNummer")
                        (control as TextBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(Controls);
            func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

    }
    }
