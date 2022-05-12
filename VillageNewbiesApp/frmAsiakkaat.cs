using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace VillageNewbiesApp
{
    public partial class frmAsiakkaat : Form
    {
        SQLConnection mySQL = new SQLConnection();
        ErrorProvider errorProvider = new ErrorProvider();
        public static int selectedAsiakas;

        public frmAsiakkaat()
        {
            InitializeComponent();
        }

        // Tyhjennetään kaikki textboxit
        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MaterialSkin.Controls.MaterialTextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }

        // Tehdään virheentarkistus ja lisätään uusi asiakas tietokantaan
        public void btnLisaa_Click(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            int postiNro = 0;
            bool isNumber = int.TryParse(tbPostiNumero.Text, out postiNro);

            foreach (Control c in this.Controls)
            {
                if (c is MaterialSkin.Controls.MaterialTextBox)
                {
                    MaterialSkin.Controls.MaterialTextBox textBox = c as MaterialSkin.Controls.MaterialTextBox;
                    if (String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        errorProvider.SetError(textBox, "Täytä kaikki kentät!");
                    }
                    else if (!isNumber || tbPostiNumero.Text.Length != 5)
                    {
                        errorProvider.SetError(tbPostiNumero, "Postinumero on virheellinen!");
                    }
                    else
                    {
                        Asiakas asiakas = new Asiakas(tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbPostiNumero.Text,
                            tbPostitoimipaikka.Text, tbSahkoPosti.Text, tbPuhelinNumero.Text);
                        mySQL.SQLinsertCustomer(asiakas);
                        btnTyhjenna_Click(sender, e);

                        MessageBox.Show("Asiakas lisätty!");                       
                    }
                }
            }
            errorProvider.Clear();
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
            tbSearchBox.Enabled = true;
        }

        // Näytetään valitun asiakkaan varaukset
        private void btnNaytaTiedot_Click(object sender, EventArgs e)
        {
            List<string> asiakkaat = mySQL.SQLnaytaTiedot();

            mlvTiedot.Items.Clear();

            string[] lista = new string[5];
            ListViewItem item;

            if (mlvAsiakkaat.SelectedItems.Count > 0)
            {
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

                    if (mlvAsiakkaat.SelectedItems[0].SubItems[1].Text == item.SubItems[0].Text)
                    {
                        lblEiVarauksia.Visible = false;
                        mlvTiedot.Items.Add(item);
                    }
                    else if (mlvTiedot.Items.Count == 0)
                    {
                        lblEiVarauksia.Visible = true;
                    }
                }
            }
        }

        // Poistetaan valittu asiakas
        private void btnPoistaAsiakas_Click(object sender, EventArgs e)
        {
            if (mlvAsiakkaat.SelectedItems.Count > 0)
            {
                mySQL.SQLdeleteCustomer(mlvAsiakkaat.SelectedItems[0].SubItems[0].Text);
                mlvAsiakkaat.Items.Remove(mlvAsiakkaat.SelectedItems[0]);
                MessageBox.Show("Asiakas poistettu!");
            }
        }

        private void btnLuoVaraus_Click_1(object sender, EventArgs e)
        {
            try
            {
                string text = mlvAsiakkaat.SelectedItems[0].Text;
                selectedAsiakas = Int32.Parse(text);
                MessageBox.Show("Asiakas valittu, valitse seuraavaksi Toiminta-alueista haluttu mökki.");
            }
            catch(Exception)
            {
                MessageBox.Show("Valinta epäonnistui." +
                    " Valitse ensin asiakas kelle varaus luodaan.");
            }
        }
    }
}
