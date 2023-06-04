using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    /// <summary>
    /// Controlleur gérant l'appel des méthodes de la couche
    /// d'accès aux données gérant et manipulant les données
    /// des séances.
    /// </summary>
    public class SeanceController
    {
        /// <summary>
        /// récupérer la liste de toutes les séances
        /// </summary>
        /// <returns></returns>
        public static List<Seance> getAll()
        {
            return SeanceDAO.getAll();  
        }

        /// <summary>
        /// récupérer la liste des séances d'un professeur par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Seance> getByIdProf(int id)
        {
            return SeanceDAO.getByIdProf(id);
        }

        /// <summary>
        /// mettre à jour les données d'une séance
        /// </summary>
        /// <param name="seance"></param>
        public static void updateSeance(Seance seance)
        {
            SeanceDAO.updateSeance(seance);
        }

        /// <summary>
        /// créer une nouvelle séance
        /// </summary>
        /// <param name="seance"></param>
        public static void InsertSeance(Seance seance)
        {
            SeanceDAO.InsertSeance(seance);
        }

        /// <summary>
        /// récupérer le dernier numéro de séance pour un professeur donné
        /// </summary>
        /// <param name="idProf"></param>
        /// <returns></returns>
        public static int getLastNumSeance(int idProf)
        {
            return SeanceDAO.getLastNumSeance(idProf);
        }





    }
}
