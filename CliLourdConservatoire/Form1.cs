﻿using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
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
    public partial class Form1 : Form
    {
        private List<Prof> listeProf;
        private List<Seance> listeSeance;
        private List<Eleve> listeEleve;
        private Prof selectedProf;
        private Seance selectedSeance;
        public Form1()
        {
            InitializeComponent();

            listeProf = ProfDAO.getAll();

            listBox1.DataSource = listeProf;
            listBox1.DisplayMember = "Email";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            string tel = textBox3.Text;
            string mail = textBox4.Text;
            string adresse = textBox5.Text;
            string instrument = textBox6.Text;
            double salaire = Convert.ToDouble(textBox7.Text);

            Prof p = new Prof(nom, prenom, tel, mail, adresse, instrument, salaire);

            ProfDAO.InsertProf(p);

            listeProf = ProfDAO.getAll();

            listBox1.DataSource = listeProf;
            listBox1.DisplayMember = "Email";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedProf = (Prof)listBox1.SelectedItem;

            ProfDAO.DeleteProf(selectedProf);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            selectedProf = (Prof)listBox1.SelectedItem;

            listeSeance = SeanceDAO.getByIdProf(selectedProf.Id);

            listBox2.DataSource = listeSeance;
            listBox2.DisplayMember = "Tranche";
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            List<Inscription> inscriptions = InscriptionDAO.getBySeance(selectedSeance);

            listeEleve = EleveDAO.getByInscrptions(inscriptions);
            listBox3.DataSource = listeEleve;
            listBox3.DisplayMember ="Email";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModifCours form = new FormModifCours(selectedSeance);
            form.ShowDialog();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSeance = (Seance)listBox2.SelectedItem;
        }
    }
}
