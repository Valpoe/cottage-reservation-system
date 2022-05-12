using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VillageNewbiesApp
{

    public partial class frmEtusivu : Form
    {
        SQLConnection mySQL = new SQLConnection();
        frmOhjeet frmOhjeet = new frmOhjeet();

        public frmEtusivu()
        {
            InitializeComponent();
            loadTotalNumbers();
            cpbVarausaste.Value = 0;
        }

        private void frmEtusivu_Load(object sender, EventArgs e)
        {
            // Paneeleiden reunojen pyöristys

            panelVaraukset.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelVaraukset.Width, panelVaraukset.Height, 5, 5));
            panelMokit.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelMokit.Width, panelMokit.Height, 5, 5));
            panelPalvelut.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelPalvelut.Width, panelPalvelut.Height, 5, 5));
            panelAsiakkaat.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelAsiakkaat.Width, panelAsiakkaat.Height, 5, 5));
            panel1.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 5, 5));
        }

        // Lataa kokonaismäärät mökeistä, palveluista, varauksista ja asiakkaista näkyviin
        private void loadTotalNumbers()
        {
            List<string> totalNumbers = mySQL.frontPageTotals();

            lblMokkiTotal.Text = totalNumbers[0];
            lblPalvelutTotal.Text = totalNumbers[1];
            lblVarausTotal.Text = totalNumbers[2];
            lblAsiakasTotal.Text = totalNumbers[3];
        }

        // Päivittää kokonaismäärät mökeistä, palveluista, varauksista ja asiakkaista näkyviin
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTotalNumbers();
        }

        // Nostaa pyöreän progressbarin arvon asteittain
        private void timer1_Tick(object sender, EventArgs e)
        {
            cpbVarausaste.Value += 1;
            cpbVarausaste.Text = cpbVarausaste.Value.ToString() + "%";
            if (cpbVarausaste.Value == 78)
            {
                timer1.Stop();
            }
        }

        private void btnOhjeet_Click(object sender, EventArgs e)
        {
            frmOhjeet.Show();
        }
    }
}
