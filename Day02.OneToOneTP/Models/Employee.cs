namespace Day02.OneToOneTP.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Car
        public Car Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
