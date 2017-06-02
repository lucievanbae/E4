namespace TableauDeBord
{
    partial class Pourcentages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnAnnee_Prec_Pourcentages = new System.Windows.Forms.Button();
            this.btnAnnee_Suiv_Pourcentages = new System.Windows.Forms.Button();
            this.chart_Pourcentages = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pourcentages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnee_Prec_Pourcentages
            // 
            this.btnAnnee_Prec_Pourcentages.Location = new System.Drawing.Point(12, 563);
            this.btnAnnee_Prec_Pourcentages.Name = "btnAnnee_Prec_Pourcentages";
            this.btnAnnee_Prec_Pourcentages.Size = new System.Drawing.Size(147, 31);
            this.btnAnnee_Prec_Pourcentages.TabIndex = 0;
            this.btnAnnee_Prec_Pourcentages.Text = "Année précédent";
            this.btnAnnee_Prec_Pourcentages.UseVisualStyleBackColor = true;
            this.btnAnnee_Prec_Pourcentages.Click += new System.EventHandler(this.btnAnnee_Prec_Pourcentages_Click);
            // 
            // btnAnnee_Suiv_Pourcentages
            // 
            this.btnAnnee_Suiv_Pourcentages.Location = new System.Drawing.Point(573, 563);
            this.btnAnnee_Suiv_Pourcentages.Name = "btnAnnee_Suiv_Pourcentages";
            this.btnAnnee_Suiv_Pourcentages.Size = new System.Drawing.Size(150, 31);
            this.btnAnnee_Suiv_Pourcentages.TabIndex = 1;
            this.btnAnnee_Suiv_Pourcentages.Text = "Année suivant";
            this.btnAnnee_Suiv_Pourcentages.UseVisualStyleBackColor = true;
            this.btnAnnee_Suiv_Pourcentages.Click += new System.EventHandler(this.btnAnnee_Suiv_Pourcentages_Click);
            // 
            // chart_Pourcentages
            // 
            this.chart_Pourcentages.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chart_Pourcentages.ChartAreas.Add(chartArea1);
            this.chart_Pourcentages.Location = new System.Drawing.Point(12, 12);
            this.chart_Pourcentages.Name = "chart_Pourcentages";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Mois";
            this.chart_Pourcentages.Series.Add(series1);
            this.chart_Pourcentages.Size = new System.Drawing.Size(711, 528);
            this.chart_Pourcentages.TabIndex = 3;
            this.chart_Pourcentages.Text = "chart1";
            title1.Name = "Pourcentage";
            this.chart_Pourcentages.Titles.Add(title1);
            // 
            // Pourcentages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 606);
            this.Controls.Add(this.chart_Pourcentages);
            this.Controls.Add(this.btnAnnee_Suiv_Pourcentages);
            this.Controls.Add(this.btnAnnee_Prec_Pourcentages);
            this.Name = "Pourcentages";
            this.Text = "Pourcentage par mois";
            this.Load += new System.EventHandler(this.Pourcentages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pourcentages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnee_Prec_Pourcentages;
        private System.Windows.Forms.Button btnAnnee_Suiv_Pourcentages;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pourcentages;
    }
}