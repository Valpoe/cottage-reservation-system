﻿using System;
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

                }
            }



                Console.WriteLine("connection closed");

            foreach(string a in SQLResult)
            {
                //MessageBox.Show(a);
            }

            return SQLResult;
        }

        public void SQLinsertCustomer(Asiakas asiakas)
        {
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

            public void SQLinsertCustormer()
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
        
    }


}
