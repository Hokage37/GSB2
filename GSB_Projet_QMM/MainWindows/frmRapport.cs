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
    public partial class frmRapport : Form
    {
        // Chargement de la liste des visiteurs dans une variable static
        public static List<Visiteur> lesVisiteurs = new List<Visiteur>(connection.recup.login.VisiteursList());

        // Chargement de la liste des médecins dans une variable static
        public static List<Medecin> LesMedecins = new List<Medecin>(connection.recup.login.MedecinList());

        public frmRapport()
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

        public void effacerZonesTexte()
        {
            txtNomMedecin.Text = "";
            txtPrenomMedecin.Text = "";
            txtMotif.Text = "";
            txtBilan.Text = "";
            dtDateRapport.Value = DateTime.Now;
            txtNomVisiteur.Text = "";
            txtPrenomVisiteur.Text = "";
            txtAdresseMedecin.Text = "";
            lvMedicaments.Items.Clear();
            listRapports.Items.Clear();
        }

        private void listRapports_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRapport = Int32.Parse(this.listRapports.Text);

            Rapport rapport = connection.recup.login.ChargerRapport(idRapport);

            txtNomVisiteur.Text = rapport.LeVisi.Nom;
            txtPrenomVisiteur.Text = rapport.LeVisi.Prenom;
            txtMotif.Text = rapport.Modif;
            txtBilan.Text = rapport.Bilan;
            dtDateRapport.Value = rapport.Date;
            txtNomMedecin.Text = rapport.LeMed.Nom;
            txtPrenomMedecin.Text = rapport.LeMed.Prenom;
            txtAdresseMedecin.Text = rapport.LeMed.Adresse;

            foreach (Echantillon eo in rapport.EchantillonsOffert)
            {
                Medicamant lesEchantillons = connection.recup.login.Getmedocs(eo.IdMedicament);
                String[] med = { lesEchantillons.NomCommercial, eo.Quantite.ToString() };  // valeurs récupérées
                ListViewItem lvAdd = new ListViewItem(med);
                lvMedicaments.Items.Add(lvAdd);
            }

        }

        private void cbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexVisiteur = cbVisiteur.SelectedIndex;
            List<int> idsDesRapports = connection.recup.login.ChercherIdsRapportsVisiteur(indexVisiteur);

            listRapports.Items.Clear();
            // On affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idsDesRapports)
            {
                // On ajoute l’idRapport aux Items de la liste listRapports
                listRapports.Items.Add(idRapport);
            }
        }

        private void cbMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMedecin = cbMedecin.SelectedIndex;
            List<Int32> idsDesRapports = connection.recup.login.ChercherIdsRapportsMedecin(indexMedecin);

            listRapports.Items.Clear();
            // On affiche ces ids de rapports dans la liste listRapports
            foreach (int idRapport in idsDesRapports)
            {
                // On ajoute l’idRapport aux Items de la liste listRapports
                listRapports.Items.Add(idRapport);
            }
        }
    }
}
