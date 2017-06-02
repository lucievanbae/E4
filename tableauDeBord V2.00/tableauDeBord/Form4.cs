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
using System.Windows.Forms.DataVisualization.Charting;

namespace TableauDeBord
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Data arrays
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];

            // Requete
            string chaineConnexion = "Data Source=win-921c8fktgae;Initial Catalog=tableaudebord;User ID=vanbaelinghem;Password=vanbaelinghem";
            SqlConnection laConnexion;
            laConnexion = new SqlConnection(chaineConnexion);
            laConnexion.Open();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT Mois, NbLitsOccup FROM Occupation WHERE Annee=2017"; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int Mois = (int)Resultat["Mois"];
                int nbLitsOccup = (int)Resultat["NbLitsOccup"];
                pointsArray[Mois - 1] = nbLitsOccup;
                // MessageBox.Show("moi " + Mois+" nbLits "+nbLitsOccup);
            }

            // Set palette
            this.chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart1.Titles.Add("Pourcentage Année 2017");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
