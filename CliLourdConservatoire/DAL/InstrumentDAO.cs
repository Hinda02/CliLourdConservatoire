using CliLourdConservatoire.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.DAL
{
    /// <summary>
    /// Couche contenant les méthodes d'accès aux données des instruments
    /// </summary>
    public class InstrumentDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        /// <summary>
        /// récupérer tous les instruments
        /// </summary>
        /// <returns type="List<Instrument>"></returns>
        public static List<Instrument> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from instrument;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Instrument> listeInstrument = new List<Instrument>();

            while (reader.Read())
            {
                string libelle = (string)reader[0];
               

                Instrument instrument = new Instrument(libelle);

                listeInstrument.Add(instrument);
            }

            reader.Close();
            connect.closeConnection();

            return listeInstrument;
        }

    }
}
