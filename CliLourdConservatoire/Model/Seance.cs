using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Seance
    {
        private int idProf;
        private int numSceance;
        private string tranche;
        private string jour;
        private int niveau;
        private int capacite;

        public Seance(int idProf, int numSceance, string tranche, string jour, int niveau, int capacite)
        {
            this.idProf = idProf;
            this.numSceance = numSceance;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;
        }

        public int IdProf { get => idProf; set => idProf = value; }
        public int NumSceance { get => numSceance; set => numSceance = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public string Jour { get => jour; set => jour = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }
    }
}
