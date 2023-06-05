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

namespace CliLourdConservatoire
{
    public partial class FormModifCours : Form
    {

        private Seance s;

        /// <summary>
        /// constructeur du formulaire de modification de cours
        /// </summary>
        /// <param name="seance"></param>
        public FormModifCours(Seance seance)
        {

            InitializeComponent();
            //affichage des données actuelles de la séance séléctionnée
            s = seance;
            cbJour.DataSource = JourController.getAll();
            cbJour.DisplayMember = "Jour";
            cbJour.Text = s.Jour;

            cbTranche.DataSource = HeureController.getBySeance(s);
            cbTranche.DisplayMember = "Tranche";
            cbTranche.Text = s.Tranche;

            Prof p = ProfController.getById(s.IdProf);
            tbMatiere.Text = p.Instrument;
            tbProfesseur.Text = p.Identite;
            tbNiveau.Text =Convert.ToString(s.Niveau);
            tbCapacite.Text = Convert.ToString(s.Capacite);

        }

        
        /// <summary>
        /// actions au changement du jour séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gestion des tranches horaires possibles
            cbTranche.DataSource = HeureController.getByJour_Id(cbJour.Text, s.IdProf);
            cbTranche.DisplayMember = "Tranche";
            cbTranche.Text = s.Tranche;
        }

        /// <summary>
        /// btn validant la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            s.Jour = cbJour.Text;
            s.Tranche = cbTranche.Text;

            SeanceController.updateSeance(s);
            this.Close();
        }

        //btn annulant la modification et fermant le formulaire
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
