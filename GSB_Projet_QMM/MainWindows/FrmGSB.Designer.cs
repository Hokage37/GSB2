namespace MainWindows
{
    partial class frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mt_Visiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDeMédicamentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerMédecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déclarerÉchantillonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccueilToolStripMenuItem,
            this.mt_Visiteur,
            this.médicamentToolStripMenuItem,
            this.médecinToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccueilToolStripMenuItem
            // 
            this.AccueilToolStripMenuItem.Name = "AccueilToolStripMenuItem";
            this.AccueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.AccueilToolStripMenuItem.Text = "Accueil";
            this.AccueilToolStripMenuItem.Click += new System.EventHandler(this.AccueilToolStripMenuItem_Click);
            // 
            // mt_Visiteur
            // 
            this.mt_Visiteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeVisiteursToolStripMenuItem,
            this.nouveauVisiteurToolStripMenuItem});
            this.mt_Visiteur.Name = "mt_Visiteur";
            this.mt_Visiteur.Size = new System.Drawing.Size(58, 20);
            this.mt_Visiteur.Text = "Visiteur";
            // 
            // listeVisiteursToolStripMenuItem
            // 
            this.listeVisiteursToolStripMenuItem.Name = "listeVisiteursToolStripMenuItem";
            this.listeVisiteursToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listeVisiteursToolStripMenuItem.Text = "Liste visiteurs";
            this.listeVisiteursToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteursToolStripMenuItem_Click);
            // 
            // nouveauVisiteurToolStripMenuItem
            // 
            this.nouveauVisiteurToolStripMenuItem.Name = "nouveauVisiteurToolStripMenuItem";
            this.nouveauVisiteurToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nouveauVisiteurToolStripMenuItem.Text = "Nouveau Visiteur";
            this.nouveauVisiteurToolStripMenuItem.Click += new System.EventHandler(this.nouveauVisiteurToolStripMenuItem_Click);
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédicamentsToolStripMenuItem,
            this.ajoutDeMédicamentToolStripMenuItem1});
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            // 
            // listeDesMédicamentsToolStripMenuItem
            // 
            this.listeDesMédicamentsToolStripMenuItem.Name = "listeDesMédicamentsToolStripMenuItem";
            this.listeDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listeDesMédicamentsToolStripMenuItem.Text = "Liste des médicaments";
            this.listeDesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédicamentsToolStripMenuItem_Click);
            // 
            // ajoutDeMédicamentToolStripMenuItem1
            // 
            this.ajoutDeMédicamentToolStripMenuItem1.Name = "ajoutDeMédicamentToolStripMenuItem1";
            this.ajoutDeMédicamentToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.ajoutDeMédicamentToolStripMenuItem1.Text = "Ajout de médicament";
            this.ajoutDeMédicamentToolStripMenuItem1.Click += new System.EventHandler(this.ajoutDeMédicamentToolStripMenuItem1_Click);
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédecinsToolStripMenuItem,
            this.créerMédecinToolStripMenuItem});
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.médecinToolStripMenuItem.Text = "Médecin";
            // 
            // listeDesMédecinsToolStripMenuItem
            // 
            this.listeDesMédecinsToolStripMenuItem.Name = "listeDesMédecinsToolStripMenuItem";
            this.listeDesMédecinsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listeDesMédecinsToolStripMenuItem.Text = "Liste des Médecins";
            this.listeDesMédecinsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédecinsToolStripMenuItem_Click);
            // 
            // créerMédecinToolStripMenuItem
            // 
            this.créerMédecinToolStripMenuItem.Name = "créerMédecinToolStripMenuItem";
            this.créerMédecinToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.créerMédecinToolStripMenuItem.Text = "Créer Médecin";
            this.créerMédecinToolStripMenuItem.Click += new System.EventHandler(this.créerMédecinToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeRapportToolStripMenuItem,
            this.créerRapportToolStripMenuItem,
            this.déclarerÉchantillonToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // listeRapportToolStripMenuItem
            // 
            this.listeRapportToolStripMenuItem.Name = "listeRapportToolStripMenuItem";
            this.listeRapportToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listeRapportToolStripMenuItem.Text = "Liste Rapport";
            this.listeRapportToolStripMenuItem.Click += new System.EventHandler(this.listeRapportToolStripMenuItem_Click);
            // 
            // créerRapportToolStripMenuItem
            // 
            this.créerRapportToolStripMenuItem.Name = "créerRapportToolStripMenuItem";
            this.créerRapportToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.créerRapportToolStripMenuItem.Text = "Créer Rapport";
            this.créerRapportToolStripMenuItem.Click += new System.EventHandler(this.créerRapportToolStripMenuItem_Click);
            // 
            // déclarerÉchantillonToolStripMenuItem
            // 
            this.déclarerÉchantillonToolStripMenuItem.Name = "déclarerÉchantillonToolStripMenuItem";
            this.déclarerÉchantillonToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.déclarerÉchantillonToolStripMenuItem.Text = "Déclarer échantillon";
            this.déclarerÉchantillonToolStripMenuItem.Click += new System.EventHandler(this.déclarerÉchantillonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 476);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "GSB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mt_Visiteur;
        private System.Windows.Forms.ToolStripMenuItem médicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeMédicamentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauVisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerMédecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déclarerÉchantillonToolStripMenuItem;
    }
}

