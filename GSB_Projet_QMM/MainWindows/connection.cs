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

namespace MainWindows
{
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }
        public bool verifCo { get; set; }

        private void btnConnecter_Click_1(object sender, EventArgs e)
        {
            //récupération des valeurs du fomulaire permettant ensuite la tentative de connexion 
            string srv = txtHost.Text;
            string DB = txtDB.Text;
            string ID = txtID.Text;
            string MDP = txtMDP.Text;
            DBConnect cnx = new DBConnect(srv, DB, ID, MDP);
            recup.login = cnx;
            if (cnx.OpenConnection())
            {

                MessageBox.Show("CONNEXION REUSSIE !!!!!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                int Nbv = cnx.NbVisiteur();
                int Nbmedoc = cnx.NbMedicament();
                int Nbmedecin =  cnx.NbMedecin();
                List<Visiteur> visiteur = cnx.VisiteursList();
                verif();
                this.Close();
            }

        }

        //Méthode statick créant une variable statick pouvant être utiliser à travers plusieurs formulaire 
        public static class recup
        {
            public static DBConnect login;

        }

        public void verif()
        {
            verifCo = true;
        }
    }
}
