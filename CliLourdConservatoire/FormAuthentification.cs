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

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiant = textBox1.Text;
            string mdp = textBox2.Text;

            bool result = EmployeDAO.Authentifier(identifiant, mdp);

            if (result)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrects!");
            }
        }
    }
}
