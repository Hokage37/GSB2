
namespace MainWindows
{
    partial class frmMedecin
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgvMedecins = new System.Windows.Forms.DataGridView();
            this.txbSpecia = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label8.Location = new System.Drawing.Point(405, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 121;
            this.label8.Text = "Département";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label7.Location = new System.Drawing.Point(51, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 120;
            this.label7.Text = "Specialite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label6.Location = new System.Drawing.Point(405, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 119;
            this.label6.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label5.Location = new System.Drawing.Point(54, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 118;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label4.Location = new System.Drawing.Point(5, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label3.Location = new System.Drawing.Point(401, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "Prénom";
            // 
            // txtDepartement
            // 
            this.txtDepartement.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartement.Enabled = false;
            this.txtDepartement.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDepartement.Location = new System.Drawing.Point(511, 367);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(145, 25);
            this.txtDepartement.TabIndex = 113;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTel.Location = new System.Drawing.Point(511, 312);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(183, 25);
            this.txtTel.TabIndex = 112;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdresse.Enabled = false;
            this.txtAdresse.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdresse.Location = new System.Drawing.Point(143, 317);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(230, 25);
            this.txtAdresse.TabIndex = 111;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrenom.Location = new System.Drawing.Point(479, 255);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(304, 25);
            this.txtPrenom.TabIndex = 110;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNom.Location = new System.Drawing.Point(69, 257);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(304, 25);
            this.txtNom.TabIndex = 109;
            // 
            // dgvMedecins
            // 
            this.dgvMedecins.AllowUserToAddRows = false;
            this.dgvMedecins.AllowUserToDeleteRows = false;
            this.dgvMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom,
            this.Prénom,
            this.Specialite,
            this.adresse,
            this.Tel,
            this.Departement});
            this.dgvMedecins.Location = new System.Drawing.Point(29, 62);
            this.dgvMedecins.Name = "dgvMedecins";
            this.dgvMedecins.ReadOnly = true;
            this.dgvMedecins.Size = new System.Drawing.Size(744, 139);
            this.dgvMedecins.TabIndex = 107;
            this.dgvMedecins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMedecins_MouseClick);
            // 
            // txbSpecia
            // 
            this.txbSpecia.BackColor = System.Drawing.SystemColors.Control;
            this.txbSpecia.Enabled = false;
            this.txbSpecia.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txbSpecia.Location = new System.Drawing.Point(143, 358);
            this.txbSpecia.Name = "txbSpecia";
            this.txbSpecia.Size = new System.Drawing.Size(230, 25);
            this.txbSpecia.TabIndex = 122;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            // 
            // Specialite
            // 
            this.Specialite.HeaderText = "Spécialité";
            this.Specialite.Name = "Specialite";
            this.Specialite.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Téléphone";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Departement
            // 
            this.Departement.HeaderText = "Département";
            this.Departement.Name = "Departement";
            this.Departement.ReadOnly = true;
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txbSpecia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvMedecins);
            this.Name = "frmMedecin";
            this.Text = "frmMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgvMedecins;
        private System.Windows.Forms.TextBox txbSpecia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departement;
    }
}