using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class InscriptionController
    {
        public static List<Inscription> getAll()
        {
            return InscriptionDAO.getAll();
        }


        public static List<Inscription> getAllAffichage()
        {
            return InscriptionDAO.getAllAffichage();
        }


        public static List<Inscription> getBySeance(Seance seance)
        {
            return InscriptionDAO.getBySeance(seance);
        }




    }
}
