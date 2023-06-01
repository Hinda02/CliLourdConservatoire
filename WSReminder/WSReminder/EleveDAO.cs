using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WSReminder
{
    public class EleveDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        public static List<Eleve> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from personne inner join eleve on personne.ID = eleve.IDELEVE;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Eleve> liste = new List<Eleve>();

            while (reader.Read())
            {
                int idEleve = (int)reader[0];
                string nom = (string)reader[1];
                string prenom = (string)reader[2];
                string tel = (string)reader[3];
                string mail = (string)reader[4];
                string adresse = (string)reader[5];
                int bourse = (int)reader[7];

                Eleve eleve = new Eleve(idEleve, nom, prenom, tel, mail, adresse, bourse);

                liste.Add(eleve);

            }

            reader.Close();
            connect.closeConnection();

            return liste;
        }


        public static Eleve getById(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from personne inner join eleve on personne.ID = eleve.IDELEVE where IDELEVE = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            Eleve eleve = null;

            while (reader.Read())
            {
                int idEleve = (int)reader[0];
                string nom = (string)reader[1];
                string prenom = (string)reader[2];
                string tel = (string)reader[3];
                string mail = (string)reader[4];
                string adresse = (string)reader[5];
                int bourse = (int)reader[7];

                eleve = new Eleve(idEleve, nom, prenom, tel, mail, adresse, bourse);

            }

            reader.Close();
            connect.closeConnection();

            return eleve;
        }

        public static List<Payer> getPaiements(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from payer where IDELEVE = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            List<Payer> liste = new List<Payer>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int idEleve = (int)reader[1];
                int numSeance = (int)reader[2];
                string libelle = (string)reader[3];
                DateTime datePaiement = (DateTime)reader[4];
                int paye = (int)reader[5];

                Payer paiement = new Payer(idProf, idEleve, numSeance, libelle, datePaiement, paye);

                liste.Add(paiement);

            }

            reader.Close();
            connect.closeConnection();

            return liste;
        }

        public static List<Trimestre> getTrimestre()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from trim ;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Trimestre> liste = new List<Trimestre>();

            while (reader.Read())
            {
                string libelle = (string)reader[0];
                DateTime dateFin = (DateTime)reader[1];

                Trimestre trimestre = new Trimestre(libelle, dateFin);

                liste.Add(trimestre);

            }

            reader.Close();
            connect.closeConnection();

            return liste;
        }


    }
}
