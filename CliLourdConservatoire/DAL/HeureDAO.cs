using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class HeureDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");
        public static List<Heure> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from heure ;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Heure> list = new List<Heure>();

            while (reader.Read())
            {

                string tranche = (string)reader[0];

                Heure heure = new Heure(tranche);
                list.Add(heure);

            }

            reader.Close();
            connect.closeConnection();

            return list;
        }

        public static List<Heure> getBySeance(Seance seance)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from heure where" +
                " TRANCHE not in(select TRANCHE from seance where JOUR = '" + seance.Jour + "'" +
                " and IDPROF <> " + seance.IdProf + ");");

            MySqlDataReader reader = connect.queryExec(request);

            List<Heure> list = new List<Heure>();

            while (reader.Read())
            {

                string tranche = (string)reader[0];

                Heure heure = new Heure(tranche);
                list.Add(heure);

            }

            reader.Close();
            connect.closeConnection();

            return list;
        }

        public static List<Heure> getByJour_Id(string jour, int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from heure where" +
                " TRANCHE not in(select TRANCHE from seance where JOUR = '" + jour + "'" +
                " and IDPROF = " + id + ");");

            MySqlDataReader reader = connect.queryExec(request);

            List<Heure> list = new List<Heure>();

            while (reader.Read())
            {

                string tranche = (string)reader[0];

                Heure heure = new Heure(tranche);
                list.Add(heure);

            }

            reader.Close();
            connect.closeConnection();

            return list;
        }

    }
}
