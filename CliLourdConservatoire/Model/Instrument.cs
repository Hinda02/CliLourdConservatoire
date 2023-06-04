using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Instrument
    /// </summary>
    public class Instrument
    {
        //Attributs privés
        private string libelle;

        /// <summary>
        /// Constructeur de la classe Instrument
        /// </summary>
        /// <param name="libelle"></param>
        public Instrument(string libelle)
        {
            this.libelle = libelle;
        }

        //Propriétés publiques
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
