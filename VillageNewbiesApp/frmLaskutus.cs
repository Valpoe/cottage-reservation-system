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
    public partial class frmLaskutus : Form
    {
        public frmLaskutus()
        {
            InitializeComponent();
        }

        private void frmLaskutus_Load(object sender, EventArgs e)
        {
            SQLConnection mySQL = new SQLConnection();

            //List<String> Asiakkaat = mySQL.SQLselectAllbyName("asiakas");


            //foreach(string asiakas in Asiakkaat)
            //{
            //    mlvLaskutus.Items.Add(asiakas);
            //}


        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
