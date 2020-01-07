
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannning_ligue
{
    class Sql
    {
        private string IP = "172.19.0.22";
        private string USER = "nadia";
        private string MDP = "0550002D";
        private string DATABASE = "planning-ligue";
        MySqlConnection conn;


        public Sql()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
            conn = new MySqlConnection(connStr);
        }


        public void ajouterSeance(string jour,string desc, string dateDeb , string dateFin,string heureDeb,string minuteDeb, string heureFin, string minuteFin, string catego)
        {
            string req = "INSERT INTO `seance` (`jour`,`descriptif`,`debut`,`fin`,`la_categorie`) VALUES (" + jour + "," + desc + ","+ dateDeb+ " " + heureDeb+":"+ minuteDeb +"," + dateFin + " " + heureFin + ":" + minuteFin + ",(SELECT id FROM categorie WHERE descriptif = '"+catego+"'))";
            MySqlCommand larequete = new MySqlCommand(req, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            this.conn.Close();
        }
    }
}
