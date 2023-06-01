using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Reflection.Emit;

namespace WSReminder
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 60000; //very important!
                                    //(60 seconds with minutes and 60 minutes with hours)params
            timer.Enabled = true;


        }

        protected override void OnStop()
        {
            this.Stop();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            DateTime d = DateTime.Now;

            if (d.Month == 6 && d.Day == 1 && d.Hour == 19 && d.Minute == 44)
            {

                List<Eleve> eleves = EleveDAO.getAll();
                List<Trimestre> trimestres = EleveDAO.getTrimestre();

                foreach (Eleve eleve in eleves)
                {
                    List<Payer> paiements = EleveDAO.getPaiements(eleve.Id);

                    foreach (Trimestre trimestre in trimestres)
                    {
                        if ((trimestre.DateFin.Month == DateTime.Now.Month) && (trimestre.DateFin.Day == (DateTime.Now.Day + 5)))
                        {
                            foreach (Payer paie in paiements)
                            {
                                if (paie.Libelle == trimestre.Libelle)
                                {
                                    if (paie.DatePaiement.Year == 0001)
                                    {
                                        var smtpClient = new SmtpClient("smtp-mail.outlook.com")
                                        {
                                            Port = 587,
                                            Credentials = new NetworkCredential("hinda.habib@efrei.net", "c'estvraimentc0mpl1que"),
                                            EnableSsl = true,
                                        };

                                        smtpClient.Send("hinda.habib@efrei.net", eleve.Email, "Rappel paiement du trimestre", "Bonjour, " +
                                            "\n\n \tNous vous rappelons que le paiement pour le trimestre en cours est dû au plus tard dans " +
                                            "5 jours. \n\nBien cordialement. \nAdministration Musique Pour Tous");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
