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
    /// des jours de la semaines.
    /// </summary>
    public class JourController
    {
        /// <summary>
        /// récupérer les jours de la semaine
        /// </summary>
        /// <returns></returns>
        public static List<Jours> getAll()
        {
            return JoursDAO.getAll();
        }

    }
}
