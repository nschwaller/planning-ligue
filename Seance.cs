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
            string jour = ChoixJour;

            if (jour=="Monday")
            {
                jour = "Lundi";
            }
            else
            {
                if(jour=="Tuesday")
                {
                    jour = "Mardi";
                }
                else
                {
                    if(jour=="Wednesday")
                    {
                        jour = "Mercredi";
                    }
                    else
                    {
                        if(jour=="Thursday")
                        {
                            jour = "Jeudi";
                        }
                        else
                        {
                            if(jour=="Friday")
                            {
                                jour = "Vendredi";
                            }
                            else
                            {
                                if(jour=="Saturday")
                                {
                                    jour = "Samedi";
                                }
                                else
                                {
                                    if(jour=="Sunday")
                                    {
                                        jour = "Dimanche";
                                    }
                                }
                            }
                                  
                        }
                    }
                }
            }
            
            string jourdeb= JourDebut.ToString("yyyy/MM/dd");
            string jourfin = JourFin.ToString("yyyy/MM/dd");

            DateTime deb = DateTime.Parse(jourdeb);
            DateTime fin = DateTime.Parse(jourfin);
            
            TimeSpan Diff = fin - deb;
            int difference = Diff.Days / 7;

            for(int i=0; i<difference;i++)
            {
                DateTime Debut = JourDebut.AddDays(7*i);
                Unnom.ajouterSeance(jour, desc,Debut.ToString("yyyy-MM-dd"),JourFin.ToString("yyyy-MM-dd"),HeureD,MinuteD,HeureF,MinuteF,Type);
            }
        }
        public string switchFormatDate(DateTime Date)
        { 
            return Date.ToString("YYYY-MM-dd");
        }
    }
}
