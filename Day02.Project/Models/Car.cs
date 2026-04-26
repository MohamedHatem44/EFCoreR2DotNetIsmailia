using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.Project.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Instructor
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        /*------------------------------------------------------------------*/
    }
}
