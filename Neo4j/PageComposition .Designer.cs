namespace Neo4j
{
    partial class PageComposition
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
            this.lstEmployeesInDepartment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEmployeesInDepartment
            // 
            this.lstEmployeesInDepartment.FormattingEnabled = true;
            this.lstEmployeesInDepartment.Location = new System.Drawing.Point(250, 50); // Position du ListBox
            this.lstEmployeesInDepartment.Name = "lstEmployeesInDepartment";
            this.lstEmployeesInDepartment.Size = new System.Drawing.Size(300, 300); // Taille du ListBox
            this.lstEmployeesInDepartment.TabIndex = 7;
            // 
            // PageComposition
            // 
            this.Controls.Add(this.lstEmployeesInDepartment);
            this.Name = "PageComposition";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployeesInDepartment;
    }
}
