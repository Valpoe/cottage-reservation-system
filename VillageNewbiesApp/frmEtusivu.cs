using MySqlConnector;
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

    public partial class frmEtusivu : Form
    {
        SQLConnection mySQL = new SQLConnection();
        public frmEtusivu()
        {
            InitializeComponent();
            loadTotalNumbers();
            cpbVarausaste.Value = 0;
        }

        private void frmEtusivu_Load(object sender, EventArgs e)
        {
            panelVaraukset.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelVaraukset.Width, panelVaraukset.Height, 5, 5));
            panelMokit.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelMokit.Width, panelMokit.Height, 5, 5));
            panelPalvelut.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelPalvelut.Width, panelPalvelut.Height, 5, 5));
            panelAsiakkaat.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelAsiakkaat.Width, panelAsiakkaat.Height, 5, 5));
        }

        private void loadTotalNumbers()
        {
            List<string> totalNumbers = mySQL.frontPageTotals();

            lblMokkiTotal.Text = totalNumbers[0];
            lblPalvelutTotal.Text = totalNumbers[1];
            lblVarausTotal.Text = totalNumbers[2];
            lblAsiakasTotal.Text = totalNumbers[3];
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTotalNumbers();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cpbVarausaste.Value += 1;
            cpbVarausaste.Text = cpbVarausaste.Value.ToString() + "%";
            if (cpbVarausaste.Value == 78)
            {
                timer1.Stop();
            }
        }
    }
}
