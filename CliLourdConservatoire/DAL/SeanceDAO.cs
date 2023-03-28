using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class SeanceDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conserv", "root", "");

        public static List<Seance> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from seance;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Seance> listeSeances = new List<Seance>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int numSeance = (int)reader[1];
                string tranche = (string)reader[2];
                string jour = (string)reader[3];
                int niveau = (int)reader[4];
                int capacite = (int)reader[5];
                

                Seance seance = new Seance(idProf, numSeance, tranche, jour, niveau, capacite);

                listeSeances.Add(seance);
            }

            reader.Close();
            connect.closeConnection();

            return listeSeances;
        }

        public static List<Seance> getByIdProf(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from seance where IDPROF = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            List<Seance> listeSeances = new List<Seance>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int numSeance = (int)reader[1];
                string tranche = (string)reader[2];
                string jour = (string)reader[3];
                int niveau = (int)reader[4];
                int capacite = (int)reader[5];


                Seance seance = new Seance(idProf, numSeance, tranche, jour, niveau, capacite);

                listeSeances.Add(seance);
            }

            reader.Close();
            connect.closeConnection();

            return listeSeances;
        }
    }
}
