using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Personne
    {
        //Attributs privés
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;
        private string adresse;

        /// <summary>
        /// Constructeur 1 de la classe Personne
        /// avec l'attribut id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="adresse"></param>
        public Personne(int id, string nom, string prenom, string telephone, string email, string adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
        }

        /// <summary>
        /// Constructeur 2 de la classe Personne
        /// sans l'attribut id
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="adresse"></param>
        public Personne(string nom, string prenom, string telephone, string email, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
        }

        //Propriétés publiques
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }

        public string Identite
        {
            get => Nom + " " + Prenom;
        }

        //Propriété Afficher dela classe Personne
        public virtual string Afficher
        {
            get =>  this.Identite;
        }
    }
}
