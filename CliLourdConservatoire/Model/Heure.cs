using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Heure
    {
        private string tranche;

        public Heure(string tranche)
        {
            this.tranche = tranche;
        }

        public string Tranche { get => tranche; set => tranche = value; }
    }
}
