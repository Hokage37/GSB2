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
    public partial class frmMedecin : Form
    {
        public static List<Medecin> LesMedecins = new List<Medecin>(connection.recup.login.MedecinList());

        public frmMedecin()
        {
            InitializeComponent();
            insertion(LesMedecins);
        }

        public void insertion(List<Medecin> LesMedecins)
        {
            //incrémente dans le data Gried view la liste des médecins et leurs informations
            for (int i = 0; i < (LesMedecins.Count); i++)
            {
                dgvMedecins.Rows.Add(LesMedecins[i].Id,LesMedecins[i].Nom, LesMedecins[i].Prenom, LesMedecins[i].LaSpecialite.Specialites, LesMedecins[i].Adresse, LesMedecins[i].Tel, LesMedecins[i].Departement);
            }

        }

        
        private void dgvMedecins_MouseClick(object sender, MouseEventArgs e)
        {
            int indexMedecin = (int)dgvMedecins.CurrentRow.Cells[0].Value;

            Affichage(LesMedecins, indexMedecin);
        }

        //affiche les information complètes du médecin dans les champs du formulaire
        public void Affichage(List<Medecin> lemeds, int Ref)
        {
            Medecin testMedecin = lemeds[0];

            for (int i = 0; i < (lemeds.Count); i++)
            {
                int test = Ref;

                if (test == lemeds[i].Id)
                {
                    testMedecin = lemeds[i];
                }
            }

            txtPrenom.Text = testMedecin.Prenom;
            txtNom.Text = testMedecin.Nom;
            txtAdresse.Text = testMedecin.Adresse;
            txtTel.Text = testMedecin.Tel;
            txtDepartement.Text = testMedecin.Departement.ToString();
            txbSpecia.Text = testMedecin.LaSpecialite.Specialites;
        }
    }
}
