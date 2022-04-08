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
        // Formin reunojen pyöristys
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
       
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Buttonin taustavärin vaihto ja otsikon tekstin vaihto
        private void ChangeColor(Button button)
        {
            panelNavigation.Visible = true;
            labelOtsikko.Visible = true;
            panelNavigation.Height = button.Height;
            panelNavigation.Top = button.Top;
            button.BackColor = Color.FromArgb(46, 51, 73);
            labelOtsikko.Text = button.Text;
        }

        // Buttonin taustavärin vaihto takaisin
        private void ChangeColorLeave(Button button)
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAlueet_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
        }

        private void btnAlueet_Leave(object sender, EventArgs e)
        {
            ChangeColorLeave(sender as Button);
        }
    }
}
