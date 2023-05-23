using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioRibos
{
    class Salarier : Membres
    {
        #region variable

        private string nomEntrerpise;
        private DateTime dateCreaEntreprise;
        private bool kbisVerif;
        private DateTime dateEnregistrementEnt;
        private string nomRepresentant;

        #endregion

        #region accesseur

        public string NomEntrerpise { get => nomEntrerpise; set => nomEntrerpise = value; }
        public DateTime DateCreaEntreprise { get => dateCreaEntreprise; set => dateCreaEntreprise = value; }
        public bool KbisVerif { get => kbisVerif; set => kbisVerif = value; }
        public DateTime DateEnregistrementEnt { get => dateEnregistrementEnt; set => dateEnregistrementEnt = value; }
        public string NomRepresentant { get => nomRepresentant; set => nomRepresentant = value; }

        #endregion

        #region controleur

        public Salarier(string nomEntrerpise, DateTime dateCreaEntreprise, bool kbisVerif, DateTime dateEnregistrementEnt, string nomRepresentant, int numInscri, string nomMembre, string prenomMembre, DateTime dateNaissance, string sexeMembre,
            string adresseMembre, int cPMembre, string villeMembre, int telMembre, string mailMembre, bool newletterChoix, string nomAssuMembre, int numContAssuMembre, bool droitImage, DateTime dateAdhésion, string gestionnaireDossier, string typeAdhérent)
            : base(numInscri, nomMembre, prenomMembre, dateNaissance, sexeMembre, adresseMembre, cPMembre, villeMembre, telMembre, mailMembre, newletterChoix, nomAssuMembre, numContAssuMembre, droitImage, dateAdhésion, gestionnaireDossier, typeAdhérent)
        {
            NomEntrerpise = nomEntrerpise;
            DateCreaEntreprise = dateCreaEntreprise;
            KbisVerif = kbisVerif;
            DateEnregistrementEnt = dateEnregistrementEnt;
            NomRepresentant = nomRepresentant;
        }

        #endregion
    }
}
