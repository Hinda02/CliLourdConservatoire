using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    /// <summary>
    /// Classe Prof
    /// </summary>
    public class Prof : Personne
    {
        //Attributs privés
        private string instrument;
        private double salaire;
        private string login;
        private string mdp;

        /// <summary>
        /// Constructeur Json de la classe Prof
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="instrument"></param>
        /// <param name="salaire"></param>
        [JsonConstructor]
        public Prof(int id, string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.salaire = salaire;
            this.instrument = instrument;

        }

        /// <summary>
        /// Constructeur 2 de la classe Prof
        /// avec l'attribut id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="instrument"></param>
        /// <param name="salaire"></param>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        public Prof(int id, string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire, string login, string mdp)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.salaire = salaire;
            this.instrument = instrument;
            this.Login = login;
            this.Mdp = mdp;
        }

        /// <summary>
        /// Constructeur 3 de la classe Prof
        /// sans l'attribut id
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="adresse"></param>
        /// <param name="instrument"></param>
        /// <param name="salaire"></param>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        public Prof(string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire, string login, string mdp)
            : base(nom, prenom, tel, mail, adresse)
        {
            this.salaire = salaire;
            this.instrument = instrument;
            this.Login = login;
            this.Mdp = mdp;
        }

        //Propriétés publiques
        public double Salaire { get => salaire; set => salaire = value; }
        public string Instrument { get => instrument; set => instrument = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }


        //Propriété Afficher héritant de Personne.Afficher
        public override string Afficher
        {
            get =>  this.Instrument.PadRight(20 - this.Instrument.Length) + "\t\t" + base.Afficher;
        }
        
    }

}
