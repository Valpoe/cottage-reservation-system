using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbiesApp
{
    public class Mokki
    {
        private int id { get; set; }
        private string nimi { get; set; }
        private string katuosoite { get; set; }
        private double hinta { get; set; }
        private string kuvaus { get; set; }
        private int henkilomaara { get; set; }
        private string varustelu { get; set; }

        public Mokki(int MokkiId, string Mokkinimi, string Mokkikatuosoite, double Mokkihinta, string Mokkikuvaus, int MokkiHenkilomaara, string Mokkivarustelu)
        {
            id = MokkiId;
            nimi = Mokkinimi;
            katuosoite = katuosoite;
            hinta = Mokkihinta;
            kuvaus = Mokkikuvaus;
            henkilomaara = MokkiHenkilomaara;
            varustelu = Mokkivarustelu;
        }


        public int GetMokkiId()
        {
            return id;
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
        
    }
}
