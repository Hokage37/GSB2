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
    public partial class frmAddMedecin : Form
    {
        //Appel de méthode recup contenant la variable login avec les information de connexion permettant l'acces et l'utilisation d'une méthode DBConnecte 
        public static List<Specialite> lesSpecia = new List<Specialite>(connection.recup.login.ListSpecia());
        public frmAddMedecin()
        {
            InitializeComponent();

            //Incrémente dans le combot box les différentes spécialité contenu dans la liste des spécilité 
            for (int i = 0; i < (lesSpecia.Count); i++)
            {
                cbSpe.Items.Add(lesSpecia[i].Specialites);
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            //parcours la liste des specialité 
            for (int i = 0; i < lesSpecia.Count; i++)
            {
                //verifie que la spécialité sélectionner correspond à une spécialité existante dans la liste 
                if (lesSpecia[i].Specialites == cbSpe.Text)
                {
                    //création d'un nouvel objet spécialité 
                    Specialite speciaAdd = new Specialite(lesSpecia[i].IdSpe, lesSpecia[i].Specialites);

                    //Création d'un nouveau médecin contenant en paramètre la spécialité précédement créer 
                    Medecin nouveauMedecin = new Medecin(
                        txtTel.Text,
                        int.Parse(txtCp.Text),
                        txtNom.Text,
                        txtPrenom.Text,
                        txtAdresse.Text,
                        speciaAdd
                        );

                    //fait appel à la méthode adMedecin afin d'envoyer l'objet à ajouter vers la DBconnect 
                    connection.recup.login.addMedecin(nouveauMedecin);

                    //vide tout les champs du formulaire
                    txtTel.Clear();
                    txtCp.Clear();
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtAdresse.Clear();
                    cbSpe.ResetText();

                }
            }
        }
    }
}
