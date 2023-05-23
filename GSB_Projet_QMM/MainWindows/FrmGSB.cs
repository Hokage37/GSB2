using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindows
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            frmAccueil  newMDIChild = new frmAccueil();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        private void ajoutDeMédicamentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddMedocs newMDIChild = new FrmAddMedocs();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void listeVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisiteurs newMDIChild = new frmVisiteurs();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void listeDesMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmMedicaments newMDIChild = new frmMedicaments();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void listeDesMédecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedecin newMDIChild = new frmMedecin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void nouveauVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVisiteur newMDIChild = new frmAddVisiteur();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void listeRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRapport newMDIChild = new frmRapport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void créerMédecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMedecin newMDIChild = new frmAddMedecin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void créerRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRapport newMDIChild = new frmAddRapport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void déclarerÉchantillonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifRapport newMDIChild = new FrmModifRapport();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void AccueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccueil newMDIChild = new frmAccueil();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
