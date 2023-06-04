using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Eleve héritant de Personne
    /// </summary>
    public class Eleve : Personne
    {
        //Attributs privés
        private int bourse;

        /// <summary>
        /// Constructeur 1 de la classe Eleve
        /// avec l'attribut id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="bourse"></param>
        public Eleve(int id, string nom, string prenom, string tel, string mail, string adresse, int bourse)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.bourse = bourse;
        }

        /// <summary>
        /// Constructeur 2 de la classe Eleve
        /// sans l'attribut id
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="bourse"></param>
        public Eleve(string nom, string prenom, string tel, string mail, string adresse, int bourse)
            : base(nom, prenom, tel, mail, adresse)
        {
            this.bourse = bourse;
        }

        //Propriétés publiques
        public int Bourse { get => bourse; set => bourse = value; }

        //Propriété Afficher héritant de Personne.Afficher
        public override string Afficher
        {
            get => Convert.ToString(this.Id).PadRight(4 - Convert.ToString(this.Id).Length) + "\t\t" + base.Afficher;
        }

    }
}
