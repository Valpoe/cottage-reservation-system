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
        
        public frmVaraukset()
        {
            InitializeComponent();                  
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Tekee varauksen kun kalenterista mustaa haluttujen päivien välit
            SQLConnection mySQL = new SQLConnection();
            string datestart = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string dateend = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            string thisday = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            DateTime start = DateTime.Parse(datestart);
            DateTime end = DateTime.Parse(dateend);
            DateTime current = DateTime.Parse(thisday);
            mySQL.SQLMakeReservation(start, end, current);
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
            monthCalendar1.RemoveAllBoldedDates();
            string mokkinimi = frmAlueet.selectedMokki;
            mlvVaraukset.Items.Clear();
            //Näyttää varaajien tiedot
            List<string> Reservation = mySQL.SQLGetReservation(mokkinimi);
            string[] tiedot = new string[2];
            ListViewItem item;

            for (int i = 0; i < Reservation.Count; i++)
            {
                tiedot[0] = Reservation[i];
                i++;
                tiedot[1] = Reservation[i];

                item = new ListViewItem(tiedot);
                mlvVaraukset.Items.Add(item);
            }
           // Tsekkaa varaukset
            List<DateTime> Reserved = mySQL.SQLCheckReservation(mokkinimi);
            Reserved.AddRange(monthCalendar1.BoldedDates);
            monthCalendar1.BoldedDates = Reserved.ToArray();
        }
    }
}
