using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.OneToOneTP.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Employee
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        /*------------------------------------------------------------------*/
    }
}
