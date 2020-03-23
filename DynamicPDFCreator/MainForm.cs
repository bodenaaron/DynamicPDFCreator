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
        WorkingPDF workingPDF = new WorkingPDF();
        public MainForm()
        {
           DBm.sqlSchema();
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
                cmb_Ansprechpartner.Items.AddRange(DBm.dbPDF.bearbeiterStringList);
                cmb_Ansprechpartner.SelectedIndex = 0;
                cmb_empfaenger.Items.Clear();
                cmb_empfaenger.Items.AddRange(DBm.dbPDF.ansprechpartnerStringList);
                cmb_absender.Items.Clear();
                cmb_absender.Items.AddRange(DBm.dbPDF.bearbeiterStringList);
                cmb_wesie.Items.Clear();
                cmb_wesie.Items.AddRange(DBm.dbPDF.wesiTeamStringList);
                workingPDF.auftrag = DBm.dbPDF.auftrag;
                //btn_hinzufuegen.Enabled = true;
                listb_vorherige_PDF.Items.Clear();
                listb_vorherige_PDF.Items.AddRange(DBm.dbPDF.pdfsTitel);
            }
            catch (Exception fe) { }
        }

        private void ReinitializeComponents()
        {
            this.WindowState = FormWindowState.Maximized;
            //Combobox Anschreiben Typ
            cmb_anschreibenTyp.Items.Clear();
            cmb_anschreibenTyp.Items.AddRange(DBm.dbPDF.anschreibenStringList);
            cmb_wesie.Items.AddRange(DBm.dbPDF.wesiTeamStringList);
            //cmb_anschreibenTyp.SelectedIndex = 2;
            cmb_Ansprechpartner.Items.Clear();
            cmb_Ansprechpartner.Items.AddRange(DBm.dbPDF.bearbeiterStringList);
            cmb_absender.Items.Clear();
            cmb_absender.Items.AddRange(DBm.dbPDF.bearbeiterStringList);
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
            AnschreibenTyp anschreiben = new AnschreibenTyp();

            if (workingPDF.auftrag!=null)
            {
                anschreiben = DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex);
            }

            switch (anschreiben.id - 1)
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
                    //ZUstimmungsbescheid
                    enableAll();
                    rtb_absprachen.Enabled = false;
                    cmb_ansprechpartnerBau.Enabled = false;
                    rtb_BeschreibungMassnahme.Enabled = false;
                    cmb_absender.Enabled = false;
                    cmb_Ansprechpartner.Enabled = false;
                    datePicker.Enabled = false;
                    datePickerAusfuehrung.Enabled = false;
                    datePickerAusfuehrungEnde.Enabled = false;
                    pdfWriter = new Interfaces.Zustimmungsbescheid();
                    pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_Zustimmungsbescheid.PFLICHTFELDER;
                    break;
                case 6:
                    //Abstimmung Naturschutz
                    enableAll();
                    rtb_absprachen.Enabled = false;
                    cmb_ansprechpartnerBau.Enabled = false;
                    cmb_Ansprechpartner.Enabled = false;
                    cmb_wesie.Enabled = false;
                    pdfWriter = new Interfaces.AbstimmungNaturschutz();
                    pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_AbstimmungNaturschutz.PFLICHTFELDER;
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
                    //Anschreiben Kampfmittel
                    enableAll();
                    cmb_absender.Enabled = false;
                    datePickerAusfuehrung.Enabled = false;
                    datePickerAusfuehrungEnde.Enabled = false;
                    cmb_Ansprechpartner.Enabled = false;
                    rtb_absprachen.Enabled = false;
                    rtb_BeschreibungMassnahme.Enabled = false;
                    cmb_ansprechpartnerBau.Enabled = false;
                    pdfWriter = new Interfaces.Kampfmittel();
                    pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_Kampfmittel.PFLICHTFELDER;
                    break;
            }


            workingPDF.anschreibenTyp = anschreiben;
        }

        private void Cmb_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingPDF.empfaenger = DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex);
            btn_bearbeiten.Enabled = true;


        }

        private void Cmb_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingPDF.absender = DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_absender.SelectedIndex);
            cmb_Ansprechpartner.SelectedIndex = cmb_absender.SelectedIndex;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            workingPDF.datum = datePicker.Value;
        }

        private void DatePickerAusfuehrung_ValueChanged(object sender, EventArgs e)
        {
            workingPDF.ausfuehrungszeitraum = datePickerAusfuehrung.Value;
            datePickerAusfuehrungEnde.Value = datePickerAusfuehrung.Value;
        }

        private void Cmb_Ansprechpartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingPDF.ansprechpartner = DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_Ansprechpartner.SelectedIndex);
        }

        private void Rtb_absprachen_TextChanged(object sender, EventArgs e)
        {
            workingPDF.abgesprochenMit = rtb_absprachen.Text;
        }

        private void Rtb_BeschreibungMassnahme_TextChanged(object sender, EventArgs e)
        {
            workingPDF.beschreibungMassnahme = rtb_BeschreibungMassnahme.Rtf;
        }

        private void Cmb_ansprechpartnerBau_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingPDF.ansprechpartnerBau = DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_ansprechpartnerBau.SelectedIndex);
        }

        private void Rtb_WesiAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_wesie_SelectedIndexChanged(object sender, EventArgs e)
        {
            workingPDF.wesiTeam = DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex);
            WesiTeam wesi = DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex);
            rtb_WesiAdresse.Text = $"{wesi.firma} {wesi.niederlassung}" + Environment.NewLine + wesi.bereich + Environment.NewLine + wesi.strasse + Environment.NewLine + wesi.plz + " " + wesi.stadt;
            tb_WesiMail.Text = wesi.email;
        }

        private void Cb_plansaetze_CheckedChanged(object sender, EventArgs e)
        {
            workingPDF.plansaetze = cb_plansaetze.Checked;
        }

        private void Cb_beteiligte_CheckedChanged(object sender, EventArgs e)
        {
            workingPDF.listeBeteiligte = cb_beteiligte.Checked;
        }

        private void Cb_techBeschreibung_CheckedChanged(object sender, EventArgs e)
        {
            workingPDF.techBeschreibung = cb_techBeschreibung.Checked;
        }        

        private void Tb_ortMassnahme_TextChanged(object sender, EventArgs e)
        {
            workingPDF.ortDerMassnahme = tb_ortMassnahme.Text;
        }

        private void Btn_saveDocument_Click(object sender, EventArgs e)
        {
            error_label.Text = "";
            List<string> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Text);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.Title = "PDF Speichern";
                saveFileDialog.ShowDialog();
                pdfWriter.writeHTMLtoPDF(FinalPDF, saveFileDialog.FileName);
                DBm.savePDF(FinalPDF);
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
                PDF FinalPDF = createPDF(zusatzanlagen,rtb.Text);

                //DBm.testSave(pdf);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                this.pdfPreview.Navigate("www.google.de");

                pdfPreview.Navigate(pdfWriter.writeHTMLtoPDF(FinalPDF, hiddenPath));
            }
            catch (Exception ef) { }

        }

        private void Btn_bearbeiten_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex), DBm.dbPDF.ansprechpartnerTypStringList);
            this.Enabled = false;
            editDataset.ShowDialog();
            this.Enabled = true;
        }

        //noch falsche reihenfolge beim checken
        private List<string> checkInput()
        {
            if (workingPDF.auftrag == null)
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
            if (cb_untervollmacht.Checked)
            {
                zusatzanlagen.Add("- Untervollmacht");
            }
            foreach (object i in listb_zusatzanlagen.Items)
            {
                zusatzanlagen.Add(i.ToString());
            }
            return zusatzanlagen;
        }
        private void Btn_bearbeiten_wesi_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex));
            this.Enabled = false;
            editDataset.ShowDialog();
            tb_WesiMail.Clear();
            rtb_WesiAdresse.Clear();
            cmb_wesie.Items.Clear();
            cmb_wesie.Items.AddRange(DBm.dbPDF.wesiTeamStringList);
            this.Enabled = true;
        }

        private PDF createPDF(List<string>zusatzanlagen, string rtb)
        {
            PDF FinalPDF = new PDF();

             switch (pdfWriter.GetType().Name)
            {
                case "EVU":
                   FinalPDF = new PDF(
                   DBm.dbPDF.auftrag,
                   DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                   DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex),
                   DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_absender.SelectedIndex),
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_Ansprechpartner.SelectedIndex),
                   tb_ortMassnahme.Text,
                   cb_plansaetze.Checked,
                   cb_beteiligte.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
                case "Wupfl":
                   FinalPDF = new PDF(
                   DBm.dbPDF.auftrag,
                   DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                   DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex),
                   DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_absender.SelectedIndex),
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_Ansprechpartner.SelectedIndex),
                   tb_ortMassnahme.Text,
                   rtb,
                   DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex),
                   cb_plansaetze.Checked,
                   cb_beteiligte.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
                case "Zustimmungsbescheid":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                    DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex),
                    tb_ortMassnahme.Text,
                    DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex)

                    );
                    break;
                case "AbstimmungNaturschutz":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                    DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex),
                    DBm.dbPDF.bearbeiter.ElementAt<Bearbeiter>(cmb_absender.SelectedIndex),
                    datePicker.Value,
                    datePickerAusfuehrung.Value,
                    datePickerAusfuehrungEnde.Value.Date,
                    tb_ortMassnahme.Text,
                    rtb,
                    cb_plansaetze.Checked,
                    cb_beteiligte.Checked,
                    cb_techBeschreibung.Checked,
                    cb_untervollmacht.Checked,
                    zusatzanlagen);
                    break;
                case "Kampfmittel":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    DBm.dbPDF.anschreiben.ElementAt<AnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex),
                    DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_empfaenger.SelectedIndex),
                    tb_ortMassnahme.Text,
                    DBm.dbPDF.wesiTeams.ElementAt<WesiTeam>(cmb_wesie.SelectedIndex),
                    datePicker.Value
                    );
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

        private void Btn_speichern_auftrag_pfad_Click(object sender, EventArgs e)
        {
            
            error_label.Text = "";
            List<string> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Text);
                string pfad = getDynamicPath(FinalPDF);
                
                pdfWriter.writeHTMLtoPDF(FinalPDF, pfad);
                DBm.savePDF(FinalPDF);
            }
            catch (Exception q) { }
        }

        private string getDynamicPath(PDF finalPDF)
        {
            string pfad = $@"C:\Datenbank\Projekte\{finalPDF.auftrag.projekt.projektbezeichnung}_{finalPDF.auftrag.projekt.id}\Aufträge\";
            string[] subdirs = Directory.GetDirectories(pfad);
            string ordnerName="";
            foreach (string dir in subdirs)
            {
                ordnerName = dir.Substring(dir.LastIndexOf("\\"));
                if (ordnerName.Contains(finalPDF.auftrag.smNummer))
                {
                    break;
                }
            }
            pfad += ordnerName;
            pfad += $@"\Wegesicherung\Anschreiben\{finalPDF.anschreibenTyp.bezeichnung}_{finalPDF.empfaenger.ansprechpartnerName}_{finalPDF.empfaenger.firma}.pdf";
            return pfad;
        }

        private void Listb_vorherige_PDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAll(false);


            loadPDF();
        }

        private void loadPDF()
        {
            PDF pdf = DBm.dbPDF.auftrag.pdfs.ElementAt<PDF>(listb_vorherige_PDF.SelectedIndex);

            cmb_anschreibenTyp.SelectedIndex=pdf.anschreibenTyp.id-1;
            cmb_empfaenger.SelectedIndex = pdf.empfaenger.id - 1;
            
            datePicker.Value = pdf.datum;
            datePickerAusfuehrung.Value = pdf.ausfuehrungszeitraum;
            datePickerAusfuehrungEnde.Value = pdf.ausfuehrungszeitraumEnde;
            
            tb_ortMassnahme.Text = pdf.ortDerMassnahme;
            rtb_absprachen.Text = pdf.abgesprochenMit;
            rtb_BeschreibungMassnahme.Text = pdf.beschreibungMassnahme;
            cmb_wesie.SelectedIndex = pdf.wesiTeam.id - 1;
            cmb_ansprechpartnerBau.SelectedIndex = pdf.ansprechpartnerBau.id - 1;
            cb_beteiligte.Checked = pdf.listeBeteiligte;
            cb_untervollmacht.Checked = pdf.untervollmacht;
            cb_plansaetze.Checked = pdf.plansaetze;
            cb_techBeschreibung.Checked = pdf.techBeschreibung;                                                   
        
            int i = 0;
            foreach (string s in cmb_Ansprechpartner.Items)
            {
                i++;
                if (s==(pdf.ansprechpartner.bearbeiterVorname + " " + pdf.ansprechpartner.bearbeiterName))
                {
                    cmb_Ansprechpartner.SelectedIndex = i;
                }
            }
            i = 0;
            foreach (string s in cmb_absender.Items)
            {
                i++;
                if (s == (pdf.absender.bearbeiterVorname + " " + pdf.absender.bearbeiterName))
                {
                    cmb_absender.SelectedIndex = i;
                }
            }            
        }

        private void Btn_add_zusatzanlagen_Click(object sender, EventArgs e)
        {
            listb_zusatzanlagen.Items.Add(tb_zusatzanlage.Text);
            tb_zusatzanlage.Clear();
        }

        private void Btn_remove_selected_Click(object sender, EventArgs e)
        {
            listb_zusatzanlagen.Items.Remove(listb_zusatzanlagen.SelectedItem);
        }

        private void Listb_zusatzanlagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_remove_selected.Enabled = true;
            btn_remove_all.Enabled = true;
            if (listb_zusatzanlagen.Items.Count<1)
            {
                btn_remove_selected.Enabled = false;
                btn_remove_all.Enabled = false;
            }
        }

        private void Btn_remove_all_Click(object sender, EventArgs e)
        {
            listb_zusatzanlagen.Items.Clear();
            if (listb_zusatzanlagen.Items.Count < 1)
            {
                btn_remove_selected.Enabled = false;
                btn_remove_all.Enabled = false;
            }
        }
    }
    }
    
