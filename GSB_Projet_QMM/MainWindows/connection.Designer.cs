namespace MainWindows
{
    partial class connection
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
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNomBdd = new System.Windows.Forms.Label();
            this.LabelHost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(251, 295);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(285, 126);
            this.btnConnecter.TabIndex = 17;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click_1);
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(485, 205);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(137, 20);
            this.txtMDP.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 205);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 20);
            this.txtID.TabIndex = 15;
            this.txtID.Text = "root";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(485, 56);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(137, 20);
            this.txtDB.TabIndex = 14;
            this.txtDB.Text = "gsb_p2";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(182, 56);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(109, 20);
            this.txtHost.TabIndex = 13;
            this.txtHost.Text = "localhost";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(482, 175);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 12;
            this.labelMdp.Text = "Mot de passe";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(179, 175);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "Identifiant";
            // 
            // labelNomBdd
            // 
            this.labelNomBdd.AutoSize = true;
            this.labelNomBdd.Location = new System.Drawing.Point(482, 29);
            this.labelNomBdd.Name = "labelNomBdd";
            this.labelNomBdd.Size = new System.Drawing.Size(140, 13);
            this.labelNomBdd.TabIndex = 10;
            this.labelNomBdd.Text = "Nom de la base de données";
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(179, 40);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(61, 13);
            this.LabelHost.TabIndex = 9;
            this.LabelHost.Text = "IP serveur :";
            // 
            // connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNomBdd);
            this.Controls.Add(this.LabelHost);
            this.Name = "connection";
            this.Text = "connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNomBdd;
        private System.Windows.Forms.Label LabelHost;
    }
}