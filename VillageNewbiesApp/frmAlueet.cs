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
    public partial class frmAlueet : Form
    {
        SQLConnection mySQL = new SQLConnection();
        public frmAlueet()
        {
            InitializeComponent();

            List<string> Alueet = mySQL.SQLselectAllAlueet();


            foreach(string a in Alueet)
            {
                mcbToimintaAlue.Items.Add(a);
            }
        }

        private void frmAlueet_Load(object sender, EventArgs e)
        {

        }

        private void mcbToimintaAlue_SelectedIndexChanged(object sender, EventArgs e)
        {

            mlvMokit.Items.Clear();

            //MessageBox.Show(mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString());
            List<string> mokit = mySQL.SQLselectMokit(mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString());


            foreach(string a in mokit)
            {
                mlvMokit.Items.Add(a);
            }
        }

        private void mlvMokit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
