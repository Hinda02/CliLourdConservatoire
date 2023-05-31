using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public  class PayerController
    {
        public static Payer getByInscription_Trimestre(Inscription insc, string trim)
        {
            return PayerDAO.getByInscription_Trimestre(insc, trim); 
        }

        public static void updateDatePaiement(Payer paiement)
        {
            PayerDAO.updateDatePaiement(paiement);
        }


    }
}
