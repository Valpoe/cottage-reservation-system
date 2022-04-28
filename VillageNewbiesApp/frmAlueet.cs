using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace VillageNewbiesApp
{
    public partial class frmAlueet : Form
    {
        public static string selectedID;
        public static string selectedAlue;
        public static string selectedMokki;

        public static List<Mokki> AlueenMokit;

        SQLConnection mySQL = new SQLConnection();
        public frmAlueet()
        {
            InitializeComponent();

            List<string> Alueet = mySQL.SQLselectAllAlueet();


            foreach(string a in Alueet)
            {
                mcbToimintaAlue.Items.Add(a);
            }
        }

        private void frmAlueet_Load(object sender, EventArgs e)
        {

        }

        private void mcbToimintaAlue_SelectedIndexChanged(object sender, EventArgs e)
        {

            mlvMokit.Items.Clear();

            List<string> mokit = mySQL.SQLselectMokit(mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString());

            selectedAlue = mcbToimintaAlue.Items[mcbToimintaAlue.SelectedIndex].ToString();

            ListViewItem itm;
            string[] arr = new string[3];

            for(int i = 0; i < mokit.Count; i++)
            {
                arr[0] = mokit[i];
                i++;
                arr[1] = mokit[i];
                i++;
                arr[2] = mokit[i];

                itm = new ListViewItem(arr);

                mlvMokit.Items.Add(itm);
            }
        }

        private void mlvMokit_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void mlvMokit_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                selectedMokki = mlvMokit.SelectedItems[0].Text;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            //MessageBox.Show(AlueenMokit.ElementAt(mlvMokit.SelectedItems[0].Index).GetNimi());
            //ei vaihdu koska ei haeta uutta mökkiä SQL:ssä
            //MessageBox.Show(selectedMokkiClass.GetNimi());
        }
    }
}
