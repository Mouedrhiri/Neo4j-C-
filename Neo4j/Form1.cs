using System.Windows.Forms;
using System;

namespace Neo4j
{
    public partial class Form1 : Form
    {
        private readonly Neo4jService _neo4jService;

        public Form1()
        {
            InitializeComponent();
            _neo4jService = new Neo4jService();
            SetPlaceholders();
            ShowWelcomePage();
        }

        private void SetPlaceholders()
        {
            // Vous pouvez définir des placeholders ici si nécessaire
        }

        // Événements pour les boutons de la sidebar
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

        // Méthode pour afficher une page dans le panneau principal
        private void ShowPage(UserControl page)
        {
            pnlMain.Controls.Clear(); // Efface les pages précédentes
            page.Dock = DockStyle.Fill; // Remplit tout l'espace du panneau principal
            pnlMain.Controls.Add(page); // Ajoute la nouvelle page dans le panneau principal
        }

        // Affiche la page de bienvenue au début
        private void ShowWelcomePage()
        {
            ShowPage(new PageWelcome(_neo4jService)); // Page d'accueil
        }
    }
}
