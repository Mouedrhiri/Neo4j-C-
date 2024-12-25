using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neo4j
{
    public class Neo4jService
    {
        private readonly IGraphClient _client;

        public Neo4jService()
        {
            _client = new BoltGraphClient(new Uri("bolt://localhost:7687"), "neo4j", "casa+fes11");
            _client.ConnectAsync().Wait();
        }

        // Créer un employé dans Neo4j
        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _client.Cypher
                .Create("(e:Employee $employee)")
                .WithParam("employee", new
                {
                    employee.Id,
                    employee.Name
                })
                .ExecuteWithoutResultsAsync();
        }

        // Créer un département dans Neo4j
        public async Task CreateDepartmentAsync(Department department)
        {
            await _client.Cypher
                .Create("(d:Department $department)")
                .WithParam("department", new
                {
                    department.Id,
                    department.Title
                })
                .ExecuteWithoutResultsAsync();
        }

        // Associer un employé à un département
        public async Task AssignEmployeeToDepartmentAsync(int employeeId, int departmentId)
        {
            await _client.Cypher
                .Match("(e:Employee)", "(d:Department)")
                .Where((Employee e) => e.Id == employeeId)
                .AndWhere((Department d) => d.Id == departmentId)
                .Create("(e)-[:ASSIGNED_TO]->(d)")
                .ExecuteWithoutResultsAsync();
        }

        // Récupérer tous les départements
        public async Task<List<Department>> GetDepartmentsAsync()
        {
            var departments = await _client.Cypher
                .Match("(d:Department)")
                .Return(d => d.As<Department>())
                .ResultsAsync;

            return departments.ToList();
        }

        // Récupérer tous les employés
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var employees = await _client.Cypher
                .Match("(e:Employee)")
                .Return(e => e.As<Employee>())
                .ResultsAsync;

            return employees.ToList();
        }

        // Récupérer les départements assignés à un employé
        public async Task<List<Department>> GetAssignedDepartmentsForEmployee(int employeeId)
        {
            var departments = await _client.Cypher
                .Match("(e:Employee)-[:ASSIGNED_TO]->(d:Department)")
                .Where((Employee e) => e.Id == employeeId)
                .Return(d => d.As<Department>())
                .ResultsAsync;

            return departments.ToList();
        }
    }
}
