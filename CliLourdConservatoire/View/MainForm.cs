using CliLourdConservatoire.DAL;
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
            List<Inscription> inscriptions = InscriptionDAO.getBySeance(selectedSeance);

            listeEleve = EleveDAO.getByInscrptions(inscriptions);
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
            selectedProf = (Prof)lbProf.SelectedItem;

            ProfDAO.DeleteProf(selectedProf);

            afficherListeProf();
        }

        private void ajoutProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutProf form1 = new FormAjoutProf();
            form1.ShowDialog();

            afficherListeProf();
        }

        private void afficherListeProf()
        {
            listeProf = ProfDAO.getAll();
            lbProf.DataSource = listeProf;
            lbProf.DisplayMember = "Afficher";
        }

        private void afficherListeSeance()
        {
            listeSeance = SeanceDAO.getByIdProf(selectedProf.Id);
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
            FormModifCours form = new FormModifCours(selectedSeance);
            form.ShowDialog();

            afficherListeSeance();
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
