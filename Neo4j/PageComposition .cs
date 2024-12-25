using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class PageComposition : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageComposition(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
            LoadComposition();
        }

        private async void LoadComposition()
        {
            try
            {
                // Récupérer les départements depuis le service Neo4j
                var departments = await _neo4jService.GetDepartmentsAsync();
                var employees = await _neo4jService.GetEmployeesAsync();

                // Vider la ListBox avant de la remplir
                lstEmployeesInDepartment.Items.Clear();

                // Associer chaque employé à ses départements
                foreach (var employee in employees)
                {
                    // Récupérer les départements associés à cet employé
                    var assignedDepartments = await _neo4jService.GetAssignedDepartmentsForEmployee(employee.Id);

                    // Si l'employé a des départements assignés
                    foreach (var department in assignedDepartments)
                    {
                        // Ajouter une entrée sous forme de chaîne "Nom de l'employé | Département"
                        lstEmployeesInDepartment.Items.Add($"{employee.Name} | {department.Title}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading composition: {ex.Message}");
            }
        }
    }
}
