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
        Ansprechpartner ansprechpartner = new Ansprechpartner();
        WesiTeam wesiTeam = new WesiTeam();
        public EditDataset()
        {
            InitializeComponent();
        }

        public void ReinitializeComponent(Ansprechpartner ansprechpartner, Dictionary<string, AnsprechpartnerTyp> ansprechpartnerTypen)
        {
            tb_vorname.Text =       ansprechpartner.ansprechpartnerVorname;
            tb_nachname.Text =      ansprechpartner.ansprechpartnerName;
            tb_strasse.Text =       ansprechpartner.strasse;
            tb_plz.Text =           ansprechpartner.plz;
            tb_ort.Text =           ansprechpartner.ort;
            tb_mobil.Text =         ansprechpartner.mobil;
            tb_tel.Text =           ansprechpartner.telefon;
            tb_mail.Text =          ansprechpartner.email;
            tb_firma.Text =         ansprechpartner.firma;
            tb_bereich.Text =       ansprechpartner.bereich;
            tb_funktion.Text =      ansprechpartner.funktion;
            
            tb_homepage.Text =      ansprechpartner.homepage;
            tb_niederlassung.Text = ansprechpartner.niederlassung;
            tb_nl_abteilung.Text =  ansprechpartner.nlAbteilung;
            tb_ptiBereich.Text =    ansprechpartner.ptiBereich;
            tb_bemerkung.Text =     ansprechpartner.bemerkung;
            this.ansprechpartner =  ansprechpartner;
            cmb_typ.DisplayMember = "Key";
            cmb_typ.ValueMember = "Value";
            cmb_typ.DataSource= new BindingSource(ansprechpartnerTypen, null);
            AnsprechpartnerTyp ansprechtyp;
            if (!ansprechpartnerTypen.TryGetValue(ansprechpartner.typ,out ansprechtyp))
            {
                ansprechpartnerTypen.TryGetValue(ansprechpartner.typ.ToUpper(), out ansprechtyp);
            }
            try
            {
                cmb_typ.SelectedItem = new KeyValuePair<string, AnsprechpartnerTyp>($@"{ansprechtyp.bezeichnung}", ansprechtyp);
            }
            catch (Exception)//todo: Errorhandler implementieren
            {
                cmb_typ.SelectedItem = null;
            }
        }
        public void ReinitializeComponent(WesiTeam wesiTeam)
        {
            tb_strasse.Text =       wesiTeam.strasse;
            tb_plz.Text =           wesiTeam.plz;
            tb_ort.Text =           wesiTeam.stadt;
            tb_mail.Text =          wesiTeam.email;
            tb_firma.Text =         wesiTeam.firma;
            tb_bereich.Text =       wesiTeam.bereich;
            tb_niederlassung.Text = wesiTeam.niederlassung;
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
            if (wesiTeam.id!=0)
            {
                wesiTeam.strasse =        tb_strasse.Text;
                wesiTeam.plz =           tb_plz.Text;
                wesiTeam.stadt =           tb_ort.Text;
                wesiTeam.email =         tb_mail.Text;
                wesiTeam.firma =         tb_firma.Text;
                wesiTeam.bereich =       tb_bereich.Text;   
                wesiTeam.niederlassung = tb_niederlassung.Text;
                DBManager dbm = new DBManager();
                dbm.set(wesiTeam);
            }

            if (ansprechpartner.id != 0)
            { 
                ansprechpartner.ansprechpartnerVorname = tb_vorname.Text;
                ansprechpartner.ansprechpartnerName = tb_nachname.Text;
                ansprechpartner.strasse = tb_strasse.Text;
                ansprechpartner.plz = tb_plz.Text;
                ansprechpartner.ort = tb_ort.Text;
                ansprechpartner.mobil = tb_mobil.Text;
                ansprechpartner.telefon = tb_tel.Text;
                ansprechpartner.email = tb_mail.Text;
                ansprechpartner.firma = tb_firma.Text;
                ansprechpartner.bereich = tb_bereich.Text;
                ansprechpartner.funktion = tb_funktion.Text;
                ansprechpartner.typ = cmb_typ.Text;
                ansprechpartner.homepage = tb_homepage.Text;
                ansprechpartner.niederlassung = tb_niederlassung.Text;
                ansprechpartner.nlAbteilung = tb_nl_abteilung.Text;
                ansprechpartner.ptiBereich = tb_ptiBereich.Text;
                ansprechpartner.bemerkung = tb_bemerkung.Text;

                DBManager dbm = new DBManager();
                dbm.set(ansprechpartner);
            }
            this.Close();

        }

        private void Btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
