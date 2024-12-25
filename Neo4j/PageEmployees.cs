using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Neo4j
{
    public partial class PageEmployees : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageEmployees(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
            LoadEmployeeList();
        }

        private async void LoadEmployeeList()
        {
            try
            {
                var employees = await _neo4jService.GetEmployeesAsync();
                lstEmployees.Items.Clear();
                foreach (var employee in employees)
                {
                    lstEmployees.Items.Add($"{employee.Id}: {employee.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }
    }
}
