using CliLourdConservatoire.DAL;
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
        public FormAjoutProf()
        {
            InitializeComponent();

            instrumentList = InstrumentDAO.getAll();
            cbMatiere.DataSource = instrumentList;
            cbMatiere.DisplayMember = "Libelle";

        }

        private void btnAbandonner_Click(object sender, EventArgs e)
        {   

            DialogResult result = MessageBox.Show("Voulez vous abandonner?", "Alerte", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string prenom = tbPrenom.Text;
            string tel = tbTel.Text;
            string mail = tbMail.Text;
            string adresse = tbAdresse.Text;
            string instrument = cbMatiere.Text;
            double salaire = Convert.ToDouble(tbSalaire.Text);
            string login = tbLogin.Text;
            string mdp = tbMdp.Text;

            Prof p = new Prof(nom, prenom, tel, mail, adresse, instrument, salaire, login, mdp);

            ProfDAO.InsertProf(p);

            this.Close();
        }

        
    }
}
