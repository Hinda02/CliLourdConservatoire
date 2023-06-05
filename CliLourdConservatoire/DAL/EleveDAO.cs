using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    /// <summary>
    /// Couche contenant les méthodes d'accès aux données des adhérents
    /// </summary>
    public class EleveDAO
    {
        //Instanciation d'une connexion à la bdd
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        /// <summary>
        /// récupérer un adhérent grâce à son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns type="Eleve"></returns>
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

        /// <summary>
        /// récuperer une liste d'adhérents grâce à leurs inscriptions.
        /// </summary>
        /// <param name="inscriptions"></param>
        /// <returns type="List<Eleve>"></returns>
        public static List<Eleve> getByInscrptions(List<Inscription> inscriptions)
        {
            Eleve eleve = null;
            List<Eleve> list = new List<Eleve>();

            foreach(Inscription inscription in inscriptions)
            {
                eleve = getById(inscription.IdEleve);
                list.Add(eleve);
            }

            return list;
        }
    }
}
