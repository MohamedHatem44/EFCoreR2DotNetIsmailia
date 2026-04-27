using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Project.Models
{
    // Domain Model
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        // Using Data Annotations
        /*------------------------------------------------------------------*/
        [Key]
        public int InstId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)] // Data Annotation for Validation
        public string Ins_Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Ins_Desc { get; set; }

        [Column(TypeName = "decimal(8,2)")]   // Total 8 123456.78
        [Range(1000, 10000)]
        public decimal Salary { get; set; }

        [StringLength(250, MinimumLength = 10)]
        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        /*------------------------------------------------------------------*/
        public bool IsDeleted { get; set; }
        /*------------------------------------------------------------------*/
        // Not in DB
        [NotMapped]
        public int NoOfCourses { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Courses
        public ICollection<Course> Courses { get; set; }
        = new HashSet<Course>();
        /*------------------------------------------------------------------*/
        // Relation With Car
        public Car? Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
