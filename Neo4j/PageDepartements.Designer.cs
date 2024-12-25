namespace Neo4j
{
    partial class PageDepartements
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
            this.lstDepartments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDepartments
            // 
            this.lstDepartments.FormattingEnabled = true;
            this.lstDepartments.Location = new System.Drawing.Point(250, 50);
            this.lstDepartments.Name = "lstDepartments";
            this.lstDepartments.Size = new System.Drawing.Size(200, 147);
            this.lstDepartments.TabIndex = 6;
            // 
            // PageDepartements
            // 
            this.Controls.Add(this.lstDepartments);
            this.Name = "PageDepartements";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDepartments;
    }
}
