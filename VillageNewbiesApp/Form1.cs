﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace VillageNewbiesApp
{
    public partial class Form1 : Form
    {
        
        mainFormToiminnallisuus toiminnallisuus = new mainFormToiminnallisuus();
        public Form1()
        {
            InitializeComponent();

            // Formin reunojen pyöristys
            
            Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        

        // Etusivu aukeaa ensimmäisenä, kun ohjelma käynnistetään
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelNavigation.Height = btnEtusivu.Height;
            panelNavigation.Top = btnEtusivu.Top;
            lblOtsikko.Text = "Etusivu";
            this.panelFormLoader.Controls.Add(toiminnallisuus.screens["Etusivu"]);
            toiminnallisuus.screens["Etusivu"].Show();
            btnEtusivu.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
           
        }

        // Sivupaneelin napeista oikean formin aukaisu ja titlen vaihto
        private void btnAlueet_Click(object sender, EventArgs e)
        {
            toiminnallisuus.ChangeNavbarAndTitle(sender as Button, this);
            toiminnallisuus.loadScreen(lblOtsikko.Text, this, sender as Button);
        }

        // Formin liikuttelu hiirellä
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainFormToiminnallisuus.ReleaseCapture();
                mainFormToiminnallisuus.SendMessage(Handle, mainFormToiminnallisuus.WM_NCLBUTTONDOWN, mainFormToiminnallisuus.HT_CAPTION, 0);
            }
        }

        // Minimize ja exit nappien toiminnallisuus
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Animoidut minimize exit painikkeet
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

        // Sisäänkirjautumisformin aukaisu
        private void btnKirjauduSisaan_Click(object sender, EventArgs e)
        {
            btnKirjauduSisaan.Enabled = false;
            frmKirjauduSisaan kirjautuminen = new frmKirjauduSisaan();
            kirjautuminen.Owner = this;
            kirjautuminen.Show();
            this.Enabled = false;
        }

        // Buttoneiden pois käytöstä ottaminen
        private void btnKirjauduUlos_Click(object sender, EventArgs e)
        {
            
            Button button = sender as Button;
            
            foreach (Button bt in button.Parent.Controls.OfType<Button>())
            {
                if (bt.Name != button.Name)
                {
                    bt.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
                }
            }
            
            panelFormLoader.Controls.Clear();
            Form1_Load(sender, e);
            
            btnAsiakkaat.Enabled = false;
            btnVaraukset.Enabled = false;
            btnToimintaAlueet.Enabled = false;
            btnRaportit.Enabled = false;
            btnMokitJaPalvelut.Enabled = false;
            btnLaskutus.Enabled = false;
            btnKirjauduUlos.Visible = false;
            btnKirjauduSisaan.Enabled = true;
            btnKirjauduSisaan.Visible = true;       
        }

        // Kellon asettaminen
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAika.Text = DateTime.Now.ToLongTimeString();
            lblPaivays.Text = DateTime.Now.ToLongDateString();
        }
    }
}
