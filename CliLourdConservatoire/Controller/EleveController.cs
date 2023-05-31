using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class EleveController
    {
        public static Eleve getById(int id)
        {
            return EleveDAO.getById(id);
        }

        public static List<Eleve> getByInscrptions(List<Inscription> inscriptions)
        {
            return EleveDAO.getByInscrptions(inscriptions);        }


    }
}
