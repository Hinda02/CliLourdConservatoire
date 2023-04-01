using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class PayerDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conserv", "root", "");

        public static Payer getByInscription_Trimestre(Inscription insc, string trim)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from payer where IDPROF = " + insc.IdProf + " and" +
                " IDELEVE = " + insc.IdEleve + " and NUMSEANCE = " + insc.NumSeance + " and" +
                " LIBELLE = '" + trim + "';");

            MySqlDataReader reader = connect.queryExec(request);

            Payer paiement = null;

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int idEleve = (int)reader[1];
                int numSeance = (int)reader[2];
                string libelle = (string)reader[3];
                DateTime datePaiement = (DateTime)reader[4];
                double paye = (double)reader[5];

                paiement = new Payer(idProf, idEleve, numSeance, libelle, datePaiement, paye);

            }
            
            reader.Close();
            connect.closeConnection();

            return paiement;
        }

        public static void updateDatePaiement(Payer paiement)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("Update payer set DATEPAIEMENT='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where IDPROF=" + paiement.IdProf + " and IDELEVE=" + paiement.IdEleve + " and NUMSEANCE=" + paiement.NumSeance + " and LIBELLE='" + paiement.Libelle + "';");


            connect.nonQueryExec(request);

            connect.closeConnection();
        }
    }
}
