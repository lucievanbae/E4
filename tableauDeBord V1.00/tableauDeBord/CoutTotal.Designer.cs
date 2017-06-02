namespace TableauDeBord
{
    partial class CoutTotal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMedoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.coutTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet10 = new TableauDeBord.tableaudebordDataSet10();
            this.coutTotalTableAdapter = new TableauDeBord.tableaudebordDataSet10TableAdapters.CoutTotalTableAdapter();
            this.btnAnnee_Prec_CT = new System.Windows.Forms.Button();
            this.btnAnnee_Suiv_CT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coutTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMedoc
            // 
            this.chartMedoc.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chartMedoc.ChartAreas.Add(chartArea1);
            this.chartMedoc.DataSource = this.coutTotalBindingSource;
            this.chartMedoc.Location = new System.Drawing.Point(12, 12);
            this.chartMedoc.Name = "chartMedoc";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Mois";
            this.chartMedoc.Series.Add(series1);
            this.chartMedoc.Size = new System.Drawing.Size(632, 459);
            this.chartMedoc.TabIndex = 4;
            this.chartMedoc.Text = "chart1";
            title1.Name = "Pourcentage";
            this.chartMedoc.Titles.Add(title1);
            // 
            // coutTotalBindingSource
            // 
            this.coutTotalBindingSource.DataMember = "CoutTotal";
            this.coutTotalBindingSource.DataSource = this.tableaudebordDataSet10;
            // 
            // tableaudebordDataSet10
            // 
            this.tableaudebordDataSet10.DataSetName = "tableaudebordDataSet10";
            this.tableaudebordDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coutTotalTableAdapter
            // 
            this.coutTotalTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnee_Prec_CT
            // 
            this.btnAnnee_Prec_CT.Location = new System.Drawing.Point(56, 496);
            this.btnAnnee_Prec_CT.Name = "btnAnnee_Prec_CT";
            this.btnAnnee_Prec_CT.Size = new System.Drawing.Size(114, 23);
            this.btnAnnee_Prec_CT.TabIndex = 5;
            this.btnAnnee_Prec_CT.Text = "Année précédente";
            this.btnAnnee_Prec_CT.UseVisualStyleBackColor = true;
            this.btnAnnee_Prec_CT.Click += new System.EventHandler(this.btnAnnee_Prec_CT_Click);
            // 
            // btnAnnee_Suiv_CT
            // 
            this.btnAnnee_Suiv_CT.Location = new System.Drawing.Point(500, 496);
            this.btnAnnee_Suiv_CT.Name = "btnAnnee_Suiv_CT";
            this.btnAnnee_Suiv_CT.Size = new System.Drawing.Size(100, 23);
            this.btnAnnee_Suiv_CT.TabIndex = 6;
            this.btnAnnee_Suiv_CT.Text = "Année suivante";
            this.btnAnnee_Suiv_CT.UseVisualStyleBackColor = true;
            this.btnAnnee_Suiv_CT.Click += new System.EventHandler(this.btnAnnee_Suiv_CT_Click);
            // 
            // CoutTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 601);
            this.Controls.Add(this.btnAnnee_Suiv_CT);
            this.Controls.Add(this.btnAnnee_Prec_CT);
            this.Controls.Add(this.chartMedoc);
            this.Name = "CoutTotal";
            this.Text = "CoutTotal";
            this.Load += new System.EventHandler(this.CoutTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coutTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedoc;
        private tableaudebordDataSet10 tableaudebordDataSet10;
        private System.Windows.Forms.BindingSource coutTotalBindingSource;
        private tableaudebordDataSet10TableAdapters.CoutTotalTableAdapter coutTotalTableAdapter;
        private System.Windows.Forms.Button btnAnnee_Prec_CT;
        private System.Windows.Forms.Button btnAnnee_Suiv_CT;
    }
}