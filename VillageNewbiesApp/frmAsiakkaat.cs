using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace VillageNewbiesApp
{
    public partial class frmAsiakkaat : Form
    {
        public frmAsiakkaat()
        {
            InitializeComponent();


            //initialize asiakkaat from tietokanta
            SQLConnection mySQL = new SQLConnection();

            List<string> asiakaslista = mySQL.SQLselectAllbyName("asiakas");

            foreach(string asiakas in asiakaslista)
            {
                //MessageBox.Show(asiakas);
                materialListView1.Items.Add(asiakas);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
        }
    }
}
