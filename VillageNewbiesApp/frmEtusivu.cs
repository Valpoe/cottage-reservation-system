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
            loadChartData();
        }

        private void frmEtusivu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelVaraukset.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelVaraukset.Width, panelVaraukset.Height, 5, 5));
            panelMokit.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelMokit.Width, panelMokit.Height, 5, 5));
            panelPalvelut.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelPalvelut.Width, panelPalvelut.Height, 5, 5));
            panelAsiakkaat.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, panelAsiakkaat.Width, panelAsiakkaat.Height, 5, 5));
            flpChart.Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, flpChart.Width, flpChart.Height, 5, 5));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAika.Text = DateTime.Now.ToLongTimeString();
            lblPaivays.Text = DateTime.Now.ToLongDateString();
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
            loadChartData();
        }

        private void loadChartData()
        {
            using (MySqlConnection connection = SQLConnection.GetConnection())
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT postinro, hinta FROM mokki", connection);
                da.Fill(ds);
                chart1.DataSource = ds;

                chart1.Series["Hinta"].XValueMember = "postinro";
                chart1.Series["Hinta"].YValueMembers = "hinta";
            }
        }
    }
}
