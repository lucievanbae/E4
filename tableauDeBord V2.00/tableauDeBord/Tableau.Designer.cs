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
            this.ComboBox_Service = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet13 = new TableauDeBord.tableaudebordDataSet13();
            this.lblService = new System.Windows.Forms.Label();
            this.lblTitreTableau = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btn_Duree_Moy = new System.Windows.Forms.Button();
            this.btn_Pourcentages = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.occupationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet12 = new TableauDeBord.tableaudebordDataSet12();
            this.occupationTableAdapter = new TableauDeBord.tableaudebordDataSet12TableAdapters.OccupationTableAdapter();
            this.serviceTableAdapter = new TableauDeBord.tableaudebordDataSet13TableAdapters.ServiceTableAdapter();
            this.tableaudebordDataSet14 = new TableauDeBord.tableaudebordDataSet14();
            this.dureeMoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dureeMoyTableAdapter = new TableauDeBord.tableaudebordDataSet14TableAdapters.dureeMoyTableAdapter();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbLitsOccupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeMoyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Service
            // 
            this.ComboBox_Service.DataSource = this.serviceBindingSource;
            this.ComboBox_Service.DisplayMember = "libelle";
            this.ComboBox_Service.FormattingEnabled = true;
            this.ComboBox_Service.Location = new System.Drawing.Point(188, 84);
            this.ComboBox_Service.Name = "ComboBox_Service";
            this.ComboBox_Service.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Service.TabIndex = 11;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.tableaudebordDataSet13;
            // 
            // tableaudebordDataSet13
            // 
            this.tableaudebordDataSet13.DataSetName = "tableaudebordDataSet13";
            this.tableaudebordDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(39, 87);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(127, 13);
            this.lblService.TabIndex = 10;
            this.lblService.Text = "Sélectionner un service : ";
            // 
            // lblTitreTableau
            // 
            this.lblTitreTableau.AutoSize = true;
            this.lblTitreTableau.Location = new System.Drawing.Point(39, 46);
            this.lblTitreTableau.Name = "lblTitreTableau";
            this.lblTitreTableau.Size = new System.Drawing.Size(189, 13);
            this.lblTitreTableau.TabIndex = 9;
            this.lblTitreTableau.Text = "Taux d\'occupation des lits de l\'hopital :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(348, 383);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btn_Duree_Moy
            // 
            this.btn_Duree_Moy.Location = new System.Drawing.Point(41, 347);
            this.btn_Duree_Moy.Name = "btn_Duree_Moy";
            this.btn_Duree_Moy.Size = new System.Drawing.Size(202, 30);
            this.btn_Duree_Moy.TabIndex = 13;
            this.btn_Duree_Moy.Text = "Afficher la durée moyenne de séjour";
            this.btn_Duree_Moy.UseVisualStyleBackColor = true;
            this.btn_Duree_Moy.Click += new System.EventHandler(this.btn_Duree_Moy_Click);
            // 
            // btn_Pourcentages
            // 
            this.btn_Pourcentages.Location = new System.Drawing.Point(277, 347);
            this.btn_Pourcentages.Name = "btn_Pourcentages";
            this.btn_Pourcentages.Size = new System.Drawing.Size(206, 30);
            this.btn_Pourcentages.TabIndex = 12;
            this.btn_Pourcentages.Text = "Afficher le pourcentage par mois";
            this.btn_Pourcentages.UseVisualStyleBackColor = true;
            this.btn_Pourcentages.Click += new System.EventHandler(this.btn_Pourcentages_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moisDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.nbLitsOccupDataGridViewTextBoxColumn,
            this.idServiceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.occupationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 230);
            this.dataGridView1.TabIndex = 15;
            // 
            // occupationBindingSource
            // 
            this.occupationBindingSource.DataMember = "Occupation";
            this.occupationBindingSource.DataSource = this.tableaudebordDataSet12;
            // 
            // tableaudebordDataSet12
            // 
            this.tableaudebordDataSet12.DataSetName = "tableaudebordDataSet12";
            this.tableaudebordDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupationTableAdapter
            // 
            this.occupationTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableaudebordDataSet14
            // 
            this.tableaudebordDataSet14.DataSetName = "tableaudebordDataSet14";
            this.tableaudebordDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dureeMoyBindingSource
            // 
            this.dureeMoyBindingSource.DataMember = "dureeMoy";
            this.dureeMoyBindingSource.DataSource = this.tableaudebordDataSet14;
            // 
            // dureeMoyTableAdapter
            // 
            this.dureeMoyTableAdapter.ClearBeforeFill = true;
            // 
            // moisDataGridViewTextBoxColumn
            // 
            this.moisDataGridViewTextBoxColumn.DataPropertyName = "Mois";
            this.moisDataGridViewTextBoxColumn.HeaderText = "Mois";
            this.moisDataGridViewTextBoxColumn.Name = "moisDataGridViewTextBoxColumn";
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            // 
            // nbLitsOccupDataGridViewTextBoxColumn
            // 
            this.nbLitsOccupDataGridViewTextBoxColumn.DataPropertyName = "nbLitsOccup";
            this.nbLitsOccupDataGridViewTextBoxColumn.HeaderText = "nbLitsOccup";
            this.nbLitsOccupDataGridViewTextBoxColumn.Name = "nbLitsOccupDataGridViewTextBoxColumn";
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            this.idServiceDataGridViewTextBoxColumn.DataPropertyName = "idService";
            this.idServiceDataGridViewTextBoxColumn.HeaderText = "idService";
            this.idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 418);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btn_Duree_Moy);
            this.Controls.Add(this.btn_Pourcentages);
            this.Controls.Add(this.ComboBox_Service);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblTitreTableau);
            this.Name = "Tableau";
            this.Text = "Tableau";
            this.Load += new System.EventHandler(this.Tableau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeMoyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Service;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblTitreTableau;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btn_Duree_Moy;
        private System.Windows.Forms.Button btn_Pourcentages;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tableaudebordDataSet12 tableaudebordDataSet12;
        private System.Windows.Forms.BindingSource occupationBindingSource;
        private tableaudebordDataSet12TableAdapters.OccupationTableAdapter occupationTableAdapter;
        private tableaudebordDataSet13 tableaudebordDataSet13;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private tableaudebordDataSet13TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private tableaudebordDataSet14 tableaudebordDataSet14;
        private System.Windows.Forms.BindingSource dureeMoyBindingSource;
        private tableaudebordDataSet14TableAdapters.dureeMoyTableAdapter dureeMoyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbLitsOccupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
    }
}