namespace DynamicPDFCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lb_SMNumber = new System.Windows.Forms.Label();
            this.tb_smNummer = new System.Windows.Forms.TextBox();
            this.lb_anschreibenTyp = new System.Windows.Forms.Label();
            this.cmb_anschreibenTyp = new System.Windows.Forms.ComboBox();
            this.cmb_empfaenger = new System.Windows.Forms.ComboBox();
            this.lb_empfaenger = new System.Windows.Forms.Label();
            this.cmb_absender = new System.Windows.Forms.ComboBox();
            this.lb_absender = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lb_datum = new System.Windows.Forms.Label();
            this.rtb_BeschreibungMassnahme = new System.Windows.Forms.RichTextBox();
            this.lb_texteditor = new System.Windows.Forms.Label();
            this.datePickerAusfuehrung = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Ansprechpartner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_absprachen = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ortMassnahme = new System.Windows.Forms.TextBox();
            this.pdfPreview = new System.Windows.Forms.WebBrowser();
            this.error_label = new System.Windows.Forms.Label();
            this.datePickerAusfuehrungEnde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suchen = new System.Windows.Forms.Button();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_remove_selected = new System.Windows.Forms.Button();
            this.tb_zusatzanlage = new System.Windows.Forms.TextBox();
            this.btn_add_zusatzanlagen = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.listb_zusatzanlagen = new System.Windows.Forms.ListBox();
            this.cb_untervollmacht = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_bearbeiten_wesi = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cmb_ansprechpartnerBau = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.rtb_WesiAdresse = new System.Windows.Forms.RichTextBox();
            this.cb_plansaetze = new System.Windows.Forms.CheckBox();
            this.cmb_wesie = new System.Windows.Forms.ComboBox();
            this.cb_beteiligte = new System.Windows.Forms.CheckBox();
            this.cb_techBeschreibung = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_WesiMail = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listb_vorherige_PDF = new System.Windows.Forms.ListBox();
            this.btn_load_PDF = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btn_speichern_auftrag_pfad = new System.Windows.Forms.Button();
            this.btn_vorschau = new System.Windows.Forms.Button();
            this.btn_saveDocument = new System.Windows.Forms.Button();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SMNumber
            // 
            resources.ApplyResources(this.lb_SMNumber, "lb_SMNumber");
            this.lb_SMNumber.Name = "lb_SMNumber";
            // 
            // tb_smNummer
            // 
            resources.ApplyResources(this.tb_smNummer, "tb_smNummer");
            this.tb_smNummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_smNummer.Name = "tb_smNummer";
            this.tb_smNummer.TextChanged += new System.EventHandler(this.Tb_smNummer_TextChanged);
            // 
            // lb_anschreibenTyp
            // 
            resources.ApplyResources(this.lb_anschreibenTyp, "lb_anschreibenTyp");
            this.lb_anschreibenTyp.Name = "lb_anschreibenTyp";
            // 
            // cmb_anschreibenTyp
            // 
            resources.ApplyResources(this.cmb_anschreibenTyp, "cmb_anschreibenTyp");
            this.cmb_anschreibenTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_anschreibenTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_anschreibenTyp.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_anschreibenTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_anschreibenTyp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_anschreibenTyp.FormattingEnabled = true;
            this.cmb_anschreibenTyp.Name = "cmb_anschreibenTyp";
            // 
            // cmb_empfaenger
            // 
            resources.ApplyResources(this.cmb_empfaenger, "cmb_empfaenger");
            this.cmb_empfaenger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_empfaenger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_empfaenger.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_empfaenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empfaenger.FormattingEnabled = true;
            this.cmb_empfaenger.Name = "cmb_empfaenger";
            this.cmb_empfaenger.SelectedIndexChanged += new System.EventHandler(this.Cmb_empfaenger_SelectedIndexChanged);
            // 
            // lb_empfaenger
            // 
            resources.ApplyResources(this.lb_empfaenger, "lb_empfaenger");
            this.lb_empfaenger.Name = "lb_empfaenger";
            // 
            // cmb_absender
            // 
            resources.ApplyResources(this.cmb_absender, "cmb_absender");
            this.cmb_absender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_absender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_absender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_absender.FormattingEnabled = true;
            this.cmb_absender.Name = "cmb_absender";
            this.cmb_absender.SelectedIndexChanged += new System.EventHandler(this.Cmb_absender_SelectedIndexChanged);
            // 
            // lb_absender
            // 
            resources.ApplyResources(this.lb_absender, "lb_absender");
            this.lb_absender.Name = "lb_absender";
            // 
            // datePicker
            // 
            resources.ApplyResources(this.datePicker, "datePicker");
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.datePicker.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.datePicker.Name = "datePicker";
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // lb_datum
            // 
            resources.ApplyResources(this.lb_datum, "lb_datum");
            this.lb_datum.Name = "lb_datum";
            // 
            // rtb_BeschreibungMassnahme
            // 
            resources.ApplyResources(this.rtb_BeschreibungMassnahme, "rtb_BeschreibungMassnahme");
            this.rtb_BeschreibungMassnahme.Name = "rtb_BeschreibungMassnahme";
            this.rtb_BeschreibungMassnahme.TextChanged += new System.EventHandler(this.Rtb_BeschreibungMassnahme_TextChanged);
            // 
            // lb_texteditor
            // 
            resources.ApplyResources(this.lb_texteditor, "lb_texteditor");
            this.lb_texteditor.Name = "lb_texteditor";
            // 
            // datePickerAusfuehrung
            // 
            resources.ApplyResources(this.datePickerAusfuehrung, "datePickerAusfuehrung");
            this.datePickerAusfuehrung.Name = "datePickerAusfuehrung";
            this.datePickerAusfuehrung.ValueChanged += new System.EventHandler(this.DatePickerAusfuehrung_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmb_Ansprechpartner
            // 
            resources.ApplyResources(this.cmb_Ansprechpartner, "cmb_Ansprechpartner");
            this.cmb_Ansprechpartner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Ansprechpartner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Ansprechpartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ansprechpartner.FormattingEnabled = true;
            this.cmb_Ansprechpartner.Name = "cmb_Ansprechpartner";
            this.cmb_Ansprechpartner.SelectedIndexChanged += new System.EventHandler(this.Cmb_Ansprechpartner_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rtb_absprachen
            // 
            resources.ApplyResources(this.rtb_absprachen, "rtb_absprachen");
            this.rtb_absprachen.Name = "rtb_absprachen";
            this.rtb_absprachen.TextChanged += new System.EventHandler(this.Rtb_absprachen_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tb_ortMassnahme
            // 
            resources.ApplyResources(this.tb_ortMassnahme, "tb_ortMassnahme");
            this.tb_ortMassnahme.Name = "tb_ortMassnahme";
            this.tb_ortMassnahme.TextChanged += new System.EventHandler(this.Tb_ortMassnahme_TextChanged);
            // 
            // pdfPreview
            // 
            resources.ApplyResources(this.pdfPreview, "pdfPreview");
            this.pdfPreview.Name = "pdfPreview";
            // 
            // error_label
            // 
            resources.ApplyResources(this.error_label, "error_label");
            this.error_label.Name = "error_label";
            this.error_label.Click += new System.EventHandler(this.error_label_Click);
            // 
            // datePickerAusfuehrungEnde
            // 
            resources.ApplyResources(this.datePickerAusfuehrungEnde, "datePickerAusfuehrungEnde");
            this.datePickerAusfuehrungEnde.Name = "datePickerAusfuehrungEnde";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btn_suchen);
            this.groupBox1.Controls.Add(this.btn_bearbeiten);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.datePickerAusfuehrungEnde);
            this.groupBox1.Controls.Add(this.lb_SMNumber);
            this.groupBox1.Controls.Add(this.tb_smNummer);
            this.groupBox1.Controls.Add(this.lb_anschreibenTyp);
            this.groupBox1.Controls.Add(this.cmb_anschreibenTyp);
            this.groupBox1.Controls.Add(this.tb_ortMassnahme);
            this.groupBox1.Controls.Add(this.cmb_empfaenger);
            this.groupBox1.Controls.Add(this.lb_empfaenger);
            this.groupBox1.Controls.Add(this.cmb_absender);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.lb_absender);
            this.groupBox1.Controls.Add(this.lb_datum);
            this.groupBox1.Controls.Add(this.datePickerAusfuehrung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Ansprechpartner);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_absprachen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn_suchen
            // 
            resources.ApplyResources(this.btn_suchen, "btn_suchen");
            this.btn_suchen.Name = "btn_suchen";
            this.btn_suchen.UseVisualStyleBackColor = true;
            this.btn_suchen.Click += new System.EventHandler(this.Btn_suchen_Click);
            // 
            // btn_bearbeiten
            // 
            resources.ApplyResources(this.btn_bearbeiten, "btn_bearbeiten");
            this.btn_bearbeiten.BackgroundImage = global::DynamicPDFCreator.Properties.Resources.edit;
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.Btn_bearbeiten_Click);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.btn_remove_all);
            this.groupBox5.Controls.Add(this.btn_remove_selected);
            this.groupBox5.Controls.Add(this.tb_zusatzanlage);
            this.groupBox5.Controls.Add(this.btn_add_zusatzanlagen);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.listb_zusatzanlagen);
            this.groupBox5.Controls.Add(this.cb_untervollmacht);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.btn_bearbeiten_wesi);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.cmb_ansprechpartnerBau);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.rtb_WesiAdresse);
            this.groupBox5.Controls.Add(this.cb_plansaetze);
            this.groupBox5.Controls.Add(this.cmb_wesie);
            this.groupBox5.Controls.Add(this.cb_beteiligte);
            this.groupBox5.Controls.Add(this.cb_techBeschreibung);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.tb_WesiMail);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btn_remove_all
            // 
            resources.ApplyResources(this.btn_remove_all, "btn_remove_all");
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.Btn_remove_all_Click);
            // 
            // btn_remove_selected
            // 
            resources.ApplyResources(this.btn_remove_selected, "btn_remove_selected");
            this.btn_remove_selected.Name = "btn_remove_selected";
            this.btn_remove_selected.UseVisualStyleBackColor = true;
            this.btn_remove_selected.Click += new System.EventHandler(this.Btn_remove_selected_Click);
            // 
            // tb_zusatzanlage
            // 
            resources.ApplyResources(this.tb_zusatzanlage, "tb_zusatzanlage");
            this.tb_zusatzanlage.Name = "tb_zusatzanlage";
            this.tb_zusatzanlage.TextChanged += new System.EventHandler(this.Tb_zusatzanlage_TextChanged);
            // 
            // btn_add_zusatzanlagen
            // 
            resources.ApplyResources(this.btn_add_zusatzanlagen, "btn_add_zusatzanlagen");
            this.btn_add_zusatzanlagen.Name = "btn_add_zusatzanlagen";
            this.btn_add_zusatzanlagen.UseVisualStyleBackColor = true;
            this.btn_add_zusatzanlagen.Click += new System.EventHandler(this.Btn_add_zusatzanlagen_Click);
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // listb_zusatzanlagen
            // 
            resources.ApplyResources(this.listb_zusatzanlagen, "listb_zusatzanlagen");
            this.listb_zusatzanlagen.FormattingEnabled = true;
            this.listb_zusatzanlagen.Name = "listb_zusatzanlagen";
            this.listb_zusatzanlagen.SelectedIndexChanged += new System.EventHandler(this.Listb_zusatzanlagen_SelectedIndexChanged);
            // 
            // cb_untervollmacht
            // 
            resources.ApplyResources(this.cb_untervollmacht, "cb_untervollmacht");
            this.cb_untervollmacht.Name = "cb_untervollmacht";
            this.cb_untervollmacht.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // btn_bearbeiten_wesi
            // 
            resources.ApplyResources(this.btn_bearbeiten_wesi, "btn_bearbeiten_wesi");
            this.btn_bearbeiten_wesi.BackgroundImage = global::DynamicPDFCreator.Properties.Resources.edit;
            this.btn_bearbeiten_wesi.Name = "btn_bearbeiten_wesi";
            this.btn_bearbeiten_wesi.UseVisualStyleBackColor = true;
            this.btn_bearbeiten_wesi.Click += new System.EventHandler(this.Btn_bearbeiten_wesi_Click);
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // cmb_ansprechpartnerBau
            // 
            resources.ApplyResources(this.cmb_ansprechpartnerBau, "cmb_ansprechpartnerBau");
            this.cmb_ansprechpartnerBau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_ansprechpartnerBau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_ansprechpartnerBau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ansprechpartnerBau.FormattingEnabled = true;
            this.cmb_ansprechpartnerBau.Name = "cmb_ansprechpartnerBau";
            this.cmb_ansprechpartnerBau.SelectedIndexChanged += new System.EventHandler(this.Cmb_ansprechpartnerBau_SelectedIndexChanged);
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // rtb_WesiAdresse
            // 
            resources.ApplyResources(this.rtb_WesiAdresse, "rtb_WesiAdresse");
            this.rtb_WesiAdresse.Name = "rtb_WesiAdresse";
            this.rtb_WesiAdresse.ReadOnly = true;
            this.rtb_WesiAdresse.TextChanged += new System.EventHandler(this.Rtb_WesiAdresse_TextChanged);
            // 
            // cb_plansaetze
            // 
            resources.ApplyResources(this.cb_plansaetze, "cb_plansaetze");
            this.cb_plansaetze.Name = "cb_plansaetze";
            this.cb_plansaetze.UseVisualStyleBackColor = true;
            this.cb_plansaetze.CheckedChanged += new System.EventHandler(this.Cb_plansaetze_CheckedChanged);
            // 
            // cmb_wesie
            // 
            resources.ApplyResources(this.cmb_wesie, "cmb_wesie");
            this.cmb_wesie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_wesie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_wesie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_wesie.FormattingEnabled = true;
            this.cmb_wesie.Name = "cmb_wesie";
            this.cmb_wesie.SelectedIndexChanged += new System.EventHandler(this.Cmb_wesie_SelectedIndexChanged);
            // 
            // cb_beteiligte
            // 
            resources.ApplyResources(this.cb_beteiligte, "cb_beteiligte");
            this.cb_beteiligte.Name = "cb_beteiligte";
            this.cb_beteiligte.UseVisualStyleBackColor = true;
            this.cb_beteiligte.CheckedChanged += new System.EventHandler(this.Cb_beteiligte_CheckedChanged);
            // 
            // cb_techBeschreibung
            // 
            resources.ApplyResources(this.cb_techBeschreibung, "cb_techBeschreibung");
            this.cb_techBeschreibung.Name = "cb_techBeschreibung";
            this.cb_techBeschreibung.UseVisualStyleBackColor = true;
            this.cb_techBeschreibung.CheckedChanged += new System.EventHandler(this.Cb_techBeschreibung_CheckedChanged);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // tb_WesiMail
            // 
            resources.ApplyResources(this.tb_WesiMail, "tb_WesiMail");
            this.tb_WesiMail.Name = "tb_WesiMail";
            this.tb_WesiMail.ReadOnly = true;
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // listb_vorherige_PDF
            // 
            resources.ApplyResources(this.listb_vorherige_PDF, "listb_vorherige_PDF");
            this.listb_vorherige_PDF.FormattingEnabled = true;
            this.listb_vorherige_PDF.Name = "listb_vorherige_PDF";
            this.listb_vorherige_PDF.SelectedIndexChanged += new System.EventHandler(this.Listb_vorherige_PDF_SelectedIndexChanged);
            // 
            // btn_load_PDF
            // 
            resources.ApplyResources(this.btn_load_PDF, "btn_load_PDF");
            this.btn_load_PDF.Name = "btn_load_PDF";
            this.btn_load_PDF.UseVisualStyleBackColor = true;
            this.btn_load_PDF.Click += new System.EventHandler(this.btn_load_PDF_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // btn_speichern_auftrag_pfad
            // 
            resources.ApplyResources(this.btn_speichern_auftrag_pfad, "btn_speichern_auftrag_pfad");
            this.btn_speichern_auftrag_pfad.Name = "btn_speichern_auftrag_pfad";
            this.btn_speichern_auftrag_pfad.UseVisualStyleBackColor = true;
            this.btn_speichern_auftrag_pfad.Click += new System.EventHandler(this.Btn_speichern_auftrag_pfad_Click);
            // 
            // btn_vorschau
            // 
            resources.ApplyResources(this.btn_vorschau, "btn_vorschau");
            this.btn_vorschau.Name = "btn_vorschau";
            this.btn_vorschau.UseVisualStyleBackColor = true;
            this.btn_vorschau.Click += new System.EventHandler(this.Btn_vorschau_Click);
            // 
            // btn_saveDocument
            // 
            resources.ApplyResources(this.btn_saveDocument, "btn_saveDocument");
            this.btn_saveDocument.Name = "btn_saveDocument";
            this.btn_saveDocument.UseVisualStyleBackColor = true;
            // 
            // btn_printDocument
            // 
            resources.ApplyResources(this.btn_printDocument, "btn_printDocument");
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.UseVisualStyleBackColor = true;
            // 
            // btn_sendEmail
            // 
            resources.ApplyResources(this.btn_sendEmail, "btn_sendEmail");
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_speichern_auftrag_pfad);
            this.Controls.Add(this.btn_vorschau);
            this.Controls.Add(this.btn_saveDocument);
            this.Controls.Add(this.btn_printDocument);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.btn_load_PDF);
            this.Controls.Add(this.listb_vorherige_PDF);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pdfPreview);
            this.Controls.Add(this.lb_texteditor);
            this.Controls.Add(this.rtb_BeschreibungMassnahme);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_SMNumber;
        public System.Windows.Forms.TextBox tb_smNummer;
        public System.Windows.Forms.Label lb_anschreibenTyp;
        public System.Windows.Forms.ComboBox cmb_anschreibenTyp;
        public System.Windows.Forms.ComboBox cmb_empfaenger;
        public System.Windows.Forms.Label lb_empfaenger;
        public System.Windows.Forms.ComboBox cmb_absender;
        public System.Windows.Forms.Label lb_absender;
        public System.Windows.Forms.DateTimePicker datePicker;
        public System.Windows.Forms.Label lb_datum;
        public System.Windows.Forms.RichTextBox rtb_BeschreibungMassnahme;
        public System.Windows.Forms.Label lb_texteditor;
        public System.Windows.Forms.DateTimePicker datePickerAusfuehrung;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_Ansprechpartner;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox rtb_absprachen;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_ortMassnahme;
        public System.Windows.Forms.WebBrowser pdfPreview;
        public System.Windows.Forms.Label error_label;
        public System.Windows.Forms.DateTimePicker datePickerAusfuehrungEnde;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_bearbeiten;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.ListBox listb_vorherige_PDF;
        public System.Windows.Forms.Button btn_load_PDF;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btn_remove_all;
        public System.Windows.Forms.Button btn_remove_selected;
        public System.Windows.Forms.TextBox tb_zusatzanlage;
        public System.Windows.Forms.Button btn_add_zusatzanlagen;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.ListBox listb_zusatzanlagen;
        public System.Windows.Forms.CheckBox cb_untervollmacht;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Button btn_bearbeiten_wesi;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.ComboBox cmb_ansprechpartnerBau;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.RichTextBox rtb_WesiAdresse;
        public System.Windows.Forms.CheckBox cb_plansaetze;
        public System.Windows.Forms.ComboBox cmb_wesie;
        public System.Windows.Forms.CheckBox cb_beteiligte;
        public System.Windows.Forms.CheckBox cb_techBeschreibung;
        public System.Windows.Forms.Label label35;
        public System.Windows.Forms.TextBox tb_WesiMail;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.Button btn_speichern_auftrag_pfad;
        public System.Windows.Forms.Button btn_vorschau;
        public System.Windows.Forms.Button btn_saveDocument;
        public System.Windows.Forms.Button btn_printDocument;
        public System.Windows.Forms.Button btn_sendEmail;
        public System.Windows.Forms.Button btn_suchen;
    }
}

