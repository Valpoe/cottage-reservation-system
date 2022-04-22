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
        // Luodaan teema manageri ja tyyli kaikille komponenteille
        
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        
        public mainFormToiminnallisuus()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink700, MaterialSkin.TextShade.WHITE);
        }

        // Luodaan dictionary ja lisätään sinne kaikki formit

        public Dictionary<string, System.Windows.Forms.Form> screens = new Dictionary<string, System.Windows.Forms.Form>()
        {
            { "Etusivu", new frmEtusivu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Toiminta-alueet", new frmAlueet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Mökit ja Palvelut", new frmPalvelut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Varaukset", new frmVaraukset() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Asiakkaat", new frmAsiakkaat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Laskutus", new frmLaskutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } },
            { "Raportit", new frmRaportit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } }
        };
        
        // Formien avaus paneeliin ja button värin vaihto
        public void loadScreen(string name, Form1 form1, Button button)
        {
            System.Windows.Forms.Form form = screens[name];
            form1.panelFormLoader.Controls.Clear();
            form1.panelFormLoader.Controls.Add(screens[name]);
            screens[name].Show();
            button.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);

            foreach (Button bt in button.Parent.Controls.OfType<Button>())
            {
                if (bt.Name != button.Name)
                {
                    bt.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
                }
            }
        }

        // Navigointipalkin siirto ja otsikon vaihto
        public void ChangeNavbarAndTitle(Button button, Form1 form1)
        {
            form1.panelNavigation.Height = button.Height;
            form1.panelNavigation.Top = button.Top;
            form1.lblOtsikko.Text = button.Text;         
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
