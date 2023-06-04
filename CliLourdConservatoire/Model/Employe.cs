using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Employe
    /// </summary>
    public class Employe
    {
        //Attributs privés
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string password;

        /// <summary>
        /// Constructeur de la classe Employe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public Employe(int id, string nom, string prenom, string login, string password)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
        }

        //Propriétés publiques
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
