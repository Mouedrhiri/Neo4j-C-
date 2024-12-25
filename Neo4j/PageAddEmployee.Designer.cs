namespace Neo4j
{
    partial class PageAddEmployee
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
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(350, 50);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeId.TabIndex = 6;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(350, 100);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(350, 150);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 40);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(250, 50);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeId.TabIndex = 9;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(250, 100);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployeeName.TabIndex = 10;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // PageAddEmployee
            // 
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeId);
            this.Name = "PageAddEmployee";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}
