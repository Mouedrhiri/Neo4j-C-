namespace Neo4j
{
    partial class PageAdministratif
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Libère toutes les ressources utilisées.
        /// </summary>
        /// <param name="disposing">Indique si les ressources managées doivent être supprimées (true) ou non (false).</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de Windows Forms

        /// <summary> 
        /// Méthode requise pour le concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.lstDepartments = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(250, 50);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(200, 147);
            this.lstEmployees.TabIndex = 6;
            // 
            // lstDepartments
            // 
            this.lstDepartments.FormattingEnabled = true;
            this.lstDepartments.Location = new System.Drawing.Point(250, 220);
            this.lstDepartments.Name = "lstDepartments";
            this.lstDepartments.Size = new System.Drawing.Size(200, 147);
            this.lstDepartments.TabIndex = 7;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(250, 380);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(200, 40);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign Employee to Department";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // PageAdministratif
            // 
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lstDepartments);
            this.Controls.Add(this.lstEmployees);
            this.Name = "PageAdministratif";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.ListBox lstDepartments;
        private System.Windows.Forms.Button btnAssign;
    }
}
