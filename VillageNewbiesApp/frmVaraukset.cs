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
            // Tekee varauksen kun kalenterista mustaa haluttujen päivien välit
           /* SQLConnection mySQL = new SQLConnection();
            string datestart = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string dateend = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            DateTime start = DateTime.Parse(datestart);
            DateTime end = DateTime.Parse(dateend);
            DateTime current = DateTime.Parse(thisday);
            mySQL.SQLMakeReservation(start, end, current);*/
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
           label1.Text = frmAlueet.selectedMokki + " VARAUKSET";
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
            string datestart = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string dateend = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            int asiakas_id = frmAsiakkaat.selectedAsiakas;
            string mokki = frmAlueet.selectedMokki;
            DateTime start = DateTime.Parse(datestart);
            DateTime end = DateTime.Parse(dateend);
            DateTime current = DateTime.Parse(thisday);
            //MessageBox.Show(selectedAsiakas.ToString());
            MessageBox.Show(mokki);
            MessageBox.Show(asiakas_id.ToString());
            mySQL.SQLMakeReservation(start, end, current, asiakas_id, mokki);
            UpdateReservations();
        }

        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            string varaus_id = mlvVaraukset.SelectedItems[0].Text;
            MessageBox.Show(varaus_id);
            mySQL.SQLRemoveReservation(varaus_id);
            UpdateReservations();
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
            string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            DateTime current = DateTime.Parse(thisday);
            string varaus_id = mlvVaraukset.SelectedItems[0].Text;
            MessageBox.Show(varaus_id);
            mySQL.SQLAddConfirmation(varaus_id, current);
            UpdateReservations();
        }
    }
}
