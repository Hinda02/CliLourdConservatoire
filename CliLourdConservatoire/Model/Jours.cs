using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Jours
    /// </summary>
    public class Jours
    {
        //Attributs privés
        private string jour;

        /// <summary>
        /// Constructeur de la classe Jours
        /// </summary>
        /// <param name="jour"></param>
        public Jours(string jour)
        {
            this.jour = jour;
        }

        //Propriétés publiques
        public string Jour { get => jour; set => jour = value; }
    }
}
