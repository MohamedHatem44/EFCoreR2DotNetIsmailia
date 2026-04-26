namespace Day02.OneToOnePP.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With EmployeeCar
        public EmployeeCar EmployeeCar { get; set; }
        /*------------------------------------------------------------------*/
    }
}
