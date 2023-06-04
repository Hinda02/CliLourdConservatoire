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
    /// des horaires.
    /// </summary>
    public class HeureController
    {
        /// <summary>
        /// récupérer les horaires
        /// </summary>
        /// <returns></returns>
        public static List<Heure> getAll()
        {
            return HeureDAO.getAll();
        }

        /// <summary>
        /// récupérer les horaires selon une séance donnée
        /// </summary>
        /// <param name="seance"></param>
        /// <returns></returns>
        public static List<Heure> getBySeance(Seance seance)
        {
            return HeureDAO.getBySeance(seance);
        }

        /// <summary>
        /// récupérer les horaires selon un jour et une idProf
        /// </summary>
        /// <param name="jour"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Heure> getByJour_Id(string jour, int id)
        {
            return HeureDAO.getByJour_Id(jour, id); 
        }





    }
}
