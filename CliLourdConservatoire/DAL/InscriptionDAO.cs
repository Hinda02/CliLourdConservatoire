using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class InscriptionDAO
    {

        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conserv", "root", "");
        
        public static List<Inscription> getBySeance(Seance seance)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from inscription where IDPROF = " + seance.IdProf + " and numSeance = " + seance.NumSceance + ";");

            MySqlDataReader reader = connect.queryExec(request);

            List<Inscription> inscriptions = new List<Inscription>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int idEleve = (int)reader[1];
                int numSeance = (int)reader[2];
                DateTime dateInscription = (DateTime)reader[3];

                Inscription inscription = new Inscription(idProf, idEleve, numSeance, dateInscription);
                inscriptions.Add(inscription);

            }

            reader.Close();
            connect.closeConnection();

            return inscriptions;
        }

        
    }
}
