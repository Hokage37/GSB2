
namespace MainWindows
{
    partial class frmAddRapport
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
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.dtDateRapport = new System.Windows.Forms.DateTimePicker();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMotif
            // 
            this.txtMotif.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotif.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(149, 203);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(228, 25);
            this.txtMotif.TabIndex = 122;
            // 
            // dtDateRapport
            // 
            this.dtDateRapport.Location = new System.Drawing.Point(140, 163);
            this.dtDateRapport.Name = "dtDateRapport";
            this.dtDateRapport.Size = new System.Drawing.Size(219, 20);
            this.dtDateRapport.TabIndex = 121;
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(528, 125);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(238, 21);
            this.cbVisiteur.TabIndex = 110;
            // 
            // cbMedecin
            // 
            this.cbMedecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(140, 124);
            this.cbMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(237, 21);
            this.cbMedecin.TabIndex = 109;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(217, 389);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(304, 39);
            this.btEnregistrer.TabIndex = 117;
            this.btEnregistrer.Text = "Enregistrer le nouveau compte-rendu";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 116;
            this.label9.Text = "Motif de la visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 115;
            this.label8.Text = "Bilan";
            // 
            // txtBilan
            // 
            this.txtBilan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBilan.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBilan.Location = new System.Drawing.Point(431, 164);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBilan.MaxLength = 255;
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(335, 99);
            this.txtBilan.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "Date de visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Nom du visiteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 112;
            this.label4.Text = "Praticien visité";
            // 
            // frmAddRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.dtDateRapport);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frmAddRapport";
            this.Text = "frmAddRapport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.DateTimePicker dtDateRapport;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}