using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    /// <summary>
    /// Controlleur gérant l'appel des méthodes de la couche
    /// d'accès aux données gérant et manipulant les données
    /// des paiements.
    /// </summary>
    public class PayerController
    {
        /// <summary>
        /// récupérer le paiement pour une inscription
        /// selon un trimestre donné.
        /// </summary>
        /// <param name="insc"></param>
        /// <param name="trim"></param>
        /// <returns></returns>
        public static Payer getByInscription_Trimestre(Inscription insc, string trim)
        {
            return PayerDAO.getByInscription_Trimestre(insc, trim); 
        }

        /// <summary>
        /// mettre à jour la datte de paiement
        /// </summary>
        /// <param name="paiement"></param>
        public static void updateDatePaiement(Payer paiement)
        {
            PayerDAO.updateDatePaiement(paiement);
        }


    }
}
