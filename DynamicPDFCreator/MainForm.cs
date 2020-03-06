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

            DBm.getAuftrag(tb_smNummer.Text);
            cmb_Ansprechpartner.Items.Clear();
            cmb_Ansprechpartner.Items.AddRange(DBm.ansprechpartnerNamen);
            cmb_Ansprechpartner.SelectedIndex=0;

        }

        private void ReinitializeComponents()
        {
            //Combobox Anschreiben Typ
            //this.cmb_anschreibenTyp.Items.AddRange(new object[] {"test1","Test2"});
        }
    }
}
