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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.btn_saveDocument = new System.Windows.Forms.Button();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.datePickerAusfuehrung = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Ansprechpartner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ortMassnahme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_absprachen = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_AnsprechpartnerBau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_WesiAdresse = new System.Windows.Forms.RichTextBox();
            this.cb_plansaetze = new System.Windows.Forms.CheckBox();
            this.cb_beteiligte = new System.Windows.Forms.CheckBox();
            this.cb_techBeschreibung = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ZusatzAnlage1 = new System.Windows.Forms.TextBox();
            this.tb_ZusatzAnlage2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ZusatzAnlage3 = new System.Windows.Forms.TextBox();
            this.tb_WesiMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_SMNumber
            // 
            this.lb_SMNumber.AutoSize = true;
            this.lb_SMNumber.Location = new System.Drawing.Point(10, 15);
            this.lb_SMNumber.Name = "lb_SMNumber";
            this.lb_SMNumber.Size = new System.Drawing.Size(65, 13);
            this.lb_SMNumber.TabIndex = 1;
            this.lb_SMNumber.Text = "SM-Nummer";
            // 
            // tb_smNummer
            // 
            this.tb_smNummer.Location = new System.Drawing.Point(123, 12);
            this.tb_smNummer.Name = "tb_smNummer";
            this.tb_smNummer.Size = new System.Drawing.Size(194, 20);
            this.tb_smNummer.TabIndex = 2;
            this.tb_smNummer.TextChanged += new System.EventHandler(this.Tb_smNummer_TextChanged);
            // 
            // lb_anschreibenTyp
            // 
            this.lb_anschreibenTyp.AutoSize = true;
            this.lb_anschreibenTyp.Location = new System.Drawing.Point(10, 88);
            this.lb_anschreibenTyp.Name = "lb_anschreibenTyp";
            this.lb_anschreibenTyp.Size = new System.Drawing.Size(87, 13);
            this.lb_anschreibenTyp.TabIndex = 3;
            this.lb_anschreibenTyp.Text = "Anschreiben Typ";
            // 
            // cmb_anschreibenTyp
            // 
            this.cmb_anschreibenTyp.FormattingEnabled = true;
            this.cmb_anschreibenTyp.Location = new System.Drawing.Point(123, 85);
            this.cmb_anschreibenTyp.Name = "cmb_anschreibenTyp";
            this.cmb_anschreibenTyp.Size = new System.Drawing.Size(194, 21);
            this.cmb_anschreibenTyp.TabIndex = 4;
            // 
            // cmb_empfaenger
            // 
            this.cmb_empfaenger.FormattingEnabled = true;
            this.cmb_empfaenger.Location = new System.Drawing.Point(123, 133);
            this.cmb_empfaenger.Name = "cmb_empfaenger";
            this.cmb_empfaenger.Size = new System.Drawing.Size(194, 21);
            this.cmb_empfaenger.TabIndex = 5;
            // 
            // lb_empfaenger
            // 
            this.lb_empfaenger.AutoSize = true;
            this.lb_empfaenger.Location = new System.Drawing.Point(10, 136);
            this.lb_empfaenger.Name = "lb_empfaenger";
            this.lb_empfaenger.Size = new System.Drawing.Size(58, 13);
            this.lb_empfaenger.TabIndex = 6;
            this.lb_empfaenger.Text = "Empfänger";
            // 
            // cmb_absender
            // 
            this.cmb_absender.FormattingEnabled = true;
            this.cmb_absender.Location = new System.Drawing.Point(123, 177);
            this.cmb_absender.Name = "cmb_absender";
            this.cmb_absender.Size = new System.Drawing.Size(194, 21);
            this.cmb_absender.TabIndex = 7;
            // 
            // lb_absender
            // 
            this.lb_absender.AutoSize = true;
            this.lb_absender.Location = new System.Drawing.Point(10, 180);
            this.lb_absender.Name = "lb_absender";
            this.lb_absender.Size = new System.Drawing.Size(52, 13);
            this.lb_absender.TabIndex = 8;
            this.lb_absender.Text = "Absender";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(123, 224);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(194, 20);
            this.datePicker.TabIndex = 9;
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Location = new System.Drawing.Point(12, 224);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(38, 13);
            this.lb_datum.TabIndex = 10;
            this.lb_datum.Text = "Datum";
            // 
            // rtb_BeschreibungMassnahme
            // 
            this.rtb_BeschreibungMassnahme.Location = new System.Drawing.Point(12, 522);
            this.rtb_BeschreibungMassnahme.Name = "rtb_BeschreibungMassnahme";
            this.rtb_BeschreibungMassnahme.Size = new System.Drawing.Size(432, 254);
            this.rtb_BeschreibungMassnahme.TabIndex = 11;
            this.rtb_BeschreibungMassnahme.Text = "";
            // 
            // lb_texteditor
            // 
            this.lb_texteditor.AutoSize = true;
            this.lb_texteditor.Location = new System.Drawing.Point(10, 506);
            this.lb_texteditor.Name = "lb_texteditor";
            this.lb_texteditor.Size = new System.Drawing.Size(146, 13);
            this.lb_texteditor.TabIndex = 12;
            this.lb_texteditor.Text = "Beschreibung der Maßnahme";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(724, 15);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(631, 822);
            this.printPreviewControl1.TabIndex = 13;
            // 
            // btn_saveDocument
            // 
            this.btn_saveDocument.Location = new System.Drawing.Point(472, 715);
            this.btn_saveDocument.Name = "btn_saveDocument";
            this.btn_saveDocument.Size = new System.Drawing.Size(162, 61);
            this.btn_saveDocument.TabIndex = 14;
            this.btn_saveDocument.Text = "Speichern unter";
            this.btn_saveDocument.UseVisualStyleBackColor = true;
            // 
            // btn_printDocument
            // 
            this.btn_printDocument.Location = new System.Drawing.Point(472, 648);
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.Size = new System.Drawing.Size(162, 61);
            this.btn_printDocument.TabIndex = 15;
            this.btn_printDocument.Text = "Drucken";
            this.btn_printDocument.UseVisualStyleBackColor = true;
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.Location = new System.Drawing.Point(472, 581);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(162, 61);
            this.btn_sendEmail.TabIndex = 16;
            this.btn_sendEmail.Text = "per Email verschicken";
            this.btn_sendEmail.UseVisualStyleBackColor = true;
            this.btn_sendEmail.Click += new System.EventHandler(this.Button1_Click);
            // 
            // datePickerAusfuehrung
            // 
            this.datePickerAusfuehrung.Location = new System.Drawing.Point(123, 263);
            this.datePickerAusfuehrung.Name = "datePickerAusfuehrung";
            this.datePickerAusfuehrung.Size = new System.Drawing.Size(194, 20);
            this.datePickerAusfuehrung.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ausführungszeitraum";
            // 
            // cmb_Ansprechpartner
            // 
            this.cmb_Ansprechpartner.FormattingEnabled = true;
            this.cmb_Ansprechpartner.Location = new System.Drawing.Point(123, 300);
            this.cmb_Ansprechpartner.Name = "cmb_Ansprechpartner";
            this.cmb_Ansprechpartner.Size = new System.Drawing.Size(194, 21);
            this.cmb_Ansprechpartner.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ansprechpartner";
            // 
            // cmb_ortMassnahme
            // 
            this.cmb_ortMassnahme.FormattingEnabled = true;
            this.cmb_ortMassnahme.Location = new System.Drawing.Point(123, 341);
            this.cmb_ortMassnahme.Name = "cmb_ortMassnahme";
            this.cmb_ortMassnahme.Size = new System.Drawing.Size(194, 21);
            this.cmb_ortMassnahme.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ort der Maßnahme";
            // 
            // rtb_absprachen
            // 
            this.rtb_absprachen.Location = new System.Drawing.Point(15, 417);
            this.rtb_absprachen.Name = "rtb_absprachen";
            this.rtb_absprachen.Size = new System.Drawing.Size(302, 36);
            this.rtb_absprachen.TabIndex = 23;
            this.rtb_absprachen.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Beschreibung mit wem das Vorhaben \r\nabgesprochen wurde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ansprechpartner Bau";
            // 
            // tb_AnsprechpartnerBau
            // 
            this.tb_AnsprechpartnerBau.Location = new System.Drawing.Point(502, 85);
            this.tb_AnsprechpartnerBau.Name = "tb_AnsprechpartnerBau";
            this.tb_AnsprechpartnerBau.Size = new System.Drawing.Size(194, 20);
            this.tb_AnsprechpartnerBau.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wesi-Team Adresse";
            // 
            // rtb_WesiAdresse
            // 
            this.rtb_WesiAdresse.Location = new System.Drawing.Point(502, 133);
            this.rtb_WesiAdresse.Name = "rtb_WesiAdresse";
            this.rtb_WesiAdresse.Size = new System.Drawing.Size(194, 65);
            this.rtb_WesiAdresse.TabIndex = 28;
            this.rtb_WesiAdresse.Text = "";
            // 
            // cb_plansaetze
            // 
            this.cb_plansaetze.AutoSize = true;
            this.cb_plansaetze.Location = new System.Drawing.Point(510, 271);
            this.cb_plansaetze.Name = "cb_plansaetze";
            this.cb_plansaetze.Size = new System.Drawing.Size(15, 14);
            this.cb_plansaetze.TabIndex = 29;
            this.cb_plansaetze.UseVisualStyleBackColor = true;
            // 
            // cb_beteiligte
            // 
            this.cb_beteiligte.AutoSize = true;
            this.cb_beteiligte.Location = new System.Drawing.Point(510, 290);
            this.cb_beteiligte.Name = "cb_beteiligte";
            this.cb_beteiligte.Size = new System.Drawing.Size(15, 14);
            this.cb_beteiligte.TabIndex = 30;
            this.cb_beteiligte.UseVisualStyleBackColor = true;
            // 
            // cb_techBeschreibung
            // 
            this.cb_techBeschreibung.AutoSize = true;
            this.cb_techBeschreibung.Location = new System.Drawing.Point(510, 310);
            this.cb_techBeschreibung.Name = "cb_techBeschreibung";
            this.cb_techBeschreibung.Size = new System.Drawing.Size(15, 14);
            this.cb_techBeschreibung.TabIndex = 31;
            this.cb_techBeschreibung.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Plansätze";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Technische Beschreibung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Liste der Beteiligten";
            // 
            // tb_ZusatzAnlage1
            // 
            this.tb_ZusatzAnlage1.Location = new System.Drawing.Point(502, 344);
            this.tb_ZusatzAnlage1.Name = "tb_ZusatzAnlage1";
            this.tb_ZusatzAnlage1.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage1.TabIndex = 35;
            // 
            // tb_ZusatzAnlage2
            // 
            this.tb_ZusatzAnlage2.Location = new System.Drawing.Point(502, 378);
            this.tb_ZusatzAnlage2.Name = "tb_ZusatzAnlage2";
            this.tb_ZusatzAnlage2.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage2.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Zusatzanlage 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Zusatzanlage 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Zusatzanlage 3";
            // 
            // tb_ZusatzAnlage3
            // 
            this.tb_ZusatzAnlage3.Location = new System.Drawing.Point(502, 414);
            this.tb_ZusatzAnlage3.Name = "tb_ZusatzAnlage3";
            this.tb_ZusatzAnlage3.Size = new System.Drawing.Size(194, 20);
            this.tb_ZusatzAnlage3.TabIndex = 40;
            // 
            // tb_WesiMail
            // 
            this.tb_WesiMail.Location = new System.Drawing.Point(502, 217);
            this.tb_WesiMail.Name = "tb_WesiMail";
            this.tb_WesiMail.Size = new System.Drawing.Size(194, 20);
            this.tb_WesiMail.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Wesi-Team Email";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 846);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_WesiMail);
            this.Controls.Add(this.tb_ZusatzAnlage3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_ZusatzAnlage2);
            this.Controls.Add(this.tb_ZusatzAnlage1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_techBeschreibung);
            this.Controls.Add(this.cb_beteiligte);
            this.Controls.Add(this.cb_plansaetze);
            this.Controls.Add(this.rtb_WesiAdresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_AnsprechpartnerBau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_absprachen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_ortMassnahme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Ansprechpartner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerAusfuehrung);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.btn_printDocument);
            this.Controls.Add(this.btn_saveDocument);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.lb_texteditor);
            this.Controls.Add(this.rtb_BeschreibungMassnahme);
            this.Controls.Add(this.lb_datum);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lb_absender);
            this.Controls.Add(this.cmb_absender);
            this.Controls.Add(this.lb_empfaenger);
            this.Controls.Add(this.cmb_empfaenger);
            this.Controls.Add(this.cmb_anschreibenTyp);
            this.Controls.Add(this.lb_anschreibenTyp);
            this.Controls.Add(this.tb_smNummer);
            this.Controls.Add(this.lb_SMNumber);
            this.Name = "MainForm";
            this.Text = "PDF Creator";
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
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btn_saveDocument;
        private System.Windows.Forms.Button btn_printDocument;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.DateTimePicker datePickerAusfuehrung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Ansprechpartner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ortMassnahme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_absprachen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_AnsprechpartnerBau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_WesiAdresse;
        private System.Windows.Forms.CheckBox cb_plansaetze;
        private System.Windows.Forms.CheckBox cb_beteiligte;
        private System.Windows.Forms.CheckBox cb_techBeschreibung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage1;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ZusatzAnlage3;
        private System.Windows.Forms.TextBox tb_WesiMail;
        private System.Windows.Forms.Label label13;
    }
}

