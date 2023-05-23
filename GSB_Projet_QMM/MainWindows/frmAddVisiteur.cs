using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioClasse;

namespace MainWindows
{
    public partial class frmAddVisiteur : Form
    {
        public frmAddVisiteur()
        {
            InitializeComponent();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            
            Visiteur nouveauVisiteur = new Visiteur(
                txtLogin.Text, 
                txtMDP.Text, 
                txtCp.Text, 
                txtVille.Text, 
                dtpDateEmbauche.Value, 
                txtNom.Text, 
                txtPrenom.Text,  
                txtAdresse.Text);

            connection.recup.login.addVisiteur(nouveauVisiteur);

            //vide les cmps du formulaires
            txtLogin.Clear(); 
            txtMDP.Clear();
            txtCp.Clear();
            txtVille.Clear();
            dtpDateEmbauche.ResetText(); 
            txtNom.Clear();
            txtPrenom.Clear();
            txtAdresse.Clear();


        }
    }
}
