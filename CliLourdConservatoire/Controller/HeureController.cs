using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class HeureController
    {
        public static List<Heure> getAll()
        {
            return HeureDAO.getAll();
        }


        public static List<Heure> getBySeance(Seance seance)
        {
            return HeureDAO.getBySeance(seance);
        }


        public static List<Heure> getByJour_Id(string jour, int id)
        {
            return HeureDAO.getByJour_Id(jour, id); 
        }





    }
}
