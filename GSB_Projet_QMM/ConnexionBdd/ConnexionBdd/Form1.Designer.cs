namespace ConnexionBdd
{
    partial class FormCnxBdd
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelHost = new System.Windows.Forms.Label();
            this.labelNomBdd = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.labelListPers = new System.Windows.Forms.Label();
            this.tableauPers = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.NomInput = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.PrenomInput = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauPers)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(43, 53);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(61, 13);
            this.LabelHost.TabIndex = 0;
            this.LabelHost.Text = "IP serveur :";
            // 
            // labelNomBdd
            // 
            this.labelNomBdd.AutoSize = true;
            this.labelNomBdd.Location = new System.Drawing.Point(235, 53);
            this.labelNomBdd.Name = "labelNomBdd";
            this.labelNomBdd.Size = new System.Drawing.Size(140, 13);
            this.labelNomBdd.TabIndex = 1;
            this.labelNomBdd.Text = "Nom de la base de données";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(43, 189);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Identifiant";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(238, 189);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 3;
            this.labelMdp.Text = "Mot de passe";
            this.labelMdp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(46, 82);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(109, 20);
            this.txtHost.TabIndex = 4;
            this.txtHost.Text = "localhost";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(238, 82);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(137, 20);
            this.txtDB.TabIndex = 5;
            this.txtDB.Text = "gsb_p2";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(46, 218);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 20);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "root";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(238, 218);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(137, 20);
            this.txtMDP.TabIndex = 7;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(163, 295);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(75, 23);
            this.btnConnecter.TabIndex = 8;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // labelListPers
            // 
            this.labelListPers.AutoSize = true;
            this.labelListPers.Location = new System.Drawing.Point(43, 378);
            this.labelListPers.Name = "labelListPers";
            this.labelListPers.Size = new System.Drawing.Size(95, 13);
            this.labelListPers.TabIndex = 9;
            this.labelListPers.Text = "List des personnes";
            // 
            // tableauPers
            // 
            this.tableauPers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom});
            this.tableauPers.Location = new System.Drawing.Point(46, 403);
            this.tableauPers.Name = "tableauPers";
            this.tableauPers.Size = new System.Drawing.Size(240, 150);
            this.tableauPers.TabIndex = 0;
            this.tableauPers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauPers_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "Column1";
            this.nom.Name = "nom";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(142, 337);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 10;
            // 
            // NomInput
            // 
            this.NomInput.Location = new System.Drawing.Point(317, 432);
            this.NomInput.Name = "NomInput";
            this.NomInput.Size = new System.Drawing.Size(109, 20);
            this.NomInput.TabIndex = 12;
            this.NomInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(314, 403);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 11;
            this.labelNom.Text = "Nom :";
            this.labelNom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PrenomInput
            // 
            this.PrenomInput.Location = new System.Drawing.Point(490, 432);
            this.PrenomInput.Name = "PrenomInput";
            this.PrenomInput.Size = new System.Drawing.Size(109, 20);
            this.PrenomInput.TabIndex = 14;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(487, 403);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prenom :";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(429, 489);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormCnxBdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 655);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrenomInput);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.NomInput);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.tableauPers);
            this.Controls.Add(this.labelListPers);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNomBdd);
            this.Controls.Add(this.LabelHost);
            this.Name = "FormCnxBdd";
            this.Text = "Connexion à la base de données";
            ((System.ComponentModel.ISupportInitialize)(this.tableauPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.Label labelNomBdd;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label labelListPers;
        private System.Windows.Forms.DataGridView tableauPers;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.TextBox NomInput;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox PrenomInput;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Button AddButton;
    }
}

