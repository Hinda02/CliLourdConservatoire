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
    /// des inscriptions.
    /// </summary>
    public class InscriptionController
    {
        /// <summary>
        /// récupérer la liste de toutes les inscriptions
        /// </summary>
        /// <returns></returns>
        public static List<Inscription> getAll()
        {
            return InscriptionDAO.getAll();
        }

        /// <summary>
        /// récupérer la liste de toutes les inscriptions formatées
        /// pour son affichage.
        /// </summary>
        /// <returns></returns>
        public static List<Inscription> getAllAffichage()
        {
            return InscriptionDAO.getAllAffichage();
        }

        /// <summary>
        /// récupérer la liste des inscription pour
        /// une séance donnée.
        /// </summary>
        /// <param name="seance"></param>
        /// <returns></returns>
        public static List<Inscription> getBySeance(Seance seance)
        {
            return InscriptionDAO.getBySeance(seance);
        }




    }
}
