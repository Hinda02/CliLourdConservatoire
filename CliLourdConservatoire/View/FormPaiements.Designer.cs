namespace CliLourdConservatoire
{
    partial class FormPaiements
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInscription = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValiderT3 = new System.Windows.Forms.Button();
            this.btnValiderT2 = new System.Windows.Forms.Button();
            this.btnValiderT1 = new System.Windows.Forms.Button();
            this.btnPayeT3 = new System.Windows.Forms.Button();
            this.btnPayeT2 = new System.Windows.Forms.Button();
            this.btnPayeT1 = new System.Windows.Forms.Button();
            this.lblDateT3 = new System.Windows.Forms.Label();
            this.lblDateT2 = new System.Windows.Forms.Label();
            this.lblDateT1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbInscription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(89)))), ((int)(((byte)(163)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des inscriptions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(445, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date Inscription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(339, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Séance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(191, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Elève";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Professeur";
            // 
            // lbInscription
            // 
            this.lbInscription.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInscription.FormattingEnabled = true;
            this.lbInscription.ItemHeight = 23;
            this.lbInscription.Location = new System.Drawing.Point(23, 93);
            this.lbInscription.Name = "lbInscription";
            this.lbInscription.Size = new System.Drawing.Size(596, 234);
            this.lbInscription.TabIndex = 0;
            this.lbInscription.SelectedIndexChanged += new System.EventHandler(this.lbInscription_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnValiderT3);
            this.groupBox2.Controls.Add(this.lblDateT2);
            this.groupBox2.Controls.Add(this.btnValiderT2);
            this.groupBox2.Controls.Add(this.lblDateT3);
            this.groupBox2.Controls.Add(this.lblDateT1);
            this.groupBox2.Controls.Add(this.btnValiderT1);
            this.groupBox2.Controls.Add(this.btnPayeT1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPayeT3);
            this.groupBox2.Controls.Add(this.btnPayeT2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(89)))), ((int)(((byte)(163)))));
            this.groupBox2.Location = new System.Drawing.Point(698, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion des paiements";
            // 
            // btnValiderT3
            // 
            this.btnValiderT3.Enabled = false;
            this.btnValiderT3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderT3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnValiderT3.Location = new System.Drawing.Point(297, 268);
            this.btnValiderT3.Name = "btnValiderT3";
            this.btnValiderT3.Size = new System.Drawing.Size(107, 30);
            this.btnValiderT3.TabIndex = 11;
            this.btnValiderT3.Text = "Valider";
            this.btnValiderT3.UseVisualStyleBackColor = true;
            this.btnValiderT3.Click += new System.EventHandler(this.btnValiderT3_Click);
            // 
            // btnValiderT2
            // 
            this.btnValiderT2.Enabled = false;
            this.btnValiderT2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderT2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnValiderT2.Location = new System.Drawing.Point(297, 166);
            this.btnValiderT2.Name = "btnValiderT2";
            this.btnValiderT2.Size = new System.Drawing.Size(107, 30);
            this.btnValiderT2.TabIndex = 10;
            this.btnValiderT2.Text = "Valider";
            this.btnValiderT2.UseVisualStyleBackColor = true;
            this.btnValiderT2.Click += new System.EventHandler(this.btnValiderT2_Click);
            // 
            // btnValiderT1
            // 
            this.btnValiderT1.Enabled = false;
            this.btnValiderT1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderT1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnValiderT1.Location = new System.Drawing.Point(297, 64);
            this.btnValiderT1.Name = "btnValiderT1";
            this.btnValiderT1.Size = new System.Drawing.Size(107, 30);
            this.btnValiderT1.TabIndex = 9;
            this.btnValiderT1.Text = "Valider";
            this.btnValiderT1.UseVisualStyleBackColor = true;
            this.btnValiderT1.Click += new System.EventHandler(this.btnValiderT1_Click);
            // 
            // btnPayeT3
            // 
            this.btnPayeT3.Enabled = false;
            this.btnPayeT3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayeT3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPayeT3.Location = new System.Drawing.Point(162, 266);
            this.btnPayeT3.Name = "btnPayeT3";
            this.btnPayeT3.Size = new System.Drawing.Size(109, 32);
            this.btnPayeT3.TabIndex = 8;
            this.btnPayeT3.Text = "button3";
            this.btnPayeT3.UseVisualStyleBackColor = true;
            // 
            // btnPayeT2
            // 
            this.btnPayeT2.Enabled = false;
            this.btnPayeT2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayeT2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPayeT2.Location = new System.Drawing.Point(162, 163);
            this.btnPayeT2.Name = "btnPayeT2";
            this.btnPayeT2.Size = new System.Drawing.Size(109, 32);
            this.btnPayeT2.TabIndex = 7;
            this.btnPayeT2.Text = "button2";
            this.btnPayeT2.UseVisualStyleBackColor = true;
            // 
            // btnPayeT1
            // 
            this.btnPayeT1.Enabled = false;
            this.btnPayeT1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayeT1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPayeT1.Location = new System.Drawing.Point(162, 62);
            this.btnPayeT1.Name = "btnPayeT1";
            this.btnPayeT1.Size = new System.Drawing.Size(109, 32);
            this.btnPayeT1.TabIndex = 6;
            this.btnPayeT1.Text = "button1";
            this.btnPayeT1.UseVisualStyleBackColor = true;
            // 
            // lblDateT3
            // 
            this.lblDateT3.AutoSize = true;
            this.lblDateT3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateT3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateT3.Location = new System.Drawing.Point(175, 316);
            this.lblDateT3.Name = "lblDateT3";
            this.lblDateT3.Size = new System.Drawing.Size(57, 26);
            this.lblDateT3.TabIndex = 5;
            this.lblDateT3.Text = "label6";
            // 
            // lblDateT2
            // 
            this.lblDateT2.AutoSize = true;
            this.lblDateT2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateT2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateT2.Location = new System.Drawing.Point(175, 211);
            this.lblDateT2.Name = "lblDateT2";
            this.lblDateT2.Size = new System.Drawing.Size(57, 26);
            this.lblDateT2.TabIndex = 4;
            this.lblDateT2.Text = "label5";
            // 
            // lblDateT1
            // 
            this.lblDateT1.AutoSize = true;
            this.lblDateT1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateT1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateT1.Location = new System.Drawing.Point(175, 111);
            this.lblDateT1.Name = "lblDateT1";
            this.lblDateT1.Size = new System.Drawing.Size(57, 26);
            this.lblDateT1.TabIndex = 3;
            this.lblDateT1.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(127)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(20, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trimestre 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(127)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(127)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trimestre 1";
            // 
            // FormPaiements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1159, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPaiements";
            this.Text = "FormPaiements";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbInscription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnValiderT3;
        private System.Windows.Forms.Button btnValiderT2;
        private System.Windows.Forms.Button btnValiderT1;
        private System.Windows.Forms.Button btnPayeT3;
        private System.Windows.Forms.Button btnPayeT2;
        private System.Windows.Forms.Button btnPayeT1;
        private System.Windows.Forms.Label lblDateT3;
        private System.Windows.Forms.Label lblDateT2;
        private System.Windows.Forms.Label lblDateT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}