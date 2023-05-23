using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Medecin : Personne
    {
        #region variable
        private string tel;
        private int departement;
        private Specialite laSpecialite;

        #endregion

        #region accesseur
        public string Tel { get => tel; set => tel = value; }
        public int Departement { get => departement; set => departement = value; }
        public Specialite LaSpecialite { get => laSpecialite; set => laSpecialite = value; }

        #endregion

        #region controleur

        public Medecin(string tel, int departement, int id, string nom, string prenom, string adresse, Specialite laSpecialite)
            : base(id, nom, prenom, adresse)
        {
            Tel = tel;
            Departement = departement;
            LaSpecialite = laSpecialite;
        }
        public Medecin(string tel, int departement, string nom, string prenom, string adresse, Specialite laSpecialite)
            : base(nom, prenom, adresse)
        {
            Tel = tel;
            Departement = departement;
            LaSpecialite = laSpecialite;
        }


        public Medecin(string tel, int departement, int id, string nom, string prenom, string adresse)
            : base(id, nom, prenom, adresse)
        {
            Tel = tel;
            Departement = departement;
        }

        #endregion
    }
}
