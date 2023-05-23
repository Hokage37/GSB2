using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Famille
    {
        #region variable
        private int id;
        private string libelle;

        #endregion

        #region accesseur
        public string Libelle { get => libelle; set => libelle = value; }
        public int Id { get => id; set => id = value; }

        public Famille(string libelle, int id)
        {
            Libelle = libelle;
            Id = id;
        }

        #endregion

        #region controleur


        #endregion
    }
}
