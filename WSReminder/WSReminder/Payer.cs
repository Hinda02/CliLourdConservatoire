using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSReminder
{
    public class Payer
    {
        private int idProf;
        private int idEleve;
        private int numSeance;
        private string libelle;
        private DateTime datePaiement;
        private int paye;

        public Payer(int idProf, int idEleve, int numSeance, string libelle, DateTime datePaiement, int paye)
        {
            this.idProf = idProf;
            this.idEleve = idEleve;
            this.numSeance = numSeance;
            this.libelle = libelle;
            this.datePaiement = datePaiement;
            this.paye = paye;
        }

        public int IdProf { get => idProf; set => idProf = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DatePaiement { get => datePaiement; set => datePaiement = value; }
        public int Paye { get => paye; set => paye = value; }

        public static bool compareDates(DateTime d1)
        {
            bool result;

            DateTime date1 = DateTime.Now;
            TimeSpan ts = new TimeSpan(10, 10, 10);
            date1 = date1.Date + ts;
            int lastyear = date1.Year - 1;
            string date = d1.ToString("MM-dd");

            if (d1.Month > 5 && date1.Month < 6)
            {
                date = date + "-" + lastyear;
            }

            DateTime date2 = Convert.ToDateTime(date);
            date2 = date2.Date + ts;

            int res = DateTime.Compare(date1, date2);

            if (res <= 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

    }

}
