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

        mainFormToiminnallisuus mainFormToiminnallisuus = new mainFormToiminnallisuus();
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
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje2_Click(object sender, EventArgs e)
        {
            string text = "Valitse Varaukset välilehdessä haluttu tilaus näkymästä." + Environment.NewLine +
                "Valittuasi halutun tilauksen, valitse Vahvista Varaus ja järjestelmä luo vahvistuksen tilaukselle.";
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje3_Click(object sender, EventArgs e)
        {
            string text = "Valitse Varaukset välilehdessä poistettava tilaus näkymästä." + Environment.NewLine +
                "Valittuasi halutun tilauksen, valitse Poista Varaus ja järjestelmä poistaa varauksen.";
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
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
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
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
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje6_Click(object sender, EventArgs e)
        {
            string text = "Avaa Toiminta-alueet välilehti, Syötä Lisää alue - painikkeen yläpuolella olevaan kyselyyn alueen nimi ja painiketta painaessa alue lisätään tietokantaan.";
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje7_Click(object sender, EventArgs e)
        {
            string text = "Avaa Mökit ja Palvelut välilehti. Valitse lisää mökki ja syötä kyselyyn mökin tiedot. Paina uudestaan Lisää Mökki painiketta ja mökki lisätään tietokantaan.";
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje10_Click(object sender, EventArgs e)
        {
            string text = "Valitse ensin haluttu toiminta-alue ja mökki, mene palvelut välilehteen, valitse Lisää Palvelu ja syötä palvelun halutut" +
                " tiedot kyselyyn ja paina lisää palvelu. Kysely lisää palvelun kyseiselle mökille" +
                " Jos haluat poistaa palvelun, valitse listasta poistettava palvelu ja valitse Poista palvelu." +
                " HUOM! Et voi poistaa palvelua joka on aktiivisena jossain varauksessa";
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje8_Click(object sender, EventArgs e)
        {
            string text = "Valitse Laskutus, valitse lataa laskut, valitse haluttu lasku näkymästä, voit lisätä halutessasi alvin" +
                " Valitse haluatko sähköposti vai paperilaskun" +
                " Viimeiseksi valitse haluatko lähettää sähköpostilaskun vai tulostaa paperilaskun";
                
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }

        private void btnOhje9_Click(object sender, EventArgs e)
        {
            string text = "Valitse Raportit välilehti, valitse alueet listasta halutut alueet joista raportteja haetaan." +
                " Valitse alku- ja loppupäivämäärä joiden väliltä raportteja haetaan." +
                " Näkymään avautuu raportti tehdyistä varauksista valitulle aikavälille." +
                "Valitsemalla Avaa Kokonaisraportti saat näkyville raportin kaikista asiakas, mökki ja palvelutiedoista";
               
            mmltbOhje.Text = text;
            mainFormToiminnallisuus.ChangeOhjeetTitle(sender as Button, this);
        }
    }
}
