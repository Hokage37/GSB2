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
    public partial class FrmModifRapport : Form
    {
        public static List<Medicamant> LesMedocs = new List<Medicamant>(connection.recup.login.MedocsList());

        public FrmModifRapport()
        {
            InitializeComponent();
            Affichage();
        }

        public void Affichage()
        {
            
            List<Rapport> lesRapport = connection.recup.login.RapportList();

            foreach (Rapport rapport in lesRapport)
            {
                int indexMedecin = rapport.IdMedecin;
                int indexVisiteur = rapport.IdVisiteur;

                //Récupération du médecin et du visiteur grâce à DBconnect en passant par les valeurs de connexion à la base de donnée 
                Medecin leMedecin = connection.recup.login.GetMedecin(indexMedecin);
                Visiteur leVisiteur = connection.recup.login.GetVisiteur(indexVisiteur);

                cbRapport.Items.Add(rapport.IdRap + " : De " + leVisiteur.Prenom + " " + leVisiteur.Nom + " au Dr. " + leMedecin.Nom);

            }

            //ajoute les médicaments à la combo box
            int i = 0;

            foreach(Medicamant medoc in LesMedocs)
            {
                cbMedicament.Items.Add(LesMedocs[i].NomCommercial);
                i++;
            }
            
        }

        //appel la méthode permettant d'ajouter des echantillons
        private void btValider_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (dgvMedicament.Rows.Count); i++)
            {
                addEchantillon(i);
            }
        }

        //lorsque l'utilisateur selectionne un rapport il à alors acces au autre fonctionaliter 
        private void button1_Click(object sender, EventArgs e)
        {
            dgvMedicament.Enabled = true;
            cbMedicament.Enabled = true;
            nudQte.Enabled = true;
            btAjoutMed.Enabled = true;
        }

        //supprime les éléments lors d'un événement double click 
        private void dgvMedicament_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer cet échantillon ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {

                dgvMedicament.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void btAjoutMed_Click(object sender, EventArgs e)
        {
            dgvMedicament.Rows.Add(cbMedicament.Text, nudQte.Value);
        }

        public bool verif()
        {
            bool resu = false;

            foreach (Medicamant medoc in LesMedocs)
            {
                if (medoc.NomCommercial == (string)dgvMedicament.CurrentRow.Cells[0].Value)
                {
                    resu = true;
                }
            }
            return resu;
        }

        public void addEchantillon(int i)
        {

            foreach (Medicamant medoc in LesMedocs)
            {
                MessageBox.Show(LesMedocs.ElementAt(i).NomCommercial, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show((string)dgvMedicament.Rows[i].Cells[0].Value, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show((string)dgvMedicament.Rows[i].Cells[1].Value, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (medoc.NomCommercial == (string)dgvMedicament.Rows[i].Cells[0].Value)
                {

                    int Qt = Decimal.ToInt32((decimal)dgvMedicament.Rows[i].Cells[1].Value);
                    Echantillon nouveauEchantillon = new Echantillon(cbRapport.SelectedIndex,LesMedocs.ElementAt(i).IdMec, Qt);

                    connection.recup.login.addEchantillon(nouveauEchantillon);
                }
                else
                {
                    MessageBox.Show("Et non", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
               
        }

        
    }
}
