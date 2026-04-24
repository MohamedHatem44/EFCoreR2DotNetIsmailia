// How To Wirte Model Class With EF RunTime
// 1- EF Conventions
// 2- DataAnnotaions => System.ComponentModel.DataAnnotations;
// 3- Fluent API        => OnModelCreating => Contexts
// 4- External Class Configration => External Files And Call it into OnModelCreating => Contexts


// EF Conventions
// 1- PK => Primitive int Id , ClassNameId, EmployeeId => PK
// 2- PK => Identity
// 3- Any Value Type By Default => Not Null
// 3- Any Reference Type By Default => Null
// 4- String => nvarchar(max) 2GB

// Before C# 8
// Reference Null
// After C#
// Non-Nullable
// Fire Warning


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day01.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department
        // Navigational Property
        // Reference To Department Class

        //[ForeignKey("Department")]
        //[ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        //[ForeignKey("DepartmentId")]
        //[ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Department Id: {DepartmentId}, Department: => {Department} <= ";
        }
        /*------------------------------------------------------------------*/
    }
}


// public int DepartmentId { get; set; }  => Required
// public int? DepartmentId { get; set; } => Optional
