using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TableauDeBord
{
    public partial class Tableau : Form
    {
        public Tableau()
        {
            InitializeComponent();
        }

        private void labelTableau_Click(object sender, EventArgs e)
        {

        }

        private void tableau_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet11.Service'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.serviceTableAdapter.Fill(this.tableaudebordDataSet11.Service);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet7.dureeMoy'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.dureeMoyTableAdapter.Fill(this.tableaudebordDataSet7.dureeMoy);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet6.Occupation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.occupationTableAdapter.Fill(this.tableaudebordDataSet6.Occupation);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet5.Occupation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.occupation2TableAdapter.Fill(this.tableaudebordDataSet5.Occupation2);
        }  

        private void btn_Duree_Moy_Click(object sender, EventArgs e)
        {
            Pourcentages form3 = new Pourcentages();
            form3.Show();
        }

        private void tableau_occupation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double occupation = Passerelle.pourcentage();
            //dataGridView1.Columns[0].Name = "annee";
            //dataGridView1.Columns[1].Name = "mois";
            //dataGridView1.Columns[2].Name = "nbLitsOccup";
            string[] lign1 = new string[] { occupation.ToString() };
        }

        private void tableau_occupation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Pourcentages_Click(object sender, EventArgs e)
        {
            DureeMoy form5 = new DureeMoy();
            form5.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Choix a = new Choix();
            a.Show();
            this.Hide();
        }

        private void ComboBox_Service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
