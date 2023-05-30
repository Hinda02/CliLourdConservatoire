using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    public class ProfDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        public static List<Prof> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from personne inner join prof on personne.ID = prof.IDPROF;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Prof> listeProfs = new List<Prof>();

            while (reader.Read())
            {
                int id = (int)reader[0];
                string nom = (string)reader[1];
                string prenom = (string)reader[2];
                string tel = (string)reader[3];
                string mail = (string)reader[4];
                string adresse = (string)reader[5];
                string instrument = (string)reader[7];
                double salaire = (double)reader[8];
                string login = (string)reader[9];
                string mdp = (string)reader[10];

                Prof prof = new Prof(id, nom, prenom, tel, mail, adresse, instrument, salaire, login, mdp);

                listeProfs.Add(prof);
            }

            reader.Close();
            connect.closeConnection();

            return listeProfs;
        }

        public static Prof getById(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from personne inner join prof on personne.ID = prof.IDPROF where IDPROF = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            Prof prof = null;

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                string nom = (string)reader[1];
                string prenom = (string)reader[2];
                string tel = (string)reader[3];
                string mail = (string)reader[4];
                string adresse = (string)reader[5];
                string instrument = (string)reader[7];
                double salaire = (double)reader[8];
                string login = (string)reader[9];
                string mdp = (string)reader[10];

                prof = new Prof(idProf, nom, prenom, tel, mail, adresse, instrument, salaire, login, mdp);

            }

            reader.Close();
            connect.closeConnection();

            return prof;
        }

        public static void InsertProf(Prof newProf)
        {
            AddPersonne(newProf);
            int id = GetIdPers(newProf.Email);

            connect.openConnection();

            MySqlCommand request = connect.reqExec("insert into prof values" +
                "(" + id + ", '" + newProf.Instrument + "', " + newProf.Salaire + ", '" + newProf.Login + "', '" + newProf.Mdp + "');");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }

        public static void AddPersonne(Prof newProf)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("Insert into personne (nom, prenom, tel, mail, adresse) values" +
               "('" + newProf.Nom + "','" + newProf.Prenom + "','"
                + newProf.Telephone + "','" + newProf.Email + "','" + newProf.Adresse +  "');");

            connect.nonQueryExec(request);
            
            connect.closeConnection();
        }

        public static int GetIdPers(string mail)
        {
            int id = -1;

            connect.openConnection();

            MySqlCommand request = connect.reqExec("select id from personne where MAIL = '" + mail + "';");

            MySqlDataReader reader = connect.queryExec(request);

            while (reader.Read())
            {
                id = (int)reader[0];
            }
            connect.closeConnection();
            return id;
        }

        public static void DeleteProf(Prof prof)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("delete from payer where IDPROF = " + prof.Id + ";" +
                                                    "delete from inscription where IDPROF = " + prof.Id + ";" +
                                                    "delete from seance where IDPROF = " + prof.Id + ";" +
                                                    "delete from prof where IDPROF = " + prof.Id + ";" +
                                                    "delete from personne where ID = " + prof.Id + ";");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }


    }
}
