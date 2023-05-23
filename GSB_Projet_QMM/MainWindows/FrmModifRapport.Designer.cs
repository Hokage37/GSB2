
namespace MainWindows
{
    partial class FrmModifRapport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.panelMed = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.med1 = new System.Windows.Forms.Panel();
            this.nudQte = new System.Windows.Forms.NumericUpDown();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAjoutMed = new System.Windows.Forms.Button();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.nomMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRapport = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.panelMed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.med1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(416, 17);
            this.label11.TabIndex = 121;
            this.label11.Text = "Vous devez d\'abord créer le compte-rendu avant d\'y lier des échantillons.";
            // 
            // panelMed
            // 
            this.panelMed.Controls.Add(this.groupBox1);
            this.panelMed.Controls.Add(this.dgvMedicament);
            this.panelMed.Controls.Add(this.label7);
            this.panelMed.Location = new System.Drawing.Point(53, 132);
            this.panelMed.Margin = new System.Windows.Forms.Padding(2);
            this.panelMed.Name = "panelMed";
            this.panelMed.Size = new System.Drawing.Size(696, 206);
            this.panelMed.TabIndex = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.med1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btAjoutMed);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(452, 180);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Echantillons de médicaments";
            // 
            // med1
            // 
            this.med1.Controls.Add(this.nudQte);
            this.med1.Controls.Add(this.cbMedicament);
            this.med1.Controls.Add(this.label12);
            this.med1.Controls.Add(this.label13);
            this.med1.Location = new System.Drawing.Point(0, 87);
            this.med1.Margin = new System.Windows.Forms.Padding(2);
            this.med1.Name = "med1";
            this.med1.Size = new System.Drawing.Size(449, 32);
            this.med1.TabIndex = 38;
            // 
            // nudQte
            // 
            this.nudQte.Enabled = false;
            this.nudQte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.nudQte.Location = new System.Drawing.Point(359, 4);
            this.nudQte.Name = "nudQte";
            this.nudQte.Size = new System.Drawing.Size(54, 25);
            this.nudQte.TabIndex = 39;
            this.nudQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMedicament
            // 
            this.cbMedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicament.Enabled = false;
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(134, 7);
            this.cbMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(160, 21);
            this.cbMedicament.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nom du médicament";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pour ce faire, il faut cliquer à nouveau sur \"Ajouter un échantillon\".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Information : Vous pouvez en ajouter plusieurs. ";
            // 
            // btAjoutMed
            // 
            this.btAjoutMed.Enabled = false;
            this.btAjoutMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutMed.Location = new System.Drawing.Point(147, 148);
            this.btAjoutMed.Name = "btAjoutMed";
            this.btAjoutMed.Size = new System.Drawing.Size(190, 27);
            this.btAjoutMed.TabIndex = 35;
            this.btAjoutMed.Text = "Ajouter un échantillon";
            this.btAjoutMed.UseVisualStyleBackColor = true;
            this.btAjoutMed.Click += new System.EventHandler(this.btAjoutMed_Click);
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.AllowUserToAddRows = false;
            this.dgvMedicament.AllowUserToDeleteRows = false;
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMedic,
            this.nombre});
            this.dgvMedicament.Location = new System.Drawing.Point(464, 17);
            this.dgvMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.ReadOnly = true;
            this.dgvMedicament.RowTemplate.Height = 24;
            this.dgvMedicament.Size = new System.Drawing.Size(230, 165);
            this.dgvMedicament.TabIndex = 35;
            this.dgvMedicament.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicament_CellContentDoubleClick);
            // 
            // nomMedic
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomMedic.DefaultCellStyle = dataGridViewCellStyle1;
            this.nomMedic.HeaderText = "Nom du médicament";
            this.nomMedic.Name = "nomMedic";
            this.nomMedic.ReadOnly = true;
            // 
            // nombre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.HeaderText = "Quantité offerte";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Visualisation des échantillons";
            // 
            // cbRapport
            // 
            this.cbRapport.FormattingEnabled = true;
            this.cbRapport.Location = new System.Drawing.Point(119, 63);
            this.cbRapport.Name = "cbRapport";
            this.cbRapport.Size = new System.Drawing.Size(214, 21);
            this.cbRapport.TabIndex = 123;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 124;
            this.button1.Text = "Selectionner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.ForestGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(248, 367);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(259, 57);
            this.btValider.TabIndex = 125;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbRapport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelMed);
            this.Name = "FrmModifRapport";
            this.Text = "FrmModifRapport";
            
            this.panelMed.ResumeLayout(false);
            this.panelMed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.med1.ResumeLayout(false);
            this.med1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel med1;
        private System.Windows.Forms.NumericUpDown nudQte;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAjoutMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRapport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btValider;
        public System.Windows.Forms.Panel panelMed;
        public System.Windows.Forms.DataGridView dgvMedicament;
    }
}