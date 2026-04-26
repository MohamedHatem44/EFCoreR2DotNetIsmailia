using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.OneToOnePP.Models
{
    public class EmployeeCar
    {
        /*------------------------------------------------------------------*/
        // Relation With Employee
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Car
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
