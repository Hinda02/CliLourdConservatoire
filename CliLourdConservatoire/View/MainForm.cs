using CliLourdConservatoire.Controller;
using CliLourdConservatoire.Model;
using CliLourdConservatoire.View;
using MySqlX.XDevAPI;
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
    public partial class MainForm : Form
    {
        private List<Prof> listeProf;
        private List<Seance> listeSeance;
        private List<Eleve> listeEleve;
        private Prof selectedProf;
        private Seance selectedSeance;
        private FormAuthentification f;
        public MainForm(FormAuthentification form)
        {

            InitializeComponent();

            this.Size = new System.Drawing.Size(750, 750);
            
            afficherListeProf();
            f = form;
            f.Hide();
        }

        private void lbProf_DoubleClick(object sender, EventArgs e)
        {
            selectedProf = (Prof)lbProf.SelectedItem;

            afficherListeSeance();
        }

        private void lbCours_DoubleClick(object sender, EventArgs e)
        {
            List<Inscription> inscriptions = InscriptionController.getBySeance(selectedSeance);

            listeEleve = EleveController.getByInscrptions(inscriptions);
            lbInscrit.DataSource = listeEleve;
            lbInscrit.DisplayMember = "Afficher";
        }

        private void lbCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSeance = (Seance)lbCours.SelectedItem;
            lbInscrit.DataSource = null;
        }

        private void supprimerProfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProf = (Prof)lbProf.SelectedItem;

                ProfController.DeleteProf(selectedProf);

                afficherListeProf();
            }
            catch (Exception)
            {

                string message = "Impossible de supprimer le compte de ce professeur.";
                string title = "Erreur";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            
        }

        private void ajoutProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutProf form1 = new FormAjoutProf();
            form1.ShowDialog();

            afficherListeProf();
        }

        private void afficherListeProf()
        {
            listeProf = ProfController.getAll();
            lbProf.DataSource = listeProf;
            lbProf.DisplayMember = "Afficher";
        }

        private void afficherListeSeance()
        {
            listeSeance = SeanceController.getByIdProf(selectedProf.Id);
            lbCours.DataSource = listeSeance;
            lbCours.DisplayMember = "Afficher";
        }

        private void gestionDesPaimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaiements form2 = new FormPaiements();
            form2.ShowDialog();
        }

        private void modifierDateCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSeance != null)
                {
                    FormModifCours form = new FormModifCours(selectedSeance);
                    form.ShowDialog();

                    afficherListeSeance();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                string message = "Veuillez selectionner un cours à modifier.";
                string title = "Erreur";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedProf = (Prof)lbProf.SelectedItem;
            FormAjoutSeance form3 = new FormAjoutSeance(selectedProf);
            form3.ShowDialog();

            afficherListeSeance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Close();
        }

        private void lbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCours.DataSource = null;
            lbInscrit.DataSource = null;
        }
    }
}
