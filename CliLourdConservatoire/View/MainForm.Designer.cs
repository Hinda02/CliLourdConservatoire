namespace CliLourdConservatoire
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProf = new System.Windows.Forms.ListBox();
            this.lbCours = new System.Windows.Forms.ListBox();
            this.lbInscrit = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerProfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierDateCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gestionDesPaimentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProf
            // 
            this.lbProf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbProf.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProf.FormattingEnabled = true;
            this.lbProf.ItemHeight = 23;
            this.lbProf.Location = new System.Drawing.Point(53, 144);
            this.lbProf.Name = "lbProf";
            this.lbProf.Size = new System.Drawing.Size(831, 188);
            this.lbProf.TabIndex = 0;
            this.lbProf.DoubleClick += new System.EventHandler(this.lbProf_DoubleClick);
            // 
            // lbCours
            // 
            this.lbCours.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbCours.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCours.FormattingEnabled = true;
            this.lbCours.ItemHeight = 23;
            this.lbCours.Location = new System.Drawing.Point(53, 457);
            this.lbCours.Name = "lbCours";
            this.lbCours.Size = new System.Drawing.Size(830, 165);
            this.lbCours.TabIndex = 10;
            this.lbCours.SelectedIndexChanged += new System.EventHandler(this.lbCours_SelectedIndexChanged);
            this.lbCours.DoubleClick += new System.EventHandler(this.lbCours_DoubleClick);
            // 
            // lbInscrit
            // 
            this.lbInscrit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbInscrit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInscrit.FormattingEnabled = true;
            this.lbInscrit.ItemHeight = 23;
            this.lbInscrit.Location = new System.Drawing.Point(53, 745);
            this.lbInscrit.Name = "lbInscrit";
            this.lbInscrit.Size = new System.Drawing.Size(820, 165);
            this.lbInscrit.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutProfesseurToolStripMenuItem,
            this.supprimerProfToolStripMenuItem,
            this.modifierDateCoursToolStripMenuItem,
            this.gestionDesPaimentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 34);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutProfesseurToolStripMenuItem
            // 
            this.ajoutProfesseurToolStripMenuItem.Name = "ajoutProfesseurToolStripMenuItem";
            this.ajoutProfesseurToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ajoutProfesseurToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ajoutProfesseurToolStripMenuItem.Text = "Ajouter un professeur";
            this.ajoutProfesseurToolStripMenuItem.Click += new System.EventHandler(this.ajoutProfesseurToolStripMenuItem_Click);
            // 
            // supprimerProfToolStripMenuItem
            // 
            this.supprimerProfToolStripMenuItem.Name = "supprimerProfToolStripMenuItem";
            this.supprimerProfToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.supprimerProfToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.supprimerProfToolStripMenuItem.Text = "Supprimer un professeur";
            this.supprimerProfToolStripMenuItem.Click += new System.EventHandler(this.supprimerProfToolStripMenuItem_Click);
            // 
            // modifierDateCoursToolStripMenuItem
            // 
            this.modifierDateCoursToolStripMenuItem.Name = "modifierDateCoursToolStripMenuItem";
            this.modifierDateCoursToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.modifierDateCoursToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.modifierDateCoursToolStripMenuItem.Text = "Modifier Date Cours";
            this.modifierDateCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierDateCoursToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste des professeurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(49, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Liste des cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(49, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Liste des inscrits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Matière";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Professeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Numéro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tranche";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Niveau";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Capacité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 726);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Id inscrit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 726);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Inscrit";
            // 
            // gestionDesPaimentsToolStripMenuItem
            // 
            this.gestionDesPaimentsToolStripMenuItem.Name = "gestionDesPaimentsToolStripMenuItem";
            this.gestionDesPaimentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.gestionDesPaimentsToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
            this.gestionDesPaimentsToolStripMenuItem.Text = "Paiements";
            this.gestionDesPaimentsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPaimentsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 948);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInscrit);
            this.Controls.Add(this.lbCours);
            this.Controls.Add(this.lbProf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProf;
        private System.Windows.Forms.ListBox lbCours;
        private System.Windows.Forms.ListBox lbInscrit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajoutProfesseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerProfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierDateCoursToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPaimentsToolStripMenuItem;
    }
}

