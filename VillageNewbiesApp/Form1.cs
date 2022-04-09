using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VillageNewbiesApp
{
    public partial class Form1 : Form
    {

        // Dictionary kaikille formeille

        private Dictionary<string, System.Windows.Forms.Form> screens = new Dictionary<string, System.Windows.Forms.Form>();

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            screens.Add("Etusivu", new frmEtusivu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Toiminta-alueet", new frmAlueet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Palvelut", new frmPalvelut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Varaukset", new frmVaraukset() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Asiakkaat", new frmAsiakkaat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Laskutus", new frmLaskutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Raportit", new frmRaportit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Eri formien avaus paneeliin
        private void loadPanel(string otsikko)
        {
            System.Windows.Forms.Form form = screens[otsikko];
            this.panelFormLoader.Controls.Clear();
            this.panelFormLoader.Controls.Add(form);
            form.Show();
        }
        // Navigointipalkin siirto ja otsikon tekstin vaihto
        private void ChangeNavbarAndTitle(Button button)
        {
            panelNavigation.Visible = true;
            labelOtsikko.Visible = true;
            panelNavigation.Height = button.Height;
            panelNavigation.Top = button.Top;
            labelOtsikko.Text = button.Text;
        }

        private void btnAlueet_Click(object sender, EventArgs e)
        {
            ChangeNavbarAndTitle(sender as Button);
            loadPanel(labelOtsikko.Text);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainFormToiminnallisuus.ReleaseCapture();
                mainFormToiminnallisuus.SendMessage(Handle, mainFormToiminnallisuus.WM_NCLBUTTONDOWN, mainFormToiminnallisuus.HT_CAPTION, 0);
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mouseHover(PictureBox pictureBox)
        {
            pictureBox.Size = new Size(32, 32);
        }

        private void mouseLeave(PictureBox pictureBox)
        {
            pictureBox.Size = new Size(25, 25);
        }
        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            mouseHover(sender as PictureBox);
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(sender as PictureBox);
        }
    }
}
