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
    public partial class MainForm : Form
    {
        private object[] pflichtfelder_typ;
        Interfaces.IPDFWriter pdfWriter;
        DBManager DBm = new DBManager();
        WorkingPDF workingPDF = new WorkingPDF();
        PDF pdf;
        public MainForm()
        {
           //DBm.sqlSchema();
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
                //Empfänger Festlegen
                if (DBm.dbPDF.auftrag!=null)
                {
                    cmb_empfaenger.DataSource = new BindingSource(DBm.dbPDF.dic_Ansprechpartner, null);
                    cmb_empfaenger.DisplayMember = "Key";
                    cmb_empfaenger.ValueMember = "Value";
                    cmb_empfaenger.SelectedItem = null;
                    cmb_empfaenger.SelectedIndexChanged += new System.EventHandler(Cmb_empfaenger_SelectedIndexChanged);
                    workingPDF.auftrag = DBm.dbPDF.auftrag;

                    //Vorherige PDFs festlegen
                    listb_vorherige_PDF.DisplayMember = "Key";
                    listb_vorherige_PDF.ValueMember = "Value";
                    listb_vorherige_PDF.DataSource = new BindingSource(DBm.dbPDF.dic_pdf, null);
                    listb_vorherige_PDF.SelectedItem = null;
                    listb_vorherige_PDF.SelectedIndexChanged += new System.EventHandler(Listb_vorherige_PDF_SelectedIndexChanged);
                }                                
            }
            catch (Exception fe) { Debug.WriteLine("\nSMnummer nicht gefunden\n\n\n"); }
        }

        private void ReinitializeComponents()
        {
            this.WindowState = FormWindowState.Maximized;
            
            cmb_anschreibenTyp.DataSource = new BindingSource(DBm.dbPDF.dic_AnschreibenTyp, null);
            cmb_anschreibenTyp.DisplayMember = "Key";
            cmb_anschreibenTyp.ValueMember = "Value";
            cmb_anschreibenTyp.SelectedItem = null;
            cmb_anschreibenTyp.SelectedIndexChanged += new System.EventHandler(Cmb_anschreibenTyp_SelectedIndexChanged);            

            //WesiTeam            
            cmb_wesie.DataSource = new BindingSource(DBm.dbPDF.dic_WesiTeam, null);            
            cmb_wesie.DisplayMember = "Key";
            cmb_wesie.ValueMember = "Value";
            cmb_wesie.SelectedItem = null;
            cmb_wesie.SelectedIndexChanged += new System.EventHandler(Cmb_wesie_SelectedIndexChanged);

            //Ansprechpartner            
            cmb_Ansprechpartner.DataSource = new BindingSource(DBm.dbPDF.dic_Bearbeiter, null);
            cmb_Ansprechpartner.DisplayMember = "Key";
            cmb_Ansprechpartner.ValueMember = "Value";
            cmb_Ansprechpartner.SelectedItem = null;
            cmb_Ansprechpartner.SelectedIndexChanged += new System.EventHandler(Cmb_Ansprechpartner_SelectedIndexChanged);
            
            //Absender
            cmb_absender.DataSource = new BindingSource(DBm.dbPDF.dic_Bearbeiter, null);
            cmb_absender.DisplayMember = "Key";
            cmb_absender.ValueMember = "Value";
            cmb_absender.SelectedItem = null;
            cmb_absender.SelectedIndexChanged += new System.EventHandler(Cmb_absender_SelectedIndexChanged);

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
            AnschreibenTyp anschreiben = new AnschreibenTyp(); ;

            if (cmb_anschreibenTyp.SelectedItem!=null)
            {
                 anschreiben = ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value;


                switch (anschreiben.id)
                {
                    case 1:
                        //EVU
                        enableAll();
                        pdfWriter = new Interfaces.EVU();
                        rtb_absprachen.Enabled = false;
                        rtb_BeschreibungMassnahme.Enabled = false;
                        cmb_wesie.Enabled = false;
                        cmb_ansprechpartnerBau.Enabled = false;
                        pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_EVU.PFLICHTFELDER;
                        break;
                    case 2:
                        break;
                    case 3:
                        //WUPFL
                        enableAll();
                        rtb_absprachen.Enabled = false;
                        cmb_ansprechpartnerBau.Enabled = false;
                        pdfWriter = new Interfaces.Wupfl();
                        pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_EVU.PFLICHTFELDER;
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
                    case 7:
                        //Abstimmung Naturschutz
                        enableAll();
                        rtb_absprachen.Enabled = false;
                        cmb_ansprechpartnerBau.Enabled = false;
                        cmb_Ansprechpartner.Enabled = false;
                        cmb_wesie.Enabled = false;
                        pdfWriter = new Interfaces.AbstimmungNaturschutz();
                        pflichtfelder_typ = Pflichtfelder_Klassen.Pflicht_AbstimmungNaturschutz.PFLICHTFELDER;
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
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
                }
            
            


            workingPDF.anschreibenTyp = anschreiben;
        }

        private void Cmb_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_empfaenger.SelectedItem!=null &&cmb_empfaenger.Items.Count>0)
            {
                workingPDF.empfaenger = ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value;
                btn_bearbeiten.Enabled = true;
            }

        }

        private void Cmb_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_absender.SelectedItem!=null)
            {
                workingPDF.absender = ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value;

            }
            cmb_Ansprechpartner.SelectedItem= cmb_absender.SelectedItem;

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
            if (cmb_Ansprechpartner.SelectedItem != null)
            {
                workingPDF.ansprechpartner = ((KeyValuePair<string, Bearbeiter>)cmb_Ansprechpartner.SelectedItem).Value; 
            }
            
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
            //workingPDF.ansprechpartnerBau = DBm.dbPDF.auftrag.projekt.ansprechpartner.ElementAt<Ansprechpartner>(cmb_ansprechpartnerBau.SelectedIndex);
        }

        private void Rtb_WesiAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_wesie_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_wesie.SelectedItem != null)
            {
                workingPDF.wesiTeam = ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value;
                WesiTeam wesi = ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value;
                rtb_WesiAdresse.Text = $"{wesi.firma} {wesi.niederlassung}" + Environment.NewLine + wesi.bereich + Environment.NewLine + wesi.strasse + Environment.NewLine + wesi.plz + " " + wesi.stadt;
                tb_WesiMail.Text = wesi.email;
            }
            tb_WesiMail.Text = "";
            rtb_WesiAdresse.Text = "";
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
            listb_vorherige_PDF.SelectedItem = null;
            error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);

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
            listb_vorherige_PDF.SelectedItem = null;
            error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen,rtb.Rtf);

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
            editDataset.ReinitializeComponent(((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value, DBm.dbPDF.dic_ansprechpartnerTypen);
            this.Enabled = false;
            editDataset.ShowDialog();
            this.Enabled = true;
        }

        //noch falsche reihenfolge beim checken
        private List<Zusatzanlage> checkInput()
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
            List<Zusatzanlage> zusatzanlagen = new List<Zusatzanlage>();
            //if (cb_plansaetze.Checked)
            //{
            //    zusatzanlagen.Add(new Zusatzanlage("- Plansatz"));
            //}
            //if (cb_beteiligte.Checked)
            //{
            //    zusatzanlagen.Add(new Zusatzanlage("- Liste der Beteiligten"));
            //}
            //if (cb_techBeschreibung.Checked)
            //{
            //    zusatzanlagen.Add(new Zusatzanlage("- Technische Beschreibung"));
            //}
            //if (cb_untervollmacht.Checked)
            //{
            //
            //    zusatzanlagen.Add(new Zusatzanlage("- Untervollmacht"));
            //}
            
            foreach (object i in listb_zusatzanlagen.Items)
            {
                zusatzanlagen.Add(new Zusatzanlage(i.ToString()));
            }
            
            return zusatzanlagen;
        }
        private void Btn_bearbeiten_wesi_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value);
            this.Enabled = false;
            editDataset.ShowDialog();
            tb_WesiMail.Clear();
            rtb_WesiAdresse.Clear();

            cmb_wesie.DisplayMember = "Key";
            cmb_wesie.ValueMember = "Value";
            cmb_wesie.DataSource=DBm.dbPDF.dic_WesiTeam;
            this.Enabled = true;
        }

        private PDF createPDF(List<Zusatzanlage> zusatzanlagen, string rtb)
        {
            PDF FinalPDF = new PDF();

             switch (pdfWriter.GetType().Name)
            {
                case "EVU":
                   FinalPDF = new PDF(
                   DBm.dbPDF.auftrag,
                   ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                   ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                   ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value,
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value,
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
                   ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                   ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                   ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value,
                   datePicker.Value,
                   datePickerAusfuehrung.Value,
                   datePickerAusfuehrungEnde.Value.Date,
                   ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value,
                   tb_ortMassnahme.Text,
                   rtb,
                   ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value,
                   cb_plansaetze.Checked,
                   cb_beteiligte.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
                case "Zustimmungsbescheid":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                    ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                    tb_ortMassnahme.Text,
                    ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value

                    );
                    break;
                case "AbstimmungNaturschutz":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                    ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                    ((KeyValuePair<string, Bearbeiter>)cmb_absender.SelectedItem).Value,
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
                    ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                    ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                    tb_ortMassnahme.Text,
                    ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value,
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
            listb_vorherige_PDF.SelectedItem = null;
            error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = checkInput();

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);
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
            if (listb_vorherige_PDF.SelectedItem != null && tb_smNummer.Text != null)
            {                
                loadPDF();
            }
            else { pdfPreview.DocumentText = null; }

            if (listb_vorherige_PDF.SelectedItem!=null)
            {
                btn_load_PDF.Enabled = true;
            }
            else { btn_load_PDF.Enabled = false; }
        }

        private void loadPDF()
        {
            PDF pdf = ((KeyValuePair<string, PDF>)listb_vorherige_PDF.SelectedItem).Value;

            switch (pdf.anschreibenTyp.bezeichnung) {
                case "Anschreiben EVU":
                    pdfWriter = new Interfaces.EVU();
                    break;
                case "Anschreiben Mitbenutzung":
                    break;
                case "Antrag Wupfl":
                    pdfWriter = new Interfaces.Wupfl();
                    break;
                case "Behördliche Genehmigung":
                    break;
                case "Erläuterungsbericht":
                    break;
                case "Zustimmungsbescheid":
                    pdfWriter = new Interfaces.Zustimmungsbescheid();
                    break;
                case "Abstimmung Naturschutz":
                    pdfWriter = new Interfaces.AbstimmungNaturschutz();   
                    break;
                case "SOS Zustimmungsbescheid":
                    break;
                case "SOS Antrag":
                    break;
                case "Anschreiben Kommune":
                    break;
                case "Anschreiben Datenblatt":
                    break;
                case "Anschreiben Kommune Trenching":
                    break;
                case "Anschreiben Kampfmittel":
                    pdfWriter = new Interfaces.Kampfmittel();
                    break;
            }
            string hiddenPath = Path.GetTempPath() + @"\testVorschaupdf.pdf";
            //this.pdfPreview.Navigate("www.google.de");

            pdfPreview.Navigate(pdfWriter.writeHTMLtoPDF(pdf, hiddenPath));
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

        private void btn_load_PDF_Click(object sender, EventArgs e)
        {
            PDF pdf = ((KeyValuePair<string, PDF>)listb_vorherige_PDF.SelectedItem).Value;
            workingPDF = new WorkingPDF(pdf);

            //Anschreiben Typ
            Dictionary<string, AnschreibenTyp> anschreibenTypen = DBm.dbPDF.dic_AnschreibenTyp;            
            cmb_anschreibenTyp.DataSource = new BindingSource(anschreibenTypen, null);
            cmb_anschreibenTyp.DisplayMember = "Key";
            cmb_anschreibenTyp.ValueMember = "Value";
            if(anschreibenTypen.TryGetValue(pdf.anschreibenTyp.bezeichnung, out AnschreibenTyp typ))
            {                                
                cmb_anschreibenTyp.SelectedItem = new KeyValuePair<string, AnschreibenTyp>(typ.bezeichnung,typ);
            }

            //Empfänger
            if (pdf.empfaenger!=null)
            {
                Dictionary<string, Ansprechpartner> empfaenger = DBm.dbPDF.dic_Ansprechpartner;
                cmb_empfaenger.DataSource = new BindingSource(empfaenger, null);
                cmb_empfaenger.DisplayMember = "Key";
                cmb_empfaenger.ValueMember = "Value";
                if (empfaenger.TryGetValue($@"{pdf.empfaenger.ansprechpartnerVorname} {pdf.empfaenger.ansprechpartnerName}", out Ansprechpartner ansp))
                {
                    cmb_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{ansp.ansprechpartnerVorname} {ansp.ansprechpartnerName}",ansp);
                }
                else if (empfaenger.TryGetValue($@"{pdf.empfaenger.firma}", out Ansprechpartner anspFirma))
                {
                    cmb_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{ansp.firma}", anspFirma);
                }
            }
            
            //Absender
            if (pdf.absender!=null)
            {
                Dictionary<string, Bearbeiter> absender = DBm.dbPDF.dic_Bearbeiter;
                cmb_absender.DataSource = new BindingSource(absender, null);
                cmb_absender.DisplayMember = "Key";
                cmb_absender.ValueMember = "Value";
                if (absender.TryGetValue($@"{pdf.absender.bearbeiterVorname} {pdf.absender.bearbeiterName}", out Bearbeiter bearb))
                {
                    cmb_absender.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{bearb.bearbeiterVorname} {bearb.bearbeiterName}",bearb);
                }
            }
            
            //Ansprechparner
            if (pdf.ansprechpartner!=null)
            {
                Dictionary<string, Bearbeiter> ansprechpartner = DBm.dbPDF.dic_Bearbeiter;
                cmb_Ansprechpartner.DataSource = new BindingSource(ansprechpartner, null);
                cmb_Ansprechpartner.DisplayMember = "Key";
                cmb_Ansprechpartner.ValueMember = "Value";
                if (ansprechpartner.TryGetValue($@"{pdf.ansprechpartner.bearbeiterVorname} {pdf.ansprechpartner.bearbeiterName}", out Bearbeiter ansprech))
                {
                    cmb_Ansprechpartner.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{ansprech.bearbeiterVorname} {ansprech.bearbeiterName}", ansprech);
                }
            }
            
            //Betreff
            tb_ortMassnahme.Text = pdf.ortDerMassnahme;

            //Absprachen
            rtb_absprachen.Text = pdf.abgesprochenMit;

            //Beschreibung der Maßnahme
            rtb_BeschreibungMassnahme.Rtf = pdf.beschreibungMassnahme;

            // Wesi Team
            if (pdf.wesiTeam!=null)
            {
                Dictionary<string, WesiTeam> wesiTeam = DBm.dbPDF.dic_WesiTeam;
                cmb_wesie.DataSource = new BindingSource(wesiTeam, null);
                cmb_wesie.DisplayMember = "Key";
                cmb_wesie.ValueMember = "Value";
                if (wesiTeam.TryGetValue($@"{pdf.wesiTeam.firma} { pdf.wesiTeam.niederlassung} ", out WesiTeam wesi))
                {
                    cmb_wesie.SelectedItem = new KeyValuePair<string, WesiTeam>($@"{wesi.firma} {wesi.niederlassung}", wesi);
                }
            }


            //Ansprechpartner Bau
            if (pdf.ansprechpartnerBau != null)
            {
                Dictionary<string, Ansprechpartner> ansprechBau = DBm.dbPDF.dic_Ansprechpartner;
                cmb_ansprechpartnerBau.DataSource = new BindingSource(ansprechBau, null);
                cmb_ansprechpartnerBau.DisplayMember = "Key";
                cmb_ansprechpartnerBau.ValueMember = "Value";
                if (ansprechBau.TryGetValue($@"{pdf.ansprechpartnerBau.ansprechpartnerVorname} {pdf.ansprechpartnerBau.ansprechpartnerName}", out Ansprechpartner anspBau))
                {
                    cmb_ansprechpartnerBau.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspBau.ansprechpartnerVorname} {anspBau.ansprechpartnerName}", anspBau);
                }
                else if (ansprechBau.TryGetValue($@"{pdf.ansprechpartnerBau.firma}", out Ansprechpartner anspBauFirma))
                {
                    cmb_ansprechpartnerBau.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspBauFirma.firma}", anspBauFirma);
                }
            }

            //Checkboxen
            cb_beteiligte.Checked = pdf.listeBeteiligte;
            cb_untervollmacht.Checked = pdf.untervollmacht;
            cb_plansaetze.Checked = pdf.plansaetze;
            cb_techBeschreibung.Checked = pdf.techBeschreibung;

            //Zusätzliche Anhänge
            if (pdf.tblZusatzanlagen != null)
            {
                listb_zusatzanlagen.Items.Clear();
                foreach (Zusatzanlage zu in pdf.tblZusatzanlagen)
                {
                    listb_zusatzanlagen.Items.Add(zu.anlage);
                }                             
            }


        }
    }
    }
    
