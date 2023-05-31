using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class TrimestreController
    {
        public static Trimestre getByTrimestre(string trim)
        {
            return  TrimestreDAO.getByTrimestre(trim);
        }

    }
}
