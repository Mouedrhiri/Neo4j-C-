using System;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class PageAdministratif : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageAdministratif(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
            LoadData();
        }

        private async void LoadData()
        {
            var employees = await _neo4jService.GetEmployeesAsync();
            var departments = await _neo4jService.GetDepartmentsAsync();

            foreach (var employee in employees)
            {
                lstEmployees.Items.Add($"{employee.Id}: {employee.Name}");
            }

            foreach (var dept in departments)
            {
                lstDepartments.Items.Add($"{dept.Id}: {dept.Title}");
            }
        }

        private async void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeId = int.Parse(lstEmployees.SelectedItem.ToString().Split(':')[0]);
                var departmentId = int.Parse(lstDepartments.SelectedItem.ToString().Split(':')[0]);

                await _neo4jService.AssignEmployeeToDepartmentAsync(employeeId, departmentId);
                MessageBox.Show("Employee Assigned Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning employee: {ex.Message}");
            }
        }
    }
}
