using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnectSpace;
using BiblioClasse;


namespace ConnexionBdd
{
    public partial class FrmCnxBdd : Form
    {
        
        public FrmCnxBdd()
        {
            InitializeComponent();
        }
        public bool verifCo { get; set; }

 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string srv = txtHost.Text;
            string DB = txtDB.Text;
            string ID = txtID.Text;
            string MDP = txtMDP.Text;
            DBConnect cnx = new DBConnect(srv, DB, ID, MDP);
            if (cnx.OpenConnection())
            {
                
                MessageBox.Show("CONNEXION REUSSIE !!!!!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //string strNbVisiteur = Convert.ToString(cnx.NbVisiteur());
                //MessageBox.Show(strNbVisiteur, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int Nb = cnx.NbVisiteur();
                List<Visiteur> visiteur = cnx.VisiteursList();

                //MessageBox.Show(visiteur[0,0] + " " + visiteur[0,1], "Avertissement", MessageBoxButtons.OK);

                verif();
                this.Close();
            }

            
            //if (cnx.OpenConnection() == 1)
            //{
            //    MessageBox.Show("Connexion au serveur impossible ! Contactez l'administrateur");
            //}

            //if (cnx.OpenConnection() == 2)
            //{
            //    MessageBox.Show("Login et/ou mot de passe invalide(s). Réessayez");
            //}

            //if (cnx.OpenConnection() == 2)
            //{
            //    MessageBox.Show("Erreur inconnue ! Réessayez");
            //}

        }

        private void tableauPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        public void verif()
        {
            verifCo = true;
        }

        private void txtMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelNomBdd_Click(object sender, EventArgs e)
        {

        }

        private void LabelHost_Click(object sender, EventArgs e)
        {

        }
    }

    
}
