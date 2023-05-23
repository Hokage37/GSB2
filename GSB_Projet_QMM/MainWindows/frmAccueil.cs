using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnectSpace;
using ConnexionBdd;

namespace MainWindows
{
    public partial class frmAccueil : Form
    {
        public bool verif;
        public frmAccueil()
        {
            InitializeComponent();
            connection form = new connection();
            form.ShowDialog();
            connect(form.verifCo);
        }


    private void bt_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void connect(bool verifCo)
        {
            if (verifCo != true)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
