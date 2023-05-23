using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Rapport
    {
        #region variable
        private int idRap;
        private DateTime date;
        private string modif;
        private string bilan;
        private int idVisiteur;
        private int idMedecin;
        private Medecin leMed;
        private Visiteur leVisi;
        private List<Echantillon> echantillonsOffert;

        public int IdRap { get => idRap; set => idRap = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Modif { get => modif; set => modif = value; }
        public string Bilan { get => bilan; set => bilan = value; }
        public int IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public int IdMedecin { get => idMedecin; set => idMedecin = value; }
        public List<Echantillon> EchantillonsOffert { get => echantillonsOffert; set => echantillonsOffert = value; }
        public Medecin LeMed { get => leMed; set => leMed = value; }
        public Visiteur LeVisi { get => leVisi; set => leVisi = value; }

        public Rapport(int idRap, DateTime date, string modif, string bilan, int idVisiteur, int idMedecin)
        {
            IdRap = idRap;
            Date = date;
            Modif = modif;
            Bilan = bilan;
            IdVisiteur = idVisiteur;
            IdMedecin = idMedecin;
        }

        public Rapport(int idRap, DateTime date, string modif, string bilan, List<Echantillon> echantillonsOffert, Medecin leMed, Visiteur leVisi)
        {
            IdRap = idRap;
            Date = date;
            Modif = modif;
            Bilan = bilan;
            EchantillonsOffert = echantillonsOffert;
            LeMed = leMed;
            LeVisi = leVisi;
        }

        public Rapport(DateTime date, string modif, string bilan, Medecin leMed, Visiteur leVisi)
        {
            Date = date;
            Modif = modif;
            Bilan = bilan;
            LeMed = leMed;
            LeVisi = leVisi;
        }





        #endregion


    }
}
