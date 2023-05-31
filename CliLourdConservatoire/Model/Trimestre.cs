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
