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
            comboBox1.DataSource = JoursDAO.getAll();
            comboBox1.DisplayMember = "Jour";
            comboBox1.Text = s.Jour;

            comboBox2.DataSource = HeureDAO.getBySeance(s);
            comboBox2.DisplayMember = "Tranche";
            comboBox2.Text = s.Tranche;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Jour = comboBox1.Text;
            s.Tranche = comboBox2.Text;

            SeanceDAO.updateSeance(s);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = HeureDAO.getByJour_Id(comboBox1.Text, s.IdProf);
            comboBox2.DisplayMember = "Tranche";
            comboBox2.Text = s.Tranche;
        }
    }
}
