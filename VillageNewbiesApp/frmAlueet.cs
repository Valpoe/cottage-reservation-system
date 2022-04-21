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
        public frmAlueet()
        {
            InitializeComponent();

            SQLConnection mySQL = new SQLConnection();
            List<string> Alueet = mySQL.SQLselectAllAlueet();


            foreach(string a in Alueet)
            {
                mcbToimintaAlue.Items.Add(a);
            }
        }

        private void frmAlueet_Load(object sender, EventArgs e)
        {

        }
    }
}
