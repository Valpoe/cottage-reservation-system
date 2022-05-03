using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace VillageNewbiesApp
{
    public partial class frmAsiakkaat : Form
    {
        SQLConnection mySQL = new SQLConnection();

        ErrorProvider errorProvider = new ErrorProvider();
        public static string selectedAsiakas;
        public frmAsiakkaat()
        {
            InitializeComponent();

        }

        private void frmAsiakkaat_Load(object sender, EventArgs e)
        {

        }

        // Tyhjennetään kaikki textboxit
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

        // Tehdään virheentarkistus ja lisätään uusi asiakas tietokantaan
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
                Asiakas asiakas = new Asiakas(tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbPostiNumero.Text,
                    tbPostitoimipaikka.Text, tbSahkoPosti.Text, tbPuhelinNumero.Text);
                mySQL.SQLinsertCustomer(asiakas);
                btnTyhjenna_Click(sender, e);

                // Asiakas lisätty label näkyy 3 sekunnin ajan
                
                lblAsiakasLisatty.Visible = true;

                var t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, a) =>
                {
                    t.Stop();
                    lblAsiakasLisatty.Visible = false;
                };
                t.Start();
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Clearataan error
        private void tbEtunimi_MouseClick(object sender, MouseEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox tb = (MaterialSkin.Controls.MaterialTextBox)sender;
            errorProvider.SetError(tb, "");
        }

        // Estetään columnien säätö
        private void mlvAsiakkaat_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.mlvAsiakkaat.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void mlvTiedot_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.mlvTiedot.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        // Etsitään ne asiakkaat tietokannasta, jotka sopivat hakutekstiin
        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            mlvAsiakkaat.Items.Clear();
            List<string> asiakkaat = mySQL.search(tbSearchBox.Text);

            string[] lista = new string[4];
            ListViewItem item;

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                lista[0] = asiakkaat[i];
                i++;
                lista[1] = asiakkaat[i];
                i++;
                lista[2] = asiakkaat[i];
                i++;
                lista[3] = asiakkaat[i];

                item = new ListViewItem(lista);

                mlvAsiakkaat.Items.Add(item);
            }
        }

        // Tuodaan asiakkaat tietokannasta listviewiin
        private void btnLataaAsiakkaat_Click(object sender, EventArgs e)
        {
            mlvAsiakkaat.Items.Clear();
            List<string> asiakkaat = mySQL.SQLselectAllbyName();

            string[] lista = new string[4];
            ListViewItem item;

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                lista[0] = asiakkaat[i];
                i++;
                lista[1] = asiakkaat[i];
                i++;
                lista[2] = asiakkaat[i];
                i++;
                lista[3] = asiakkaat[i];

                item = new ListViewItem(lista);

                mlvAsiakkaat.Items.Add(item);
            }
        }

        // Näytetään valitun asiakkaan varaukset
        private void btnNaytaTiedot_Click(object sender, EventArgs e)
        {
            List<string> asiakkaat = mySQL.SQLnaytaTiedot();

            mlvTiedot.Items.Clear();

            string[] lista = new string[5];
            ListViewItem item;

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                lista[0] = asiakkaat[i];
                i++;
                lista[1] = asiakkaat[i];
                i++;
                lista[2] = asiakkaat[i];
                i++;
                lista[3] = asiakkaat[i];
                i++;
                lista[4] = asiakkaat[i];

                item = new ListViewItem(lista);

                if (mlvAsiakkaat.SelectedItems.Count > 0)
                {
                    if (mlvAsiakkaat.SelectedItems[0].SubItems[1].Text == item.SubItems[0].Text)
                    {
                        lblEiVarauksia.Text = "";
                        mlvTiedot.Items.Add(item);
                        break;
                    }
                    else
                    {
                        lblEiVarauksia.Text = "Ei varauksia";
                    }                   
                }               
            }
        }

        private void btnLuoVaraus_Click(object sender, EventArgs e)
        {
          // var SelectedItem = (dynamic)mlvAsiakkaat.SelectedItems[0];
          //  MessageBox.Show(SelectedItem.ToString());
            selectedAsiakas = mlvAsiakkaat.SelectedItems[0].Text;
            MessageBox.Show(selectedAsiakas);
            // tämä on vettä
            

        }
    }
}
