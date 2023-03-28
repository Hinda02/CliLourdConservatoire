using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Inscription
    {
        private int idProf;
        private int idEleve;
        private int numSeance;
        private DateTime dateInscription;

        public Inscription(int idProf, int idEleve, int numSeance, DateTime dateInscription)
        {
            this.idProf = idProf;
            this.idEleve = idEleve;
            this.numSeance = numSeance;
            this.dateInscription = dateInscription;
        }

        public int IdProf { get => idProf; set => idProf = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public DateTime DateInscription { get => dateInscription; set => dateInscription = value; }
    }
}
