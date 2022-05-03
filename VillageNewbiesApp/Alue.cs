using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbiesApp
{
    internal class Alue
    {
        private string Nimi { get; set; }
        private int Alueid { get; set; }

        public Alue (string nimi, int alueid)
        {
            Nimi = nimi;
            Alueid = alueid;
        }
        
        public string GetNimi()
        {
            return Nimi;
        }

        public int GetAlueid()
        {
            return Alueid;
        }
    }
}
