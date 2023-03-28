using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Eleve : Personne
    {
        private int bourse;

        public Eleve(int id, string nom, string prenom, string tel, string mail, string adresse, int bourse)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.bourse = bourse;
        }

        public Eleve(string nom, string prenom, string tel, string mail, string adresse, int bourse)
            : base(nom, prenom, tel, mail, adresse)
        {
            this.bourse = bourse;
        }

        public int Bourse { get => bourse; set => bourse = value; }
    }
}
