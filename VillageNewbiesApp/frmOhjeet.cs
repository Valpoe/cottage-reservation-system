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
    public partial class frmOhjeet : Form
    {
        private Point location;
        public frmOhjeet()
        {
            InitializeComponent();
        }

        private void btnOhje1_Click(object sender, EventArgs e)
        { 
            string text = "Valitse Asiakkaat välilehdestä asiakas jolle varaus luodaan." + Environment.NewLine +
                "Tämän jälkeen valitse Alueet välilehdestä mökki jolle haluat luoda varauksen." + Environment.NewLine +
                "Seuraavaksi valitse Varaukset välilehdestä kalenterista mustaamalla halutut päivät varaukselle." + Environment.NewLine +
                "HUOM! Kalenteri näyttää mustattuna jo varatut päivät." + Environment.NewLine +
                "Valittuasi päivät, valitse Luo Varaus ja järjestelmään tallennettaan uusi varaus.";
            mmltbOhje.Text = text;       
        }

        private void btnOhje2_Click(object sender, EventArgs e)
        {
            string text = "Valitse Varaukset välilehdessä haluttu tilaus näkymästä." + Environment.NewLine +
                "Valittuasi halutun tilauksen, valitse Vahvista Varaus ja järjestelmä luo vahvistuksen tilaukselle.";
            mmltbOhje.Text = text;
        }

        private void btnOhje3_Click(object sender, EventArgs e)
        {
            string text = "Valitse Varaukset välilehdessä poistettava tilaus näkymästä." + Environment.NewLine +
                "Valittuasi halutun tilauksen, valitse Poista Varaus ja järjestelmä poistaa varauksen.";
            mmltbOhje.Text = text;
        }

        private void frmOhjeet_Load(object sender, EventArgs e)
        {

        }

        private void btnOhje4_Click(object sender, EventArgs e)
        {
            string text = "Valitse Asiakkaat välilehdessä poistettava asiakas näkymästä." + Environment.NewLine +
                "Valittuasi halutun asiakkaan, valitse Poista Asiakas ja asiakas poistetaan järjestelmästä." + Environment.NewLine +
                "HUOM. Et voi poistaa järjestelmästä asiakasta jolla on tehtyjä varauksia!";
            mmltbOhje.Text = text;
        }

        private void frmOhjeet_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void frmOhjeet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - location.X;
                int dy = e.Location.Y - location.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnOhje5_Click(object sender, EventArgs e)
        {
            string text = "Avaa asiakas välilehti, syötä asiakkaan tiedot vasemmassa reunassa olevaan kyselyyn ja paina Lisää asiakas.";
            mmltbOhje.Text = text;
        }

        private void btnOhje6_Click(object sender, EventArgs e)
        {
            string text = "Avaa Toiminta-alueet välilehti, Syötä Lisää alue - painikkeen yläpuolella olevaan kyselyyn alueen nimi ja painiketta painaessa alue lisätään tietokantaan.";
            mmltbOhje.Text = text;
        }

        private void btnOhje7_Click(object sender, EventArgs e)
        {
            string text = "Avaa Mökit ja Palvelut välilehti. Valitse lisää mökki ja syötä kyselyyn mökin tiedot. Paina uudestaan Lisää Mökki painiketta ja mökki lisätään tietokantaan.";
            mmltbOhje.Text = text;
        }
    }
}
