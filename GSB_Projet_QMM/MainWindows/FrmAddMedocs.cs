using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioClasse;
using DBConnectSpace;

namespace MainWindows
{
    public partial class FrmAddMedocs : Form
    {
        public static List<Famille> LesFam = new List<Famille>(connection.recup.login.ListesDesFam());

        public FrmAddMedocs()
        {
            InitializeComponent();


            for (int i = 0; i < (LesFam.Count); i++)
            {
                cbFam.Items.Add(LesFam[i].Libelle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < LesFam.Count; i++)
            {
                if (LesFam[i].Libelle == cbFam.Text)
                {
                    Famille famAdd = new Famille(LesFam[i].Libelle, LesFam[i].Id);

                    // `nomCommercial`, `composition`, `effets`, `contreindications`, `idFamille`
                    Medicamant newMedoc = new Medicamant(
                        txbNomCom.Text, // int numInscri
                        txtComp.Text, // string nomMembre
                        txtEffet.Text, // string prenomMembre
                        txtContrein.Text,
                        famAdd // string sexeMembre
                        );

                    connection.recup.login.addmedocs(newMedoc);

                    txbNomCom.Clear();
                    txtComp.Clear();
                    txtEffet.Clear();
                    txtContrein.Clear();
                    cbFam.ResetText();

                }
            }
        }
    }
}
