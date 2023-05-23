using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Personne
    {
        #region variable
        private int id;
        private string nom;
        private string prenom;
        private string adresse;

        #endregion

        #region accesseur
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        #endregion

        #region controleur

        public Personne(int id, string nom, string prenom, string adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        //controleur vide
        public Personne()
        { }

        public Personne(string nom, string prenom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
            Prenom = prenom;
        }



        #endregion

    }
}
