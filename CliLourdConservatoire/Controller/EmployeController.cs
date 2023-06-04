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
    /// des employés.
    /// </summary>
    public class EmployeController
    {
        /// <summary>
        /// gestion de l'appel de la méthode d'authentification
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool Authentifier(string login, string pwd)
        {
            try
            {
                return EmployeDAO.Authentifier(login, pwd);
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }


    }
}
