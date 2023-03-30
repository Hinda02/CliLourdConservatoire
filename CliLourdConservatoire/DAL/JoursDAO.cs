using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class JoursDAO
    {

        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conserv", "root", "");

        public static List<Jours> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from jour ;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Jours> list = new List<Jours>();

            while (reader.Read())
            {
               
                string jour = (string)reader[0];
             
                Jours jourSemaine = new Jours(jour);
                list.Add(jourSemaine);

            }

            reader.Close();
            connect.closeConnection();

            return list;
        }



    }
}
