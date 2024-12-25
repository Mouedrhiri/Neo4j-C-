namespace Neo4j
{
    partial class PageAddDepartment
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
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.txtDepartmentTitle = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.lblDepartmentTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(350, 50);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(200, 20);
            this.txtDepartmentId.TabIndex = 6;
            // 
            // txtDepartmentTitle
            // 
            this.txtDepartmentTitle.Location = new System.Drawing.Point(350, 100);
            this.txtDepartmentTitle.Name = "txtDepartmentTitle";
            this.txtDepartmentTitle.Size = new System.Drawing.Size(200, 20);
            this.txtDepartmentTitle.TabIndex = 7;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(350, 150);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(200, 40);
            this.btnAddDepartment.TabIndex = 8;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Location = new System.Drawing.Point(250, 50);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(94, 13);
            this.lblDepartmentId.TabIndex = 9;
            this.lblDepartmentId.Text = "Department ID:";
            // 
            // lblDepartmentTitle
            // 
            this.lblDepartmentTitle.AutoSize = true;
            this.lblDepartmentTitle.Location = new System.Drawing.Point(250, 100);
            this.lblDepartmentTitle.Name = "lblDepartmentTitle";
            this.lblDepartmentTitle.Size = new System.Drawing.Size(97, 13);
            this.lblDepartmentTitle.TabIndex = 10;
            this.lblDepartmentTitle.Text = "Department Title:";
            // 
            // PageAddDepartment
            // 
            this.Controls.Add(this.lblDepartmentTitle);
            this.Controls.Add(this.lblDepartmentId);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.txtDepartmentTitle);
            this.Controls.Add(this.txtDepartmentId);
            this.Name = "PageAddDepartment";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.TextBox txtDepartmentTitle;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.Label lblDepartmentTitle;
    }
}
