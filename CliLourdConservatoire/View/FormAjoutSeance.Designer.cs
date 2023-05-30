namespace CliLourdConservatoire.View
{
    partial class FormAjoutSeance
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
            this.btnAjout = new System.Windows.Forms.Button();
            this.cbJour = new System.Windows.Forms.ComboBox();
            this.tbNumS = new System.Windows.Forms.TextBox();
            this.tbCapacite = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMatiere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProf = new System.Windows.Forms.TextBox();
            this.cbTranche = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radNiv1 = new System.Windows.Forms.RadioButton();
            this.radNiv2 = new System.Windows.Forms.RadioButton();
            this.radNiv3 = new System.Windows.Forms.RadioButton();
            this.radNiv4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(62)))));
            this.btnAjout.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjout.Location = new System.Drawing.Point(196, 537);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(135, 42);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // cbJour
            // 
            this.cbJour.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJour.FormattingEnabled = true;
            this.cbJour.Location = new System.Drawing.Point(52, 275);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(406, 31);
            this.cbJour.TabIndex = 3;
            this.cbJour.SelectedIndexChanged += new System.EventHandler(this.cbJour_SelectedIndexChanged);
            // 
            // tbNumS
            // 
            this.tbNumS.Enabled = false;
            this.tbNumS.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumS.Location = new System.Drawing.Point(52, 210);
            this.tbNumS.Name = "tbNumS";
            this.tbNumS.Size = new System.Drawing.Size(406, 29);
            this.tbNumS.TabIndex = 4;
            // 
            // tbCapacite
            // 
            this.tbCapacite.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCapacite.Location = new System.Drawing.Point(52, 470);
            this.tbCapacite.Name = "tbCapacite";
            this.tbCapacite.Size = new System.Drawing.Size(406, 29);
            this.tbCapacite.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.radNiv4);
            this.groupBox1.Controls.Add(this.radNiv3);
            this.groupBox1.Controls.Add(this.radNiv2);
            this.groupBox1.Controls.Add(this.radNiv1);
            this.groupBox1.Controls.Add(this.tbMatiere);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbProf);
            this.groupBox1.Controls.Add(this.cbTranche);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCapacite);
            this.groupBox1.Controls.Add(this.btnAjout);
            this.groupBox1.Controls.Add(this.tbNumS);
            this.groupBox1.Controls.Add(this.cbJour);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(89)))), ((int)(((byte)(186)))));
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 618);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout Séance";
            // 
            // tbMatiere
            // 
            this.tbMatiere.Enabled = false;
            this.tbMatiere.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatiere.Location = new System.Drawing.Point(52, 87);
            this.tbMatiere.Name = "tbMatiere";
            this.tbMatiere.Size = new System.Drawing.Size(406, 29);
            this.tbMatiere.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(48, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Professeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(47, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacité";
            // 
            // tbProf
            // 
            this.tbProf.Enabled = false;
            this.tbProf.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProf.Location = new System.Drawing.Point(52, 150);
            this.tbProf.Name = "tbProf";
            this.tbProf.Size = new System.Drawing.Size(406, 29);
            this.tbProf.TabIndex = 12;
            // 
            // cbTranche
            // 
            this.cbTranche.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTranche.FormattingEnabled = true;
            this.cbTranche.Location = new System.Drawing.Point(52, 337);
            this.cbTranche.Name = "cbTranche";
            this.cbTranche.Size = new System.Drawing.Size(406, 31);
            this.cbTranche.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(47, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(47, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(47, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tranche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numéro Séance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matière";
            // 
            // radNiv1
            // 
            this.radNiv1.AutoSize = true;
            this.radNiv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radNiv1.Location = new System.Drawing.Point(53, 403);
            this.radNiv1.Name = "radNiv1";
            this.radNiv1.Size = new System.Drawing.Size(51, 37);
            this.radNiv1.TabIndex = 16;
            this.radNiv1.TabStop = true;
            this.radNiv1.Text = "1";
            this.radNiv1.UseVisualStyleBackColor = true;
            // 
            // radNiv2
            // 
            this.radNiv2.AutoSize = true;
            this.radNiv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radNiv2.Location = new System.Drawing.Point(174, 403);
            this.radNiv2.Name = "radNiv2";
            this.radNiv2.Size = new System.Drawing.Size(51, 37);
            this.radNiv2.TabIndex = 17;
            this.radNiv2.TabStop = true;
            this.radNiv2.Text = "2";
            this.radNiv2.UseVisualStyleBackColor = true;
            // 
            // radNiv3
            // 
            this.radNiv3.AutoSize = true;
            this.radNiv3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radNiv3.Location = new System.Drawing.Point(291, 403);
            this.radNiv3.Name = "radNiv3";
            this.radNiv3.Size = new System.Drawing.Size(51, 37);
            this.radNiv3.TabIndex = 18;
            this.radNiv3.TabStop = true;
            this.radNiv3.Text = "3";
            this.radNiv3.UseVisualStyleBackColor = true;
            // 
            // radNiv4
            // 
            this.radNiv4.AutoSize = true;
            this.radNiv4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radNiv4.Location = new System.Drawing.Point(407, 403);
            this.radNiv4.Name = "radNiv4";
            this.radNiv4.Size = new System.Drawing.Size(51, 37);
            this.radNiv4.TabIndex = 19;
            this.radNiv4.TabStop = true;
            this.radNiv4.Text = "4";
            this.radNiv4.UseVisualStyleBackColor = true;
            // 
            // FormAjoutSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(587, 676);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjoutSeance";
            this.Text = "FormAjoutSeance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.TextBox tbNumS;
        private System.Windows.Forms.TextBox tbCapacite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTranche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMatiere;
        private System.Windows.Forms.RadioButton radNiv4;
        private System.Windows.Forms.RadioButton radNiv3;
        private System.Windows.Forms.RadioButton radNiv2;
        private System.Windows.Forms.RadioButton radNiv1;
    }
}