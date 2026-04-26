namespace Day02.ManyToManyV02.Models
{
    public class Student
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        /*------------------------------------------------------------------*/
    }
}
