using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Project.Models
{
    public class StudentCourse
    {
        /*------------------------------------------------------------------*/
        // Relation With Student
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Course
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        /*------------------------------------------------------------------*/
        public int Grade { get; set; }
        /*------------------------------------------------------------------*/
    }
}
