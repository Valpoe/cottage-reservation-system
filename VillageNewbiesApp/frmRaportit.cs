using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VillageNewbiesApp
{  
    public partial class frmRaportit : Form
    {
        SQLConnection mySQL = new SQLConnection();
        public static string selectedAlue;
        public static string selectedAlueet;
        public static string firstAlue;
        public frmRaportit()
        {
            InitializeComponent();
            
            List<string> Alueet = mySQL.SQLselectAllAlueet();


            foreach (string a in Alueet)
            {
                mcbAlueet.Items.Add(a);
            }

            foreach (string a in Alueet)
            {
                this.mclbAlueet.Items.Add(a);
            }
            
        }

        private void frmRaportit_Load(object sender, EventArgs e)
        {
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            // if mclbAlueet.CheckedItems.Count == 0 // !=
            selectedAlue = mcbAlueet.Items[mcbAlueet.SelectedIndex].ToString();

            for (int i = 0; i < mclbAlueet.Items.Count; i++)
            {
                if (i == 0)
                {
                    selectedAlueet = "'" + mclbAlueet.Items[0].Text.ToString() + "'";
                }
                else if (i > 0)
                {
                    selectedAlueet = "'" + mclbAlueet.Items[0].Text.ToString() + "'" + ", '" + mclbAlueet.Items[i].Text.ToString() + "'";
                }
                Console.WriteLine(selectedAlueet);
            }

            Console.WriteLine(selectedAlueet);

            mlvMokkiData.Items.Clear();
            mlvPalveluData.Items.Clear();
            string datestart = dtpAlkupvm.Value.ToString("yyyy-MM-dd");
            string dateend = dtpLoppupvm.Value.ToString("yyyy-MM-dd");
            DateTime start = Convert.ToDateTime(datestart);
            DateTime end = Convert.ToDateTime(dateend);
            List<string> mokkiData = mySQL.mokkiData(start, end, selectedAlue);

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

            List<string> palveluData = mySQL.palveluData(start, end, selectedAlue);

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

        private void btnAvaaRaportti_Click(object sender, EventArgs e)
        {
            frmKokonaisRaportti kokonaisRaportti = new frmKokonaisRaportti();
            kokonaisRaportti.Show();
        }
    }
}
