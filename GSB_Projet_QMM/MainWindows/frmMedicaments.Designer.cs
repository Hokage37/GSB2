namespace MainWindows
{
    partial class frmMedicaments
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
            this.dgv_Medoc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComposition = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContre = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblEffet = new System.Windows.Forms.Label();
            this.tbEffet = new System.Windows.Forms.TextBox();
            this.tbCompo = new System.Windows.Forms.TextBox();
            this.tbContreIndic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Medoc
            // 
            this.dgv_Medoc.AllowUserToAddRows = false;
            this.dgv_Medoc.AllowUserToDeleteRows = false;
            this.dgv_Medoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomCom});
            this.dgv_Medoc.Location = new System.Drawing.Point(12, 21);
            this.dgv_Medoc.Name = "dgv_Medoc";
            this.dgv_Medoc.ReadOnly = true;
            this.dgv_Medoc.Size = new System.Drawing.Size(245, 386);
            this.dgv_Medoc.TabIndex = 0;
            this.dgv_Medoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Medoc_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Famille";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nomCom
            // 
            this.nomCom.HeaderText = "Nom Commercial ";
            this.nomCom.Name = "nomCom";
            this.nomCom.ReadOnly = true;
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposition.Location = new System.Drawing.Point(260, 21);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(49, 18);
            this.lblComposition.TabIndex = 4;
            this.lblComposition.Text = "Nom :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(263, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContre);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.lblEffet);
            this.groupBox1.Controls.Add(this.tbEffet);
            this.groupBox1.Controls.Add(this.tbCompo);
            this.groupBox1.Controls.Add(this.tbContreIndic);
            this.groupBox1.Location = new System.Drawing.Point(263, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 338);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblContre
            // 
            this.lblContre.AutoSize = true;
            this.lblContre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContre.Location = new System.Drawing.Point(3, 27);
            this.lblContre.Name = "lblContre";
            this.lblContre.Size = new System.Drawing.Size(113, 16);
            this.lblContre.TabIndex = 5;
            this.lblContre.Text = "Contre Indication :";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(155, 73);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(89, 16);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "Composition :";
            // 
            // lblEffet
            // 
            this.lblEffet.AutoSize = true;
            this.lblEffet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffet.Location = new System.Drawing.Point(324, 27);
            this.lblEffet.Name = "lblEffet";
            this.lblEffet.Size = new System.Drawing.Size(40, 16);
            this.lblEffet.TabIndex = 3;
            this.lblEffet.Text = "Effet :";
            // 
            // tbEffet
            // 
            this.tbEffet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbEffet.Enabled = false;
            this.tbEffet.Location = new System.Drawing.Point(334, 46);
            this.tbEffet.Multiline = true;
            this.tbEffet.Name = "tbEffet";
            this.tbEffet.Size = new System.Drawing.Size(191, 286);
            this.tbEffet.TabIndex = 0;
            // 
            // tbCompo
            // 
            this.tbCompo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbCompo.Enabled = false;
            this.tbCompo.Location = new System.Drawing.Point(155, 92);
            this.tbCompo.Multiline = true;
            this.tbCompo.Name = "tbCompo";
            this.tbCompo.Size = new System.Drawing.Size(173, 188);
            this.tbCompo.TabIndex = 2;
            // 
            // tbContreIndic
            // 
            this.tbContreIndic.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbContreIndic.Enabled = false;
            this.tbContreIndic.Location = new System.Drawing.Point(6, 46);
            this.tbContreIndic.Multiline = true;
            this.tbContreIndic.Name = "tbContreIndic";
            this.tbContreIndic.Size = new System.Drawing.Size(143, 286);
            this.tbContreIndic.TabIndex = 1;
            // 
            // frmMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblComposition);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dgv_Medoc);
            this.Name = "frmMedicaments";
            this.Text = "frmMedicaments";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Medoc;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContre;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblEffet;
        private System.Windows.Forms.TextBox tbEffet;
        private System.Windows.Forms.TextBox tbCompo;
        private System.Windows.Forms.TextBox tbContreIndic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCom;
    }
}