using CliLourdConservatoire.Controller;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliLourdConservatoire.View
{
    public partial class FormAjoutSeance : Form
    {
        private Prof prof;

        public FormAjoutSeance(Prof p)
        {  
            InitializeComponent();

            prof = p;
            tbMatiere.Text = prof.Instrument;
            tbProf.Text = prof.Identite;

            int numS = SeanceController.getLastNumSeance(prof.Id);
            if (numS != -1)
            {
                tbNumS.Text = (numS+1).ToString();
            }
            else
            {
                tbNumS.Text = "1";
            }

            cbJour.DataSource = JourController.getAll();
            cbJour.DisplayMember = "Jour";

            cbTranche.DataSource = HeureController.getAll();
            cbTranche.DisplayMember = "Tranche";

        }

        private void cbJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTranche.DataSource = HeureController.getByJour_Id(cbJour.Text, prof.Id);
            cbTranche.DisplayMember = "Tranche";
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            int idProf = prof.Id;
            int numSeance = Convert.ToInt32(tbNumS.Text);
            string tranche = cbTranche.Text;
            string jour = cbJour.Text;
            int niveau = 0;

            bool check1 = radNiv1.Checked;
            bool check2 = radNiv2.Checked;
            bool check3 = radNiv3.Checked;
            bool check4 = radNiv4.Checked;

            if (check1)
            {
                niveau = Convert.ToInt32(radNiv1.Text);
            }
            else if (check2)
            {
                niveau = Convert.ToInt32(radNiv2.Text);
            }
            else if (check3)
            {
                niveau = Convert.ToInt32(radNiv3.Text);
            }
            else if (check4)
            {
                niveau = Convert.ToInt32(radNiv4.Text);
            }

            int capacite = Convert.ToInt32(tbCapacite.Text);

            Seance seance = new Seance(idProf, numSeance, tranche, jour, niveau, capacite);
            SeanceController.InsertSeance(seance);
            this.Close();
        }
    }
}
