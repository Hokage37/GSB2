using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Specialite
    {
        #region variable
        private int idSpe;
        private string libelleSpe;
        #endregion

        #region accesseur
        public int IdSpe { get => idSpe; set => idSpe = value; }
        public string Specialites { get => libelleSpe; set => libelleSpe = value; }

        #endregion

        #region controleur
        public Specialite(int idSpe, string specia)
        {
            this.idSpe = idSpe;
            this.libelleSpe = specia;
        }

        //controleur vide
        public Specialite()
        { }


        #endregion
    }
}
