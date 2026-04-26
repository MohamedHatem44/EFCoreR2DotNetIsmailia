namespace Day02.Project.Models
{
    public class Student
    {
        /*------------------------------------------------------------------*/
        // External Class Configuration
        /*------------------------------------------------------------------*/
        public int StdId { get; set; }
        public string StdName { get; set; }
        public string StdDesc { get; set; }
        public int Age { get; set; }
        public DateOnly DOF { get; set; }
        public string Email { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department
        public int DeptId { get; set; }
        public Department Department { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With StudentCourse
        public ICollection<StudentCourse> StudentCourses { get; set; }
        = new HashSet<StudentCourse>();
        /*------------------------------------------------------------------*/
    }
}
