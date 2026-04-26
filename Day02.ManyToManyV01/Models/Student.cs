namespace Day02.ManyToManyV01.Models
{
    public class Student
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        // Many-to-Many: Course <-> Student
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        /*------------------------------------------------------------------*/
    }
}
