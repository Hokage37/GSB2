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
    public partial class frmMedicaments : Form
    {
        public static List<Medicamant> LesMedocs = new List<Medicamant>(connection.recup.login.MedocsList());

        public frmMedicaments()
        {
            InitializeComponent();
            

            insertion(LesMedocs);

            //incrémente les données de la liste lesMedocs dans le combo box 
            for (int i = 0; i < (LesMedocs.Count); i++)
            {
                comboBox2.Items.Add(LesMedocs[i].NomCommercial);
            }

        }

        //affiche les données correspondant à l'élément séléctionner dans le combo box
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomDeRef = comboBox2.Text;
            
            Affichage(LesMedocs, nomDeRef);
            
        }

        //insert les données dans le data grid view
        public void insertion(List<Medicamant> LesMedocs)
        {
            for (int i = 0; i < (LesMedocs.Count); i++)
            {
                dgv_Medoc.Rows.Add(LesMedocs[i].LaFamille.Libelle, LesMedocs[i].NomCommercial);
            }

        }

        //Affiche des médicaments dans les champs du formualires
        public void Affichage(List<Medicamant> LesMedocs, string Ref)
        {
            Medicamant leMedoc = LesMedocs[0];

            for  (int i = 0; i < (LesMedocs.Count) ; i++)
            {
                string test = Ref;

                if (test == LesMedocs[i].NomCommercial)
                {
                    leMedoc = LesMedocs[i];
                }
            }

            tbContreIndic.Text = leMedoc.Contreindiactions;
            tbCompo.Text = leMedoc.Composition;
            tbEffet.Text = leMedoc.Effets;
        }

        private void dgv_Medoc_MouseClick(object sender, MouseEventArgs e)
        {
            //Récupération de l'indice du visteur sélectionné
            string indexMedoc = (string)dgv_Medoc.CurrentRow.Cells[1].Value;

            Affichage(LesMedocs, indexMedoc);
           
        }
    }
}
