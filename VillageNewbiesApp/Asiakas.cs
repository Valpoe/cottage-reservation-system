using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbiesApp
{
    public class Asiakas
    {
        // Asetetaan muuttujat
        private string Id { get; set; }
        private string Etunimi { get; set; }
        private string Sukunimi { get; set; }
        private string Osoite { get; set; }
        private string Postinumero { get; set; }
        private string Postitoimipaikka { get; set; }
        private string Puhnro { get; set; }
        private string Email { get; set; }

        // Tehdään constructor joka saa parametreina kaikki asiakkaan tiedot
        public Asiakas(string etunimi, string sukunimi, string osoite, string postinumero, string postitoimipaikka, string email, string puhnro)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Osoite = osoite;
            Postinumero = postinumero;
            Postitoimipaikka = postitoimipaikka;
            Email = email;
            Puhnro = puhnro;
        }

        public Asiakas(string id, string etunimi, string sukunimi, string email, string puhelinnumero)
        {
            Id = id;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Email = email;
            Puhnro = puhelinnumero;
        }

        // Tehdään getterit jotka palauttavat asiakkaan tiedot
        public string GetID()
        {
            return Id;
        }
        public string GetEtunimi()
        {
            return Etunimi;
        }

        public string GetSukunimi()
        {
            return Sukunimi;
        }

        public string GetOsoite()
        {
            return Osoite;
        }

        public string GetPostinumero()
        {
            return Postinumero;
        }
        public string GetPostitoimipaikka()
        {
            return Postitoimipaikka;
        }

        public string GetPuhnro()
        {
            return Puhnro;
        }

        public string GetEmail()
        {
            return Email;
        }
    }
}
