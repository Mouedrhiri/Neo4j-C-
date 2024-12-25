using System;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class PageWelcome : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageWelcome(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
            lblWelcome.Text = "Bienvenue dans l'application de gestion des employés et départements.";
        }

        // Événements pour chaque bouton dans la barre latérale
        private void btnNosEmployees_Click(object sender, EventArgs e)
        {
            ShowPage(new PageEmployees(_neo4jService));
        }

        private void btnNosDepartements_Click(object sender, EventArgs e)
        {
            ShowPage(new PageDepartements(_neo4jService));
        }

        private void btnAjouterEmployee_Click(object sender, EventArgs e)
        {
            ShowPage(new PageAddEmployee(_neo4jService));
        }

        private void btnAjouterDepartement_Click(object sender, EventArgs e)
        {
            ShowPage(new PageAddDepartment(_neo4jService));
        }

        private void btnAdministratif_Click(object sender, EventArgs e)
        {
            ShowPage(new PageAdministratif(_neo4jService));
        }

        private void btnVoirComposition_Click(object sender, EventArgs e)
        {
            ShowPage(new PageComposition(_neo4jService));
        }

        // Méthode pour afficher une autre page dans le panneau principal
        private void ShowPage(UserControl page)
        {
            pnlMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(page);
        }
    }
}
