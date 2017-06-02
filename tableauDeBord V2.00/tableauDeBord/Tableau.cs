using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableauDeBord
{
    public partial class Tableau : Form
    {
        public Tableau()
        {
            InitializeComponent();
        }

        private void Tableau_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet14.dureeMoy'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.dureeMoyTableAdapter.Fill(this.tableaudebordDataSet14.dureeMoy);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet13.Service'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.serviceTableAdapter.Fill(this.tableaudebordDataSet13.Service);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet12.Occupation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.occupationTableAdapter.Fill(this.tableaudebordDataSet12.Occupation);

        }

        private void btn_Duree_Moy_Click(object sender, EventArgs e)
        {
            DureeMoy form5 = new DureeMoy();
            form5.Show();
            this.Hide();
        }

        private void btn_Pourcentages_Click(object sender, EventArgs e)
        {
            Pourcentages form3 = new Pourcentages();
            form3.Show();
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Choix a = new Choix();
            a.Show();
            this.Hide();
        }
    }
}
