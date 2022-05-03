﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

        public List<string> SQLselectAllbyName()
        {
            List<string> SQLResult = new List<string>();
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                MySqlCommand cmd = new MySqlCommand("SELECT asiakas_id, etunimi, sukunimi, email, puhelinnro FROM asiakas", connection);

                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("asiakas_id")).ToString());
                    string kokonimi = Reader.GetString(Reader.GetOrdinal("etunimi")) + " " +
                        Reader.GetString(Reader.GetOrdinal("sukunimi"));
                    SQLResult.Add(kokonimi);
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("email")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("puhelinnro")).ToString());
                }
            }
            return SQLResult;
        }

        // Näytetään sen asiakkaan varaustiedot, joka on valittu listasta
        public List<string> SQLnaytaTiedot()
        {
            List<string> SQLResult = new List<string>();
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                MySqlCommand cmd = new MySqlCommand("SELECT a.asiakas_id, a.etunimi, a.sukunimi, m.mokkinimi," +
                    " v.vahvistus_pvm, v.varattu_alkupvm, v.varattu_loppupvm FROM asiakas a, varaus v," +
                    " mokki m WHERE a.asiakas_id = v.asiakas_id AND v.mokki_mokki_id = m.mokki_id", connection);

                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    string kokonimi = Reader.GetString(Reader.GetOrdinal("etunimi")) + " " +
                        Reader.GetString(Reader.GetOrdinal("sukunimi"));
                    SQLResult.Add(kokonimi);
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("vahvistus_pvm")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("varattu_alkupvm")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("varattu_loppupvm")).ToString());
                }
            }
            return SQLResult;
        }

        // Lisätään asiakas + postitiedot tietokantaan
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

        // Etsitään asiakkaita listasta kirjoittamalla textboxiin
        public List<string> search(String searchTerm)
        {
            List<string> SQLResult = new List<string>();
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                string sql = "SELECT asiakas_id, etunimi, sukunimi, email, puhelinnro FROM asiakas WHERE asiakas_id LIKE '%" + searchTerm + "%' OR etunimi LIKE '%" + searchTerm + "%' OR sukunimi LIKE '%" +
                searchTerm + "%' OR email LIKE '%" + searchTerm + "%' OR puhelinnro LIKE '%" + searchTerm + "%'";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("asiakas_id")).ToString());
                    string kokonimi = Reader.GetString(Reader.GetOrdinal("etunimi")) + " " +
                        Reader.GetString(Reader.GetOrdinal("sukunimi"));
                    SQLResult.Add(kokonimi);
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("email")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("puhelinnro")).ToString());
                }
            }
            return SQLResult;
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
            using (MySqlConnection connection = GetConnection())
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

