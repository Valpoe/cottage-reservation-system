using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

        public List<string> SQLselectAllbyName(string select)
        {

            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                MySqlCommand Command = new MySqlCommand("SELECT * FROM " + select, connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    result.Append(Reader.GetInt32(Reader.GetOrdinal("asiakas_id")) + " ; ");
                    result.Append(Reader.GetString(Reader.GetOrdinal("etunimi")) + " ; ");
                    result.Append(Reader.GetString(Reader.GetOrdinal("sukunimi")) + " ; ");
                    result.Append(Reader.GetString(Reader.GetOrdinal("puhelinnro")));

                    SQLResult.Add(result.ToString());
                    result.Clear();

                }
            }

            Console.WriteLine("connection closed");

            foreach (string a in SQLResult)
            {
                //MessageBox.Show(a);
            }

            return SQLResult;
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
    }
}

