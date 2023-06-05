using CliLourdConservatoire.Controller;
using CliLourdConservatoire.Model;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CliLourdConservatoire
{
    public partial class FormAjoutProf : Form
    {
        List<Instrument> instrumentList;
        /// <summary>
        /// Constructeur du formulaire d'ajout d'un professeur
        /// </summary>
        public FormAjoutProf()
        {
            InitializeComponent();

            instrumentList = InstrumentController.getAll();
            cbMatiere.DataSource = instrumentList;
            cbMatiere.DisplayMember = "Libelle";

        }

        /// <summary>
        /// btn abandonner fermant le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbandonner_Click(object sender, EventArgs e)
        {   

            DialogResult result = MessageBox.Show("Voulez vous abandonner?", "Alerte", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        /// <summary>
        /// btn permettant de valider l'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbNom.Text;
                string prenom = tbPrenom.Text;
                string tel = tbTel.Text;
                string mail = tbMail.Text;
                string adresse = tbAdresse.Text;
                string instrument = cbMatiere.Text;
                double salaire = Convert.ToDouble(tbSalaire.Text);
                string identifiant = tbLogin.Text;
                string password = tbMdp.Text;

                Prof p = new Prof(nom, prenom, tel, mail, adresse, instrument, salaire, identifiant, password);

                ProfController.InsertProf(p);

                this.Close();
            }
            catch (Exception)
            {

                string message = "Veuillez remplir tous les champs et au bon format.";
                string title = "Erreur";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
