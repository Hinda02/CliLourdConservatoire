using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliLourdConservatoire.Controller
{
    public class EmployeController
    {
        public static bool Authentifier(string login, string pwd)
        {
            try
            {
                return EmployeDAO.Authentifier(login, pwd);
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }


    }
}
