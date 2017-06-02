namespace TableauDeBord
{
    partial class DureeMoy
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
            this.chart_Duree_Moy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAnnee_Prec_Duree_Moy = new System.Windows.Forms.Button();
            this.btnAnnee_Suiv_Duree_Moy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Duree_Moy)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Duree_Moy
            // 
            this.chart_Duree_Moy.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chart_Duree_Moy.ChartAreas.Add(chartArea1);
            this.chart_Duree_Moy.Location = new System.Drawing.Point(12, 27);
            this.chart_Duree_Moy.Name = "chart_Duree_Moy";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart_Duree_Moy.Series.Add(series1);
            this.chart_Duree_Moy.Size = new System.Drawing.Size(714, 539);
            this.chart_Duree_Moy.TabIndex = 2;
            this.chart_Duree_Moy.Text = "chart2";
            this.chart_Duree_Moy.Click += new System.EventHandler(this.chart_Duree_Moy_Click);
            // 
            // btnAnnee_Prec_Duree_Moy
            // 
            this.btnAnnee_Prec_Duree_Moy.Location = new System.Drawing.Point(39, 567);
            this.btnAnnee_Prec_Duree_Moy.Name = "btnAnnee_Prec_Duree_Moy";
            this.btnAnnee_Prec_Duree_Moy.Size = new System.Drawing.Size(139, 33);
            this.btnAnnee_Prec_Duree_Moy.TabIndex = 3;
            this.btnAnnee_Prec_Duree_Moy.Text = "année précédente";
            this.btnAnnee_Prec_Duree_Moy.UseVisualStyleBackColor = true;
            this.btnAnnee_Prec_Duree_Moy.Click += new System.EventHandler(this.btnAnnee_Prec_Duree_Moy_Click);
            // 
            // btnAnnee_Suiv_Duree_Moy
            // 
            this.btnAnnee_Suiv_Duree_Moy.Location = new System.Drawing.Point(552, 572);
            this.btnAnnee_Suiv_Duree_Moy.Name = "btnAnnee_Suiv_Duree_Moy";
            this.btnAnnee_Suiv_Duree_Moy.Size = new System.Drawing.Size(133, 28);
            this.btnAnnee_Suiv_Duree_Moy.TabIndex = 4;
            this.btnAnnee_Suiv_Duree_Moy.Text = "année suivante";
            this.btnAnnee_Suiv_Duree_Moy.UseVisualStyleBackColor = true;
            this.btnAnnee_Suiv_Duree_Moy.Click += new System.EventHandler(this.btnAnnee_Suiv_Duree_Moy_Click);
            // 
            // DureeMoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 612);
            this.Controls.Add(this.btnAnnee_Suiv_Duree_Moy);
            this.Controls.Add(this.btnAnnee_Prec_Duree_Moy);
            this.Controls.Add(this.chart_Duree_Moy);
            this.Name = "DureeMoy";
            this.Text = "Duree moyenne des séjours";
            this.Load += new System.EventHandler(this.DureeMoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Duree_Moy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Duree_Moy;
        private System.Windows.Forms.Button btnAnnee_Prec_Duree_Moy;
        private System.Windows.Forms.Button btnAnnee_Suiv_Duree_Moy;

    }
}