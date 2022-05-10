using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageNewbiesApp
{
    internal class Lasku
    {
        private string laskuID { get; set; }

        public Lasku(string laskuID)
        {
            this.laskuID = laskuID;
        }
        public Lasku()
        {
        }

        public void setLaskuID(string lID)
        {
            laskuID = lID;
        }
        public string getLaskuID()
        {
            return laskuID;
        }
    }
}
