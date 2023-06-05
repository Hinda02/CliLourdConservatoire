using CliLourdConservatoire.Controller;
using Mysqlx.Notice;
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
    public partial class FormAuthentification : Form
    {
        /// <summary>
        /// Constructeur du formulaire d'authentification
        /// </summary>
        public FormAuthentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton appelant la méthode de gestion d'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuthentification_Click(object sender, EventArgs e)
        {
            string identifiant = tbLogin.Text;
            string mdp = tbPassword.Text;

            try
            {
                bool result = EmployeController.Authentifier(identifiant, mdp);

                if (result)
                {
                    MainForm form = new MainForm(this);
                    form.ShowDialog();
                }
                else
                {
                    string message = "Login ou mot de passe incorrect";
                    string title = "Message d'erreur";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                    tbLogin.Clear();
                    tbPassword.Clear();

                }

            }
            catch (Exception)
            {
                string message = "Erreur de traitement de votre saisie.";
                string title = "Message d'erreur";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                tbLogin.Clear();
                tbPassword.Clear();

            }

        }

    }
}
