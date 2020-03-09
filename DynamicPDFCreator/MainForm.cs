using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Tb_smNummer_TextChanged(object sender, EventArgs e)
        {

            DBm=new DBManager(tb_smNummer.Text);
            cmb_Ansprechpartner.Items.Clear();
            cmb_Ansprechpartner.Items.AddRange(DBm.ansprechpartnerNamen);
            cmb_Ansprechpartner.SelectedIndex=0;
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_Ansprechpartner.Items.AddRange(DBm.bearbeiterNamen);
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_ansprechpartnerBau.Items.AddRange(DBm.ansprechpartnerNamen);
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_empfaenger.Items.AddRange(DBm.ansprechpartnerNamen);
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_absender.Items.AddRange(DBm.bearbeiterNamen);
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_Ansprechpartner.Items.AddRange(DBm.bearbeiterNamen);
            this.cmb_Ansprechpartner.Items.Clear();
            this.cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);

            pdf.auftrag = DBm.auftrag;

        }

        private void ReinitializeComponents()
        {
            //Combobox Anschreiben Typ
            this.cmb_anschreibenTyp.Items.AddRange(DBm.anschreibenNamen);
            this.cmb_wesie.Items.AddRange(DBm.wesiTeamNamen);
        }

        private void Cmb_anschreibenTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.anschreibenTyp = DBm.anschreiben.ElementAt<TblAnschreibenTyp>(cmb_anschreibenTyp.SelectedIndex);
        }

        private void Cmb_empfaenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.empfaenger = DBm.ansprechpartner.ElementAt<TblAnsprechpartner>(cmb_Ansprechpartner.SelectedIndex);
        }

        private void Cmb_absender_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.absender = cmb_absender.Text;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            pdf.datum = datePicker.Value;
        }

        private void DatePickerAusfuehrung_ValueChanged(object sender, EventArgs e)
        {
            pdf.ausfuehrungszeitraum = datePickerAusfuehrung.Value;
        }

        private void Cmb_Ansprechpartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.ansprechpartner = DBm.bearbeiter.ElementAt<TblBearbeiter>(cmb_Ansprechpartner.SelectedIndex);
        }

        private void Cmb_ortMassnahme_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdf.ortDerMaßnahme = cmb_ortMassnahme.Text;
        }

        private void Rtb_absprachen_TextChanged(object sender, EventArgs e)
        {
            pdf.abgesprochenMit = rtb_absprachen.Text;
        }

        private void Rtb_BeschreibungMassnahme_TextChanged(object sender, EventArgs e)
        {
            pdf.beschreibungMassnahme = rtb_BeschreibungMassnahme.Text;
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
    }
}
