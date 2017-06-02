namespace TableauDeBord
{
    partial class Tableau
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
            this.lblTitreTableau = new System.Windows.Forms.Label();
            this.btn_Pourcentages = new System.Windows.Forms.Button();
            this.occupation2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet5 = new TableauDeBord.tableaudebordDataSet5();
            this.occupation2TableAdapter = new TableauDeBord.tableaudebordDataSet5TableAdapters.Occupation2TableAdapter();
            this.tableau_occupation = new System.Windows.Forms.DataGridView();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeMoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeMoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet7 = new TableauDeBord.tableaudebordDataSet7();
            this.occupationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet6 = new TableauDeBord.tableaudebordDataSet6();
            this.occupationTableAdapter = new TableauDeBord.tableaudebordDataSet6TableAdapters.OccupationTableAdapter();
            this.btn_Duree_Moy = new System.Windows.Forms.Button();
            this.dureeMoyTableAdapter = new TableauDeBord.tableaudebordDataSet7TableAdapters.dureeMoyTableAdapter();
            this.lblService = new System.Windows.Forms.Label();
            this.ComboBox_Service = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet11 = new TableauDeBord.tableaudebordDataSet11();
            this.serviceTableAdapter = new TableauDeBord.tableaudebordDataSet11TableAdapters.ServiceTableAdapter();
            this.linkLabel_RtOccup = new System.Windows.Forms.LinkLabel();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occupation2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_occupation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeMoyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreTableau
            // 
            this.lblTitreTableau.AutoSize = true;
            this.lblTitreTableau.Location = new System.Drawing.Point(29, 31);
            this.lblTitreTableau.Name = "lblTitreTableau";
            this.lblTitreTableau.Size = new System.Drawing.Size(189, 13);
            this.lblTitreTableau.TabIndex = 0;
            this.lblTitreTableau.Text = "Taux d\'occupation des lits de l\'hopital :";
            // 
            // btn_Pourcentages
            // 
            this.btn_Pourcentages.Location = new System.Drawing.Point(260, 368);
            this.btn_Pourcentages.Name = "btn_Pourcentages";
            this.btn_Pourcentages.Size = new System.Drawing.Size(206, 30);
            this.btn_Pourcentages.TabIndex = 3;
            this.btn_Pourcentages.Text = "Afficher le pourcentage par mois";
            this.btn_Pourcentages.UseVisualStyleBackColor = true;
            this.btn_Pourcentages.Click += new System.EventHandler(this.btn_Duree_Moy_Click);
            // 
            // occupation2BindingSource
            // 
            this.occupation2BindingSource.DataMember = "Occupation2";
            this.occupation2BindingSource.DataSource = this.tableaudebordDataSet5;
            // 
            // tableaudebordDataSet5
            // 
            this.tableaudebordDataSet5.DataSetName = "tableaudebordDataSet5";
            this.tableaudebordDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupation2TableAdapter
            // 
            this.occupation2TableAdapter.ClearBeforeFill = true;
            // 
            // tableau_occupation
            // 
            this.tableau_occupation.AutoGenerateColumns = false;
            this.tableau_occupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau_occupation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moisDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.dureeMoyDataGridViewTextBoxColumn});
            this.tableau_occupation.DataSource = this.dureeMoyBindingSource;
            this.tableau_occupation.Location = new System.Drawing.Point(32, 138);
            this.tableau_occupation.Name = "tableau_occupation";
            this.tableau_occupation.Size = new System.Drawing.Size(382, 224);
            this.tableau_occupation.TabIndex = 4;
            this.tableau_occupation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // moisDataGridViewTextBoxColumn
            // 
            this.moisDataGridViewTextBoxColumn.DataPropertyName = "mois";
            this.moisDataGridViewTextBoxColumn.HeaderText = "mois";
            this.moisDataGridViewTextBoxColumn.Name = "moisDataGridViewTextBoxColumn";
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            // 
            // dureeMoyDataGridViewTextBoxColumn
            // 
            this.dureeMoyDataGridViewTextBoxColumn.DataPropertyName = "dureeMoy";
            this.dureeMoyDataGridViewTextBoxColumn.HeaderText = "dureeMoy";
            this.dureeMoyDataGridViewTextBoxColumn.Name = "dureeMoyDataGridViewTextBoxColumn";
            // 
            // dureeMoyBindingSource
            // 
            this.dureeMoyBindingSource.DataMember = "dureeMoy";
            this.dureeMoyBindingSource.DataSource = this.tableaudebordDataSet7;
            // 
            // tableaudebordDataSet7
            // 
            this.tableaudebordDataSet7.DataSetName = "tableaudebordDataSet7";
            this.tableaudebordDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupationBindingSource
            // 
            this.occupationBindingSource.DataMember = "Occupation";
            this.occupationBindingSource.DataSource = this.tableaudebordDataSet6;
            // 
            // tableaudebordDataSet6
            // 
            this.tableaudebordDataSet6.DataSetName = "tableaudebordDataSet6";
            this.tableaudebordDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupationTableAdapter
            // 
            this.occupationTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Duree_Moy
            // 
            this.btn_Duree_Moy.Location = new System.Drawing.Point(32, 368);
            this.btn_Duree_Moy.Name = "btn_Duree_Moy";
            this.btn_Duree_Moy.Size = new System.Drawing.Size(202, 30);
            this.btn_Duree_Moy.TabIndex = 5;
            this.btn_Duree_Moy.Text = "Afficher la durée moyenne de séjour";
            this.btn_Duree_Moy.UseVisualStyleBackColor = true;
            this.btn_Duree_Moy.Click += new System.EventHandler(this.btn_Pourcentages_Click);
            // 
            // dureeMoyTableAdapter
            // 
            this.dureeMoyTableAdapter.ClearBeforeFill = true;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(29, 72);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(127, 13);
            this.lblService.TabIndex = 7;
            this.lblService.Text = "Sélectionner un service : ";
            // 
            // ComboBox_Service
            // 
            this.ComboBox_Service.DataSource = this.serviceBindingSource;
            this.ComboBox_Service.DisplayMember = "libelle";
            this.ComboBox_Service.FormattingEnabled = true;
            this.ComboBox_Service.Location = new System.Drawing.Point(178, 69);
            this.ComboBox_Service.Name = "ComboBox_Service";
            this.ComboBox_Service.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Service.TabIndex = 8;
            this.ComboBox_Service.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Service_SelectedIndexChanged);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.tableaudebordDataSet11;
            // 
            // tableaudebordDataSet11
            // 
            this.tableaudebordDataSet11.DataSetName = "tableaudebordDataSet11";
            this.tableaudebordDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel_RtOccup
            // 
            this.linkLabel_RtOccup.Location = new System.Drawing.Point(0, 0);
            this.linkLabel_RtOccup.Name = "linkLabel_RtOccup";
            this.linkLabel_RtOccup.Size = new System.Drawing.Size(100, 23);
            this.linkLabel_RtOccup.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(339, 404);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Tableau
            // 
            this.ClientSize = new System.Drawing.Size(493, 439);
            this.Controls.Add(this.linkLabel_RtOccup);
            this.Controls.Add(this.ComboBox_Service);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btn_Duree_Moy);
            this.Controls.Add(this.tableau_occupation);
            this.Controls.Add(this.btn_Pourcentages);
            this.Controls.Add(this.lblTitreTableau);
            this.MinimizeBox = false;
            this.Name = "Tableau";
            this.Text = "Tableau du taux d\'occupation";
            this.Load += new System.EventHandler(this.tableau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occupation2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_occupation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeMoyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreTableau;
        private System.Windows.Forms.Button btn_Pourcentages;
        private tableaudebordDataSet5 tableaudebordDataSet5;
        private System.Windows.Forms.BindingSource occupation2BindingSource;
        private tableaudebordDataSet5TableAdapters.Occupation2TableAdapter occupation2TableAdapter;
        private System.Windows.Forms.DataGridView tableau_occupation;
        private tableaudebordDataSet6 tableaudebordDataSet6;
        private System.Windows.Forms.BindingSource occupationBindingSource;
        private tableaudebordDataSet6TableAdapters.OccupationTableAdapter occupationTableAdapter;
        private System.Windows.Forms.Button btn_Duree_Moy;
        private tableaudebordDataSet7 tableaudebordDataSet7;
        private System.Windows.Forms.BindingSource dureeMoyBindingSource;
        private tableaudebordDataSet7TableAdapters.dureeMoyTableAdapter dureeMoyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeMoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox ComboBox_Service;
        private tableaudebordDataSet11 tableaudebordDataSet11;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private tableaudebordDataSet11TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel_RtOccup;
        private System.Windows.Forms.Button btnRetour;
    }
}