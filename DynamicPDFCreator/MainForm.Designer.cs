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
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_remove_selected = new System.Windows.Forms.Button();
            this.tb_zusatzanlage = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
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
            this.lb_SMNumber.AutoSize = true;
            this.lb_SMNumber.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SMNumber.Location = new System.Drawing.Point(17, 30);
            this.lb_SMNumber.Name = "lb_SMNumber";
            this.lb_SMNumber.Size = new System.Drawing.Size(70, 14);
            this.lb_SMNumber.TabIndex = 1;
            this.lb_SMNumber.Text = "SM-Nummer";
            // 
            // tb_smNummer
            // 
            this.tb_smNummer.BackColor = System.Drawing.SystemColors.Window;
            this.tb_smNummer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_smNummer.Location = new System.Drawing.Point(130, 27);
            this.tb_smNummer.Name = "tb_smNummer";
            this.tb_smNummer.Size = new System.Drawing.Size(217, 20);
            this.tb_smNummer.TabIndex = 2;
            this.tb_smNummer.TextChanged += new System.EventHandler(this.Tb_smNummer_TextChanged);
            // 
            // lb_anschreibenTyp
            // 
            this.lb_anschreibenTyp.AutoSize = true;
            this.lb_anschreibenTyp.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_anschreibenTyp.Location = new System.Drawing.Point(17, 103);
            this.lb_anschreibenTyp.Name = "lb_anschreibenTyp";
            this.lb_anschreibenTyp.Size = new System.Drawing.Size(112, 14);
            this.lb_anschreibenTyp.TabIndex = 3;
            this.lb_anschreibenTyp.Text = "Anschreiben Typ";
            // 
            // cmb_anschreibenTyp
            // 
            this.cmb_anschreibenTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_anschreibenTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_anschreibenTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_anschreibenTyp.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_anschreibenTyp.FormattingEnabled = true;
            this.cmb_anschreibenTyp.Location = new System.Drawing.Point(189, 100);
            this.cmb_anschreibenTyp.Name = "cmb_anschreibenTyp";
            this.cmb_anschreibenTyp.Size = new System.Drawing.Size(190, 22);
            this.cmb_anschreibenTyp.TabIndex = 4;
            // 
            // cmb_empfaenger
            // 
            this.cmb_empfaenger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_empfaenger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_empfaenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empfaenger.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empfaenger.FormattingEnabled = true;
            this.cmb_empfaenger.Location = new System.Drawing.Point(93, 148);
            this.cmb_empfaenger.Name = "cmb_empfaenger";
            this.cmb_empfaenger.Size = new System.Drawing.Size(286, 22);
            this.cmb_empfaenger.TabIndex = 5;
            this.cmb_empfaenger.SelectedIndexChanged += new System.EventHandler(this.Cmb_empfaenger_SelectedIndexChanged);
            // 
            // lb_empfaenger
            // 
            this.lb_empfaenger.AutoSize = true;
            this.lb_empfaenger.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empfaenger.Location = new System.Drawing.Point(17, 151);
            this.lb_empfaenger.Name = "lb_empfaenger";
            this.lb_empfaenger.Size = new System.Drawing.Size(70, 14);
            this.lb_empfaenger.TabIndex = 6;
            this.lb_empfaenger.Text = "Empfänger";
            // 
            // cmb_absender
            // 
            this.cmb_absender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_absender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_absender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_absender.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_absender.FormattingEnabled = true;
            this.cmb_absender.Location = new System.Drawing.Point(189, 192);
            this.cmb_absender.Name = "cmb_absender";
            this.cmb_absender.Size = new System.Drawing.Size(190, 22);
            this.cmb_absender.TabIndex = 7;
            this.cmb_absender.SelectedIndexChanged += new System.EventHandler(this.Cmb_absender_SelectedIndexChanged);
            // 
            // lb_absender
            // 
            this.lb_absender.AutoSize = true;
            this.lb_absender.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_absender.Location = new System.Drawing.Point(17, 195);
            this.lb_absender.Name = "lb_absender";
            this.lb_absender.Size = new System.Drawing.Size(63, 14);
            this.lb_absender.TabIndex = 8;
            this.lb_absender.Text = "Absender";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(189, 239);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(190, 20);
            this.datePicker.TabIndex = 9;
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datum.Location = new System.Drawing.Point(19, 239);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(42, 14);
            this.lb_datum.TabIndex = 10;
            this.lb_datum.Text = "Datum";
            // 
            // rtb_BeschreibungMassnahme
            // 
            this.rtb_BeschreibungMassnahme.Location = new System.Drawing.Point(12, 701);
            this.rtb_BeschreibungMassnahme.Name = "rtb_BeschreibungMassnahme";
            this.rtb_BeschreibungMassnahme.Size = new System.Drawing.Size(411, 185);
            this.rtb_BeschreibungMassnahme.TabIndex = 11;
            this.rtb_BeschreibungMassnahme.Text = "";
            this.rtb_BeschreibungMassnahme.TextChanged += new System.EventHandler(this.Rtb_BeschreibungMassnahme_TextChanged);
            // 
            // lb_texteditor
            // 
            this.lb_texteditor.AutoSize = true;
            this.lb_texteditor.Location = new System.Drawing.Point(9, 685);
            this.lb_texteditor.Name = "lb_texteditor";
            this.lb_texteditor.Size = new System.Drawing.Size(146, 13);
            this.lb_texteditor.TabIndex = 12;
            this.lb_texteditor.Text = "Beschreibung der Maßnahme";
            // 
            // datePickerAusfuehrung
            // 
            this.datePickerAusfuehrung.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerAusfuehrung.Location = new System.Drawing.Point(189, 278);
            this.datePickerAusfuehrung.Name = "datePickerAusfuehrung";
            this.datePickerAusfuehrung.Size = new System.Drawing.Size(190, 20);
            this.datePickerAusfuehrung.TabIndex = 17;
            this.datePickerAusfuehrung.ValueChanged += new System.EventHandler(this.DatePickerAusfuehrung_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ausführungszeitraum";
            // 
            // cmb_Ansprechpartner
            // 
            this.cmb_Ansprechpartner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Ansprechpartner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Ansprechpartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ansprechpartner.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ansprechpartner.FormattingEnabled = true;
            this.cmb_Ansprechpartner.Location = new System.Drawing.Point(189, 359);
            this.cmb_Ansprechpartner.Name = "cmb_Ansprechpartner";
            this.cmb_Ansprechpartner.Size = new System.Drawing.Size(190, 22);
            this.cmb_Ansprechpartner.TabIndex = 19;
            this.cmb_Ansprechpartner.SelectedIndexChanged += new System.EventHandler(this.Cmb_Ansprechpartner_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ansprechpartner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Betreff";
            // 
            // rtb_absprachen
            // 
            this.rtb_absprachen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_absprachen.Location = new System.Drawing.Point(20, 463);
            this.rtb_absprachen.Name = "rtb_absprachen";
            this.rtb_absprachen.Size = new System.Drawing.Size(302, 36);
            this.rtb_absprachen.TabIndex = 23;
            this.rtb_absprachen.Text = "";
            this.rtb_absprachen.TextChanged += new System.EventHandler(this.Rtb_absprachen_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Beschreibung mit wem das Vorhaben \r\nabgesprochen wurde";
            // 
            // tb_ortMassnahme
            // 
            this.tb_ortMassnahme.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ortMassnahme.Location = new System.Drawing.Point(189, 396);
            this.tb_ortMassnahme.Name = "tb_ortMassnahme";
            this.tb_ortMassnahme.Size = new System.Drawing.Size(190, 20);
            this.tb_ortMassnahme.TabIndex = 46;
            this.tb_ortMassnahme.TextChanged += new System.EventHandler(this.Tb_ortMassnahme_TextChanged);
            // 
            // pdfPreview
            // 
            this.pdfPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pdfPreview.Location = new System.Drawing.Point(983, 12);
            this.pdfPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfPreview.Name = "pdfPreview";
            this.pdfPreview.Size = new System.Drawing.Size(678, 891);
            this.pdfPreview.TabIndex = 47;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(12, 901);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 48;
            this.error_label.Click += new System.EventHandler(this.error_label_Click);
            // 
            // datePickerAusfuehrungEnde
            // 
            this.datePickerAusfuehrungEnde.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerAusfuehrungEnde.Location = new System.Drawing.Point(189, 314);
            this.datePickerAusfuehrungEnde.Name = "datePickerAusfuehrungEnde";
            this.datePickerAusfuehrungEnde.Size = new System.Drawing.Size(190, 20);
            this.datePickerAusfuehrungEnde.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 574);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.BackgroundImage = global::DynamicPDFCreator.Properties.Resources.edit;
            this.btn_bearbeiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bearbeiten.Enabled = false;
            this.btn_bearbeiten.Location = new System.Drawing.Point(385, 148);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(24, 23);
            this.btn_bearbeiten.TabIndex = 53;
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.Btn_bearbeiten_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.btn_remove_all);
            this.groupBox5.Controls.Add(this.btn_remove_selected);
            this.groupBox5.Controls.Add(this.tb_zusatzanlage);
            this.groupBox5.Controls.Add(this.button4);
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
            this.groupBox5.Location = new System.Drawing.Point(414, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(529, 510);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Enabled = false;
            this.btn_remove_all.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_all.Location = new System.Drawing.Point(352, 439);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(93, 41);
            this.btn_remove_all.TabIndex = 61;
            this.btn_remove_all.Text = "Alle Entfernen";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.Btn_remove_all_Click);
            // 
            // btn_remove_selected
            // 
            this.btn_remove_selected.Enabled = false;
            this.btn_remove_selected.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_selected.Location = new System.Drawing.Point(352, 393);
            this.btn_remove_selected.Name = "btn_remove_selected";
            this.btn_remove_selected.Size = new System.Drawing.Size(93, 25);
            this.btn_remove_selected.TabIndex = 60;
            this.btn_remove_selected.Text = "Entfernen";
            this.btn_remove_selected.UseVisualStyleBackColor = true;
            this.btn_remove_selected.Click += new System.EventHandler(this.Btn_remove_selected_Click);
            // 
            // tb_zusatzanlage
            // 
            this.tb_zusatzanlage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_zusatzanlage.Location = new System.Drawing.Point(11, 358);
            this.tb_zusatzanlage.Name = "tb_zusatzanlage";
            this.tb_zusatzanlage.Size = new System.Drawing.Size(335, 20);
            this.tb_zusatzanlage.TabIndex = 54;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(352, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 25);
            this.button4.TabIndex = 59;
            this.button4.Text = "Hinzufügen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_add_zusatzanlagen_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 335);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(147, 14);
            this.label28.TabIndex = 58;
            this.label28.Text = "Zusätzliche Anlagen:";
            // 
            // listb_zusatzanlagen
            // 
            this.listb_zusatzanlagen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listb_zusatzanlagen.FormattingEnabled = true;
            this.listb_zusatzanlagen.ItemHeight = 14;
            this.listb_zusatzanlagen.Location = new System.Drawing.Point(11, 389);
            this.listb_zusatzanlagen.Name = "listb_zusatzanlagen";
            this.listb_zusatzanlagen.Size = new System.Drawing.Size(335, 102);
            this.listb_zusatzanlagen.TabIndex = 57;
            this.listb_zusatzanlagen.SelectedIndexChanged += new System.EventHandler(this.Listb_zusatzanlagen_SelectedIndexChanged);
            // 
            // cb_untervollmacht
            // 
            this.cb_untervollmacht.AutoSize = true;
            this.cb_untervollmacht.Location = new System.Drawing.Point(186, 263);
            this.cb_untervollmacht.Name = "cb_untervollmacht";
            this.cb_untervollmacht.Size = new System.Drawing.Size(15, 14);
            this.cb_untervollmacht.TabIndex = 55;
            this.cb_untervollmacht.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(8, 263);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 14);
            this.label29.TabIndex = 56;
            this.label29.Text = "Untervollmacht";
            // 
            // btn_bearbeiten_wesi
            // 
            this.btn_bearbeiten_wesi.BackgroundImage = global::DynamicPDFCreator.Properties.Resources.edit;
            this.btn_bearbeiten_wesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bearbeiten_wesi.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bearbeiten_wesi.Location = new System.Drawing.Point(501, 30);
            this.btn_bearbeiten_wesi.Name = "btn_bearbeiten_wesi";
            this.btn_bearbeiten_wesi.Size = new System.Drawing.Size(22, 22);
            this.btn_bearbeiten_wesi.TabIndex = 54;
            this.btn_bearbeiten_wesi.UseVisualStyleBackColor = true;
            this.btn_bearbeiten_wesi.Click += new System.EventHandler(this.Btn_bearbeiten_wesi_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(11, 33);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 14);
            this.label30.TabIndex = 47;
            this.label30.Text = "Wesi-Team";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(8, 282);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 14);
            this.label31.TabIndex = 46;
            this.label31.Text = "Plansätze";
            // 
            // cmb_ansprechpartnerBau
            // 
            this.cmb_ansprechpartnerBau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_ansprechpartnerBau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_ansprechpartnerBau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ansprechpartnerBau.Enabled = false;
            this.cmb_ansprechpartnerBau.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ansprechpartnerBau.FormattingEnabled = true;
            this.cmb_ansprechpartnerBau.Location = new System.Drawing.Point(152, 209);
            this.cmb_ansprechpartnerBau.Name = "cmb_ansprechpartnerBau";
            this.cmb_ansprechpartnerBau.Size = new System.Drawing.Size(194, 22);
            this.cmb_ansprechpartnerBau.TabIndex = 43;
            this.cmb_ansprechpartnerBau.SelectedIndexChanged += new System.EventHandler(this.Cmb_ansprechpartnerBau_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(140, 14);
            this.label32.TabIndex = 25;
            this.label32.Text = "Ansprechpartner Bau";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 76);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(126, 14);
            this.label33.TabIndex = 27;
            this.label33.Text = "Wesi-Team Adresse";
            // 
            // rtb_WesiAdresse
            // 
            this.rtb_WesiAdresse.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_WesiAdresse.Location = new System.Drawing.Point(152, 73);
            this.rtb_WesiAdresse.Name = "rtb_WesiAdresse";
            this.rtb_WesiAdresse.ReadOnly = true;
            this.rtb_WesiAdresse.Size = new System.Drawing.Size(194, 65);
            this.rtb_WesiAdresse.TabIndex = 28;
            this.rtb_WesiAdresse.Text = "";
            this.rtb_WesiAdresse.TextChanged += new System.EventHandler(this.Rtb_WesiAdresse_TextChanged);
            // 
            // cb_plansaetze
            // 
            this.cb_plansaetze.AutoSize = true;
            this.cb_plansaetze.Location = new System.Drawing.Point(186, 282);
            this.cb_plansaetze.Name = "cb_plansaetze";
            this.cb_plansaetze.Size = new System.Drawing.Size(15, 14);
            this.cb_plansaetze.TabIndex = 29;
            this.cb_plansaetze.UseVisualStyleBackColor = true;
            this.cb_plansaetze.CheckedChanged += new System.EventHandler(this.Cb_plansaetze_CheckedChanged);
            // 
            // cmb_wesie
            // 
            this.cmb_wesie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_wesie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_wesie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_wesie.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_wesie.FormattingEnabled = true;
            this.cmb_wesie.Location = new System.Drawing.Point(152, 30);
            this.cmb_wesie.Name = "cmb_wesie";
            this.cmb_wesie.Size = new System.Drawing.Size(343, 22);
            this.cmb_wesie.TabIndex = 44;
            // 
            // cb_beteiligte
            // 
            this.cb_beteiligte.AutoSize = true;
            this.cb_beteiligte.Location = new System.Drawing.Point(186, 243);
            this.cb_beteiligte.Name = "cb_beteiligte";
            this.cb_beteiligte.Size = new System.Drawing.Size(15, 14);
            this.cb_beteiligte.TabIndex = 30;
            this.cb_beteiligte.UseVisualStyleBackColor = true;
            this.cb_beteiligte.CheckedChanged += new System.EventHandler(this.Cb_beteiligte_CheckedChanged);
            // 
            // cb_techBeschreibung
            // 
            this.cb_techBeschreibung.AutoSize = true;
            this.cb_techBeschreibung.Location = new System.Drawing.Point(186, 302);
            this.cb_techBeschreibung.Name = "cb_techBeschreibung";
            this.cb_techBeschreibung.Size = new System.Drawing.Size(15, 14);
            this.cb_techBeschreibung.TabIndex = 31;
            this.cb_techBeschreibung.UseVisualStyleBackColor = true;
            this.cb_techBeschreibung.CheckedChanged += new System.EventHandler(this.Cb_techBeschreibung_CheckedChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 166);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 14);
            this.label35.TabIndex = 42;
            this.label35.Text = "Wesi-Team Email";
            // 
            // tb_WesiMail
            // 
            this.tb_WesiMail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WesiMail.Location = new System.Drawing.Point(152, 159);
            this.tb_WesiMail.Name = "tb_WesiMail";
            this.tb_WesiMail.ReadOnly = true;
            this.tb_WesiMail.Size = new System.Drawing.Size(194, 20);
            this.tb_WesiMail.TabIndex = 41;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(8, 303);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(168, 14);
            this.label37.TabIndex = 33;
            this.label37.Text = "Technische Beschreibung";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(8, 243);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(154, 14);
            this.label38.TabIndex = 34;
            this.label38.Text = "Liste der Beteiligten";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 629);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "ENTER = Absatz";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 653);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "SHIFT+ENTER = Umbruch";
            // 
            // listb_vorherige_PDF
            // 
            this.listb_vorherige_PDF.FormattingEnabled = true;
            this.listb_vorherige_PDF.Location = new System.Drawing.Point(595, 622);
            this.listb_vorherige_PDF.Name = "listb_vorherige_PDF";
            this.listb_vorherige_PDF.Size = new System.Drawing.Size(299, 264);
            this.listb_vorherige_PDF.TabIndex = 55;
            this.listb_vorherige_PDF.SelectedIndexChanged += new System.EventHandler(this.Listb_vorherige_PDF_SelectedIndexChanged);
            // 
            // btn_load_PDF
            // 
            this.btn_load_PDF.Enabled = false;
            this.btn_load_PDF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_PDF.Location = new System.Drawing.Point(900, 622);
            this.btn_load_PDF.Name = "btn_load_PDF";
            this.btn_load_PDF.Size = new System.Drawing.Size(59, 25);
            this.btn_load_PDF.TabIndex = 62;
            this.btn_load_PDF.Text = "Laden";
            this.btn_load_PDF.UseVisualStyleBackColor = true;
            this.btn_load_PDF.Click += new System.EventHandler(this.btn_load_PDF_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 685);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Beschreibung der Maßnahme";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 901);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 13);
            this.label39.TabIndex = 48;
            this.label39.Click += new System.EventHandler(this.error_label_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(12, 629);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(105, 14);
            this.label40.TabIndex = 53;
            this.label40.Text = "ENTER = Absatz";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(12, 653);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(154, 14);
            this.label41.TabIndex = 54;
            this.label41.Text = "SHIFT+ENTER = Umbruch";
            // 
            // btn_speichern_auftrag_pfad
            // 
            this.btn_speichern_auftrag_pfad.Location = new System.Drawing.Point(427, 618);
            this.btn_speichern_auftrag_pfad.Name = "btn_speichern_auftrag_pfad";
            this.btn_speichern_auftrag_pfad.Size = new System.Drawing.Size(162, 49);
            this.btn_speichern_auftrag_pfad.TabIndex = 67;
            this.btn_speichern_auftrag_pfad.Text = "Im Auftragsordner speichern";
            this.btn_speichern_auftrag_pfad.UseVisualStyleBackColor = true;
            // 
            // btn_vorschau
            // 
            this.btn_vorschau.Location = new System.Drawing.Point(427, 673);
            this.btn_vorschau.Name = "btn_vorschau";
            this.btn_vorschau.Size = new System.Drawing.Size(162, 49);
            this.btn_vorschau.TabIndex = 66;
            this.btn_vorschau.Text = "Vorschau";
            this.btn_vorschau.UseVisualStyleBackColor = true;
            // 
            // btn_saveDocument
            // 
            this.btn_saveDocument.Location = new System.Drawing.Point(427, 838);
            this.btn_saveDocument.Name = "btn_saveDocument";
            this.btn_saveDocument.Size = new System.Drawing.Size(162, 49);
            this.btn_saveDocument.TabIndex = 63;
            this.btn_saveDocument.Text = "Speichern unter";
            this.btn_saveDocument.UseVisualStyleBackColor = true;
            // 
            // btn_printDocument
            // 
            this.btn_printDocument.Enabled = false;
            this.btn_printDocument.Location = new System.Drawing.Point(427, 783);
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.Size = new System.Drawing.Size(162, 49);
            this.btn_printDocument.TabIndex = 64;
            this.btn_printDocument.Text = "Drucken";
            this.btn_printDocument.UseVisualStyleBackColor = true;
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.Enabled = false;
            this.btn_sendEmail.Location = new System.Drawing.Point(427, 728);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(162, 49);
            this.btn_sendEmail.TabIndex = 65;
            this.btn_sendEmail.Text = "per Email verschicken";
            this.btn_sendEmail.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 936);
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
            this.Text = "PDF Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SMNumber;
        private System.Windows.Forms.TextBox tb_smNummer;
        private System.Windows.Forms.Label lb_anschreibenTyp;
        private System.Windows.Forms.ComboBox cmb_anschreibenTyp;
        private System.Windows.Forms.ComboBox cmb_empfaenger;
        private System.Windows.Forms.Label lb_empfaenger;
        private System.Windows.Forms.ComboBox cmb_absender;
        private System.Windows.Forms.Label lb_absender;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lb_datum;
        private System.Windows.Forms.RichTextBox rtb_BeschreibungMassnahme;
        private System.Windows.Forms.Label lb_texteditor;
        private System.Windows.Forms.DateTimePicker datePickerAusfuehrung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Ansprechpartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_absprachen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ortMassnahme;
        private System.Windows.Forms.WebBrowser pdfPreview;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.DateTimePicker datePickerAusfuehrungEnde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listb_vorherige_PDF;
        private System.Windows.Forms.Button btn_load_PDF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_remove_all;
        private System.Windows.Forms.Button btn_remove_selected;
        private System.Windows.Forms.TextBox tb_zusatzanlage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox listb_zusatzanlagen;
        private System.Windows.Forms.CheckBox cb_untervollmacht;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_bearbeiten_wesi;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmb_ansprechpartnerBau;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RichTextBox rtb_WesiAdresse;
        private System.Windows.Forms.CheckBox cb_plansaetze;
        private System.Windows.Forms.ComboBox cmb_wesie;
        private System.Windows.Forms.CheckBox cb_beteiligte;
        private System.Windows.Forms.CheckBox cb_techBeschreibung;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tb_WesiMail;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btn_speichern_auftrag_pfad;
        private System.Windows.Forms.Button btn_vorschau;
        private System.Windows.Forms.Button btn_saveDocument;
        private System.Windows.Forms.Button btn_printDocument;
        private System.Windows.Forms.Button btn_sendEmail;
    }
}

