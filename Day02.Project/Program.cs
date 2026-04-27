using Day02.Project.Context;
using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Context
            AppDbContext db = new AppDbContext();
            #endregion
            /*------------------------------------------------------------------*/
            //Instructor instructor = new Instructor
            //{
            //    Ins_Name = "Ismailia",
            //    Ins_Desc = "Ismailia is a city in Egypt.",
            //    Salary = 4000,
            //    Address = "123 Main St, Ismailia, Egypt",
            //    Email = "instructor@mail.com"
            //};
            //db.Add(instructor);
            //db.SaveChanges();
            /*------------------------------------------------------------------*/
            //var instructors = db.Instructors.IgnoreQueryFilters().ToList();
            /*------------------------------------------------------------------*/
        }
    }
}