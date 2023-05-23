using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioRibos
{
    public class Membres
    {
        #region variable
        private Int32 numInscri;
        private string nomMembre;
        private string prenomMembre;
        private DateTime dateNaissance;
        private string sexeMembre;
        private string adresseMembre;
        private Int32 cPMembre;
        private string villeMembre;
        private Int32 telMembre;
        private string mailMembre;
        private bool newletterChoix;
        private string nomAssuMembre;
        private Int32 numContAssuMembre;
        private bool droitImage;
        private DateTime dateAdhésion;
        private string gestionnaireDossier;
        private string typeAdhérent;

        #endregion

        #region accesseur

        public int NumInscri { get => numInscri; set => numInscri = value; }
        public string NomMembre { get => nomMembre; set => nomMembre = value; }
        public string PrenomMembre { get => prenomMembre; set => prenomMembre = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string SexeMembre { get => sexeMembre; set => sexeMembre = value; }
        public string AdresseMembre { get => adresseMembre; set => adresseMembre = value; }
        public int CPMembre { get => cPMembre; set => cPMembre = value; }
        public string VilleMembre { get => villeMembre; set => villeMembre = value; }
        public int TelMembre { get => telMembre; set => telMembre = value; }
        public string MailMembre { get => mailMembre; set => mailMembre = value; }
        public bool NewletterChoix { get => newletterChoix; set => newletterChoix = value; }
        public string NomAssuMembre { get => nomAssuMembre; set => nomAssuMembre = value; }
        public int NumContAssuMembre { get => numContAssuMembre; set => numContAssuMembre = value; }
        public bool DroitImage { get => droitImage; set => droitImage = value; }
        public DateTime DateAdhésion { get => dateAdhésion; set => dateAdhésion = value; }
        public string GestionnaireDossier { get => gestionnaireDossier; set => gestionnaireDossier = value; }
        public string TypeAdhérent { get => typeAdhérent; set => typeAdhérent = value; }

        #endregion

        #region controleur

        public Membres(int numInscri, string nomMembre, string prenomMembre, DateTime dateNaissance, string sexeMembre, string adresseMembre, int cPMembre, string villeMembre, int telMembre, string mailMembre,
            bool newletterChoix, string nomAssuMembre, int numContAssuMembre, bool droitImage, DateTime dateAdhésion, string gestionnaireDossier, string typeAdhérent)
        {
            NumInscri = numInscri;
            NomMembre = nomMembre;
            PrenomMembre = prenomMembre;
            DateNaissance = dateNaissance;
            SexeMembre = sexeMembre;
            AdresseMembre = adresseMembre;
            CPMembre = cPMembre;
            VilleMembre = villeMembre;
            TelMembre = telMembre;
            MailMembre = mailMembre;
            NewletterChoix = newletterChoix;
            NomAssuMembre = nomAssuMembre;
            NumContAssuMembre = numContAssuMembre;
            DroitImage = droitImage;
            DateAdhésion = dateAdhésion;
            GestionnaireDossier = gestionnaireDossier;
            TypeAdhérent = typeAdhérent;
        }

        #endregion
    }
}