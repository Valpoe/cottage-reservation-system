using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbiesApp
{
    public class Mokki
    {
        private int ID { get; set; }
        private int alueID { get; set; }
        private string nimi { get; set; }
        private string katuosoite { get; set; }
        private double hinta { get; set; }
        private string kuvaus { get; set; }
        private int henkilomaara { get; set; }
        private string varustelu { get; set; }
        private int postinumero { get; set; }

        public Mokki( string Mokkinimi, string Mokkikatuosoite, double Mokkihinta, string Mokkikuvaus, int MokkiHenkilomaara, string Mokkivarustelu, int Mokkipostinumero)
        {
            nimi = Mokkinimi;
            katuosoite = Mokkikatuosoite;
            hinta = Mokkihinta;
            kuvaus = Mokkikuvaus;
            henkilomaara = MokkiHenkilomaara;
            varustelu = Mokkivarustelu;
            postinumero = Mokkipostinumero;
        }

        public Mokki()
        {

        }

        public void setAlueID(int ID)
        {
            alueID = ID;
        }

        public int getAlueID()
        {
            return alueID;
        }

        public string GetNimi()
        {
            return nimi;
        }

        public string GetKatuosoite()
        {
            return katuosoite;
        }

        public double GetHinta()
        {
            return hinta;
        }

        public string GetKuvaus()
        {
            return kuvaus;
        }
        public string GetVarustelu()
        {
            return varustelu;
        }
        public int GetHenkilomaara()
        {
            return henkilomaara;
        }

        public int GetPostinumero()
        {
            return postinumero;
        }
        public int GetID()
        {
            return ID;
        }

        public void setNimi(string Mokkinimi)
        {
            nimi = Mokkinimi;
        }

        public void setID(int MokkiID)
        {
            ID = MokkiID;
        }

        public void setKatuosoite(string Mokkikatuosoite)
        {
            katuosoite = Mokkikatuosoite;
        }

    }
}
