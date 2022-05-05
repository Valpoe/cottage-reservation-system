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
    public partial class frmRaportit : Form
    {
        public frmRaportit()
        {
            InitializeComponent();
        }

        private void frmRaportit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.varaus' table. You can move, or remove it, as needed.
            this.alueTableAdapter1.Fill(this.dataSet1.alue);
            this.mokkiTableAdapter1.Fill(this.dataSet1.mokki);
            this.palveluTableAdapter1.Fill(this.dataSet1.palvelu);
            this.varausTableAdapter1.Fill(this.dataSet1.varaus);
            this.laskuTableAdapter1.Fill(this.dataSet1.lasku);
            this.asiakasTableAdapter1.Fill(this.dataSet1.asiakas);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
