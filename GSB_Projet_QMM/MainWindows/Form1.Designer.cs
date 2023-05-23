namespace ConnexionBdd
{
    partial class FrmCnxBdd
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
            this.SuspendLayout();
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(123, 162);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(61, 13);
            this.LabelHost.TabIndex = 0;
            this.LabelHost.Text = "IP serveur :";
            this.LabelHost.Click += new System.EventHandler(this.LabelHost_Click);
            // 
            // labelNomBdd
            // 
            this.labelNomBdd.AutoSize = true;
            this.labelNomBdd.Location = new System.Drawing.Point(426, 151);
            this.labelNomBdd.Name = "labelNomBdd";
            this.labelNomBdd.Size = new System.Drawing.Size(140, 13);
            this.labelNomBdd.TabIndex = 1;
            this.labelNomBdd.Text = "Nom de la base de données";
            this.labelNomBdd.Click += new System.EventHandler(this.labelNomBdd_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(123, 297);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Identifiant";
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(426, 297);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 3;
            this.labelMdp.Text = "Mot de passe";
            this.labelMdp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(126, 178);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(109, 20);
            this.txtHost.TabIndex = 4;
            this.txtHost.Text = "localhost";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(429, 178);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(137, 20);
            this.txtDB.TabIndex = 5;
            this.txtDB.Text = "gsb_p2";
            this.txtDB.TextChanged += new System.EventHandler(this.txtDB_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 327);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 20);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "root";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(429, 327);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(137, 20);
            this.txtMDP.TabIndex = 7;
            this.txtMDP.TextChanged += new System.EventHandler(this.txtMDP_TextChanged);
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(195, 417);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(285, 126);
            this.btnConnecter.TabIndex = 8;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // FrmCnxBdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 655);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNomBdd);
            this.Controls.Add(this.LabelHost);
            this.Name = "FrmCnxBdd";
            this.Text = "Connexion à la base de données";
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
    }
}

