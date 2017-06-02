namespace TableauDeBord
{
    partial class Choix
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
            this.btnOcc = new System.Windows.Forms.Button();
            this.btnMedoc = new System.Windows.Forms.Button();
            this.lblTitreChoix = new System.Windows.Forms.Label();
            this.lblInter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOcc
            // 
            this.btnOcc.Location = new System.Drawing.Point(60, 226);
            this.btnOcc.Name = "btnOcc";
            this.btnOcc.Size = new System.Drawing.Size(131, 23);
            this.btnOcc.TabIndex = 0;
            this.btnOcc.Text = "Taux d\'occupation";
            this.btnOcc.UseVisualStyleBackColor = true;
            this.btnOcc.Click += new System.EventHandler(this.btnOcc_Click);
            // 
            // btnMedoc
            // 
            this.btnMedoc.Location = new System.Drawing.Point(366, 226);
            this.btnMedoc.Name = "btnMedoc";
            this.btnMedoc.Size = new System.Drawing.Size(128, 23);
            this.btnMedoc.TabIndex = 1;
            this.btnMedoc.Text = "Prix total médicaments";
            this.btnMedoc.UseVisualStyleBackColor = true;
            this.btnMedoc.Click += new System.EventHandler(this.btnMedoc_Click);
            // 
            // lblTitreChoix
            // 
            this.lblTitreChoix.AutoSize = true;
            this.lblTitreChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreChoix.Location = new System.Drawing.Point(151, 96);
            this.lblTitreChoix.Name = "lblTitreChoix";
            this.lblTitreChoix.Size = new System.Drawing.Size(257, 25);
            this.lblTitreChoix.TabIndex = 2;
            this.lblTitreChoix.Text = "Que souhaitez-vous voir?";
            // 
            // lblInter
            // 
            this.lblInter.AutoSize = true;
            this.lblInter.Location = new System.Drawing.Point(264, 231);
            this.lblInter.Name = "lblInter";
            this.lblInter.Size = new System.Drawing.Size(19, 13);
            this.lblInter.TabIndex = 3;
            this.lblInter.Text = "ou";
            // 
            // Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 366);
            this.Controls.Add(this.lblInter);
            this.Controls.Add(this.lblTitreChoix);
            this.Controls.Add(this.btnMedoc);
            this.Controls.Add(this.btnOcc);
            this.Name = "Choix";
            this.Text = "Choix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcc;
        private System.Windows.Forms.Button btnMedoc;
        private System.Windows.Forms.Label lblTitreChoix;
        private System.Windows.Forms.Label lblInter;
    }
}