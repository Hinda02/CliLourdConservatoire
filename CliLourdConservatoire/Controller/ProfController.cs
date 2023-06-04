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
    /// des professeurs.
    /// </summary>
    public class ProfController
    {
        /// <summary>
        /// récupérer la liste de tous les professeurs
        /// </summary>
        /// <returns></returns>
        public static List<Prof> getAll()
        {
            return ProfDAO.getAll();
        }

        /// <summary>
        /// récupérer un prof selon son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Prof getById(int id)
        {
            return ProfDAO.getById(id);
        }

        /// <summary>
        /// Insérer un nouveau professeur
        /// </summary>
        /// <param name="newProf"></param>
        public static void InsertProf(Prof newProf)
        {
            ProfDAO.InsertProf(newProf);
        }

        /// <summary>
        /// Insérer une personne
        /// </summary>
        /// <param name="newProf"></param>
        public static void AddPersonne(Prof newProf)
        {
            ProfDAO.AddPersonne(newProf);
        }

        /// <summary>
        /// récuperer l'id d'une personne selon son mail
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static int GetIdPers(string mail)
        {
            return ProfDAO.GetIdPers(mail);
        }

        /// <summary>
        /// supprimer un professeur
        /// </summary>
        /// <param name="prof"></param>
        public static void DeleteProf(Prof prof) 
        { 
            ProfDAO.DeleteProf(prof);
        
        }




    }
}
