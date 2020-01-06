using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannning_ligue
{
    class Seance
    {
        public Seance(string ChoixJour , DateTime JourDebut , DateTime JourFin , string HeureD , string MinuteD , string HeureF, string MinuteF, string Type ,string desc)
        {
            // foreach ou for a faire ....
            Sql Unnom = new Sql();
            
        }
        public string switchFormatDate(DateTime Date)
        { 
            return Date.ToString("YYYY-MM-dd");
        }
    }
}
