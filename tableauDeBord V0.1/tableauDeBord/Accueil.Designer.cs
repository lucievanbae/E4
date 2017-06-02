namespace TableauDeBord
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMdp = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.btnValider_Connexion = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(27, 81);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(27, 13);
            this.lblMdp.TabIndex = 0;
            this.lblMdp.Text = "mdp";
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(70, 78);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(104, 20);
            this.mdp.TabIndex = 2;
            this.mdp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(27, 35);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lbl_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(70, 32);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 20);
            this.login.TabIndex = 1;
            // 
            // btnValider_Connexion
            // 
            this.btnValider_Connexion.Location = new System.Drawing.Point(81, 155);
            this.btnValider_Connexion.Name = "btnValider_Connexion";
            this.btnValider_Connexion.Size = new System.Drawing.Size(75, 23);
            this.btnValider_Connexion.TabIndex = 3;
            this.btnValider_Connexion.Text = "Valider";
            this.btnValider_Connexion.UseVisualStyleBackColor = true;
            this.btnValider_Connexion.Click += new System.EventHandler(this.btnValider_Connexion_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(37, 120);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(101, 13);
            this.lblErreur.TabIndex = 5;
            this.lblErreur.Text = "erreur de connexion";
            this.lblErreur.Visible = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnValider_Connexion);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.lblMdp);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button btnValider_Connexion;
        private System.Windows.Forms.Label lblErreur;
    }
}

