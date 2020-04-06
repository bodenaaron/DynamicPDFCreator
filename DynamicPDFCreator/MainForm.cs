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
        EnableHandler eH;                     
        DBManager DBm = new DBManager();
        public WorkingPDF workingPDF;
        public bool neuzuweisung;
        public string savedFile;
        public string savedFolder;
        public MainForm()
        {
            this.Font= new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DBm.sqlSchema();
            InitializeComponent();
            eH = new EnableHandler(this);            
            ReinitializeComponents();            
        }
        private void ReinitializeComponents()
        {
            eH.disableAll(true);
            this.WindowState = FormWindowState.Maximized;
            //Alle Methoden die auf selectedIndexChanged hören deaktivieren
            neuzuweisung = true;
            cmb_anschreibenTyp.DataSource = new BindingSource(DBm.dbPDF.dic_AnschreibenTyp, null);
            cmb_anschreibenTyp.DisplayMember = "Key";
            cmb_anschreibenTyp.ValueMember = "Value";
            cmb_anschreibenTyp.SelectedItem = null;
            cmb_anschreibenTyp.FlatStyle = FlatStyle.Popup;
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

            //Absender EF
            cmb_ef_absender.DataSource = new BindingSource(DBm.dbPDF.dic_Bearbeiter, null);
            cmb_ef_absender.DisplayMember = "Key";
            cmb_ef_absender.ValueMember = "Value";
            cmb_ef_absender.SelectedItem = null;
            cmb_ef_absender.SelectedIndexChanged += new System.EventHandler(cmb_ef_absender_SelectedIndexChanged);

            //Datepicker custom form
            datePickerAusfuehrung.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrung.CustomFormat = "MMMM-yyyy";

            datePickerAusfuehrungEnde.Format = DateTimePickerFormat.Custom;
            datePickerAusfuehrungEnde.CustomFormat = "MMMM-yyyy";

            //enableAll();
            btn_bearbeiten.Enabled = false;
            //btn_hinzufuegen.Enabled = false;

            //Alle Methoden die auf selectedIndexChanged hören aktivieren
            neuzuweisung = false;

            workingPDF = new WorkingPDF();

        }
        public void tabSwitch(object sender, EventArgs e)
        {
            workingPDF = new WorkingPDF();
            MainTab = new TabPage();
            customFormular = new TabPage();
            TabPage page = sender as TabPage;
            if (this.tabControl.SelectedTab.Text=="Eigenes Formular")
            {
               //workingPDF.pdfWriter = new Interfaces.EigenesFormular();
                workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_EigenesFormular.PFLICHTFELDER;
                if (tb_EF_SMNummer.Text=="")
                {
                    eH.manageFieldsEF(Pflichtfelder_Klassen.Pflicht_EigenesFormular.FELDER);
                }
                else { eH.manageFieldsSwitchTabs(); }
            }
            else { eH.disableAll(false); eH.clearColor(true); }            
            listb_EF_vorherigePDF.SelectedItem = null;
        }

        private void Tb_smNummer_TextChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }

            if (tb_smNummer.TextLength>0)
            {
                btn_suchen.Enabled = true;
            }
            else{ btn_suchen.Enabled = false; }
        }

        private void tb_EF_SMNummer_TextChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }

            if (tb_EF_SMNummer.TextLength > 0)
            {
                btn_EF_suchen.Enabled = true;
            }
            else { btn_EF_suchen.Enabled = false; }
        }     

        private void Cmb_anschreibenTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            AnschreibenTyp anschreiben = new AnschreibenTyp();
            
            if (cmb_anschreibenTyp.SelectedItem!=null)
            {
                 anschreiben = ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value;

                switch (anschreiben.id)
                {
                    case 1:
                        //EVU
                        workingPDF.pdfWriter = new Interfaces.EVU();
                        workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_EVU.PFLICHTFELDER;
                        eH.manageFields(Pflichtfelder_Klassen.Pflicht_EVU.FELDER);
                        break;
                    case 2:
                        break;
                    case 3:
                        //WUPFL                                                
                        workingPDF.pdfWriter = new Interfaces.Wupfl();
                        workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Wupfl.PFLICHTFELDER;
                        eH.manageFields(Pflichtfelder_Klassen.Pflicht_Wupfl.FELDER);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        //ZUstimmungsbescheid                        
                        workingPDF.pdfWriter = new Interfaces.Zustimmungsbescheid();
                        workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Zustimmungsbescheid.FELDER;
                        eH.manageFields(Pflichtfelder_Klassen.Pflicht_Zustimmungsbescheid.FELDER);
                        break;
                    case 7:
                        //Abstimmung Naturschutz                        
                        workingPDF.pdfWriter = new Interfaces.AbstimmungNaturschutz();
                        workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_AbstimmungNaturschutz.FELDER;
                        eH.manageFields(Pflichtfelder_Klassen.Pflicht_AbstimmungNaturschutz.FELDER);
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
                        workingPDF.pdfWriter = new Interfaces.Kampfmittel();
                        workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Kampfmittel.FELDER;
                        eH.manageFields(Pflichtfelder_Klassen.Pflicht_Kampfmittel.FELDER);
                        break;
                    case 14:
                        //todo: tab wechsel einbauen
                        break;
                    case 15:
                        //Liste der Beteiligten
                        tb_LB_SMNummer.Text = tb_smNummer.Text;
                        neuzuweisung = true;
                        checked_listBox_Beteiligte.DataSource = new BindingSource(DBm.dbPDF.dic_Ansprechpartner_mitTyp, null);
                        checked_listBox_Beteiligte.DisplayMember = "Key";
                        checked_listBox_Beteiligte.ValueMember = "Value";
                        checked_listBox_Beteiligte.SelectedItem = null;
                        neuzuweisung = false;
                        workingPDF.pdfWriter = new Interfaces.ListeBeteiligte();
                        tabControl.SelectedIndex = 2;
                        tb_LB_SMNummer.Enabled = true;
                        btn_LB_suchen.Enabled = true;//todo: mit dem Fieldhandler behandeln
                        Btn_LB_suchen_Click(sender ,e);
                        break;
                }
                workingPDF.anschreibenTyp = anschreiben;
            }
        }

        private void Cmb_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            if (cmb_empfaenger.SelectedItem!=null &&cmb_empfaenger.Items.Count>0)
            {
                workingPDF.empfaenger = ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value;                
            }

            try
            {
                string key = ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Key;
                btn_bearbeiten.Enabled = true;
            }
            catch(Exception) {btn_bearbeiten.Enabled = false; cmb_empfaenger.SelectedItem = null; }
            
        }

        private void cmb_EF_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            if (cmb_EF_empfaenger.SelectedItem != null && cmb_EF_empfaenger.Items.Count > 0)
            {
                workingPDF.empfaenger = ((KeyValuePair<string, Ansprechpartner>)cmb_EF_empfaenger.SelectedItem).Value;
            }

            try
            {
                string key = ((KeyValuePair<string, Ansprechpartner>)cmb_EF_empfaenger.SelectedItem).Key;
                btn_EF_empfaengerBearbeiten.Enabled = true;
            }
            catch (Exception) { btn_EF_empfaengerBearbeiten.Enabled = false; cmb_EF_empfaenger.SelectedItem = null; }

        }

        private void Cmb_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
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
            if (neuzuweisung)
            {
                return;
            }
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

        private void Cmb_wesie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            if (cmb_wesie.SelectedItem != null)
            {
                workingPDF.wesiTeam = ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value;
                 
                
                rtb_WesiAdresse.Text = $"{workingPDF.wesiTeam.firma} {workingPDF.wesiTeam.niederlassung}" + Environment.NewLine + workingPDF.wesiTeam.bereich + Environment.NewLine + workingPDF.wesiTeam.strasse + Environment.NewLine + workingPDF.wesiTeam.plz + " " + workingPDF.wesiTeam.stadt;
                tb_WesiMail.Text = workingPDF.wesiTeam.email;
                btn_bearbeiten_wesi.Enabled = true;
            }
            else
            {
                tb_WesiMail.Text = "";
                rtb_WesiAdresse.Text = "";
                btn_bearbeiten_wesi.Enabled = false;
            }
        }

        private void Cb_plansaetze_CheckedChanged(object sender, EventArgs e)
        {
            workingPDF.plansaetze = cb_beteiligte.Checked;
        }

        private void Cb_beteiligte_CheckedChanged(object sender, EventArgs e)
        {
            workingPDF.listeBeteiligte = cb_untervollmacht.Checked;
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
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.Title = "PDF Speichern";
                saveFileDialog.ShowDialog();
                try
                {
                    DBpdf dataBasePDF = new DBpdf(FinalPDF);
                    workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, saveFileDialog.FileName);
                    DBm.savePDF(dataBasePDF);
                    savedFile = saveFileDialog.FileName;
                    savedFolder = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf("\\"));
                    btn_openFile.Enabled = true;
                    btn_openFolder.Enabled = true;
                }
                catch (Exception) { return; }
               
            }
            catch (Exception) { }
        }

        private void Btn_vorschau_Click(object sender, EventArgs e)
        {
            listb_vorherige_PDF.SelectedItem = null;
            error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen,rtb.Rtf);

                //DBm.testSave(pdf);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                this.pdfPreview.Navigate("www.google.de");

                pdfPreview.Navigate(workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, hiddenPath));
            }
            catch (Exception) { }

        }

        private void Btn_bearbeiten_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value, DBm.dbPDF.dic_ansprechpartnerTypen);
            this.Enabled = false;
            editDataset.ShowDialog();
            this.Enabled = true;
        }
        
        private void Btn_bearbeiten_wesi_Click(object sender, EventArgs e)
        {
            EditDataset editDataset = new EditDataset();
            editDataset.ReinitializeComponent(((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value);
            this.Enabled = false;
            editDataset.ShowDialog();
            tb_WesiMail.Clear();
            rtb_WesiAdresse.Clear();

            neuzuweisung = true;
            cmb_wesie.DisplayMember = "Key";
            cmb_wesie.ValueMember = "Value";
            cmb_wesie.DataSource = new BindingSource(DBm.dbPDF.dic_WesiTeam, null);
            this.Enabled = true;
            neuzuweisung = false;
        }

        private PDF createPDF(List<Zusatzanlage> zusatzanlagen, string rtb)
        {
            PDF FinalPDF = new PDF();

            if (workingPDF.pdfWriter==null)
            {
                workingPDF.pdfWriter = new Interfaces.EigenesFormular();
            }
             switch (workingPDF.anschreibenTyp.bezeichnung)
            {
                case "Anschreiben EVU":
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
                   cb_beteiligte.Checked,
                   cb_untervollmacht.Checked,
                   cb_techBeschreibung.Checked,
                   cb_untervollmacht.Checked,
                   zusatzanlagen);
                    break;
                case "Antrag Wupfl":
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
                case "Abstimmung Naturschutz":
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
                case "Anschreiben Kampfmittel":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    ((KeyValuePair<string, AnschreibenTyp>)cmb_anschreibenTyp.SelectedItem).Value,
                    ((KeyValuePair<string, Ansprechpartner>)cmb_empfaenger.SelectedItem).Value,
                    tb_ortMassnahme.Text,
                    ((KeyValuePair<string, WesiTeam>)cmb_wesie.SelectedItem).Value,
                    datePicker.Value
                    );
                    break;
                case "EigenesFormular":
                    FinalPDF = new PDF(
                    DBm.dbPDF.auftrag,
                    new AnschreibenTyp() { bezeichnung = "EigenesFormular", id=14 },
                    ((KeyValuePair<string, Ansprechpartner>)cmb_EF_empfaenger.SelectedItem).Value,
                    ((KeyValuePair<string, Bearbeiter>)cmb_ef_absender.SelectedItem).Value,
                    Datepicker_EF_datum.Value,
                    tb_EF_betreff.Text,
                    rtb,
                    zusatzanlagen
                    ) ;
                    break;
                case "Liste der Beteiligten":
                    workingPDF.pdfWriter = new Interfaces.ListeBeteiligte(); //todo: nicht sauber
                    List<Ansprechpartner> beteiligte = new List<Ansprechpartner>();
                    foreach(var item in checked_listBox_Beteiligte.CheckedItems)
                    {
                        var row = ((KeyValuePair<string, Ansprechpartner>)item).Value;
                        beteiligte.Add(row);
                    }

                    FinalPDF = new PDF(
                        DBm.dbPDF.auftrag,
                        workingPDF.anschreibenTyp,
                        beteiligte
                        );
                    break;
            }
            FinalPDF.aktiv = true;
            return FinalPDF;
        }        

        private void Btn_speichern_auftrag_pfad_Click(object sender, EventArgs e)
        {
            listb_vorherige_PDF.SelectedItem = null;
            error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_BeschreibungMassnahme.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);
                string pfad = getDynamicPath(FinalPDF);

                workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, pfad);
                DBm.savePDF(new DBpdf(FinalPDF));
                error_label.Text = $@"Gespeichert unter {pfad}";
                savedFile = pfad;
                savedFolder = pfad.Substring(0,pfad.LastIndexOf("\\"));
                btn_openFile.Enabled = true;
                btn_openFolder.Enabled = true;
            }
            catch (Exception qe) { error_label.Text = "Datei konnte nicht gespeichert werden "+qe.Message;}
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
            if (neuzuweisung)
            {
                return;
            }

            if (listb_vorherige_PDF.SelectedItem != null && tb_smNummer.Text != null)
            {
                pdfPreview.Navigate(loadPDF(0));
            }
            else { pdfPreview.DocumentText = null; }
           

            if (listb_vorherige_PDF.SelectedItem!=null)
            {
                btn_load_PDF.Enabled = true;
                btn_delete_pdf.Enabled = true;
            }
            else { btn_load_PDF.Enabled = false; btn_delete_pdf.Enabled = false; }
        }

        private string loadPDF(int tab)
        {            
            switch (tab)
            {
                case 0:
                    workingPDF = new WorkingPDF(((KeyValuePair<string, PDF>)listb_vorherige_PDF.SelectedItem).Value);                                        
                    break;
                case 1:
                    workingPDF = new WorkingPDF(((KeyValuePair<string, PDF>)listb_EF_vorherigePDF.SelectedItem).Value);                    
                    break;            
            }

            switch (workingPDF.anschreibenTyp.bezeichnung)
            {
                case "Anschreiben EVU":
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_EVU.FELDER;
                    workingPDF.pdfWriter = new Interfaces.EVU();
                    break;
                case "Anschreiben Mitbenutzung":
                    break;
                case "Antrag Wupfl":
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Wupfl.FELDER;
                    workingPDF.pdfWriter = new Interfaces.Wupfl();
                    break;
                case "Behördliche Genehmigung":
                    break;
                case "Erläuterungsbericht":
                    break;
                case "Zustimmungsbescheid":
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Zustimmungsbescheid.FELDER;
                    workingPDF.pdfWriter = new Interfaces.Zustimmungsbescheid();
                    break;
                case "Abstimmung Naturschutz":
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_AbstimmungNaturschutz.FELDER;
                    workingPDF.pdfWriter = new Interfaces.AbstimmungNaturschutz();
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
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_Kampfmittel.FELDER;
                    workingPDF.pdfWriter = new Interfaces.Kampfmittel();
                    break;
                case "EigenesFormular":
                    workingPDF.pflichtfelder = Pflichtfelder_Klassen.Pflicht_EigenesFormular.FELDER;
                    workingPDF.pdfWriter = new Interfaces.EigenesFormular();
                    break;
            }
            string hiddenPath = Path.GetTempPath() + @"\testVorschaupdf.pdf";
            //this.pdfPreview.Navigate("www.google.de");

            return workingPDF.pdfWriter.writeHTMLtoPDF(workingPDF, hiddenPath);
        }

        private void fillFormular(int tab, WorkingPDF pdf, object sender, EventArgs e)
        {
            neuzuweisung = true;
            switch (tab)
            {
                case 1:
                    //SM Nummer
                    tb_EF_SMNummer.Text = pdf.auftrag.smNummer;
                    btn_EF_suchen_Click(sender, e);

                    //Empfänger
                    if (pdf.empfaenger != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Ansprechpartner> empfaenger = DBm.dbPDF.dic_Ansprechpartner;
                        cmb_EF_empfaenger.DataSource = new BindingSource(empfaenger, null);
                        cmb_EF_empfaenger.DisplayMember = "Key";
                        cmb_EF_empfaenger.ValueMember = "Value";
                        neuzuweisung = false;

                        if (empfaenger.TryGetValue($@"{pdf.empfaenger.ansprechpartnerVorname} {pdf.empfaenger.ansprechpartnerName}", out Ansprechpartner ansp))
                        {
                            cmb_EF_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{ansp.ansprechpartnerVorname} {ansp.ansprechpartnerName}", ansp);
                        }
                        else if (empfaenger.TryGetValue($@"{pdf.empfaenger.firma}", out Ansprechpartner anspFirma))
                        {
                            cmb_EF_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspFirma.firma}", anspFirma);
                        }
                    }

                    if (pdf.absender != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Bearbeiter> absender = DBm.dbPDF.dic_Bearbeiter;
                        cmb_ef_absender.DataSource = new BindingSource(absender, null);
                        cmb_ef_absender.DisplayMember = "Key";
                        cmb_ef_absender.ValueMember = "Value";
                        neuzuweisung = false;
                        if (absender.TryGetValue($@"{pdf.absender.bearbeiterVorname} {pdf.absender.bearbeiterName}", out Bearbeiter bearb))
                        {
                            cmb_ef_absender.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{bearb.bearbeiterVorname} {bearb.bearbeiterName}", bearb);
                        }
                    }

                    //Betreff
                    tb_EF_betreff.Text = pdf.ortDerMassnahme;

                    rtb_EF_Anschreiben.Rtf = pdf.beschreibungMassnahme;
                    //Zusätzliche Anhänge
                    if (pdf.zusatzanlagen != null)
                    {
                        listb_EF_Zusatz.Items.Clear();
                        foreach (Zusatzanlage zu in pdf.zusatzanlagen)
                        {
                            listb_EF_Zusatz.Items.Add(zu.anlage);
                        }
                    }

                    break;
                case 0:
                    //Anschreiben Typ
                    neuzuweisung = true;
                    Dictionary<string, AnschreibenTyp> anschreibenTypen = DBm.dbPDF.dic_AnschreibenTyp;
                    cmb_anschreibenTyp.DataSource = new BindingSource(anschreibenTypen, null);
                    cmb_anschreibenTyp.DisplayMember = "Key";
                    cmb_anschreibenTyp.ValueMember = "Value";

                    if (anschreibenTypen.TryGetValue(pdf.anschreibenTyp.bezeichnung, out AnschreibenTyp typ))
                    {
                        cmb_anschreibenTyp.SelectedItem = new KeyValuePair<string, AnschreibenTyp>(typ.bezeichnung, typ);
                    }
                    eH.manageFields(workingPDF.pflichtfelder);
                    neuzuweisung = false;
                    //Empfänger
                    if (workingPDF.empfaenger != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Ansprechpartner> empfaenger = DBm.dbPDF.dic_Ansprechpartner;
                        cmb_empfaenger.DataSource = new BindingSource(empfaenger, null);
                        cmb_empfaenger.DisplayMember = "Key";
                        cmb_empfaenger.ValueMember = "Value";
                        neuzuweisung = false;

                        foreach (var item in cmb_empfaenger.Items)
                        {
                            if (((KeyValuePair<string, Ansprechpartner>)item).Value == workingPDF.empfaenger)
                            {
                                cmb_empfaenger.SelectedItem = item;
                            }
                        }
                    
                        //if (empfaenger.TryGetValue($@"{workingPDF.empfaenger.ansprechpartnerVorname} {workingPDF.empfaenger.ansprechpartnerName}", out Ansprechpartner ansp))
                        //{
                        //    cmb_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{ansp.ansprechpartnerVorname} {ansp.ansprechpartnerName}", ansp);
                        //}
                        //else if (empfaenger.TryGetValue($@"{workingPDF.empfaenger.firma}", out Ansprechpartner anspFirma))
                        //{
                        //    cmb_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspFirma.firma}", anspFirma);
                        //}
                    }

                    //Absender
                    if (workingPDF.absender != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Bearbeiter> absender = DBm.dbPDF.dic_Bearbeiter;
                        cmb_absender.DataSource = new BindingSource(absender, null);
                        cmb_absender.DisplayMember = "Key";
                        cmb_absender.ValueMember = "Value";
                        neuzuweisung = false;
                        if (absender.TryGetValue($@"{workingPDF.absender.bearbeiterVorname} {workingPDF.absender.bearbeiterName}", out Bearbeiter bearb))
                        {
                            cmb_absender.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{bearb.bearbeiterVorname} {bearb.bearbeiterName}", bearb);
                        }
                    }

                    //Ansprechparner
                    if (workingPDF.ansprechpartner != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Bearbeiter> ansprechpartner = DBm.dbPDF.dic_Bearbeiter;
                        cmb_Ansprechpartner.DataSource = new BindingSource(ansprechpartner, null);
                        cmb_Ansprechpartner.DisplayMember = "Key";
                        cmb_Ansprechpartner.ValueMember = "Value";
                        neuzuweisung = false;
                        if (ansprechpartner.TryGetValue($@"{workingPDF.ansprechpartner.bearbeiterVorname} {workingPDF.ansprechpartner.bearbeiterName}", out Bearbeiter ansprech))
                        {
                            cmb_Ansprechpartner.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{ansprech.bearbeiterVorname} {ansprech.bearbeiterName}", ansprech);
                        }
                    }

                    //Betreff
                    tb_ortMassnahme.Text = workingPDF.ortDerMassnahme;

                    //Absprachen
                    rtb_absprachen.Text = workingPDF.abgesprochenMit;

                    //Beschreibung der Maßnahme
                    rtb_BeschreibungMassnahme.Rtf = workingPDF.beschreibungMassnahme;

                    // Wesi Team
                    if (workingPDF.wesiTeam != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, WesiTeam> wesiTeam = DBm.dbPDF.dic_WesiTeam;
                        cmb_wesie.DataSource = new BindingSource(wesiTeam, null);
                        cmb_wesie.DisplayMember = "Key";
                        cmb_wesie.ValueMember = "Value";
                        neuzuweisung = false;
                        if (wesiTeam.TryGetValue($@"{workingPDF.wesiTeam.firma} { workingPDF.wesiTeam.niederlassung} ", out WesiTeam wesi))
                        {
                            cmb_wesie.SelectedItem = new KeyValuePair<string, WesiTeam>($@"{wesi.firma} {wesi.niederlassung}", wesi);
                        }
                    }


                    //Ansprechpartner Bau
                    if (workingPDF.ansprechpartnerBau != null)
                    {
                        neuzuweisung = true;
                        Dictionary<string, Ansprechpartner> ansprechBau = DBm.dbPDF.dic_Ansprechpartner;
                        cmb_ansprechpartnerBau.DataSource = new BindingSource(ansprechBau, null);
                        cmb_ansprechpartnerBau.DisplayMember = "Key";
                        cmb_ansprechpartnerBau.ValueMember = "Value";
                        neuzuweisung = false;
                        if (ansprechBau.TryGetValue($@"{workingPDF.ansprechpartnerBau.ansprechpartnerVorname} {workingPDF.ansprechpartnerBau.ansprechpartnerName}", out Ansprechpartner anspBau))
                        {
                            cmb_ansprechpartnerBau.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspBau.ansprechpartnerVorname} {anspBau.ansprechpartnerName}", anspBau);
                        }
                        else if (ansprechBau.TryGetValue($@"{workingPDF.ansprechpartnerBau.firma}", out Ansprechpartner anspBauFirma))
                        {
                            cmb_ansprechpartnerBau.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspBauFirma.firma}", anspBauFirma);
                        }
                    }

                    //Checkboxen
                    cb_untervollmacht.Checked = workingPDF.listeBeteiligte;
                    cb_untervollmacht.Checked = workingPDF.untervollmacht;
                    cb_beteiligte.Checked = workingPDF.plansaetze;
                    cb_techBeschreibung.Checked = workingPDF.techBeschreibung;

                    //Zusätzliche Anhänge
                    if (workingPDF.zusatzanlagen != null)
                    {
                        listb_zusatzanlagen.Items.Clear();
                        foreach (Zusatzanlage zu in workingPDF.zusatzanlagen)
                        {
                            listb_zusatzanlagen.Items.Add(zu.anlage);
                        }
                    }

                    break;
                    
            }
            neuzuweisung = false;
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
            if (neuzuweisung)
            {
                return;
            }

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

        private void Btn_load_PDF_Click(object sender, EventArgs e)
        {            
            if (workingPDF.anschreibenTyp.bezeichnung == "EigenesFormular")
            {
                fillFormular(1,workingPDF, sender, e);
                btn_EF_vorschau_Click(sender, e);
                tabControl.SelectedIndex = 1;
            }
            else
            {
                fillFormular(0, workingPDF, sender, e);
            }
            string pfad = getDynamicPath(workingPDF);
            savedFile = pfad;
            savedFolder = pfad.Substring(0, pfad.LastIndexOf("\\"));
            btn_openFile.Enabled = true;
            btn_openFolder.Enabled = true;
        }

        private void Btn_suchen_Click(object sender, EventArgs e)
        {
            try
            {
                DBm = new DBManager(tb_smNummer.Text);
                //Empfänger Festlegen
                if (DBm.dbPDF.auftrag != null)
                {
                    if (DBm.dbPDF.dic_Ansprechpartner.Count > 0)
                    {
                        neuzuweisung = true;
                        cmb_empfaenger.DataSource = new BindingSource(DBm.dbPDF.dic_Ansprechpartner, null);
                        cmb_empfaenger.DisplayMember = "Key";
                        cmb_empfaenger.ValueMember = "Value";
                        cmb_empfaenger.SelectedItem = null;
                        neuzuweisung = false;
                        cmb_empfaenger.SelectedIndexChanged += new System.EventHandler(Cmb_empfaenger_SelectedIndexChanged);
                    }
                    else { cmb_empfaenger.DataSource = null; }

                    workingPDF.auftrag = DBm.dbPDF.auftrag;

                    if (DBm.dbPDF.auftrag.pdfs.Count > 0)
                    {
                        //Vorherige PDFs festlegen
                        neuzuweisung = true;
                        listb_vorherige_PDF.DisplayMember = "Key";
                        listb_vorherige_PDF.ValueMember = "Value";
                        listb_vorherige_PDF.DataSource = new BindingSource(DBm.dbPDF.dic_pdf, null);
                        listb_vorherige_PDF.SelectedItem = null;
                        neuzuweisung = false;

                        listb_vorherige_PDF.SelectedIndexChanged += new System.EventHandler(Listb_vorherige_PDF_SelectedIndexChanged);
                        
                    }
                    else { listb_vorherige_PDF.DataSource = null; }

                    if (workingPDF.auftrag!=null)
                    {
                        cmb_anschreibenTyp.Enabled = true;
                        cmb_anschreibenTyp.BackColor = eH.colorEnabled;
                    }


                }
            }
            catch (Exception) { Debug.WriteLine("\nSMnummer nicht gefunden\n\n\n"); }
        }

        private void btn_EF_suchen_Click(object sender, EventArgs e)
        {
            try
            {

                DBm = new DBManager(tb_EF_SMNummer.Text);
                //Empfänger Festlegen
                if (DBm.dbPDF.auftrag != null)
                {
                    if (DBm.dbPDF.dic_Ansprechpartner.Count > 0)
                    {
                        neuzuweisung = true;
                        cmb_EF_empfaenger.DataSource = new BindingSource(DBm.dbPDF.dic_Ansprechpartner, null);
                        cmb_EF_empfaenger.DisplayMember = "Key";
                        cmb_EF_empfaenger.ValueMember = "Value";
                        cmb_EF_empfaenger.SelectedItem = null;
                        cmb_EF_empfaenger.SelectedIndexChanged += new System.EventHandler(cmb_EF_empfaenger_SelectedIndexChanged);
                        neuzuweisung = false;
                    }
                    else { cmb_EF_empfaenger.DataSource = null; }

                    workingPDF.auftrag = DBm.dbPDF.auftrag;

                    if (DBm.dbPDF.auftrag.pdfs.Count > 0)
                    {
                        neuzuweisung = true;
                        //Vorherige PDFs festlegen
                        listb_EF_vorherigePDF.DisplayMember = "Key";
                        listb_EF_vorherigePDF.ValueMember = "Value";
                        listb_EF_vorherigePDF.DataSource = new BindingSource(DBm.dbPDF.dic_pdf, null);
                        listb_EF_vorherigePDF.SelectedItem = null;
                        neuzuweisung = false;

                        listb_EF_vorherigePDF.SelectedIndexChanged += new System.EventHandler(listb_EF_vorherigePDF_SelectedIndexChanged);
                        
                        
                    }
                    else { listb_EF_vorherigePDF.DataSource = null; }


                }
            }
            catch (Exception) { Debug.WriteLine("\nSMnummer nicht gefunden\n\n\n"); }
        }

        private void Tb_zusatzanlage_TextChanged(object sender, EventArgs e)
        {
            if (tb_zusatzanlage.TextLength > 0)
            {
                btn_add_zusatzanlagen.Enabled = true;
            }
            else
            {
                btn_add_zusatzanlagen.Enabled = false;
            }
            
        }

        private void listb_EF_vorherigePDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            if (listb_EF_vorherigePDF.SelectedItem != null && tb_EF_SMNummer.Text != null)
            {
                PDF pdf = ((KeyValuePair<string, PDF>)listb_EF_vorherigePDF.SelectedItem).Value;
                if (pdf.anschreibenTyp.bezeichnung!= "EigenesFormular")
                {
                    fillFormular(1, workingPDF, sender, e);
                    tabControl.SelectedIndex = 0;
                }
                else { pdfPreview_EF.Navigate(loadPDF(0));}
                
            }
            else { pdfPreview_EF.DocumentText = null; }

            if (listb_EF_vorherigePDF.SelectedItem != null)
            {
                btn_EF_PDF_laden.Enabled = true;
            }
            else { btn_EF_PDF_laden.Enabled = false; }
        }

        private void cmb_ef_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }
            if (cmb_ef_absender.SelectedItem != null)
            {
                workingPDF.absender = ((KeyValuePair<string, Bearbeiter>)cmb_ef_absender.SelectedItem).Value;

            }            
        }

        private void Datepicker_datum_ValueChanged(object sender, EventArgs e)
        {
            workingPDF.datum = Datepicker_EF_datum.Value;
        }

        private void tb_EF_betreff_TextChanged(object sender, EventArgs e)
        {
            workingPDF.ortDerMassnahme = tb_EF_betreff.Text;
        }

        private void tb_EF_zusatz_TextChanged(object sender, EventArgs e)
        {
            if (tb_EF_zusatz.TextLength > 0)
            {
                btn_EF_zusatzHinzufuegen.Enabled = true;
            }
            else
            {
                btn_EF_zusatzHinzufuegen.Enabled = false;
            }
        }

        private void btn_EF_zusatzHinzufuegen_Click(object sender, EventArgs e)
        {
            listb_EF_Zusatz.Items.Add(tb_EF_zusatz.Text);
            tb_EF_zusatz.Clear();
        }

        private void listb_EF_Zusatz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (neuzuweisung)
            {
                return;
            }

            btn_EF_zusatzEntfernen.Enabled = true;
            btn_EF_allesEntfernen.Enabled = true;
            if (listb_EF_Zusatz.Items.Count < 1)
            {
                btn_EF_zusatzEntfernen.Enabled = false;
                btn_EF_allesEntfernen.Enabled = false;
            }
        }

        private void btn_EF_PDF_laden_Click(object sender, EventArgs e)
        {
            PDF pdf = ((KeyValuePair<string, PDF>)listb_EF_vorherigePDF.SelectedItem).Value;
            workingPDF = new WorkingPDF(pdf);      
            workingPDF.pflichtfelder= Pflichtfelder_Klassen.Pflicht_EigenesFormular.PFLICHTFELDER;
            //Empfänger
            if (pdf.empfaenger != null)
            {
                neuzuweisung = true;
                Dictionary<string, Ansprechpartner> empfaenger = DBm.dbPDF.dic_Ansprechpartner;
                cmb_EF_empfaenger.DataSource = new BindingSource(empfaenger, null);
                cmb_EF_empfaenger.DisplayMember = "Key";
                cmb_EF_empfaenger.ValueMember = "Value";
                neuzuweisung = false;
                if (empfaenger.TryGetValue($@"{pdf.empfaenger.ansprechpartnerVorname} {pdf.empfaenger.ansprechpartnerName}", out Ansprechpartner ansp))
                {
                    cmb_EF_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{ansp.ansprechpartnerVorname} {ansp.ansprechpartnerName}", ansp);
                }
                else if (empfaenger.TryGetValue($@"{pdf.empfaenger.firma}", out Ansprechpartner anspFirma))
                {
                    cmb_EF_empfaenger.SelectedItem = new KeyValuePair<string, Ansprechpartner>($@"{anspFirma.firma}", anspFirma);
                }
            }

            //Absender
            if (pdf.absender != null)
            {
                neuzuweisung = true;
                Dictionary<string, Bearbeiter> absender = DBm.dbPDF.dic_Bearbeiter;
                cmb_ef_absender.DataSource = new BindingSource(absender, null);
                cmb_ef_absender.DisplayMember = "Key";
                cmb_ef_absender.ValueMember = "Value";
                neuzuweisung = false;
                if (absender.TryGetValue($@"{workingPDF.absender.bearbeiterVorname} {workingPDF.absender.bearbeiterName}", out Bearbeiter bearb))
                {
                    cmb_ef_absender.SelectedItem = new KeyValuePair<string, Bearbeiter>($@"{bearb.bearbeiterVorname} {bearb.bearbeiterName}", bearb);
                }
            }
            //Datum
            Datepicker_EF_datum.Value = workingPDF.datum;

            //Betreff
            tb_EF_betreff.Text = workingPDF.ortDerMassnahme;

            //Beschreibung der Maßnahme
            rtb_EF_Anschreiben.Rtf = workingPDF.beschreibungMassnahme;
            
            //Zusätzliche Anhänge
            if (pdf.tblZusatzanlagen != null)
            {
                listb_EF_Zusatz.Items.Clear();
                foreach (Zusatzanlage zu in workingPDF.zusatzanlagen)
                {
                    listb_EF_Zusatz.Items.Add(zu.anlage);
                }
            }
        }

        private void rtb_EF_Anschreiben_TextChanged(object sender, EventArgs e)
        {
            workingPDF.beschreibungMassnahme = rtb_EF_Anschreiben.Rtf;
        }
        
        private void btn_EF_auftragsordner_speichern_Click(object sender, EventArgs e)
        {
            listb_EF_vorherigePDF.SelectedItem = null;
            EF_error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_EF_Anschreiben.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);
                string pfad = getDynamicPath(FinalPDF);

                workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, pfad);
                DBm.savePDF(new DBpdf(FinalPDF));
                EF_error_label.Text = $@"Gespeichert unter {pfad}";
            }
            catch (Exception) { error_label.Text = "Datei konnte nicht gespeichert werden, vielleicht anderweitig geöffnet"; }
        }

        private void btn_EF_vorschau_Click(object sender, EventArgs e)
        {
            listb_EF_vorherigePDF.SelectedItem = null;
            EF_error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_EF_Anschreiben.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);

                //DBm.testSave(pdf);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                pdfPreview_EF.Navigate("www.google.de");

                pdfPreview_EF.Navigate(workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, hiddenPath));
            }
            catch (Exception) { }
        }

        private void btn_EF_speichernUnter_Click(object sender, EventArgs e)
        {
            listb_EF_vorherigePDF.SelectedItem = null;
            EF_error_label.Text = "";
            List<Zusatzanlage> zusatzanlagen = eH.checkInput(workingPDF.pflichtfelder);

            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtb_EF_Anschreiben.Rtf;
            try
            {
                PDF FinalPDF = createPDF(zusatzanlagen, rtb.Rtf);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.Title = "PDF Speichern";
                saveFileDialog.ShowDialog();
                workingPDF.pdfWriter.writeHTMLtoPDF(FinalPDF, saveFileDialog.FileName);
                DBm.savePDF(new DBpdf(FinalPDF));
            }
            catch (Exception) { }
        }

        private void Btn_delete_pdf_Click(object sender, EventArgs e)
        {
            PDF p = ((KeyValuePair<string, PDF>)listb_vorherige_PDF.SelectedItem).Value;
            p.aktiv = false;
            DBm.savePDF(new DBpdf(p));
            Btn_suchen_Click(sender,e);
        }

        private void Btn_LB_suchen_Click(object sender, EventArgs e)
        {           
            try
            {                
                //DBm.testSave(pdf);
                string hiddenPath = Path.GetTempPath() + @"\testpdf.pdf";
                this.pdfPreview.Navigate("www.google.de");
                workingPDF.pdfWriter = new Interfaces.ListeBeteiligte(); //todo: unsauber
                pdfPreview_ListeBeteiligte.Navigate(workingPDF.pdfWriter.writeHTMLtoPDF(createPDF(null, null), hiddenPath));
            }
            catch (Exception) { }//todo: Errorhandler implementieren
        }

        private void Btn_openFolder_Click(object sender, EventArgs e)
        {
            if (savedFolder!=null)
            {
                Process.Start(savedFolder);
            }
        }

        private void Btn_openFile_Click(object sender, EventArgs e)
        {
            if (savedFile != null)
            {
                Process.Start(savedFile);
            }
        }
    }
}
    
