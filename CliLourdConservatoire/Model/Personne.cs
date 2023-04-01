using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;
        private string adresse;

        public Personne(int id, string nom, string prenom, string telephone, string email, string adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
        }

        public Personne(string nom, string prenom, string telephone, string email, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
        }

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

        public virtual string Afficher
        {
            get =>  this.Identite;
        }
    }
}
