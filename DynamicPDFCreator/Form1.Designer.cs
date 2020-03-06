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
            this.txt_editor = new System.Windows.Forms.RichTextBox();
            this.lb_texteditor = new System.Windows.Forms.Label();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.btn_saveDocument = new System.Windows.Forms.Button();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tb_smNummer.Location = new System.Drawing.Point(103, 12);
            this.tb_smNummer.Name = "tb_smNummer";
            this.tb_smNummer.Size = new System.Drawing.Size(194, 20);
            this.tb_smNummer.TabIndex = 2;
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
            this.cmb_anschreibenTyp.Location = new System.Drawing.Point(103, 85);
            this.cmb_anschreibenTyp.Name = "cmb_anschreibenTyp";
            this.cmb_anschreibenTyp.Size = new System.Drawing.Size(194, 21);
            this.cmb_anschreibenTyp.TabIndex = 4;
            // 
            // cmb_empfaenger
            // 
            this.cmb_empfaenger.FormattingEnabled = true;
            this.cmb_empfaenger.Location = new System.Drawing.Point(103, 133);
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
            this.cmb_absender.Location = new System.Drawing.Point(103, 180);
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
            this.datePicker.Location = new System.Drawing.Point(103, 224);
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
            // txt_editor
            // 
            this.txt_editor.Location = new System.Drawing.Point(12, 324);
            this.txt_editor.Name = "txt_editor";
            this.txt_editor.Size = new System.Drawing.Size(432, 452);
            this.txt_editor.TabIndex = 11;
            this.txt_editor.Text = "";
            // 
            // lb_texteditor
            // 
            this.lb_texteditor.AutoSize = true;
            this.lb_texteditor.Location = new System.Drawing.Point(10, 308);
            this.lb_texteditor.Name = "lb_texteditor";
            this.lb_texteditor.Size = new System.Drawing.Size(54, 13);
            this.lb_texteditor.TabIndex = 12;
            this.lb_texteditor.Text = "Texteditor";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(661, 12);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(604, 764);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "per Email verschicken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_printDocument);
            this.Controls.Add(this.btn_saveDocument);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.lb_texteditor);
            this.Controls.Add(this.txt_editor);
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
        private System.Windows.Forms.RichTextBox txt_editor;
        private System.Windows.Forms.Label lb_texteditor;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btn_saveDocument;
        private System.Windows.Forms.Button btn_printDocument;
        private System.Windows.Forms.Button button1;
    }
}

