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
    public partial class EditDataset : Form
    {
        TblAnsprechpartner ansprechpartner = new TblAnsprechpartner();
        TblWesiTeam wesiTeam = new TblWesiTeam();
        public EditDataset()
        {
            InitializeComponent();
        }

        public void ReinitializeComponent(TblAnsprechpartner ansprechpartner)
        {
            tb_vorname.Text =       ansprechpartner.AnsprechpartnerVorname;
            tb_nachname.Text =      ansprechpartner.AnsprechpartnerName;
            tb_strasse.Text =       ansprechpartner.Straße;
            tb_plz.Text =           ansprechpartner.PLZ;
            tb_ort.Text =           ansprechpartner.Ort;
            tb_mobil.Text =         ansprechpartner.Mobil;
            tb_tel.Text =           ansprechpartner.Telefon;
            tb_mail.Text =          ansprechpartner.Email;
            tb_firma.Text =         ansprechpartner.Firma;
            tb_bereich.Text =       ansprechpartner.Bereich;
            tb_funktion.Text =      ansprechpartner.Funktion;
            cmb_typ.Text =          ansprechpartner.Typ;
            tb_homepage.Text =      ansprechpartner.Homepage;
            tb_niederlassung.Text = ansprechpartner.Niederlassung;
            tb_nl_abteilung.Text =  ansprechpartner.NLAbteilung;
            tb_ptiBereich.Text =    ansprechpartner.PTIBereich;
            tb_bemerkung.Text =     ansprechpartner.Bemerkung;
            this.ansprechpartner =  ansprechpartner;
        }

        public void ReinitializeComponent(TblWesiTeam wesiTeam)
        {
            tb_strasse.Text =       wesiTeam.Strasse;
            tb_plz.Text =           wesiTeam.PLZ;
            tb_ort.Text =           wesiTeam.Stadt;
            tb_mail.Text =          wesiTeam.Email;
            tb_firma.Text =         wesiTeam.Firma;
            tb_bereich.Text =       wesiTeam.Bereich;
            tb_niederlassung.Text = wesiTeam.Niederlassung;
            //tb_ptiBereich.Text =  ansprechpartner.PTIBereich;

            tb_vorname.Enabled = false;
            tb_nachname.Enabled = false;
            tb_mobil.Enabled = false;
            tb_tel.Enabled = false;
            tb_funktion.Enabled = false;
            cmb_typ.Enabled = false;
            tb_homepage.Enabled = false;
            tb_nl_abteilung.Enabled = false;
            tb_ptiBereich.Enabled = false;
            tb_bemerkung.Enabled = false;
            this.wesiTeam = wesiTeam;
        }

        private void Btn_speichern_Click(object sender, EventArgs e)
        {
            if (wesiTeam.Id!=0)
            {
                wesiTeam.Strasse =        tb_strasse.Text;
                wesiTeam.PLZ =           tb_plz.Text;
                wesiTeam.Stadt =           tb_ort.Text;
                wesiTeam.Email =         tb_mail.Text;
                wesiTeam.Firma =         tb_firma.Text;
                wesiTeam.Bereich =       tb_bereich.Text;   
                wesiTeam.Niederlassung = tb_niederlassung.Text;
                DBManager dbm = new DBManager();
                dbm.set(wesiTeam);
            }

            if (ansprechpartner.IdAnsprechpartner != 0)
            { 
                ansprechpartner.AnsprechpartnerVorname = tb_vorname.Text;
                ansprechpartner.AnsprechpartnerName = tb_nachname.Text;
                ansprechpartner.Straße = tb_strasse.Text;
                ansprechpartner.PLZ = tb_plz.Text;
                ansprechpartner.Ort = tb_ort.Text;
                ansprechpartner.Mobil = tb_mobil.Text;
                ansprechpartner.Telefon = tb_tel.Text;
                ansprechpartner.Email = tb_mail.Text;
                ansprechpartner.Firma = tb_firma.Text;
                ansprechpartner.Bereich = tb_bereich.Text;
                ansprechpartner.Funktion = tb_funktion.Text;
                ansprechpartner.Typ = cmb_typ.Text;
                ansprechpartner.Homepage = tb_homepage.Text;
                ansprechpartner.Niederlassung = tb_niederlassung.Text;
                ansprechpartner.NLAbteilung = tb_nl_abteilung.Text;
                ansprechpartner.PTIBereich = tb_ptiBereich.Text;
                ansprechpartner.Bemerkung = tb_bemerkung.Text;

                DBManager dbm = new DBManager();
                dbm.set(ansprechpartner);
            }
            this.Close();

        }

        private void Btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
