using CliLourdConservatoire.DAL;
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
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void btnAuthentification_Click(object sender, EventArgs e)
        {
            string identifiant = tbLogin.Text;
            string mdp = tbPassword.Text;

            bool result = EmployeDAO.Authentifier(identifiant, mdp);

            if (result)
            {
                Form1 form = new Form1();
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
    }
}
