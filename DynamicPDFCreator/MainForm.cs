using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPDFCreator
{
    public partial class MainForm : Form
    {
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

        private void Label7_Click(object sender, EventArgs e)
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
            }
            catch (Exception fe) { }
        }

        private void ReinitializeComponents()
        {
            //Combobox Anschreiben Typ
            cmb_anschreibenTyp.Items.AddRange(DBm.anschreibenNamen);
            cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);
            cmb_anschreibenTyp.SelectedIndex = 2;
            cmb_Ansprechpartner.Items.Clear();
            cmb_Ansprechpartner.Items.AddRange(DBm.bearbeiterNamen);
            cmb_absender.Items.Clear();
            cmb_absender.Items.AddRange(DBm.bearbeiterNamen);
            //Datepicker custom form

            datePickerAusfuehrung.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrung.CustomFormat = "MMMM-yyyy";

            datePickerAusfuehrungEnde.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrungEnde.CustomFormat = "MMMM-yyyy";

        }

        private void Cmb_anschreibenTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblAnschreibenTyp anschreiben= DBm.anschreiben.ElementAt<TblAnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex);

            switch (anschreiben.Id-1)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    //Interfaces.Wupfl wupfl = new Interfaces.Wupfl();
                    //pdfPreview.DocumentText= wupfl.getHTML(pdf);
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
            rtb_WesiAdresse.Text = wesi.Bezeichnung + Environment.NewLine + wesi.Bereich + Environment.NewLine + wesi.Strasse + " " + wesi.Hausnummer + Environment.NewLine + wesi.PLZ + " " + wesi.Stadt;
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

            if (pdf.auftrag == null)
            {
                displayError(ERROR_SMNUMMER);
            }
            if (tb_ortMassnahme.Text=="")
            {
                displayError(ERROR_ORTDERMASSNAHME);
            }
            if (rtb_WesiAdresse.Text == "")
            {
                displayError(ERROR_WESI_TEAM_ADRESSE);
            }
            List<string> zusatzanlagen=new List<string>();
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
            if (tb_ZusatzAnlage1.Text!="")
            {
                zusatzanlagen.Add("- "+tb_ZusatzAnlage1.Text);
            }
            if (tb_ZusatzAnlage2.Text != "")
            {
                zusatzanlagen.Add("- " + tb_ZusatzAnlage2.Text);
            }
            if (tb_ZusatzAnlage3.Text != "")
            {
                zusatzanlagen.Add("- " + tb_ZusatzAnlage3.Text);
            }

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = new PDF(
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
                    zusatzanlagen);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.Title = "PDF Speichern";
                saveFileDialog.ShowDialog();

                Interfaces.Wupfl wupfl = new Interfaces.Wupfl();

                string html = wupfl.getHTML(FinalPDF);
                wupfl.writeHTMLtoPDF(html, saveFileDialog.FileName);
            }
            catch (Exception q) { }
        }

        private void Btn_vorschau_Click(object sender, EventArgs e)
        {
            
            if (pdf.auftrag == null)
            {
                displayError(ERROR_SMNUMMER);
            }
            if (tb_ortMassnahme.Text == "")
            {
                displayError(ERROR_ORTDERMASSNAHME);
            }
            if (rtb_WesiAdresse.Text == "")
            {
                displayError(ERROR_WESI_TEAM_ADRESSE);
            }

            if (cmb_empfaenger.Text=="")
            {
                displayError(ERROR_EMPFAENGER);
            }
            if (cmb_absender.Text == "")
            {
                displayError(ERROR_ABSENDER);
            }
            if (rtb_BeschreibungMassnahme.Text == "")
            {
                displayError(ERROR_BESCHREIBUNGMASSNAHME);
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

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                 PDF FinalPDF = new PDF(
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
                    zusatzanlagen);

                Interfaces.Wupfl wupfl = new Interfaces.Wupfl();

                string html = wupfl.getHTML(FinalPDF);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                this.pdfPreview.Navigate("www.google.de");

                pdfPreview.Navigate(wupfl.writeHTMLtoPDF(html, hiddenPath));
            }
            catch (Exception ef) { }
            
        }

        private void Btn_bearbeiten_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_empfaenger.SelectedIndex));
            this.Enabled=false;
            editDataset.ShowDialog();
            this.Enabled = true;
        }
    }
}
