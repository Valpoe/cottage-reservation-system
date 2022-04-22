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

        public void SQLinsertCustomer(Asiakas asiakas)
        {
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                MySqlCommand command = new MySqlCommand("INSERT INTO posti(postinro, toimipaikka)" +
                    "VALUES(" + asiakas.GetPostinumero() + ",'" + asiakas.GetPostitoimipaikka() + "')", connection);

                MySqlCommand command2 = new MySqlCommand("INSERT INTO asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro)" +
                    "VALUES(" + asiakas.GetPostinumero() + ",'" + asiakas.GetEtunimi() + "','" + asiakas.GetSukunimi() + "','" + asiakas.GetOsoite() + "','" + asiakas.GetEmail() + "','" + asiakas.GetPuhnro() + "')", connection);

                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
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

        public List<string> SQLselectMokit(string selection)
        {

            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();

            using (MySqlConnection connection = GetConnection())
            {
                //MessageBox.Show("SELECT * FROM mokki WHERE alue_id IN (SELECT alue_id FROM alue WHERE nimi LIKE '" + selection + "'");

                MySqlCommand Command = new MySqlCommand("SELECT * FROM mokki WHERE alue_id IN (SELECT alue_id FROM alue WHERE nimi LIKE '" + selection + "')", connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                /*  SELECT* FROM mokki
                    WHERE alue_id IN
                    (SELECT alue_id FROM alue WHERE nimi LIKE 'Kuopio')
                */ 
                while (Reader.Read())
                {
                    result.Append(Reader.GetString(Reader.GetOrdinal("mokkinimi")));
                    result.Append(Reader.GetDouble(Reader.GetOrdinal("hinta")));
                    result.Append(Reader.GetInt32(Reader.GetOrdinal("henkilomaara")));

                    SQLResult.Add(result.ToString());
                    result.Clear();
                }
            }

            return SQLResult;
        }

    }
}

