using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySqlConnector;
using Microsoft.Reporting.WinForms;

namespace VillageNewbiesApp
{
    public partial class frmLaskutus : Form
    {
        SQLConnection mySQL = new SQLConnection();

        NetworkCredential login;
        SmtpClient client;
        MailMessage message;
        string laskuID;
        public frmLaskutus()
        {
            InitializeComponent();         
        }
        private void frmLaskutus_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLahetaLasku_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(tbKayttajaTunnus.Text, tbSalasana.Text);
            client = new SmtpClient(tbSmtp.Text);
            client.Port = int.Parse(tbPortti.Text);
            client.EnableSsl = mcSSL.Checked;
            client.Credentials = login;

            message = new MailMessage { From = new MailAddress
                (tbKayttajaTunnus.Text + tbSmtp.Text.Replace("smtp.", "@"), "admin", Encoding.UTF8) };
            
            message.To.Add(new MailAddress(tbVastaanottaja.Text));

            if (!string.IsNullOrEmpty(tbCC.Text))
            {
                message.To.Add(new MailAddress(tbCC.Text));
            }

            message.Subject = tbAihe.Text;
            message.Body = mmltbViesti.Text;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.Normal;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            client.SendAsync(message, null);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Laskun lähetys peruutettiin.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Laskun lähetyksessä tapahtui virhe: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Lasku lähetetty.");
            }           
        }

        private void btnLataaLaskut_Click(object sender, EventArgs e)
        {
            mlvLaskut.Items.Clear();
            List<string> asiakkaat = mySQL.selectLasku();

            string[] lista = new string[3];
            ListViewItem item;

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                lista[0] = asiakkaat[i];
                i++;
                lista[1] = asiakkaat[i];
                i++;
                lista[2] = asiakkaat[i];

                item = new ListViewItem(lista);

                mlvLaskut.Items.Add(item);
            }
        }

        private void btnSahkopostiLasku_Click(object sender, EventArgs e)
        {

            if (mlvLaskut.SelectedItems.Count == 0)
            {
                MessageBox.Show("Valitse lasku.");
                return;
            }
            
            List<string> asiakkaat = mySQL.laskutusTiedot(mlvLaskut.SelectedItems[0].SubItems[0].Text);

            string[] lista = new string[10];

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                lista[i] = asiakkaat[i];
            }
            string alv;
            if (mcbALV.Checked)
            {
                alv = lista[8];
            }
            else
                alv = "0";
            
            tbVastaanottaja.Text = lista[3];
            tbAihe.Text = "Village Newbies lasku, tunniste: " + lista[0];
            mmltbViesti.Text = "Village Newbies lasku\r\n" + "\r\n" +
                "Mökin nimi: " + lista[1] + "\r\n" + "\r\n" + "Asiakkaan tiedot\r\n" + "\r\n" + "Nimi: " + lista[2] + "\r\n" +
                "Osoite: " + lista[4] + "\r\n" + "Postinumero: " + lista[5] + "\r\n" + "Postitoimipaikka: " + lista[6] + "\r\n" + "\r\n" +
                "Laskun tiedot\r\n" + "\r\n" + "Laskun summa: " + lista[7] + "\r\n" + "ALV: " + alv + "\r\n" + "Yhteensä: " + lista[9] + "\r\n" + "\r\n" +
                "Tilinumero: FI91 2892 1857 1855 85\r\n" + "Viite: 8 20294 38383 19187";

            tbKayttajaTunnus.Text = "admin";
            tbSalasana.Text = "admin";
            mcSSL.Checked = true;
        }
        private void btnPaperilasku_Click(object sender, EventArgs e)
        {
            laskuID = mlvLaskut.SelectedItems[0].SubItems[0].Text;

            using (MySqlConnection connection = SQLConnection.GetConnection())
            {
                Console.WriteLine("paperilasku avattu");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT l.lasku_id, m.mokkinimi, a.etunimi, a.sukunimi, a.email, a.lahiosoite, a.postinro, " +
                    "p.toimipaikka, l.summa, l.alv, l.summa + l.alv AS Yhteensa " +
                    "FROM lasku l INNER JOIN varaus v ON v.varaus_id = l.varaus_id " +
                    "INNER JOIN mokki m ON m.mokki_id = v.mokki_mokki_id " +
                    "INNER JOIN asiakas a ON v.asiakas_id = a.asiakas_id " +
                    "INNER JOIN posti p ON a.postinro = p.postinro " +
                    "WHERE l.lasku_id = '" + laskuID + "'", connection);

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "DataTable1");

                ReportDataSource datasource = new ReportDataSource("Dataset_Report", ds.Tables[8]);

                frmPaperilasku paperilasku = new frmPaperilasku();
                paperilasku.reportViewer1.LocalReport.DataSources.Clear();
                paperilasku.reportViewer1.LocalReport.DataSources.Add(datasource);
                paperilasku.reportViewer1.LocalReport.Refresh();
                paperilasku.Show();
            }
        }
    }
}
