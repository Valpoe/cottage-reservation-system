using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VillageNewbiesApp
{
    public partial class frmRaportit : Form
    {
        SQLConnection mySQL = new SQLConnection();

        frmKokonaisRaportti kokonaisRaportti = new frmKokonaisRaportti();

        public static string selectedAlueet;
        public static string firstAlue;
        public frmRaportit()
        {
            InitializeComponent();

            // Alueiden tuonti listboxiin
            
            List<string> Alueet = mySQL.SQLselectAllAlueet();

            string[] arr = new string[Alueet.Count];

            for (int i = 0; i < Alueet.Count; i++)
            {
                lbAlueet.Items.Add(Alueet[i]);
            }
        }

        // Mökkien ja palveluiden tuonti listviewiin alueen/alueiden valinnan ja aikajakson mukaan
        private void etsiMokitJaPalvelut()
        {
            selectedAlueet = "";
            for (int i = 0; i < lbAlueet.SelectedItems.Count; i++)
            {
                if (lbAlueet.SelectedItems.Count == 1)
                {
                    firstAlue = "'" + lbAlueet.SelectedItems[i].ToString() + "'";
                }
                else if (lbAlueet.SelectedItems.Count > 1)
                {
                    firstAlue = "";
                    selectedAlueet += ", '" + lbAlueet.SelectedItems[i].ToString() + "'";
                }
            }
            selectedAlueet = firstAlue + selectedAlueet.TrimStart(',', ' ');

            mlvMokkiData.Items.Clear();
            mlvPalveluData.Items.Clear();
            string datestart = dtpAlkupvm.Value.ToString("yyyy-MM-dd");
            string dateend = dtpLoppupvm.Value.ToString("yyyy-MM-dd");
            DateTime start = Convert.ToDateTime(datestart);
            DateTime end = Convert.ToDateTime(dateend);

            List<string> mokkiData = mySQL.mokkiData(start, end, selectedAlueet);

            string[] mokkiLista = new string[4];
            ListViewItem item;

            for (int i = 0; i < mokkiData.Count; i++)
            {
                mokkiLista[0] = mokkiData[i];
                i++;
                mokkiLista[1] = mokkiData[i];
                i++;
                mokkiLista[2] = mokkiData[i];
                i++;
                mokkiLista[3] = mokkiData[i];

                item = new ListViewItem(mokkiLista);

                mlvMokkiData.Items.Add(item);
            }

            List<string> palveluData = mySQL.palveluData(start, end, selectedAlueet);

            string[] palveluLista = new string[4];
            ListViewItem item2;

            for (int i = 0; i < palveluData.Count; i++)
            {
                palveluLista[0] = palveluData[i];
                i++;
                palveluLista[1] = palveluData[i];
                i++;
                palveluLista[2] = palveluData[i];
                i++;
                palveluLista[3] = palveluData[i];

                item2 = new ListViewItem(palveluLista);

                mlvPalveluData.Items.Add(item2);
            }
        }
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            if (lbAlueet.SelectedItems.Count == 0)
            {
                MessageBox.Show("Valitse vähintään yksi alue");
            }
            else
            {
                etsiMokitJaPalvelut();
            }
        }

        // Kokonaisraporttiformin aukaisu
        private void btnAvaaRaportti_Click(object sender, EventArgs e)
        {            
            kokonaisRaportti.Show();
        }
    }
}
