using CliLourdConservatoire.Controller;
using CliLourdConservatoire.Model;
using CliLourdConservatoire.View;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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

        /// <summary>
        /// Constructeur du formulaire principal
        /// </summary>
        /// <param name="form"></param>
        public MainForm(FormAuthentification form)
        {

            InitializeComponent();

            //paramétrage de la taille de la fenêtre
            this.Size = new System.Drawing.Size(750, 750);
            
            //affichage de la liste des professeurs
            afficherListeProf();
            //cacher le formulaire d'authentification
            f = form;
            f.Hide();
        }

        /// <summary>
        /// actions après un double clique sur un prof
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbProf_DoubleClick(object sender, EventArgs e)
        {
            selectedProf = (Prof)lbProf.SelectedItem;

            //afficher la liste des séance du professeur séléctionné
            afficherListeSeance();
        }

        /// <summary>
        /// actions après un double clique sur une séance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCours_DoubleClick(object sender, EventArgs e)
        {
            List<Inscription> inscriptions = InscriptionController.getBySeance(selectedSeance);

            //afficher la liste des élèves inscrits au cours séléctionné
            listeEleve = EleveController.getByInscrptions(inscriptions);
            lbInscrit.DataSource = listeEleve;
            lbInscrit.DisplayMember = "Afficher";
        }

        /// <summary>
        /// actions après un clique sur un autre cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSeance = (Seance)lbCours.SelectedItem;
            lbInscrit.DataSource = null;
        }

        /// <summary>
        /// btn supprimer un professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerProfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProf = (Prof)lbProf.SelectedItem;

                //effacer un professeur
                ProfController.DeleteProf(selectedProf);
                //réafficher la liste des profs
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

        /// <summary>
        /// btn ajouter un professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //afficher le formulaire permettant l'insertion d'un nouveau prof
            FormAjoutProf form1 = new FormAjoutProf();
            form1.ShowDialog();

            //réafficher la liste des profs
            afficherListeProf();
        }

        /// <summary>
        /// fonction gérant l'affichage des professeurs
        /// </summary>
        private void afficherListeProf()
        {

            //appel de l'API
            using (WebClient web = new WebClient())
            {

                try
                {

                    string url = string.Format("https://localhost:7213/Prof");
                    var json = web.DownloadString(url);

                    byte[] bytes = Encoding.Default.GetBytes(json);
                    json = Encoding.UTF8.GetString(bytes);

                    listeProf = JsonConvert.DeserializeObject<List<Prof>>(json);

                    lbProf.DataSource = listeProf;
                    lbProf.DisplayMember = "Afficher";


                }
                catch (JsonException execption)
                {

                    execption.GetBaseException();
                }
            }


           
        }

        /// <summary>
        /// fonction gérant l'affichage des séances
        /// </summary>
        private void afficherListeSeance()
        {
            listeSeance = SeanceController.getByIdProf(selectedProf.Id);
            lbCours.DataSource = listeSeance;
            lbCours.DisplayMember = "Afficher";
        }

        /// <summary>
        /// btn ouvrant le formulaire de gestion des paiements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesPaimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaiements form2 = new FormPaiements();
            form2.ShowDialog();
        }

        /// <summary>
        /// btn ouvrant le formulaire de modification d'un cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// btn ouvrant le formulaire d'ajout d'un nouveau cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedProf = (Prof)lbProf.SelectedItem;
            FormAjoutSeance form3 = new FormAjoutSeance(selectedProf);
            form3.ShowDialog();

            afficherListeSeance();
        }

        /// <summary>
        /// btn fermant et arrêtant l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            f.Close();
            System.Windows.Forms.Application.ExitThread();
        }

        /// <summary>
        /// actions après séléction d'un autre professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCours.DataSource = null;
            lbInscrit.DataSource = null;
        }
    }
}
