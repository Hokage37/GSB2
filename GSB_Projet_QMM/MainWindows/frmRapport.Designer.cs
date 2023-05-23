
namespace MainWindows
{
    partial class frmRapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateRapport = new System.Windows.Forms.DateTimePicker();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.colMedicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtAdresseMedecin = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbPrenomM = new System.Windows.Forms.Label();
            this.lbNomM = new System.Windows.Forms.Label();
            this.lb2Medecins = new System.Windows.Forms.Label();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.lbBilan = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMotif = new System.Windows.Forms.Label();
            this.lbPrenomV = new System.Windows.Forms.Label();
            this.lbNomV = new System.Windows.Forms.Label();
            this.lb2Visiteurs = new System.Windows.Forms.Label();
            this.lbRapports = new System.Windows.Forms.Label();
            this.listRapports = new System.Windows.Forms.ListBox();
            this.lbMedecins = new System.Windows.Forms.Label();
            this.lbVisiteurs = new System.Windows.Forms.Label();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Echantillons offerts";
            // 
            // dtDateRapport
            // 
            this.dtDateRapport.Enabled = false;
            this.dtDateRapport.Location = new System.Drawing.Point(145, 123);
            this.dtDateRapport.Name = "dtDateRapport";
            this.dtDateRapport.Size = new System.Drawing.Size(237, 20);
            this.dtDateRapport.TabIndex = 140;
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.BackColor = System.Drawing.SystemColors.Control;
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicament,
            this.colQuantite});
            this.lvMedicaments.Enabled = false;
            this.lvMedicaments.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lvMedicaments.FullRowSelect = true;
            this.lvMedicaments.GridLines = true;
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(145, 197);
            this.lvMedicaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Scrollable = false;
            this.lvMedicaments.Size = new System.Drawing.Size(237, 109);
            this.lvMedicaments.TabIndex = 138;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // colMedicament
            // 
            this.colMedicament.Text = "Médicaments offerts";
            this.colMedicament.Width = 150;
            // 
            // colQuantite
            // 
            this.colQuantite.Text = "Quantité";
            this.colQuantite.Width = 80;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomMedecin.Enabled = false;
            this.txtNomMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNomMedecin.Location = new System.Drawing.Point(472, 34);
            this.txtNomMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtNomMedecin.TabIndex = 137;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenomMedecin.Enabled = false;
            this.txtPrenomMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrenomMedecin.Location = new System.Drawing.Point(472, 76);
            this.txtPrenomMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtPrenomMedecin.TabIndex = 136;
            // 
            // txtAdresseMedecin
            // 
            this.txtAdresseMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdresseMedecin.Enabled = false;
            this.txtAdresseMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdresseMedecin.Location = new System.Drawing.Point(472, 118);
            this.txtAdresseMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresseMedecin.Name = "txtAdresseMedecin";
            this.txtAdresseMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtAdresseMedecin.TabIndex = 135;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbAdresse.Location = new System.Drawing.Point(407, 121);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(58, 18);
            this.lbAdresse.TabIndex = 134;
            this.lbAdresse.Text = "Adresse";
            // 
            // lbPrenomM
            // 
            this.lbPrenomM.AutoSize = true;
            this.lbPrenomM.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbPrenomM.Location = new System.Drawing.Point(407, 80);
            this.lbPrenomM.Name = "lbPrenomM";
            this.lbPrenomM.Size = new System.Drawing.Size(57, 18);
            this.lbPrenomM.TabIndex = 133;
            this.lbPrenomM.Text = "Prénom";
            // 
            // lbNomM
            // 
            this.lbNomM.AutoSize = true;
            this.lbNomM.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbNomM.Location = new System.Drawing.Point(407, 43);
            this.lbNomM.Name = "lbNomM";
            this.lbNomM.Size = new System.Drawing.Size(38, 18);
            this.lbNomM.TabIndex = 132;
            this.lbNomM.Text = "Nom";
            // 
            // lb2Medecins
            // 
            this.lb2Medecins.AutoSize = true;
            this.lb2Medecins.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lb2Medecins.Location = new System.Drawing.Point(384, 4);
            this.lb2Medecins.Name = "lb2Medecins";
            this.lb2Medecins.Size = new System.Drawing.Size(62, 18);
            this.lb2Medecins.TabIndex = 131;
            this.lb2Medecins.Text = "Médecin";
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenomVisiteur.Enabled = false;
            this.txtPrenomVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(145, 58);
            this.txtPrenomVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(237, 25);
            this.txtPrenomVisiteur.TabIndex = 130;
            // 
            // txtMotif
            // 
            this.txtMotif.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotif.Enabled = false;
            this.txtMotif.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(145, 95);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(237, 25);
            this.txtMotif.TabIndex = 129;
            // 
            // txtBilan
            // 
            this.txtBilan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBilan.Enabled = false;
            this.txtBilan.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBilan.Location = new System.Drawing.Point(145, 164);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(237, 25);
            this.txtBilan.TabIndex = 128;
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomVisiteur.Enabled = false;
            this.txtNomVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNomVisiteur.Location = new System.Drawing.Point(141, 20);
            this.txtNomVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(237, 25);
            this.txtNomVisiteur.TabIndex = 127;
            // 
            // lbBilan
            // 
            this.lbBilan.AutoSize = true;
            this.lbBilan.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbBilan.Location = new System.Drawing.Point(24, 164);
            this.lbBilan.Name = "lbBilan";
            this.lbBilan.Size = new System.Drawing.Size(39, 18);
            this.lbBilan.TabIndex = 126;
            this.lbBilan.Text = "Bilan";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbDate.Location = new System.Drawing.Point(24, 127);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(107, 18);
            this.lbDate.TabIndex = 125;
            this.lbDate.Text = "Date de la visite";
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbMotif.Location = new System.Drawing.Point(24, 98);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(111, 18);
            this.lbMotif.TabIndex = 124;
            this.lbMotif.Text = "Motif de la visite";
            // 
            // lbPrenomV
            // 
            this.lbPrenomV.AutoSize = true;
            this.lbPrenomV.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbPrenomV.Location = new System.Drawing.Point(24, 61);
            this.lbPrenomV.Name = "lbPrenomV";
            this.lbPrenomV.Size = new System.Drawing.Size(57, 18);
            this.lbPrenomV.TabIndex = 123;
            this.lbPrenomV.Text = "Prénom";
            // 
            // lbNomV
            // 
            this.lbNomV.AutoSize = true;
            this.lbNomV.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbNomV.Location = new System.Drawing.Point(24, 23);
            this.lbNomV.Name = "lbNomV";
            this.lbNomV.Size = new System.Drawing.Size(38, 18);
            this.lbNomV.TabIndex = 122;
            this.lbNomV.Text = "Nom";
            // 
            // lb2Visiteurs
            // 
            this.lb2Visiteurs.AutoSize = true;
            this.lb2Visiteurs.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lb2Visiteurs.Location = new System.Drawing.Point(6, 4);
            this.lb2Visiteurs.Name = "lb2Visiteurs";
            this.lb2Visiteurs.Size = new System.Drawing.Size(57, 18);
            this.lb2Visiteurs.TabIndex = 121;
            this.lb2Visiteurs.Text = "Visiteur";
            // 
            // lbRapports
            // 
            this.lbRapports.AutoSize = true;
            this.lbRapports.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbRapports.Location = new System.Drawing.Point(400, 9);
            this.lbRapports.Name = "lbRapports";
            this.lbRapports.Size = new System.Drawing.Size(119, 18);
            this.lbRapports.TabIndex = 120;
            this.lbRapports.Text = "Rapports de visite";
            // 
            // listRapports
            // 
            this.listRapports.BackColor = System.Drawing.SystemColors.Control;
            this.listRapports.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.listRapports.FormattingEnabled = true;
            this.listRapports.ItemHeight = 17;
            this.listRapports.Location = new System.Drawing.Point(540, 9);
            this.listRapports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRapports.Name = "listRapports";
            this.listRapports.Size = new System.Drawing.Size(217, 89);
            this.listRapports.TabIndex = 119;
            this.listRapports.SelectedIndexChanged += new System.EventHandler(this.listRapports_SelectedIndexChanged);
            // 
            // lbMedecins
            // 
            this.lbMedecins.AutoSize = true;
            this.lbMedecins.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbMedecins.Location = new System.Drawing.Point(12, 65);
            this.lbMedecins.Name = "lbMedecins";
            this.lbMedecins.Size = new System.Drawing.Size(62, 18);
            this.lbMedecins.TabIndex = 118;
            this.lbMedecins.Text = "Médecin";
            // 
            // lbVisiteurs
            // 
            this.lbVisiteurs.AutoSize = true;
            this.lbVisiteurs.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbVisiteurs.Location = new System.Drawing.Point(12, 13);
            this.lbVisiteurs.Name = "lbVisiteurs";
            this.lbVisiteurs.Size = new System.Drawing.Size(57, 18);
            this.lbVisiteurs.TabIndex = 117;
            this.lbVisiteurs.Text = "Visiteur";
            // 
            // cbMedecin
            // 
            this.cbMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.cbMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(148, 58);
            this.cbMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(217, 25);
            this.cbMedecin.TabIndex = 114;
            this.cbMedecin.SelectedIndexChanged += new System.EventHandler(this.cbMedecin_SelectedIndexChanged);
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.cbVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(148, 9);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(217, 25);
            this.cbVisiteur.TabIndex = 113;
            this.cbVisiteur.SelectedIndexChanged += new System.EventHandler(this.cbVisiteur_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomVisiteur);
            this.groupBox1.Controls.Add(this.lb2Visiteurs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbNomV);
            this.groupBox1.Controls.Add(this.dtDateRapport);
            this.groupBox1.Controls.Add(this.lbPrenomV);
            this.groupBox1.Controls.Add(this.lvMedicaments);
            this.groupBox1.Controls.Add(this.lbMotif);
            this.groupBox1.Controls.Add(this.txtNomMedecin);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.txtPrenomMedecin);
            this.groupBox1.Controls.Add(this.lbBilan);
            this.groupBox1.Controls.Add(this.txtAdresseMedecin);
            this.groupBox1.Controls.Add(this.txtBilan);
            this.groupBox1.Controls.Add(this.lbAdresse);
            this.groupBox1.Controls.Add(this.txtMotif);
            this.groupBox1.Controls.Add(this.lbPrenomM);
            this.groupBox1.Controls.Add(this.txtPrenomVisiteur);
            this.groupBox1.Controls.Add(this.lbNomM);
            this.groupBox1.Controls.Add(this.lb2Medecins);
            this.groupBox1.Location = new System.Drawing.Point(24, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 329);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            // 
            // frmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRapports);
            this.Controls.Add(this.listRapports);
            this.Controls.Add(this.lbMedecins);
            this.Controls.Add(this.lbVisiteurs);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.cbVisiteur);
            this.Name = "frmRapport";
            this.Text = "frmRapport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateRapport;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.ColumnHeader colMedicament;
        private System.Windows.Forms.ColumnHeader colQuantite;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtAdresseMedecin;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbPrenomM;
        private System.Windows.Forms.Label lbNomM;
        private System.Windows.Forms.Label lb2Medecins;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.Label lbBilan;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.Label lbPrenomV;
        private System.Windows.Forms.Label lbNomV;
        private System.Windows.Forms.Label lb2Visiteurs;
        private System.Windows.Forms.Label lbRapports;
        private System.Windows.Forms.ListBox listRapports;
        private System.Windows.Forms.Label lbMedecins;
        private System.Windows.Forms.Label lbVisiteurs;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}