namespace Neo4j
{
    partial class PageWelcome
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">True si les ressources managées doivent être supprimées ; sinon, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur

        /// <summary>
        /// Méthode requise pour le soutien du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNosEmployees = new System.Windows.Forms.Button();
            this.btnNosDepartements = new System.Windows.Forms.Button();
            this.btnAjouterEmployee = new System.Windows.Forms.Button();
            this.btnAjouterDepartement = new System.Windows.Forms.Button();
            this.btnAdministratif = new System.Windows.Forms.Button();
            this.btnVoirComposition = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSidebar.Controls.Add(this.btnVoirComposition);
            this.pnlSidebar.Controls.Add(this.btnAdministratif);
            this.pnlSidebar.Controls.Add(this.btnAjouterDepartement);
            this.pnlSidebar.Controls.Add(this.btnAjouterEmployee);
            this.pnlSidebar.Controls.Add(this.btnNosDepartements);
            this.pnlSidebar.Controls.Add(this.btnNosEmployees);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(150, 450);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNosEmployees
            // 
            this.btnNosEmployees.Location = new System.Drawing.Point(12, 10);
            this.btnNosEmployees.Name = "btnNosEmployees";
            this.btnNosEmployees.Size = new System.Drawing.Size(120, 30);
            this.btnNosEmployees.TabIndex = 0;
            this.btnNosEmployees.Text = "Nos Employés";
            this.btnNosEmployees.UseVisualStyleBackColor = true;
            this.btnNosEmployees.Click += new System.EventHandler(this.btnNosEmployees_Click);
            // 
            // btnNosDepartements
            // 
            this.btnNosDepartements.Location = new System.Drawing.Point(12, 50);
            this.btnNosDepartements.Name = "btnNosDepartements";
            this.btnNosDepartements.Size = new System.Drawing.Size(120, 30);
            this.btnNosDepartements.TabIndex = 1;
            this.btnNosDepartements.Text = "Nos Départements";
            this.btnNosDepartements.UseVisualStyleBackColor = true;
            this.btnNosDepartements.Click += new System.EventHandler(this.btnNosDepartements_Click);
            // 
            // btnAjouterEmployee
            // 
            this.btnAjouterEmployee.Location = new System.Drawing.Point(12, 90);
            this.btnAjouterEmployee.Name = "btnAjouterEmployee";
            this.btnAjouterEmployee.Size = new System.Drawing.Size(120, 30);
            this.btnAjouterEmployee.TabIndex = 2;
            this.btnAjouterEmployee.Text = "Ajouter Employé";
            this.btnAjouterEmployee.UseVisualStyleBackColor = true;
            this.btnAjouterEmployee.Click += new System.EventHandler(this.btnAjouterEmployee_Click);
            // 
            // btnAjouterDepartement
            // 
            this.btnAjouterDepartement.Location = new System.Drawing.Point(12, 130);
            this.btnAjouterDepartement.Name = "btnAjouterDepartement";
            this.btnAjouterDepartement.Size = new System.Drawing.Size(120, 30);
            this.btnAjouterDepartement.TabIndex = 3;
            this.btnAjouterDepartement.Text = "Ajouter Département";
            this.btnAjouterDepartement.UseVisualStyleBackColor = true;
            this.btnAjouterDepartement.Click += new System.EventHandler(this.btnAjouterDepartement_Click);
            // 
            // btnAdministratif
            // 
            this.btnAdministratif.Location = new System.Drawing.Point(12, 170);
            this.btnAdministratif.Name = "btnAdministratif";
            this.btnAdministratif.Size = new System.Drawing.Size(120, 30);
            this.btnAdministratif.TabIndex = 4;
            this.btnAdministratif.Text = "Administratif";
            this.btnAdministratif.UseVisualStyleBackColor = true;
            this.btnAdministratif.Click += new System.EventHandler(this.btnAdministratif_Click);
            // 
            // btnVoirComposition
            // 
            this.btnVoirComposition.Location = new System.Drawing.Point(12, 210);
            this.btnVoirComposition.Name = "btnVoirComposition";
            this.btnVoirComposition.Size = new System.Drawing.Size(120, 30);
            this.btnVoirComposition.TabIndex = 5;
            this.btnVoirComposition.Text = "Voir Composition";
            this.btnVoirComposition.UseVisualStyleBackColor = true;
            this.btnVoirComposition.Click += new System.EventHandler(this.btnVoirComposition_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(150, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(650, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(359, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenue dans l'application de gestion des employés et départements.";
            // 
            // PageWelcome
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "PageWelcome";
            this.Size = new System.Drawing.Size(800, 450);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNosEmployees;
        private System.Windows.Forms.Button btnNosDepartements;
        private System.Windows.Forms.Button btnAjouterEmployee;
        private System.Windows.Forms.Button btnAjouterDepartement;
        private System.Windows.Forms.Button btnAdministratif;
        private System.Windows.Forms.Button btnVoirComposition;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
    }
}
