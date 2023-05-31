using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class SeanceController
    {

        public static List<Seance> getAll()
        {
            return SeanceDAO.getAll();  
        }

        public static List<Seance> getByIdProf(int id)
        {
            return SeanceDAO.getByIdProf(id);
        }

        public static void updateSeance(Seance seance)
        {
            return SeanceDAO.updateSeance(seance);
        }

        public static void InsertSeance(Seance seance)
        {
            SeanceDAO.InsertSeance(seance);
        }

        public static int getLastNumSeance(int idProf)
        {
            return SeanceDAO.getLastNumSeance(idProf);
        }





    }
}
