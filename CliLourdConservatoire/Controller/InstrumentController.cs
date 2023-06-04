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
    /// des instruments.
    /// </summary>
    public class InstrumentController
    {
        /// <summary>
        /// récupérer tous les instruments
        /// </summary>
        /// <returns></returns>
        public static List<Instrument> getAll()
        {
            return InstrumentDAO.getAll();
        }

    }
}
