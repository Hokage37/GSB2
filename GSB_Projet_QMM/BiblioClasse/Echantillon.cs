using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Echantillon
    {
        private int idRapport;
        private int idMedicament;
        private int quantite;

        public int IdRapport { get => idRapport; set => idRapport = value; }
        public int IdMedicament { get => idMedicament; set => idMedicament = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        public Echantillon(int idRapport, int idMedicament, int quantite)
        {
            IdRapport = idRapport;
            IdMedicament = idMedicament;
            Quantite = quantite;
        }

        public Echantillon(int idMedicament, int quantite)
        {
            IdMedicament = idMedicament;
            Quantite = quantite;
        }
    }
}
