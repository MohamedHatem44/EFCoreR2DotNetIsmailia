using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.OneToOnePP.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With EmployeeCar
        public EmployeeCar EmployeeCar { get; set; }
        /*------------------------------------------------------------------*/
    }
}
