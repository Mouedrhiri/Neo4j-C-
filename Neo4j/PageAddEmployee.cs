using System;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class PageAddEmployee : UserControl
    {
        private readonly Neo4jService _neo4jService;

        public PageAddEmployee(Neo4jService neo4jService)
        {
            InitializeComponent();
            _neo4jService = neo4jService;
        }

        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee
                {
                    Id = int.Parse(txtEmployeeId.Text),
                    Name = txtEmployeeName.Text
                };

                await _neo4jService.CreateEmployeeAsync(employee);
                MessageBox.Show("Employee Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating employee: {ex.Message}");
            }
        }
    }
}
