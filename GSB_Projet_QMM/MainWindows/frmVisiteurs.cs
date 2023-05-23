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
using DBConnectSpace;

namespace MainWindows
{
    public partial class frmVisiteurs : Form
    {
        public static List<Visiteur> LesVisiteurs = new List<Visiteur>(connection.recup.login.VisiteursList());
        public frmVisiteurs()
        {
            InitializeComponent();

            insertion(LesVisiteurs);
        }

        public void insertion(List<Visiteur> LesVisiteurs)
        {
            
            for (int i = 0; i < (LesVisiteurs.Count); i++)
            {
                dgvVisiteur.Rows.Add(LesVisiteurs[i].Id, LesVisiteurs[i].Nom, LesVisiteurs[i].Prenom,LesVisiteurs[i].Ville);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int indexVisiteur = (int)dgvVisiteur.CurrentRow.Cells[0].Value;

            Affichage(LesVisiteurs, indexVisiteur);
        }

        public void Affichage(List<Visiteur> leVisiteur, int Ref)
        {
            Visiteur testVisiteur = leVisiteur[0];

            for (int i = 0; i < (leVisiteur.Count); i++)
            {
                int test = Ref;

                if (test == leVisiteur[i].Id)
                {
                    testVisiteur = leVisiteur[i];
                }
            }

            txtPrenom.Text = testVisiteur.Prenom;
            txtNom.Text = testVisiteur.Nom;
            txtAdresse.Text = testVisiteur.Adresse;
            txtCP.Text = testVisiteur.Cp;
            txtVille.Text = testVisiteur.Ville;
            dateTimePicker1.Value = testVisiteur.DateEmbauche;
        }
    }
}
