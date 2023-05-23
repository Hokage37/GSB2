using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioRibos
{
    class Mineur : Membres
    {
        #region variable

        private string nomRespon;
        private string prenomRespon;
        private int telRespon;

        #endregion

        #region accesseur

        public string NomRespon { get => nomRespon; set => nomRespon = value; }
        public string PrenomRespon { get => prenomRespon; set => prenomRespon = value; }
        public int TelRespon { get => telRespon; set => telRespon = value; }

        #endregion

        #region controleur

        public Mineur(string nomRespon, string prenomRespon, int telRespon, int numInscri, string nomMembre, string prenomMembre, DateTime dateNaissance, string sexeMembre,string adresseMembre, int cPMembre, string villeMembre, int telMembre, 
            string mailMembre, bool newletterChoix, string nomAssuMembre, int numContAssuMembre, bool droitImage, DateTime dateAdhésion, string gestionnaireDossier, string typeAdhérent)
            : base(numInscri, nomMembre, prenomMembre, dateNaissance, sexeMembre, adresseMembre, cPMembre, villeMembre, telMembre, mailMembre, newletterChoix, nomAssuMembre, numContAssuMembre, droitImage, dateAdhésion, gestionnaireDossier, typeAdhérent)
        {
            NomRespon = nomRespon;
            PrenomRespon = prenomRespon;
            TelRespon = telRespon;
        }

        #endregion
    }
}
