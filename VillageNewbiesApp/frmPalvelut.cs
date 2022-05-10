﻿using System;
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
        private List<Panel> paneelit = new List<Panel>();
        private int count;

        public frmPalvelut()
        {
            InitializeComponent();

            //lisätään paneelit listaan
            paneelit.Add(pnlLisaaMokki);
            paneelit.Add(pnlPalvelut);
            paneelit.Add(pnlPoistaMokki);

            lblAlue.Text = "";
            pnlLisaaMokki.Hide();

            List<string> Alueet = mySQL.SQLselectAllAlueet();

            foreach (string a in Alueet)
            {
                mcbToimintaAlue.Items.Add(a);
            }

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
            mclbPalvelut.Controls.Clear();

            selectedID = frmAlueet.selectedID;

            List<string> palvelut = mySQL.aluePalvelut(Convert.ToInt32(frmAlueet.selectedID));


            foreach (string a in palvelut)
            {
                mclbPalvelut.Items.Add(a);
            }
        }

        private void lblAlue_TextChanged(object sender, EventArgs e)
        {

        }



        private void lblMokki_VisibleChanged(object sender, EventArgs e)
        {
            lblMokki.Text = frmAlueet.selectedMokki;
        }


        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlLisaaMokki.Controls)
            {
                if (c is MaterialSkin.Controls.MaterialTextBox)
                {
                    c.Text = String.Empty;
                }
            }

            msHenkilomaara.Value = 0;
        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            if(pnlLisaaMokki.Visible == true)
            {
                btnLisaaMokki.Text = "Lisää mökki";
                hidePanels(pnlPalvelut);
                return;
            }

            hidePanels(pnlLisaaMokki);
            btnLisaaMokki.Text = "Valitse palvelut";

        }

        private void lblMokki_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMokinLisays_Click(object sender, EventArgs e)
        {

            if(tbToimipaikka.Text == "")
            {
                MessageBox.Show("toimipaikka on pakollinen!");
            }

            try
            {
                Mokki lisattavaMokki = new Mokki(tbMokkinimi.Text, tbOsoite.Text, Convert.ToDouble(tbHinta.Text), mltbKuvaus.Text, Convert.ToInt32(tbHenkilomaara.Text), mltbVarustelu.Text, Convert.ToInt32(tbPostinumero.Text));
                string alue = mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString();
                lisattavaMokki.setAlueID(mySQL.getAlueID(alue));
                //mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString()
                mySQL.addMokki(lisattavaMokki);

                lblStatus.Visible = true;
                lblStatus.Text = "Lisäys onnistui!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Lisäyksessä tapahtui virhe!";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void mcbToimintaAlue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString() + " alue_ID: " + mySQL.getAlueID(mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString()));
            
        }

        private void msHenkilomaara_Click(object sender, EventArgs e)
        {

        }

        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                msHenkilomaara.Value = Convert.ToInt32(tbHenkilomaara.Text);
            }

        }

        private void msHenkilomaara_onValueChanged(object sender, int newValue)
        {
            tbHenkilomaara.Text = msHenkilomaara.Value.ToString();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            mlvPoistaMokki.Items.Clear();

            hidePanels(pnlPoistaMokki);

            List<Mokki> MokkiLista = new List<Mokki>();
            

            MokkiLista.AddRange(mySQL.getAllMokki());
            count = MokkiLista.Count();

            ListViewItem itm;
            string[] arr = new string[3];


            foreach (Mokki a in MokkiLista)
            {
                arr[0] = a.GetID().ToString();
                arr[1] = a.GetNimi();
                arr[2] = a.GetKatuosoite();

                itm = new ListViewItem(arr);

                mlvPoistaMokki.Items.Add(itm);
            }
        }

        private void hidePanels(Panel panel)
        {
            if (panel.Name == pnlLisaaMokki.Name)
            {
                btnTyhjenna.Visible = true;
            }
            else
            {
                btnTyhjenna.Visible = false;
            }
            foreach (Panel p in paneelit)
            {
                if (p == panel)
                {
                    p.Show();
                    continue;
                }

                p.Hide();
            }
        }

        private void btnPoistaValitut_Click(object sender, EventArgs e)
        {

            if(mlvPoistaMokki.SelectedItems.Count > 0)
            {
                bool check = mySQL.SQLdeleteMokki(mlvPoistaMokki.SelectedItems[0].SubItems[0].Text);

                if(check == true)
                {
                    mlvPoistaMokki.Items.Remove(mlvPoistaMokki.SelectedItems[0]);
                }
            }

        }

        private void tbPostinumero_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {              

                e.Handled = true;
            }
        }
    }
}
