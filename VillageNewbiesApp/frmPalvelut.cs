using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbiesApp
{
    

    public partial class frmPalvelut : Form
    {

        SQLConnection mySQL = new SQLConnection();
        private static string selectedID;

        public frmPalvelut()
        {
            InitializeComponent();
            lblAlue.Text = "";
            pnlLisaaMokki.Hide();

            List<string> Alueet = mySQL.SQLselectAllAlueet();

            foreach (string a in Alueet)
            {
                mcbToimintaAlue.Items.Add(a);
            }

        }

        private void lblAlue_VisibleChanged(object sender, EventArgs e)
        {
            lblAlue.Text = frmAlueet.selectedAlue;

            mySQL.setAlueID(lblAlue.Text);
            lblAlueID.Text = frmAlueet.selectedID;

            if (frmAlueet.selectedID == selectedID)
            {
                return;
            }

            //remove all items
            mclbPalvelut.Controls.Clear();

            selectedID = frmAlueet.selectedID;

            List<string> palvelut = mySQL.aluePalvelut(Convert.ToInt32(frmAlueet.selectedID));


            foreach (string a in palvelut)
            {
                mclbPalvelut.Items.Add(a);
            }
        }

        private void lblAlue_TextChanged(object sender, EventArgs e)
        {

        }



        private void lblMokki_VisibleChanged(object sender, EventArgs e)
        {
            lblMokki.Text = frmAlueet.selectedMokki;
        }


        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            if(pnlLisaaMokki.Visible == true)
            {

            }
        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            if(pnlPalvelut.Visible == false)
            {
                pnlPalvelut.Show();
                pnlLisaaMokki.Hide();
                btnLisaaMokki.Text = "Lisää mokki";
                return;
            }

            pnlPalvelut.Hide();
            pnlLisaaMokki.Show();
            btnLisaaMokki.Text = "Valitse palvelut";
        }

        private void lblMokki_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMokinLisays_Click(object sender, EventArgs e)
        {
            
        }
    }
}
