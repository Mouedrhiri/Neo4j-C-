using System.Collections.Generic;

namespace Neo4j
{
    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}