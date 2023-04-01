using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Prof : Personne
    {
        private string instrument;
        private double salaire;
        
        public Prof(int id, string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.salaire = salaire;
            this.instrument = instrument;
        }

        public Prof(string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire)
            : base(nom, prenom, tel, mail, adresse)
        {
            this.salaire = salaire;
            this.instrument = instrument;
        }

        public double Salaire { get => salaire; set => salaire = value; }
        public string Instrument { get => instrument; set => instrument = value; }

        public override string Afficher
        {
            get =>  this.Instrument.PadRight(20 - this.Instrument.Length) + "\t\t" + base.Afficher;
        }
    }

}
