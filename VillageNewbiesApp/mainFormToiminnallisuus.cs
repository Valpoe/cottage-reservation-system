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
            { "Etusivu", new frmEtusivu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Toiminta-alueet", new frmAlueet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Palvelut", new frmPalvelut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Varaukset", new frmVaraukset() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Asiakkaat", new frmAsiakkaat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Laskutus", new frmLaskutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Raportit", new frmRaportit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } }
        };

        // Formien avaus paneeliin
        public void loadScreen(string name, Form1 form1)
        {
                System.Windows.Forms.Form form = screens[name];
                form1.panelFormLoader.Controls.Clear();
                form1.panelFormLoader.Controls.Add(screens[name]);
                screens[name].Show();
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
