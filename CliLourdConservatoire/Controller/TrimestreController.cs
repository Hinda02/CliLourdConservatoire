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
    /// des trimestres.
    /// </summary>
    public class TrimestreController
    {
        /// <summary>
        /// récupérer les données d'un trimestre selon son libelle
        /// </summary>
        /// <param name="trim"></param>
        /// <returns></returns>
        public static Trimestre getByTrimestre(string trim)
        {
            return  TrimestreDAO.getByTrimestre(trim);
        }

    }
}
