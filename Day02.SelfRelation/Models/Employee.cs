using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.SelfRelation.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Manager
        [ForeignKey("Manager")]
        public int ManagerId { get; set; }
        public Employee Manager { get; set; }
        /*------------------------------------------------------------------*/
        // Relation Manager To Employee
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        /*------------------------------------------------------------------*/
    }
}
