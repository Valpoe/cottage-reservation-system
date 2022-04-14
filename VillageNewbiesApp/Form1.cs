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
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        mainFormToiminnallisuus toiminnallisuus = new mainFormToiminnallisuus();
 
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Luodaan teema manageri ja tyyli kaikille komponenteille
            
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.DeepPurple200, MaterialSkin.TextShade.WHITE);
        }

        // Kotisivu aukeaa ensimmäisenä, kun ohjelma käynnistetään
        private void Form1_Load(object sender, EventArgs e)
        {
            panelNavigation.Height = btnEtusivu.Height;
            panelNavigation.Top = btnEtusivu.Top;
            labelOtsikko.Text = "Etusivu";
            this.panelFormLoader.Controls.Add(toiminnallisuus.screens["Etusivu"]);
            toiminnallisuus.screens["Etusivu"].Show();
        }
  
        private void btnAlueet_Click(object sender, EventArgs e)
        {
            toiminnallisuus.ChangeNavbarAndTitle(sender as Button, this);
            toiminnallisuus.loadScreen(labelOtsikko.Text, this, sender as Button);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainFormToiminnallisuus.ReleaseCapture();
                mainFormToiminnallisuus.SendMessage(Handle, mainFormToiminnallisuus.WM_NCLBUTTONDOWN, mainFormToiminnallisuus.HT_CAPTION, 0);
            }
        }

        // Minimize, maximize ja exit nappien toiminnallisuus
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

        // Animoidut minimize, maximize ja exit painikkeet
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
