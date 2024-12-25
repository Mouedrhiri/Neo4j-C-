using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Neo4j
{
    public partial class PageDepartements : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageDepartements(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
            LoadDepartmentList();
        }

        private async void LoadDepartmentList()
        {
            try
            {
                var departments = await _neo4jService.GetDepartmentsAsync();
                lstDepartments.Items.Clear();
                foreach (var dept in departments)
                {
                    lstDepartments.Items.Add($"{dept.Id}: {dept.Title}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }
    }
}
