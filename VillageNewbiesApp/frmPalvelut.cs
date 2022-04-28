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
        }

        private void lblAlue_VisibleChanged(object sender, EventArgs e)
        {
            lblAlue.Text = frmAlueet.selectedAlue;

            mySQL.setAlueID(lblAlue.Text);
            lblAlueID.Text = frmAlueet.selectedID;
        }

        private void lblAlue_TextChanged(object sender, EventArgs e)
        {

        }

        private void mcbPalvelut_VisibleChanged(object sender, EventArgs e)
        {
            if(frmAlueet.selectedID == selectedID)
            {
                return;
            }

            selectedID = frmAlueet.selectedID;

            List<string> palvelut = mySQL.aluePalvelut(Convert.ToInt32(frmAlueet.selectedID));
            mcbPalvelut.Items.Clear();

            foreach(string a in palvelut)
            {
                mcbPalvelut.Items.Add(a);
            }
        }

        private void lblMokki_VisibleChanged(object sender, EventArgs e)
        {
            lblMokki.Text = frmAlueet.selectedMokki;
        }
    }
}
