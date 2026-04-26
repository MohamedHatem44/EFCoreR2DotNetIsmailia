namespace Day02.Project.Models
{
    public class Course
    {
        /*------------------------------------------------------------------*/
        // Fluent API
        /*------------------------------------------------------------------*/
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public string? Crs_Desc { get; set; }
        public int NoOfHours { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With StudentCourse
        public ICollection<StudentCourse> StudentCourses { get; set; }
        = new HashSet<StudentCourse>();
        /*------------------------------------------------------------------*/
        // Relation With Instructor
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
    }
}
