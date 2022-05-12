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
    public partial class frmVaraukset : Form
    {
        SQLConnection mySQL = new SQLConnection();
        private static int selectedAsiakas = frmAsiakkaat.selectedAsiakas;
        private static string selectedMokki = frmAlueet.selectedMokki;

        public frmVaraukset()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void frmVaraukset_Activated(object sender, EventArgs e)
        {
           
        }

        private void frmVaraukset_VisibleChanged(object sender, EventArgs e)
        {
            UpdateReservations();
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            // Tekee varauksen kun kalenterista mustaa haluttujen päivien välit
            SQLConnection mySQL = new SQLConnection();
            bool isFree = CheckIfReserved();
            if (isFree == false)
            {
                MessageBox.Show("Varaus ei onnistu koska valituille päiville on jo varaus");
                
            }
            else
            {
                try
                {
                    string datestart = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                    string dateend = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
                    string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
                    int asiakas_id = frmAsiakkaat.selectedAsiakas;
                    string mokki = frmAlueet.selectedMokki;
                    DateTime start = DateTime.Parse(datestart);
                    DateTime end = DateTime.Parse(dateend);
                    DateTime current = DateTime.Parse(thisday);               
                    mySQL.SQLMakeReservation(start, end, current, asiakas_id, mokki);
                    UpdateReservations();
                    MessageBox.Show("Varaus onnistui");
                }
                catch (Exception)
                {
                    MessageBox.Show("Valitse asiakas, mökki ja varauspäivät ennen varauksen tekoa");
                }
            }
            
        }

        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            try
            {
                string varaus_id = mlvVaraukset.SelectedItems[0].Text;
                mySQL.SQLRemoveReservation(varaus_id);
                UpdateReservations();
                MessageBox.Show("Varaus poistettu");
            }
            catch (Exception)
            {
                MessageBox.Show("Poisto epäonnistui, valitse ensin poistettava varaus.");
            }
        }
        private void UpdateReservations()
        {
            monthCalendar1.RemoveAllBoldedDates();
            string mokkinimi = frmAlueet.selectedMokki;
            mlvVaraukset.Items.Clear();
            List<string> Reservation = mySQL.SQLGetReservation(mokkinimi);
            string[] tiedot = new string[6];
            ListViewItem item;

            for (int i = 0; i < Reservation.Count; i++)
            {
                tiedot[0] = Reservation[i];
                i++;
                tiedot[1] = Reservation[i];
                i++;
                tiedot[2] = Reservation[i];
                i++;
                tiedot[3] = Reservation[i];
                i++;
                tiedot[4] = Reservation[i];
                i++;
                tiedot[5] = Reservation[i];

                item = new ListViewItem(tiedot);
                mlvVaraukset.Items.Add(item);
            }
            // Tsekkaa varaukset
            List<DateTime> Reserved = mySQL.SQLCheckReservation(mokkinimi);
            Reserved.AddRange(monthCalendar1.BoldedDates);
            monthCalendar1.BoldedDates = Reserved.ToArray();  
        }

        private void btnVahvistaVaraus_Click(object sender, EventArgs e)
        {
            try
            {
                string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
                DateTime current = DateTime.Parse(thisday);
                string varaus_id = mlvVaraukset.SelectedItems[0].Text;
                mySQL.SQLAddConfirmation(varaus_id, current);
                UpdateReservations();
                MessageBox.Show("Varaus vahvistettu");
            }
            catch(Exception)
            {
                 MessageBox.Show("Vahvistus epäonnistui, valitse ensin vahvistettava varaus");
            }
        }
        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        public bool CheckIfReserved()
        {
            string mokkinimi = frmAlueet.selectedMokki;
            string datestart1 = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string dateend1 = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            DateTime start1 = DateTime.Parse(datestart1);
            DateTime end1 = DateTime.Parse(dateend1);
            List<DateTime> Reserved = mySQL.SQLCheckReservation(mokkinimi);
            Reserved.AddRange(monthCalendar1.BoldedDates);
            Reserved.ToArray();

            List<DateTime> Selected = new List<DateTime>();
            for (DateTime start = start1; start <= end1; start = start.AddDays(1))
            {
                Selected.Add(DateTime.Parse(start.ToLongDateString()));
            }
            Selected.ToArray();
            foreach (DateTime d in Reserved)
            {   
                if (Selected.Contains(d))
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
