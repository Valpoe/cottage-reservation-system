using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageNewbiesApp
{
    
    internal class mainFormToiminnallisuus
    {
        // Luodaan dictionary ja lisätään sinne kaikki formit
        
        public Dictionary<string, System.Windows.Forms.Form> screens = new Dictionary<string, System.Windows.Forms.Form>()
        {
            { "Etusivu", new frmEtusivu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Toiminta-alueet", new frmAlueet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Palvelut", new frmPalvelut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Varaukset", new frmVaraukset() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Asiakkaat", new frmAsiakkaat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Laskutus", new frmLaskutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } },
            { "Raportit", new frmRaportit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false } }
        };
        
        // Formien avaus paneeliin
        public void loadScreen(string name, Form1 form1, Button button)
        {
            System.Windows.Forms.Form form = screens[name];
            form1.panelFormLoader.Controls.Clear();
            form1.panelFormLoader.Controls.Add(screens[name]);
            screens[name].Show();
        }

        // Navigointipalkin siirto ja otsikon vaihto
        public void ChangeNavbarAndTitle(Button button, Form1 form1)
        {
            form1.panelNavigation.Height = button.Height;
            form1.panelNavigation.Top = button.Top;
            form1.labelOtsikko.Text = button.Text;         
        }

        // Formin liikuttelu hiirellä

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Formin reunojen pyöristys
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
    }




}
