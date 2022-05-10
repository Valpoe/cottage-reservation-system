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

        // Tuodaan asiakkaat tietokannasta listviewiin
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

        // Poistetaan valittu asiakas tietokannata
        public void SQLdeleteCustomer(string asiakas_id)
        {
            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                MySqlCommand Command = new MySqlCommand("DELETE FROM asiakas WHERE asiakas_id = @asiakas_id", connection);

                Command.Parameters.AddWithValue("@asiakas_id", asiakas_id);

                Command.ExecuteNonQuery();
            }
        }


        // Poistetaan valittu mökki
        public bool SQLdeleteMokki(string mokki_id)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                    MySqlCommand Command = new MySqlCommand("DELETE FROM mokki WHERE mokki_id = @mokki_id", connection);
                    Command.Parameters.AddWithValue("@mokki_id", mokki_id);
                    Command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mökkiä ei voi poistaa jos sillä on varauksia!");
                    return false;
                }
            }
        }


        // Kokonaismäärien haku tietokannasta
        public List<string> frontPageTotals()
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                string sql = "SELECT(SELECT COUNT(mokki_id) FROM mokki) AS mokki_id," +
                    "(SELECT COUNT(palvelu_id)FROM palvelu) AS palvelu_id,(SELECT COUNT(varaus_id) FROM varaus) AS varaus_id," +
                    "(SELECT COUNT(asiakas_id) FROM asiakas) AS asiakas_id";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("mokki_id")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("palvelu_id")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("varaus_id")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("asiakas_id")).ToString());
                }
            }
            return SQLResult;
        }

        // Majoittumisten raportointi aikajaksolla valituilla toiminta-alueilla
        public List<string> mokkiData(DateTime alkupvm, DateTime loppupvm, string alue)
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                string alku = alkupvm.ToString("yyyy-MM-dd");
                string loppu = loppupvm.ToString("yyyy-MM-dd");

                string sql = "SELECT m.mokkinimi, m.katuosoite, m.postinro, v.vahvistus_pvm" +
                    " FROM mokki m " +
                    " INNER JOIN varaus v ON m.mokki_id = v.mokki_mokki_id" +
                    " INNER JOIN alue a ON a.alue_id = m.alue_id " +
                    "WHERE a.nimi IN(" + alue + ") " +
                    "AND v.vahvistus_pvm " +
                    "BETWEEN '" + alku + "' AND '" + loppu + "'";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("katuosoite")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("postinro")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("vahvistus_pvm")).ToString());
                }
            }
            return SQLResult;
        }

        // Varausten raportointi aikajaksolla valituilla toiminta-alueilla
        public List<string> palveluData(DateTime alkupvm, DateTime loppupvm, string alue)
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                string alku = alkupvm.ToString("yyyy-MM-dd");
                string loppu = loppupvm.ToString("yyyy-MM-dd");

                string sql = "SELECT p.nimi, p.tyyppi, p.kuvaus, v.vahvistus_pvm" +
                    " FROM palvelu p " +
                    " INNER JOIN varauksen_palvelut vp ON vp.palvelu_id = p.palvelu_id" +
                    " INNER JOIN varaus v ON v.varaus_id = vp.varaus_id " +
                    " INNER JOIN alue a ON p.alue_id = a.alue_id " +
                    "WHERE a.nimi IN(" + alue + ") " +
                    "AND v.vahvistus_pvm " +
                    "BETWEEN '" + alku + "' AND '" + loppu + "'";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("nimi")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("tyyppi")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("kuvaus")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("vahvistus_pvm")).ToString());
                }
            }
            return SQLResult;
        }

        // Tuodaan kaikki laskut listviewiin
        public List<string> selectLasku()
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");
                MySqlCommand Command = new MySqlCommand("SELECT l.lasku_id, l.varaus_id, " +
                    "a.etunimi, a.sukunimi " +
                    "FROM lasku l " +
                    "INNER JOIN varaus v ON v.varaus_id = l.varaus_id " +
                    "INNER JOIN asiakas a ON v.asiakas_id = a.asiakas_id", connection);

                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("lasku_id")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("varaus_id")).ToString());
                    string kokonimi = Reader.GetString(Reader.GetOrdinal("etunimi")).ToString() + " " +
                        Reader.GetString(Reader.GetOrdinal("sukunimi")).ToString();
                    SQLResult.Add(kokonimi);
                }
            }
            return SQLResult;
        }

        // Tuodaan laskun kaikki tiedot listview valinnan perusteella
        public List<string> laskutusTiedot(string laskuID)
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                Console.WriteLine("Success, nyt tietokanta on avattu turvallisesti using statementilla!");

                string cmd = "SELECT l.lasku_id, m.mokkinimi, a.etunimi, a.sukunimi, a.email, a.lahiosoite, a.postinro, " +
                    "p.toimipaikka, l.summa, l.alv, l.summa + l.alv AS Yhteensa " +
                    "FROM lasku l INNER JOIN varaus v ON v.varaus_id = l.varaus_id " +
                    "INNER JOIN mokki m ON m.mokki_id = v.mokki_mokki_id " +
                    "INNER JOIN asiakas a ON v.asiakas_id = a.asiakas_id " +
                    "INNER JOIN posti p ON a.postinro = p.postinro " +
                    "WHERE l.lasku_id = '" + laskuID + "'";

                MySqlCommand Command = new MySqlCommand(cmd, connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("lasku_id")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")).ToString());
                    string kokonimi = Reader.GetString(Reader.GetOrdinal("etunimi")) + " " +
                        Reader.GetString(Reader.GetOrdinal("sukunimi"));
                    SQLResult.Add(kokonimi);
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("email")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("lahiosoite")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("postinro")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("toimipaikka")).ToString());
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("summa")).ToString());
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("alv")).ToString());
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("Yhteensa")).ToString());
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

                while (Reader.Read())
                {

                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")));
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("hinta")).ToString());
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("henkilomaara")).ToString());
                }

            }

            return SQLResult;
        }

        public List<Mokki> getAllMokki()
        {

            List<Mokki> SQLResult = new List<Mokki>();
            using (MySqlConnection connection = GetConnection())
            {
                //MessageBox.Show("SELECT * FROM mokki WHERE alue_id IN (SELECT alue_id FROM alue WHERE nimi LIKE '" + selection + "'");

                MySqlCommand Command = new MySqlCommand("SELECT * FROM mokki", connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Mokki item = new Mokki();
                    item.setNimi(Reader.GetString(Reader.GetOrdinal("mokkinimi")));
                    item.setID(Reader.GetInt32(Reader.GetOrdinal("mokki_id")));
                    SQLResult.Add(item);
                }
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

        public int getAlueID(string select)
        {
            using (MySqlConnection connection = GetConnection())
            {
                int alueID = 0;
                MySqlCommand Command = new MySqlCommand("SELECT alue_id FROM alue WHERE nimi LIKE '" + select + "'", connection);

                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    alueID = Reader.GetInt32(Reader.GetOrdinal("alue_id"));
                }

                return alueID;
            }
        }

        public int getMokkiID(string select)
        {
            int mokkiID = 0;

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT mokki_id FROM mokki WHERE mokkinimi LIKE '" + select + "'", connection);
                Console.Write("Haettu alueID alueelle" + select);

                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    mokkiID = Reader.GetInt32(Reader.GetOrdinal("mokki_id"));
                }

                return mokkiID;
            }
        }
        public void addMokki(Mokki mokki)
        {

            using (MySqlConnection connection = GetConnection())
            {

                try
                {
                    MySqlCommand Command = new MySqlCommand("select * FROM posti WHERE postinro LIKE " + mokki.GetPostinumero(), connection);
                    MySqlDataReader Reader = Command.ExecuteReader();

                    if (!Reader.HasRows)
                    {
                        MessageBox.Show("Postinumeroa ei löytynyt, lisätään!");
                        Reader.Close();
                        Command = new MySqlCommand("INSERT INTO posti(postinro) VALUES (" + mokki.GetPostinumero() + ")", connection);
                        Command.ExecuteNonQuery();
                    }

                    Reader.Close();

                    Command = new MySqlCommand("INSERT INTO mokki(alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu)" +
                    " VALUES ('" + mokki.getAlueID() + "', '" + mokki.GetPostinumero() + "', '" + mokki.GetNimi() + "', '" + mokki.GetKatuosoite() + "', " + mokki.GetHinta() +
                    ", '" + mokki.GetKuvaus() + "', " + mokki.GetHenkilomaara() + ", '" + mokki.GetVarustelu() + "')", connection);
                    Command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void SQLaddAlue(string alue)
        {

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand Command = new MySqlCommand("INSERT INTO alue(nimi)" +
                  " VALUES ('" + alue + "')", connection);
                Command.ExecuteNonQuery();

                MessageBox.Show("Alue lisätty!");
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
        public List<String> Palvelut(int alueID)
        {
            List<string> SQLResult = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT palvelu_id, nimi, hinta FROM palvelu WHERE alue_id LIKE '" + alueID + "'", connection);

                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("palvelu_id")).ToString());
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("nimi")));
                    SQLResult.Add(Reader.GetDouble(Reader.GetOrdinal("hinta")).ToString());
                }
                return SQLResult;
            }
        }

        public List<string> SQLGetReservation(string mokkinimi)
        {
            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT a.etunimi, a.sukunimi, m.mokkinimi, v.vahvistus_pvm, v.varattu_alkupvm, v.varattu_loppupvm, v.varaus_id" +
                    " FROM asiakas a JOIN varaus v" +
                    " ON a.asiakas_id = v.asiakas_id" +
                    " JOIN mokki m" +
                    " ON v.mokki_mokki_id = m.mokki_id" +
                    " WHERE m.mokkinimi LIKE '" + mokkinimi + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    SQLResult.Add(Reader.GetInt32(Reader.GetOrdinal("varaus_id")).ToString());
                    string nimi = Reader.GetString(Reader.GetOrdinal("etunimi")) + " " + Reader.GetString(Reader.GetOrdinal("sukunimi"));
                    SQLResult.Add(nimi);
                    SQLResult.Add(Reader.GetString(Reader.GetOrdinal("mokkinimi")));
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("varattu_alkupvm")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("varattu_loppupvm")).ToString());
                    SQLResult.Add(Reader.GetValue(Reader.GetOrdinal("vahvistus_pvm")).ToString());
                }
            }
            return SQLResult;
        }
        public void SQLMakeReservation(DateTime start, DateTime end, DateTime current, int asiakas_id, string mokki)
        {
            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();
            int mokkid;
            string datestart = start.ToString("yyyy-MM-dd");
            string dateend = end.ToString("yyyy-MM-dd");
            string thisday = current.ToString("yyyy-MM-dd");
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("SELECT  m.mokki_id FROM mokki m " +
                    " where m.mokkinimi LIKE '" + mokki + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int mokki_id = Reader.GetInt32(Reader.GetOrdinal("mokki_id"));
                    SQLResult.Add(mokki_id.ToString());
                }
                Reader.Close();
            }
            mokkid = Int32.Parse(SQLResult[0]);
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("INSERT INTO varaus(asiakas_id, mokki_mokki_id, varattu_alkupvm, varattu_loppupvm, varattu_pvm)"
                + "VALUES('" + asiakas_id + "', '" + mokkid + "','" + datestart + "', '" + dateend + "','" + thisday + "')", connection);
                Command.ExecuteNonQuery();
            }
        }
        public List<DateTime> SQLCheckReservation(string mokkinimi)
        {
            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();
            List<string> varaukset = new List<string>();

            using (MySqlConnection connection = GetConnection())
            {

                MySqlCommand Command = new MySqlCommand("SELECT v.varattu_alkupvm, v.varattu_loppupvm" +
                    " FROM varaus v JOIN mokki m" +
                    " ON v.mokki_mokki_id = m.mokki_id" +
                    " WHERE m.mokkinimi LIKE '" + mokkinimi + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                List<DateTime> Reserved2 = new List<DateTime>();
                while (Reader.Read())
                {
                    DateTime date = Reader.GetDateTime(Reader.GetOrdinal("varattu_alkupvm"));
                    DateTime date2 = Reader.GetDateTime(Reader.GetOrdinal("varattu_loppupvm"));
                    //Kuinka saada DateTime monthcalendarille luettavaan muotoon:
                    // string datestart = date.ToString("dd/MM/yyyy HH:mm:ss");
                    //string dateend = date2.ToString("dd/MM/yyyy HH:mm:ss");
                    for (DateTime start = date; start <= date2; start = start.AddDays(1))
                    {
                        Reserved2.Add(DateTime.Parse(start.ToLongDateString()));
                    }
                }
                return Reserved2;
            }
        }
        public void SQLRemoveReservation(string varaus_id)
        {
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("DELETE FROM varaus WHERE varaus_id = '" + varaus_id + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
            }
        }
        public void SQLAddConfirmation(string varaus_id, DateTime current)
        {
            string thisday = current.ToString("yyyy-MM-dd");
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("UPDATE varaus" +
                    " SET vahvistus_pvm = '" + thisday + "'" +
                    " WHERE varaus_id = '" + varaus_id + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
            }
        }

        public void AddPalvelu(string alue_id, string nimi, string type, string kuvaus, double hinta, double alvi)
        {
            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("INSERT INTO palvelu(alue_id, nimi, tyyppi, kuvaus, hinta, alv)" +
                    "VALUES('" + alue_id + "', '" + nimi + "', '" + type + "', '" + kuvaus + "', '" + hinta + "', '" + alvi + "')", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                Command.ExecuteNonQuery();
            }
        }
        public void RemovePalvelu(string palvelu_id)
        {
            List<string> SQLResult = new List<string>();
            StringBuilder result = new StringBuilder();
            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand Command = new MySqlCommand("DELETE FROM palvelu WHERE palvelu_id = '" + palvelu_id + "'", connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                Command.ExecuteNonQuery();
            }
        }

    }
}

