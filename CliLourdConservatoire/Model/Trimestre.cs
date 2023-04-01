using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Model
{
    public class Trimestre
    {
        private string libelle;
        private DateTime dateFin;

        public Trimestre(string libelle, DateTime dateFin)
        {
            this.libelle = libelle;
            this.dateFin = dateFin;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
    }
}
