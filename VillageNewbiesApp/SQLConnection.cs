using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

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

                    //SQLResult.Add(Reader.GetString(Reader.GetOrdinal("sukunimi")));
                    //SQLResult.Add(Reader.GetValues().ToString());
                    //SQLResult.Add(Reader[0].ToString());
                }
            }


            Console.WriteLine("connection closed");

            foreach(string a in SQLResult)
            {
                //MessageBox.Show(a);
            }

            return SQLResult;
        }

            public void SQLinsertCustormer()
            {
                using (MySqlConnection connection = GetConnection())
                {
                    Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                    MySqlCommand Command = new MySqlCommand("INSERT asiakas (etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES" +
                        "('Mauri', 'Heinola', 'Kanttorintie 15', 'Mauri.Heinola@heinähattu.fi', 0400011129 )", connection);

                     Command.ExecuteNonQuery();
                }
        }
    }


}
