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
using MySql.Data.MySqlClient;
using BiblioClasse;


namespace ConnexionBdd
{
    public partial class FormCnxBdd : Form
    {
        public FormCnxBdd()
        {
            InitializeComponent();
        }

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
                tableauPers.Rows.Clear();
                tableauPers.Columns.Clear();
                tableauPers.Columns.Add("NOM", "Nom");
                tableauPers.Columns.Add("PRENOM", "Prenom");
                
                MessageBox.Show("CONNEXION REUSSIE !!!!!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //string strNbVisiteur = Convert.ToString(cnx.NbVisiteur());
                //MessageBox.Show(strNbVisiteur, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int Nb = cnx.NbVisiteur();
                List<Visiteur> visiteurs = cnx.VisiteursList();

                //MessageBox.Show(visiteur + " " + visiteur[0,1], "Avertissement", MessageBoxButtons.OK);

                //for (int i = 0; i < Nb; i++)
                //{
                //    comboBox.Items.Add(visiteur[i, 0] + " " + visiteur[i, 1]);

                //    tableauPers.Rows.Add(visiteur[i, 0], visiteur[i, 1]);
                //}
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

        public List<string> connection()
        {
            List<string> login = new List<string>();

            login.Add (txtHost.Text);
            login.Add(txtDB.Text);
            login.Add(txtID.Text);
            login.Add(txtMDP.Text);
            return login;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //string nom = NomInput.Text;
            //string prenom = PrenomInput.Text;
            //string login = nom + prenom;
            //string adresse = "lycee raoul follereau";
            //string cp = "58000";
            //string ville = "nevers";
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
