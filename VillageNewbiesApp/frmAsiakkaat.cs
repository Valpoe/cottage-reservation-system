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
        SQLConnection mySQL = new SQLConnection();
        public frmAsiakkaat()
        {
            InitializeComponent();


            //initialize asiakkaat from tietokanta
            
            List<string> asiakaslista = mySQL.SQLselectAllbyName("asiakas");

            foreach(string asiakas in asiakaslista)
            {
                //MessageBox.Show(asiakas);
                mlvAsiakkaat.Items.Add(asiakas);
            }
            
        }

        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbEtunimi.Text = String.Empty;
            tbSukunimi.Text = String.Empty;
            tbOsoite.Text = String.Empty;
            tbSahkoPosti.Text = String.Empty;
            tbPuhelinNumero.Text = String.Empty;
            tbPostiNumero.Text = String.Empty;
            tbPostitoimipaikka.Text = String.Empty;
        }

        public void btnLisaa_Click(object sender, EventArgs e)
        {
            Asiakas asiakas = new Asiakas(tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbPostiNumero.Text, tbPostitoimipaikka.Text, tbSahkoPosti.Text, tbPuhelinNumero.Text);
            MessageBox.Show(asiakas.GetEtunimi());
            mySQL.SQLinsertCustomer(asiakas);

        }
    }
}
