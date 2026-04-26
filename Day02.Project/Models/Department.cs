namespace Day02.Project.Models
{
    public class Department
    {
        /*------------------------------------------------------------------*/
        // EF Convention
        /*------------------------------------------------------------------*/
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Students
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        /*------------------------------------------------------------------*/
        // Relation With Instructors
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
    }
}
