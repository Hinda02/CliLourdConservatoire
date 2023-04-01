using CliLourdConservatoire.DAL;
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

namespace CliLourdConservatoire
{
    public partial class FormModifCours : Form
    {

        private Seance s;
        public FormModifCours(Seance seance)
        {

            InitializeComponent();
            s = seance;
            cbJour.DataSource = JoursDAO.getAll();
            cbJour.DisplayMember = "Jour";
            cbJour.Text = s.Jour;

            cbTranche.DataSource = HeureDAO.getBySeance(s);
            cbTranche.DisplayMember = "Tranche";
            cbTranche.Text = s.Tranche;

            Prof p = ProfDAO.getById(s.IdProf);
            tbMatiere.Text = p.Instrument;
            tbProfesseur.Text = p.Identite;
            tbNiveau.Text =Convert.ToString(s.Niveau);
            tbCapacite.Text = Convert.ToString(s.Capacite);

        }

        

        private void cbJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTranche.DataSource = HeureDAO.getByJour_Id(cbJour.Text, s.IdProf);
            cbTranche.DisplayMember = "Tranche";
            cbTranche.Text = s.Tranche;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            s.Jour = cbJour.Text;
            s.Tranche = cbTranche.Text;

            SeanceDAO.updateSeance(s);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous annuler?", "Alerte", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
