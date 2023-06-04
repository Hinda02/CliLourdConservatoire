using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Seance
    /// </summary>
    public class Seance
    {
        //Attributs privés
        private int idProf;
        private int numSceance;
        private string tranche;
        private string jour;
        private int niveau;
        private int capacite;

        /// <summary>
        /// Constructeur de la classe Seance
        /// </summary>
        /// <param name="idProf"></param>
        /// <param name="numSceance"></param>
        /// <param name="tranche"></param>
        /// <param name="jour"></param>
        /// <param name="niveau"></param>
        /// <param name="capacite"></param>
        public Seance(int idProf, int numSceance, string tranche, string jour, int niveau, int capacite)
        {
            this.idProf = idProf;
            this.numSceance = numSceance;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;
        }

        //Propriétés publiques
        public int IdProf { get => idProf; set => idProf = value; }
        public int NumSceance { get => numSceance; set => numSceance = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public string Jour { get => jour; set => jour = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }

        //Propriété affichant les attributs de la classe sous un format précis
        public string Afficher
        {
            get => Convert.ToString(this.NumSceance).PadRight(3 - Convert.ToString(this.NumSceance).Length) 
                + "\t\t" + this.Jour.PadRight(19 - this.Jour.Length) + "\t\t"
                + this.Tranche.PadRight(14 - this.Tranche.Length) + "\t\t"
                + Convert.ToString(this.Niveau).PadRight(2 - Convert.ToString(this.Niveau).Length) + "\t\t"
                + Convert.ToString(this.Capacite).PadRight(3 - Convert.ToString(this.Capacite).Length);
        }
    }
}
