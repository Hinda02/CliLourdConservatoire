using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class InstrumentController
    {
        public static List<Instrument> getAll()
        {
            return InstrumentDAO.getAll();
        }

    }
}
