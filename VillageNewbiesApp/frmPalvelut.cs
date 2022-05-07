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

            if (frmAlueet.selectedID == selectedID)
            {
                return;
            }

            //remove all items
            mclPalvelut.Items.Clear();

            selectedID = frmAlueet.selectedID;

            List<string> palvelut = mySQL.aluePalvelut(Convert.ToInt32(frmAlueet.selectedID));


            foreach (string a in palvelut)
            {
                mclPalvelut.Items.Add(a);
            }
        }

        private void lblAlue_TextChanged(object sender, EventArgs e)
        {

        }



        private void lblMokki_VisibleChanged(object sender, EventArgs e)
        {
            lblMokki.Text = frmAlueet.selectedMokki;
        }


        private void mbtnPoista_Click(object sender, EventArgs e)
        {
            foreach (int i in mclPalvelut.CheckedIndices)
            {
                mclPalvelut.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
