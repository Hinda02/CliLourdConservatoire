using CliLourdConservatoire.Model;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    /// <summary>
    /// Couche contenant les méthodes d'accès aux données des employés
    /// </summary>
    public class EmployeDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        /// <summary>
        /// gestion de l'authentification d'un employé
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns type="bool"></returns>
        public static bool Authentifier(string login, string pwd)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from employe where login = '" + login + "' and pw = '" + pwd + "';");

            MySqlDataReader reader = connect.queryExec(request);

            int id = -1;

            while (reader.Read())
            {
                id = (int)reader[0];
            }

            reader.Close();
            connect.closeConnection();

            if (id == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
