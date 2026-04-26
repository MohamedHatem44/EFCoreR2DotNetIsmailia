using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.DbMigrations.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Age2 { get; set; }
        public decimal Salary { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        //public string Address3 { get; set; }
        //public string Address4 { get; set; }
        /*------------------------------------------------------------------*/
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Department Id: {DepartmentId}, Department: => {Department} <= ";
        }
        /*------------------------------------------------------------------*/
    }
}
