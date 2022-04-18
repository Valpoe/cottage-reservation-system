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

            using (MySqlConnection connection = GetConnection())
            {
                MessageBox.Show("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                MySqlCommand Command = new MySqlCommand("SELECT * FROM " + select, connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("etunimi")));
                }
            }

            Console.WriteLine("connection closed");

            foreach(string a in SQLResult)
            {
                MessageBox.Show(a);
            }
            return SQLResult;
        }
    }


}
