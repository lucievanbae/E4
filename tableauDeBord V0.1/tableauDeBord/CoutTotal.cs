using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace TableauDeBord
{
    public partial class CoutTotal : Form
    {
        private int annee;
        public CoutTotal()
        {
            InitializeComponent();
        }

        private void CoutTotal_Load(object sender, EventArgs e)
        {
            annee = 2016;
            // Data arrays
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];

            pointsArray = Passerelle.coutTotalMedoc(annee);

            // Set palette
            this.chartMedoc.Palette = ChartColorPalette.EarthTones;
            // Set title
            this.chartMedoc.Titles.Add("Pourcentage Année" + annee);

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chartMedoc.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }


        }

        private void btnAnnee_Prec_CT_Click(object sender, EventArgs e)
        {
            annee--;
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];
            pointsArray = Passerelle.coutTotalMedoc(annee);
            // Set palette
            this.chartMedoc.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chartMedoc.Titles.Clear();
            this.chartMedoc.Titles.Add("Pourcentage Année" + annee);
            this.chartMedoc.Series.Clear();
            // Add series.
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Series series = this.chartMedoc.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void btnAnnee_Suiv_CT_Click(object sender, EventArgs e)
        {
            annee++;
            string[] seriesArray = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            int[] pointsArray = new int[12];
            pointsArray = Passerelle.coutTotalMedoc(annee);
            // Set palette
            this.chartMedoc.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chartMedoc.Titles.Clear();
            this.chartMedoc.Titles.Add("Pourcentage Année" + annee);
            this.chartMedoc.Series.Clear();

            // Add series.
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Series series = this.chartMedoc.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        
        }

    }
}
