using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Jours
    {

        private string jour;

        public Jours(string jour)
        {
            this.jour = jour;
        }

        public string Jour { get => jour; set => jour = value; }
    }
}
