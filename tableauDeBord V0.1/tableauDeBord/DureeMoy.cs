using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace TableauDeBord
{
    public partial class DureeMoy : Form
    {
        //pour permettre d'afficher différentes années sur la même page
        private int annee;

        public DureeMoy()
        {
            InitializeComponent();
        }

        private void chart_Duree_Moy_Click(object sender, EventArgs e)
        {
            
        }

        private void DureeMoy_Load(object sender, EventArgs e)
        {
            //l'année est définie pour la selection des données dans la BDD
            annee = 2016;
            // Data arrays
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];

            //on appele la fonction qui effectue la requête
            pointsArray = Passerelle.dureeMoy(annee);
            //affichage du titre
            this.chart_Duree_Moy.Palette = ChartColorPalette.EarthTones;
            this.chart_Duree_Moy.Titles.Add("Pourcentage Année" + annee);
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Series series = this.chart_Duree_Moy.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void btnAnnee_Prec_Duree_Moy_Click(object sender, EventArgs e)
        {
            annee--;
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];
            pointsArray = Passerelle.dureeMoy(annee);
            // Set palette
            this.chart_Duree_Moy.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart_Duree_Moy.Titles.Clear();
            this.chart_Duree_Moy.Titles.Add("Pourcentage Année" + annee);
            this.chart_Duree_Moy.Series.Clear();
            // Add series.
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Series series = this.chart_Duree_Moy.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void btnAnnee_Suiv_Duree_Moy_Click(object sender, EventArgs e)
        {
            annee++;
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];
            pointsArray = Passerelle.dureeMoy(annee);
            // Set palette
            this.chart_Duree_Moy.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart_Duree_Moy.Titles.Clear();
            this.chart_Duree_Moy.Titles.Add("Pourcentage Année" + annee);
            this.chart_Duree_Moy.Series.Clear();
            // Add series.
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Series series = this.chart_Duree_Moy.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}
