using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CliLourdConservatoire
{
    public partial class FormPaiements : Form
    {
        private List<Inscription> listeGetAll;
        private List<Inscription> listeGetAllAffichage;
        private Inscription selectedInscription;

        private Payer paieT1;
        private Payer paieT2;
        private Payer paieT3;

        private Trimestre trimestre1;
        private Trimestre trimestre2;
        private Trimestre trimestre3;
        public FormPaiements()
        {
            InitializeComponent();
            this.Size = new Size(900, 400);

            trimestre1 = TrimestreDAO.getByTrimestre("trimestre1");
            trimestre2 = TrimestreDAO.getByTrimestre("trimestre2");
            trimestre3 = TrimestreDAO.getByTrimestre("trimestre3");

            listeGetAll = InscriptionDAO.getAll();
            listeGetAllAffichage = InscriptionDAO.getAllAffichage();
            lbInscription.DataSource = listeGetAllAffichage;
            lbInscription.DisplayMember = "Afficher";

        }
        
        private void lbInscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbInscription.SelectedIndex;
            selectedInscription = listeGetAll[index];

            paieT1 = PayerDAO.getByInscription_Trimestre(selectedInscription, "trimestre1");
            paieT2 = PayerDAO.getByInscription_Trimestre(selectedInscription, "trimestre2");
            paieT3 = PayerDAO.getByInscription_Trimestre(selectedInscription, "trimestre3");

            if (paieT1.DatePaiement.Year != 0001)
            {
                btnPayeT1.BackColor = Color.Green;
                btnPayeT1.ForeColor = Color.DarkGreen;
                btnPayeT1.Text = "payé";
                lblDateT1.Text = paieT1.DatePaiement.ToString("dd/MM/yyyy");

                btnValiderT1.Enabled = false;
            }
            else
            {
                btnPayeT1.BackColor = Color.Red;
                btnPayeT1.ForeColor = Color.DarkRed;
                btnPayeT1.Text = "pas payé";
                lblDateT1.Text = "";

                btnValiderT1.Enabled = true;
            }

            if (paieT2.DatePaiement.Year != 0001)
            {
                btnPayeT2.BackColor = Color.Green;
                btnPayeT2.ForeColor = Color.DarkGreen;
                btnPayeT2.Text = "payé";
                lblDateT2.Text = paieT2.DatePaiement.ToString("dd/MM/yyyy");

                btnValiderT2.Enabled = false;
            }
            else
            {
                btnPayeT2.BackColor = Color.Red;
                btnPayeT2.ForeColor = Color.DarkRed;
                btnPayeT2.Text = "pas payé";
                lblDateT2.Text = "";

                btnValiderT2.Enabled = true;
            }

            if (paieT3.DatePaiement.Year != 0001)
            {
                btnPayeT3.BackColor = Color.Green;
                btnPayeT3.ForeColor = Color.DarkGreen;
                btnPayeT3.Text = "payé";
                lblDateT3.Text = paieT3.DatePaiement.ToString("dd/MM/yyyy");

                btnValiderT3.Enabled = false;
            }
            else
            {
                btnPayeT3.BackColor = Color.Red;
                btnPayeT3.ForeColor = Color.DarkRed;
                btnPayeT3.Text = "pas payé";
                lblDateT3.Text = "";

                btnValiderT3.Enabled = true;
            }
        }

        private void btnValiderT1_Click(object sender, EventArgs e)
        {
            bool res = Trimestre.compareDates(trimestre1.DateFin);

            if (res)
            {
                PayerDAO.updateDatePaiement(paieT1);
            }
            else
            {
                MessageBox.Show("Impossible de valider ce paiement. \nLa date butoire a été dépassée.", "Attention", MessageBoxButtons.OK);
            }

            int index = lbInscription.SelectedIndex;
            lbInscription.SetSelected(index, true);
        }

        private void btnValiderT2_Click(object sender, EventArgs e)
        {
            bool res = Trimestre.compareDates(trimestre2.DateFin);

            if (res)
            {
                PayerDAO.updateDatePaiement(paieT2);
            }
            else
            {
                MessageBox.Show("Impossible de valider ce paiement. \nLa date butoire a été dépassée.", "Attention", MessageBoxButtons.OK);
            }

            int index = lbInscription.SelectedIndex;
            lbInscription.SetSelected(index, true);
        }

        private void btnValiderT3_Click(object sender, EventArgs e)
        {
            bool res = Trimestre.compareDates(trimestre3.DateFin);

            if (res)
            {
                PayerDAO.updateDatePaiement(paieT3);
            }
            else
            {
                MessageBox.Show("Impossible de valider ce paiement. \nLa date butoire a été dépassée.", "Attention", MessageBoxButtons.OK);
            }

            int index = lbInscription.SelectedIndex;
            lbInscription.SetSelected(index, true);
        }

        /*public bool compareDates(DateTime d1)
        {
            bool result;

            DateTime date1 = DateTime.Now;
            int lastyear = date1.Year - 1;
            string date = d1.ToString("MM-dd");

            if(d1.Month > 5 && date1.Month < 6)
            {
                date = date + "-" + lastyear;
            }

            DateTime date2 = Convert.ToDateTime(date);

            int res = DateTime.Compare(date1, date2);

            if (res <= 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }*/
    }
}
