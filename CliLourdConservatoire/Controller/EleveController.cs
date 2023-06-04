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
    /// des adhérents.
    /// </summary>
    public class EleveController
    {
        /// <summary>
        /// récupérer un adhérent grâce à son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Eleve getById(int id)
        {
            return EleveDAO.getById(id);
        }

        /// <summary>
        /// récuperer une liste d'adhérents grâce à leurs inscriptions.
        /// </summary>
        /// <param name="inscriptions"></param>
        /// <returns></returns>
        public static List<Eleve> getByInscrptions(List<Inscription> inscriptions)
        {
            return EleveDAO.getByInscrptions(inscriptions);        }


    }
}
