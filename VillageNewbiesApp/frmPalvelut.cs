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

        public frmPalvelut()
        {
            InitializeComponent();
            lblAlue.Text = "";
        }

        private void lblAlue_VisibleChanged(object sender, EventArgs e)
        {
            lblAlue.Text = frmAlueet.selectedAlue;
        }

        private void lblAlue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
