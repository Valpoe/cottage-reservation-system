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

        ErrorProvider errorProvider = new ErrorProvider();
        public frmAsiakkaat()
        {
            InitializeComponent();


            //initialize asiakkaat from tietokanta
            
            //List<string> asiakaslista = mySQL.SQLselectAllbyName("asiakas");

            //foreach(string asiakas in asiakaslista)
            //{
            //    //MessageBox.Show(asiakas);
            //    mlvAsiakkaat.Items.Add(asiakas);
            //}
            
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
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            int postiNro = 0;
            bool isNumber = int.TryParse(tbPostiNumero.Text, out postiNro);

            if (String.IsNullOrWhiteSpace(tbEtunimi.Text))
            {
                errorProvider.SetError(tbEtunimi, "Etunimi on pakollinen");
            }
            if (String.IsNullOrWhiteSpace(tbSukunimi.Text))
            {
                errorProvider.SetError(tbSukunimi, "Sukunimi on pakollinen");
            }
            if (String.IsNullOrWhiteSpace(tbOsoite.Text))
            {
                errorProvider.SetError(tbOsoite, "Osoite on pakollinen");
            }
            if (String.IsNullOrWhiteSpace(tbSahkoPosti.Text))
            {
                errorProvider.SetError(tbSahkoPosti, "Sähköposti on pakollinen");
            }
            if (String.IsNullOrWhiteSpace(tbPuhelinNumero.Text))
            {
                errorProvider.SetError(tbPuhelinNumero, "Puhelinnumero on pakollinen");
            }
            if (String.IsNullOrWhiteSpace(tbPostiNumero.Text))
            {
                errorProvider.SetError(tbPostiNumero, "Postinumero on pakollinen");
            }
            else if (!isNumber || tbPostiNumero.Text.Length != 5)
            {
                errorProvider.SetError(tbPostiNumero, "Postinumero on virheellinen");
            }
            if (String.IsNullOrWhiteSpace(tbPostitoimipaikka.Text))
            {
                errorProvider.SetError(tbPostitoimipaikka, "Postitoimipaikka on pakollinen");
            }
            else
            {
                Asiakas asiakas = new Asiakas(tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbPostiNumero.Text, tbPostitoimipaikka.Text, tbSahkoPosti.Text, tbPuhelinNumero.Text);
                MessageBox.Show(asiakas.GetEtunimi());
                mySQL.SQLinsertCustomer(asiakas);
            }
            
        }

        private void tbEtunimi_MouseClick(object sender, MouseEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox tb = (MaterialSkin.Controls.MaterialTextBox)sender;
            errorProvider.SetError(tb, "");
        }

        private void btnLataaAsiakkaat_Click(object sender, EventArgs e)
        {
            mySQL.SQLselectAllbyName();
        }
    }
}
