using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Medicamant
    {
        #region variable
        private int idMec;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreindiactions;
        private Famille laFamille;

        //idMec; nomCommercial;composition; effets; contreindiactions; laFamille;

        #endregion

        #region accesseur
        public int IdMec { get => idMec; set => idMec = value; }
        public string NomCommercial { get => nomCommercial; set => nomCommercial = value; }
        public string Composition { get => composition; set => composition = value; }
        public string Effets { get => effets; set => effets = value; }
        public string Contreindiactions { get => contreindiactions; set => contreindiactions = value; }
        public Famille LaFamille { get => laFamille; set => laFamille = value; }

        #endregion

        #region constructure

        public Medicamant()
        {
            idMec = 0;
            composition = "";
            nomCommercial = "";
            effets = "";
            contreindiactions = "";
        }


        public Medicamant(int idMec, string nomCommercial, string contreindiactions, string effets, string composition, Famille LaFamille)
        {
            this.idMec = idMec;
            this.composition = composition;
            this.nomCommercial = nomCommercial;
            this.effets = effets;
            this.contreindiactions = contreindiactions;
            this.LaFamille = LaFamille;
        }

        public Medicamant(string nomCommercial, string composition, string effets, string contreindiactions, Famille laFamille)
        {
            NomCommercial = nomCommercial;
            Composition = composition;
            Effets = effets;
            Contreindiactions = contreindiactions;
            LaFamille = laFamille;
        }

        public Medicamant(int idMec, string nomCommercial, string composition, string effets, string contreindiactions)
        {
            IdMec = idMec;
            NomCommercial = nomCommercial;
            Composition = composition;
            Effets = effets;
            Contreindiactions = contreindiactions;
        }





        #endregion

        #region Methode

        //public List<Medicamant> getMedoc(List<Medicamant> LesMedocs)
        //{
        //    LesMedocs = 

        //    return 
        //}

        #endregion

    }
}
