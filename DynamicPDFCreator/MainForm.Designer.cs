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
            this.btn_saveDocument = new System.Windows.Forms.Button();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.datePickerAusfuehrung = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Ansprechpartner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_absprachen = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_WesiAdresse = new System.Windows.Forms.RichTextBox();
            this.cb_plansaetze = new System.Windows.Forms.CheckBox();
            this.cb_beteiligte = new System.Windows.Forms.CheckBox();
            this.cb_techBeschreibung = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_WesiMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_ansprechpartnerBau = new System.Windows.Forms.ComboBox();
            this.cmb_wesie = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_ortMassnahme = new System.Windows.Forms.TextBox();
            this.pdfPreview = new System.Windows.Forms.WebBrowser();
            this.tb_ZusatzAnlage3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ZusatzAnlage2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ZusatzAnlage1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.btn_vorschau = new System.Windows.Forms.Button();
            this.datePickerAusfuehrungEnde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_bearbeiten_wesi = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SMNumber
            // 
            this.lb_SMNumber.AutoSize = true;
            this.lb_SMNumber.Location = new System.Drawing.Point(17, 30);
            this.lb_SMNumber.Name = "lb_SMNumber";
            this.lb_SMNumber.Size = new System.Drawing.Size(65, 13);
            this.lb_SMNumber.TabIndex = 1;
            this.lb_SMNumber.Text = "SM-Nummer";
            // 
            // tb_smNummer
            // 
            this.tb_smNummer.BackColor = System.Drawing.SystemColors.Window;
            this.tb_smNummer.Location = new System.Drawing.Point(130, 27);
            this.tb_smNummer.Name = "tb_smNummer";
            this.tb_smNummer.Size = new System.Drawing.Size(194, 20);
            this.tb_smNummer.TabIndex = 2;
            this.tb_smNummer.TextChanged += new System.EventHandler(this.Tb_smNummer_TextChanged);
            // 
            // lb_anschreibenTyp
            // 
            this.lb_anschreibenTyp.AutoSize = true;
            this.lb_anschreibenTyp.Location = new System.Drawing.Point(17, 103);
            this.lb_anschreibenTyp.Name = "lb_anschreibenTyp";
            this.lb_anschreibenTyp.Size = new System.Drawing.Size(87, 13);
            this.lb_anschreibenTyp.TabIndex = 3;
            this.lb_anschreibenTyp.Text = "Anschreiben Typ";
            // 
            // cmb_anschreibenTyp
            // 
            this.cmb_anschreibenTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_anschreibenTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_anschreibenTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_anschreibenTyp.FormattingEnabled = true;
            this.cmb_anschreibenTyp.Location = new System.Drawing.Point(130, 100);
            this.cmb_anschreibenTyp.Name = "cmb_anschreibenTyp";
            this.cmb_anschreibenTyp.Size = new System.Drawing.Size(194, 21);
            this.cmb_anschreibenTyp.TabIndex = 4;
            this.cmb_anschreibenTyp.SelectedIndexChanged += new System.EventHandler(this.Cmb_anschreibenTyp_SelectedIndexChanged);
            // 
            // cmb_empfaenger
            // 
            this.cmb_empfaenger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_empfaenger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_empfaenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empfaenger.FormattingEnabled = true;
            this.cmb_empfaenger.Location = new System.Drawing.Point(130, 148);
            this.cmb_empfaenger.Name = "cmb_empfaenger";
            this.cmb_empfaenger.Size = new System.Drawing.Size(194, 21);
            this.cmb_empfaenger.TabIndex = 5;
            this.cmb_empfaenger.SelectedIndexChanged += new System.EventHandler(this.Cmb_empfaenger_SelectedIndexChanged);
            // 
            // lb_empfaenger
            // 
            this.lb_empfaenger.AutoSize = true;
            this.lb_empfaenger.Location = new System.Drawing.Point(17, 151);
            this.lb_empfaenger.Name = "lb_empfaenger";
            this.lb_empfaenger.Size = new System.Drawing.Size(58, 13);
            this.lb_empfaenger.TabIndex = 6;
            this.lb_empfaenger.Text = "Empfänger";
            // 
            // cmb_absender
            // 
            this.cmb_absender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_absender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_absender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_absender.FormattingEnabled = true;
            this.cmb_absender.Location = new System.Drawing.Point(130, 192);
            this.cmb_absender.Name = "cmb_absender";
            this.cmb_absender.Size = new System.Drawing.Size(194, 21);
            this.cmb_absender.TabIndex = 7;
            this.cmb_absender.SelectedIndexChanged += new System.EventHandler(this.Cmb_absender_SelectedIndexChanged);
            // 
            // lb_absender
            // 
            this.lb_absender.AutoSize = true;
            this.lb_absender.Location = new System.Drawing.Point(17, 195);
            this.lb_absender.Name = "lb_absender";
            this.lb_absender.Size = new System.Drawing.Size(52, 13);
            this.lb_absender.TabIndex = 8;
            this.lb_absender.Text = "Absender";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(130, 239);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(194, 20);
            this.datePicker.TabIndex = 9;
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Location = new System.Drawing.Point(19, 239);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(38, 13);
            this.lb_datum.TabIndex = 10;
            this.lb_datum.Text = "Datum";
            // 
            // rtb_BeschreibungMassnahme
            // 
            this.rtb_BeschreibungMassnahme.Location = new System.Drawing.Point(12, 701);
            this.rtb_BeschreibungMassnahme.Name = "rtb_BeschreibungMassnahme";
            this.rtb_BeschreibungMassnahme.Size = new System.Drawing.Size(504, 185);
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
            // btn_saveDocument
            // 
            this.btn_saveDocument.Location = new System.Drawing.Point(61, 220);
            this.btn_saveDocument.Name = "btn_saveDocument";
            this.btn_saveDocument.Size = new System.Drawing.Size(162, 61);
            this.btn_saveDocument.TabIndex = 14;
            this.btn_saveDocument.Text = "Speichern unter";
            this.btn_saveDocument.UseVisualStyleBackColor = true;
            this.btn_saveDocument.Click += new System.EventHandler(this.Btn_saveDocument_Click);
            // 
            // btn_printDocument
            // 
            this.btn_printDocument.Enabled = false;
            this.btn_printDocument.Location = new System.Drawing.Point(61, 153);
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.Size = new System.Drawing.Size(162, 61);
            this.btn_printDocument.TabIndex = 15;
            this.btn_printDocument.Text = "Drucken";
            this.btn_printDocument.UseVisualStyleBackColor = true;
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.Enabled = false;
            this.btn_sendEmail.Location = new System.Drawing.Point(61, 86);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(162, 61);
            this.btn_sendEmail.TabIndex = 16;
            this.btn_sendEmail.Text = "per Email verschicken";
            this.btn_sendEmail.UseVisualStyleBackColor = true;
            this.btn_sendEmail.Click += new System.EventHandler(this.Button1_Click);
            // 
            // datePickerAusfuehrung
            // 
            this.datePickerAusfuehrung.Location = new System.Drawing.Point(130, 278);
            this.datePickerAusfuehrung.Name = "datePickerAusfuehrung";
            this.datePickerAusfuehrung.Size = new System.Drawing.Size(194, 20);
            this.datePickerAusfuehrung.TabIndex = 17;
            this.datePickerAusfuehrung.ValueChanged += new System.EventHandler(this.DatePickerAusfuehrung_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ausführungszeitraum";
            // 
            // cmb_Ansprechpartner
            // 
            this.cmb_Ansprechpartner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Ansprechpartner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Ansprechpartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ansprechpartner.FormattingEnabled = true;
            this.cmb_Ansprechpartner.Location = new System.Drawing.Point(130, 359);
            this.cmb_Ansprechpartner.Name = "cmb_Ansprechpartner";
            this.cmb_Ansprechpartner.Size = new System.Drawing.Size(194, 21);
            this.cmb_Ansprechpartner.TabIndex = 19;
            this.cmb_Ansprechpartner.SelectedIndexChanged += new System.EventHandler(this.Cmb_Ansprechpartner_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ansprechpartner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ort der Maßnahme";
            // 
            // rtb_absprachen
            // 
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
            this.label4.Location = new System.Drawing.Point(20, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Beschreibung mit wem das Vorhaben \r\nabgesprochen wurde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ansprechpartner Bau";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wesi-Team Adresse";
            // 
            // rtb_WesiAdresse
            // 
            this.rtb_WesiAdresse.Location = new System.Drawing.Point(137, 73);
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
            this.cb_plansaetze.Location = new System.Drawing.Point(145, 263);
            this.cb_plansaetze.Name = "cb_plansaetze";
            this.cb_plansaetze.Size = new System.Drawing.Size(15, 14);
            this.cb_plansaetze.TabIndex = 29;
            this.cb_plansaetze.UseVisualStyleBackColor = true;
            this.cb_plansaetze.CheckedChanged += new System.EventHandler(this.Cb_plansaetze_CheckedChanged);
            // 
            // cb_beteiligte
            // 
            this.cb_beteiligte.AutoSize = true;
            this.cb_beteiligte.Location = new System.Drawing.Point(145, 282);
            this.cb_beteiligte.Name = "cb_beteiligte";
            this.cb_beteiligte.Size = new System.Drawing.Size(15, 14);
            this.cb_beteiligte.TabIndex = 30;
            this.cb_beteiligte.UseVisualStyleBackColor = true;
            this.cb_beteiligte.CheckedChanged += new System.EventHandler(this.Cb_beteiligte_CheckedChanged);
            // 
            // cb_techBeschreibung
            // 
            this.cb_techBeschreibung.AutoSize = true;
            this.cb_techBeschreibung.Location = new System.Drawing.Point(145, 302);
            this.cb_techBeschreibung.Name = "cb_techBeschreibung";
            this.cb_techBeschreibung.Size = new System.Drawing.Size(15, 14);
            this.cb_techBeschreibung.TabIndex = 31;
            this.cb_techBeschreibung.UseVisualStyleBackColor = true;
            this.cb_techBeschreibung.CheckedChanged += new System.EventHandler(this.Cb_techBeschreibung_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-56, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Plansätze";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Technische Beschreibung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Liste der Beteiligten";
            // 
            // tb_WesiMail
            // 
            this.tb_WesiMail.Location = new System.Drawing.Point(137, 159);
            this.tb_WesiMail.Name = "tb_WesiMail";
            this.tb_WesiMail.ReadOnly = true;
            this.tb_WesiMail.Size = new System.Drawing.Size(194, 20);
            this.tb_WesiMail.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Wesi-Team Email";
            // 
            // cmb_ansprechpartnerBau
            // 
            this.cmb_ansprechpartnerBau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_ansprechpartnerBau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_ansprechpartnerBau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ansprechpartnerBau.Enabled = false;
            this.cmb_ansprechpartnerBau.FormattingEnabled = true;
            this.cmb_ansprechpartnerBau.Location = new System.Drawing.Point(137, 209);
            this.cmb_ansprechpartnerBau.Name = "cmb_ansprechpartnerBau";
            this.cmb_ansprechpartnerBau.Size = new System.Drawing.Size(194, 21);
            this.cmb_ansprechpartnerBau.TabIndex = 43;
            this.cmb_ansprechpartnerBau.SelectedIndexChanged += new System.EventHandler(this.Cmb_ansprechpartnerBau_SelectedIndexChanged);
            // 
            // cmb_wesie
            // 
            this.cmb_wesie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_wesie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_wesie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_wesie.FormattingEnabled = true;
            this.cmb_wesie.Location = new System.Drawing.Point(137, 30);
            this.cmb_wesie.Name = "cmb_wesie";
            this.cmb_wesie.Size = new System.Drawing.Size(343, 21);
            this.cmb_wesie.TabIndex = 44;
            this.cmb_wesie.SelectedIndexChanged += new System.EventHandler(this.Cmb_wesie_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-56, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Wesi-Team";
            // 
            // tb_ortMassnahme
            // 
            this.tb_ortMassnahme.Location = new System.Drawing.Point(130, 396);
            this.tb_ortMassnahme.Name = "tb_ortMassnahme";
            this.tb_ortMassnahme.Size = new System.Drawing.Size(194, 20);
            this.tb_ortMassnahme.TabIndex = 46;
            this.tb_ortMassnahme.TextChanged += new System.EventHandler(this.Tb_ortMassnahme_TextChanged);
            // 
            // pdfPreview
            // 
            this.pdfPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pdfPreview.Location = new System.Drawing.Point(1069, 0);
            this.pdfPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfPreview.Name = "pdfPreview";
            this.pdfPreview.Size = new System.Drawing.Size(782, 898);
            this.pdfPreview.TabIndex = 47;
            // 
            // tb_ZusatzAnlage3
            // 
            this.tb_ZusatzAnlage3.Location = new System.Drawing.Point(137, 406);
            this.tb_ZusatzAnlage3.Name = "tb_ZusatzAnlage3";
            this.tb_ZusatzAnlage3.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage3.TabIndex = 40;
            this.tb_ZusatzAnlage3.TextChanged += new System.EventHandler(this.Tb_ZusatzAnlage3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Zusatzanlage 3";
            // 
            // tb_ZusatzAnlage2
            // 
            this.tb_ZusatzAnlage2.Location = new System.Drawing.Point(137, 370);
            this.tb_ZusatzAnlage2.Name = "tb_ZusatzAnlage2";
            this.tb_ZusatzAnlage2.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage2.TabIndex = 36;
            this.tb_ZusatzAnlage2.TextChanged += new System.EventHandler(this.Tb_ZusatzAnlage2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Zusatzanlage 2";
            // 
            // tb_ZusatzAnlage1
            // 
            this.tb_ZusatzAnlage1.Location = new System.Drawing.Point(137, 336);
            this.tb_ZusatzAnlage1.Name = "tb_ZusatzAnlage1";
            this.tb_ZusatzAnlage1.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage1.TabIndex = 35;
            this.tb_ZusatzAnlage1.TextChanged += new System.EventHandler(this.Tb_ZusatzAnlage1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Zusatzanlage 1";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(223, 216);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 48;
            // 
            // btn_vorschau
            // 
            this.btn_vorschau.Location = new System.Drawing.Point(61, 19);
            this.btn_vorschau.Name = "btn_vorschau";
            this.btn_vorschau.Size = new System.Drawing.Size(162, 61);
            this.btn_vorschau.TabIndex = 49;
            this.btn_vorschau.Text = "Vorschau";
            this.btn_vorschau.UseVisualStyleBackColor = true;
            this.btn_vorschau.Click += new System.EventHandler(this.Btn_vorschau_Click);
            // 
            // datePickerAusfuehrungEnde
            // 
            this.datePickerAusfuehrungEnde.Location = new System.Drawing.Point(130, 314);
            this.datePickerAusfuehrungEnde.Name = "datePickerAusfuehrungEnde";
            this.datePickerAusfuehrungEnde.Size = new System.Drawing.Size(194, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 518);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.Location = new System.Drawing.Point(330, 148);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(75, 23);
            this.btn_bearbeiten.TabIndex = 53;
            this.btn_bearbeiten.Text = "bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.Btn_bearbeiten_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btn_bearbeiten_wesi);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmb_ansprechpartnerBau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rtb_WesiAdresse);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cb_plansaetze);
            this.groupBox2.Controls.Add(this.cmb_wesie);
            this.groupBox2.Controls.Add(this.cb_beteiligte);
            this.groupBox2.Controls.Add(this.cb_techBeschreibung);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_WesiMail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_ZusatzAnlage3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_ZusatzAnlage1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_ZusatzAnlage2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(458, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 445);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // btn_bearbeiten_wesi
            // 
            this.btn_bearbeiten_wesi.Location = new System.Drawing.Point(494, 30);
            this.btn_bearbeiten_wesi.Name = "btn_bearbeiten_wesi";
            this.btn_bearbeiten_wesi.Size = new System.Drawing.Size(75, 23);
            this.btn_bearbeiten_wesi.TabIndex = 54;
            this.btn_bearbeiten_wesi.Text = "bearbeiten";
            this.btn_bearbeiten_wesi.UseVisualStyleBackColor = true;
            this.btn_bearbeiten_wesi.Click += new System.EventHandler(this.Btn_bearbeiten_wesi_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Wesi-Team";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Plansätze";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.btn_vorschau);
            this.groupBox3.Controls.Add(this.btn_saveDocument);
            this.groupBox3.Controls.Add(this.btn_printDocument);
            this.groupBox3.Controls.Add(this.btn_sendEmail);
            this.groupBox3.Controls.Add(this.error_label);
            this.groupBox3.Location = new System.Drawing.Point(522, 586);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 300);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 898);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pdfPreview);
            this.Controls.Add(this.lb_texteditor);
            this.Controls.Add(this.rtb_BeschreibungMassnahme);
            this.Name = "MainForm";
            this.Text = "PDF Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btn_saveDocument;
        private System.Windows.Forms.Button btn_printDocument;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.DateTimePicker datePickerAusfuehrung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Ansprechpartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_absprachen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_WesiAdresse;
        private System.Windows.Forms.CheckBox cb_plansaetze;
        private System.Windows.Forms.CheckBox cb_beteiligte;
        private System.Windows.Forms.CheckBox cb_techBeschreibung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_WesiMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_ansprechpartnerBau;
        private System.Windows.Forms.ComboBox cmb_wesie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_ortMassnahme;
        private System.Windows.Forms.WebBrowser pdfPreview;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button btn_vorschau;
        private System.Windows.Forms.DateTimePicker datePickerAusfuehrungEnde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_bearbeiten_wesi;
    }
}

