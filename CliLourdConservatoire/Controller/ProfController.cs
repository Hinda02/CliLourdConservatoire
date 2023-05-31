using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class ProfController
    {

        public static List<Prof> getAll()
        {
            return ProfDAO.getAll();
        }

        public static Prof getById(int id)
        {
            return ProfDAO.getById(id);
        }

        public static void InsertProf(Prof newProf)
        {
            ProfDAO.InsertProf(newProf);
        }

        public static void AddPersonne(Prof newProf)
        {
            ProfDAO.AddPersonne(newProf);
        }

        public static int GetIdPers(string mail)
        {
            return ProfDAO.GetIdPers(mail);
        }

        public static void DeleteProf(Prof prof) 
        { 
            ProfDAO.DeleteProf(prof);
        
        }




    }
}
