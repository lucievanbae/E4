using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TableauDeBord
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Connexion_Click(object sender, EventArgs e)
        {
            Passerelle.Connection();    // connexion bdd
            Boolean i = Passerelle.utilisateur(login.Text, mdp.Text);
            if (i == false)
            {
                lblErreur.Visible = true;
            }
            else
            {
                Choix a = new Choix();
                a.Show();   // ouverture du Form: choix
            }

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
