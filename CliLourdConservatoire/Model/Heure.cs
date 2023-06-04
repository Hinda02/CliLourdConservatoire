using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Heure
    /// </summary>
    public class Heure
    {
        //Attributs privés
        private string tranche;

        /// <summary>
        /// Constructeur de la classe Heure
        /// </summary>
        /// <param name="tranche"></param>
        public Heure(string tranche)
        {
            this.tranche = tranche;
        }

        //Propriétés publiques
        public string Tranche { get => tranche; set => tranche = value; }
    }
}
