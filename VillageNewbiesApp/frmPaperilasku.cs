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
    public partial class frmPaperilasku : Form
    {
        public string laskuntiedot { get; set; }
        public frmPaperilasku()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(mmltbLaskunTiedon.Text, new Font("Nirmala UI", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void frmPaperilasku_Load(object sender, EventArgs e)
        {
            mmltbLaskunTiedon.Text = laskuntiedot;
        }
    }
}
