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
    public partial class frmKirjauduSisaan : Form
    {
        private bool flag;
        public frmKirjauduSisaan()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(mainFormToiminnallisuus.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                (this.Owner as Form1).btnToimintaAlueet.Enabled = true;
                (this.Owner as Form1).btnMokitJaPalvelut.Enabled = true;
                (this.Owner as Form1).btnRaportit.Enabled = true;
                (this.Owner as Form1).btnVaraukset.Enabled = true;
                (this.Owner as Form1).btnAsiakkaat.Enabled = true;
                (this.Owner as Form1).btnLaskutus.Enabled = true;
                (this.Owner as Form1).btnKirjauduSisaan.Visible = false;
                (this.Owner as Form1).btnKirjauduUlos.Visible = true;
                (this.Owner as Form1).Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Käyttäjätunnus tai salasana on väärin");
            }         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).btnKirjauduSisaan.Enabled = true;
            (this.Owner as Form1).Enabled = true;
            this.Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                btnShowPassword.Image = VillageNewbiesApp.Properties.Resources.show1;
                tbPassword.PasswordChar = '\0';
                tbPassword.Focus();
            }
            else
            {
                btnShowPassword.Image = VillageNewbiesApp.Properties.Resources.hide;
                tbPassword.PasswordChar = '•';
                tbPassword.Focus();
            }
            flag = !flag;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainFormToiminnallisuus.ReleaseCapture();
                mainFormToiminnallisuus.SendMessage(Handle, mainFormToiminnallisuus.WM_NCLBUTTONDOWN, mainFormToiminnallisuus.HT_CAPTION, 0);
            }
        }
    }
}
