using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    /// <summary>
    /// Couche contenant les méthodes d'accès aux données des horaires
    /// </summary>
    public class InscriptionDAO
    {

        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        /// <summary>
        /// récupérer la liste de toutes les inscriptions
        /// </summary>
        /// <returns type="List<Inscription>"></returns>
        public static List<Inscription> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from inscription;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Inscription> listeInscriptions = new List<Inscription>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int idEleve = (int)reader[1];
                int numSeance = (int)reader[2];
                DateTime dateInscription = (DateTime)reader[3];

                Inscription inscription = new Inscription(idProf, idEleve, numSeance, dateInscription);

                listeInscriptions.Add(inscription);
            }

            reader.Close();
            connect.closeConnection();

            return listeInscriptions;
        }

        /// <summary>
        /// récupérer la liste de toutes les inscriptions formatées
        /// </summary>
        /// <returns type="List<Inscription>"></returns>
        public static List<Inscription> getAllAffichage()
        {
            List<Inscription> listeReturn = new List<Inscription>();

            List<Inscription> listeInscriptions = getAll();

            foreach(Inscription insc in listeInscriptions)
            {
                Prof prof = ProfDAO.getById(insc.IdProf);
                Eleve eleve = EleveDAO.getById(insc.IdEleve);

                Inscription inscription = new Inscription(prof.Identite, eleve.Identite, insc.NumSeance, insc.DateInscription);
                listeReturn.Add(inscription);
            }

            return listeReturn;
        }

        /// <summary>
        /// récupérer la liste des inscription pour
        /// une séance donnée.
        /// </summary>
        /// <param name="seance"></param>
        /// <returns type="List<Inscription>"></returns>
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
