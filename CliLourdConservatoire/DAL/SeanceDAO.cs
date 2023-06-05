using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    /// <summary>
    /// Couche contenant les méthodes d'accès aux données des séances
    /// </summary>
    public class SeanceDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        /// <summary>
        /// récupérer la liste de toutes les séances
        /// </summary>
        /// <returns type="List<Seance>"></returns>
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

        /// <summary>
        /// récupérer la liste des séances d'un professeur par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns type="List<Seance>"></returns>
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

        /// <summary>
        /// mettre à jour les données d'une séance
        /// </summary>
        /// <param name="seance"></param>
        public static void updateSeance(Seance seance)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("Update seance set JOUR='" + seance.Jour + "', TRANCHE='" + seance.Tranche + "'where IDPROF=" + seance.IdProf + " and NUMSEANCE="+seance.NumSceance+";");
              

            connect.nonQueryExec(request);

            connect.closeConnection();
        }

        /// <summary>
        /// créer une nouvelle séance
        /// </summary>
        /// <param name="seance"></param>
        public static void InsertSeance(Seance seance)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("Insert into seance (idprof, numseance, tranche, jour, niveau, capacite) values" +
               "('" + seance.IdProf + "','" + seance.NumSceance + "','"
                + seance.Tranche + "','" + seance.Jour + "','" + seance.Niveau + "','" + seance.Capacite + "');");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }

        /// <summary>
        /// récupérer le dernier numéro de séance pour un professeur donné
        /// </summary>
        /// <param name="idProf"></param>
        /// <returns></returns>
        public static int getLastNumSeance(int idProf)
        {
            int numSeance = -1;

            connect.openConnection();

            MySqlCommand request = connect.reqExec("select max(numSeance) from seance where IDPROF = " + idProf + ";");

            MySqlDataReader reader = connect.queryExec(request);

            while (reader.Read())
            {
                string s = reader[0].ToString();
                if (s != "")
                {
                    numSeance = (int)reader[0];
                }

            }

            reader.Close();
            connect.closeConnection();

            return numSeance;

        }
    }
}
