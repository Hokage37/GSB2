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
    public partial class frmAddRapport : Form
    {
        // Chargement de la liste des visiteurs dans une variable static
        public static List<Visiteur> lesVisiteurs = new List<Visiteur>(connection.recup.login.VisiteursList());

        // Chargement de la liste des médecins dans une variable static
        public static List<Medecin> LesMedecins = new List<Medecin>(connection.recup.login.MedecinList());
        public frmAddRapport()
        {
            InitializeComponent();
            frmRapport_Load();
        }

        private void frmRapport_Load()
        {

            // Remplir la liste des visiteurs (cbVisiteur)
            foreach (Visiteur unVisiteur in lesVisiteurs)
            {
                cbVisiteur.Items.Add(unVisiteur.Nom + " " + unVisiteur.Prenom);
            }
            // Remplir la liste des visiteurs (cbMedecin)
            foreach (Medecin unMedecin in LesMedecins)
            {
                cbMedecin.Items.Add(unMedecin.Nom + " " + unMedecin.Prenom);
            }
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {

            //Récupération des valeurs des champs de texte et instanciation d'un rapport
            //Récupération de l'index sélectionné dans Medecin et Visiteur
            int indexMedecin = cbMedecin.SelectedIndex;
            int indexVisiteur = cbVisiteur.SelectedIndex;

            //Récupération du médecin et du visiteur grâce à DBconnect en passant par les valeurs de connexion à la base de donnée 
            Medecin leMedecin = connection.recup.login.GetMedecin(indexMedecin);
            Visiteur leVisiteur = connection.recup.login.GetVisiteur(indexVisiteur);

            //Instanciation du rapport
            Rapport nouveauRapport = new Rapport(dtDateRapport.Value, txtMotif.Text, txtBilan.Text, leMedecin, leVisiteur);

            connection.recup.login.AddRapport(nouveauRapport);

            //vide les cmps du formulaires
            txtBilan.Clear();
            txtMotif.Clear();
            cbMedecin.ResetText();
            cbVisiteur.ResetText();
            dtDateRapport.ResetText();


        }
    }
}
