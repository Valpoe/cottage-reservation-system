using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace VillageNewbiesApp
{
    class SQLConnection
    {

        public static MySqlConnection GetConnection()
        {
            string cString = "datasource=localhost;port=3307;username=root;password=Ruutti;database=vn";
            MySqlConnection connectionString = new MySqlConnection(cString);
            try
            {
                connectionString.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Yhdistäminen epäonnistui, " + ex.Message);
            }

            return connectionString;
        }

        public void SQLselectAllbyName()
        {
            frmAsiakkaat asiakkaat = new frmAsiakkaat();
            List<Asiakas> asiakaslista = new List<Asiakas>();
            //int id = 1;
            //string etunimi = "pekka";
            //string sukunimi;
            //string email;
            //string puhelinnumero;

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                asiakkaat.mlvAsiakkaat.View = View.Details;
                MySqlCommand cmd;
                DataTable dt;
                MySqlDataAdapter da;
                DataSet ds;
       
                asiakkaat.mlvAsiakkaat.Columns.Add("ID", 50);
                asiakkaat.mlvAsiakkaat.Columns.Add("Etunimi", 100);
                asiakkaat.mlvAsiakkaat.Columns.Add("Sukunimi", 100);
                asiakkaat.mlvAsiakkaat.Columns.Add("Email", 100);
                asiakkaat.mlvAsiakkaat.Columns.Add("Puhelinnumero", 100);
                asiakkaat.mlvAsiakkaat.View = View.Details;
                cmd = new MySqlCommand("SELECT asiakas_id, etunimi, sukunimi, email, puhelinnro FROM asiakas", connection);
                da = new MySqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds, "testitaulu");

                dt = ds.Tables["testitaulu"];

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    asiakkaat.mlvAsiakkaat.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    asiakkaat.mlvAsiakkaat.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    asiakkaat.mlvAsiakkaat.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    asiakkaat.mlvAsiakkaat.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    asiakkaat.mlvAsiakkaat.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                }

                //MySqlDataReader Reader = Command.ExecuteReader();

                //while (Reader.Read())
                //{
                //    id = Reader.GetInt32("asiakas_id");
                //    etunimi = Reader.GetString("etunimi");
                //    sukunimi = Reader.GetString("sukunimi");
                //    email = Reader.GetString("email");
                //    puhelinnumero = Reader.GetString("puhelinnro");


                //    asiakaslista.Add(new Asiakas(id.ToString(), etunimi, sukunimi, email, puhelinnumero));
                //    asiakkaat.mlvAsiakkaat.Items.Clear();
                //    foreach(var item in asiakaslista)
                //    {
                //        ListViewItem rivi = new ListViewItem(id.ToString());
                //        rivi.SubItems.Add(etunimi);
                //        rivi.SubItems.Add(sukunimi);
                //        rivi.SubItems.Add(email);
                //        rivi.SubItems.Add(puhelinnumero);
                //        asiakkaat.mlvAsiakkaat.Items.Add(rivi);
                //    }

                //}
                }
            }

        // Lisätään asiakas ja postinumero + postitoimipaikka tietokantaan
        public void SQLinsertCustomer(Asiakas asiakas)
        {
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                MySqlCommand Command = new MySqlCommand("SELECT postinro FROM posti WHERE postinro LIKE " + asiakas.GetPostinumero(), connection);

                MySqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows != true)
                {
                    Reader.Close();
                    Command = new MySqlCommand("INSERT INTO posti(postinro, toimipaikka) VALUES (@postinro, @toimipaikka)", connection);

                    Command.Parameters.AddWithValue("@postinro", asiakas.GetPostinumero());
                    Command.Parameters.AddWithValue("@toimipaikka", asiakas.GetPostitoimipaikka());

                    Command.ExecuteNonQuery();
                }

                Reader.Close();
                
                Command = new MySqlCommand("INSERT INTO asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES(@postinro, @etunimi, @sukunimi, @lahiosoite, @email, @puhelinnro)", connection);

                Command.Parameters.AddWithValue("@postinro", asiakas.GetPostinumero());
                Command.Parameters.AddWithValue("@etunimi", asiakas.GetEtunimi());
                Command.Parameters.AddWithValue("@sukunimi", asiakas.GetSukunimi());
                Command.Parameters.AddWithValue("@lahiosoite", asiakas.GetOsoite());
                Command.Parameters.AddWithValue("@email", asiakas.GetEmail());
                Command.Parameters.AddWithValue("@puhelinnro", asiakas.GetPuhnro());

                Command.ExecuteNonQuery();
            }
        }
        public List<string> SQLselectAllAlueet()
        {

            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                MySqlCommand Command = new MySqlCommand("SELECT * FROM alue", connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    result.Append(Reader.GetString(Reader.GetOrdinal("nimi")));

                    SQLResult.Add(result.ToString());
                    result.Clear();
                }
            }

            return SQLResult;
        }

        public List<string> SQLselectMokit(string select)
        {

            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();

            using (MySqlConnection connection = GetConnection())
            {
                //MessageBox.Show("SELECT * FROM mokki WHERE alue_id IN (SELECT alue_id FROM alue WHERE nimi LIKE '" + selection + "'");

                MySqlCommand Command = new MySqlCommand("SELECT * FROM mokki WHERE alue_id IN (SELECT alue_id FROM alue WHERE nimi LIKE '" + select + "')", connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                //tyhjennetään lista kun haku tehdään, lista täyttyy vain jos siellä on mökkejä
                List<Mokki> MokkiHolder = new List<Mokki>();

                while (Reader.Read())
                {

                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")));
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("hinta")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("henkilomaara")).ToString());

                    //lisätään mökit static listaan - testi
                    MokkiHolder.Add(new Mokki(Reader.GetInt32(Reader.GetOrdinal("mokki_id")), Reader.GetString(Reader.GetOrdinal("mokkinimi")),
                        Reader.GetString(Reader.GetOrdinal("katuosoite")), Reader.GetDouble(Reader.GetOrdinal("hinta")), Reader.GetString(Reader.GetOrdinal("kuvaus")),
                        Reader.GetInt32(Reader.GetOrdinal("henkilomaara")), Reader.GetString(Reader.GetOrdinal("varustelu"))));
                }

                frmAlueet.AlueenMokit = MokkiHolder;
            }

            return SQLResult;
        }

        public void setAlueID(string select)
        {
            using(MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT alue_id FROM alue WHERE nimi LIKE '" + select + "'", connection);
                Console.Write("Haettu alueID alueelle" + select);

                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    frmAlueet.selectedID = Reader.GetInt32(Reader.GetOrdinal("alue_id")).ToString();
                }
            }
        }

        public List<String> aluePalvelut(int alueID)
        {
            List<string> palvelut = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT * FROM palvelu WHERE alue_id LIKE '" + alueID + "'", connection);

                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    palvelut.Add(Reader.GetString(Reader.GetOrdinal("kuvaus")));
                }
                return palvelut;
            }
        }

    }
}

