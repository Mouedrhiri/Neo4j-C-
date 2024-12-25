using System;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class PageAddDepartment : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageAddDepartment(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
        }

        private async void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new Department
                {
                    Id = int.Parse(txtDepartmentId.Text),
                    Title = txtDepartmentTitle.Text
                };

                await _neo4jService.CreateDepartmentAsync(department);
                MessageBox.Show("Department Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating department: {ex.Message}");
            }
        }
    }
}
