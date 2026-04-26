namespace Day02.ManyToManyV01.Models
{
    public class Course
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        // Many-to-Many: Course <-> Student
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        /*------------------------------------------------------------------*/
    }
}
