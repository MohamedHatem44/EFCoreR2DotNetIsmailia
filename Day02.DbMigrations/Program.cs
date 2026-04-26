using Day02.DbMigrations.Context;
using Day02.DbMigrations.Models;

namespace Day02.DbMigrations
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
            #region Migrations
            // Tools
            // Add-Migration <MigrationName>
            // Add-Migration V01

            // Update-Database

            // Remove-Migration
            #endregion
            /*------------------------------------------------------------------*/
            #region Crud
            #region Add Departments
            //Department d1 = new Department() { DeptName = "IT" };
            //Department d2 = new Department() { DeptName = "HR" };
            //Department d3 = new Department() { DeptName = "Finance" };
            //Department d4 = new Department() { DeptName = "Marketing" };
            //Department d5 = new Department() { DeptName = "Sales" };

            //db.AddRange(d1, d2, d3, d4, d5);
            //db.SaveChanges();
            #endregion

            #region Add Employees
            //Employee e1 = new Employee() { Name = "John Doe", Age = 25, Salary = 60000, DepartmentId = 1 };
            //Employee e2 = new Employee() { Name = "Jane Smith", Age = 30, Salary = 75000, DepartmentId = 2 };
            //Employee e3 = new Employee() { Name = "Michael Johnson", Age = 35, Salary = 90000, DepartmentId = 3 };
            //Employee e4 = new Employee() { Name = "Emily Davis", Age = 28, Salary = 65000, DepartmentId = 4 };
            //Employee e5 = new Employee() { Name = "David Wilson", Age = 40, Salary = 120000, DepartmentId = 5 };
            //db.AddRange(e1, e2, e3, e4, e5);
            //db.SaveChanges();
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
            #region Test Guid
            //string guid = Guid.NewGuid().ToString();
            // 2CE73C0C-89C3-4C13-78E3-08DEA3ACC188
            //TestGuid tg1 = new TestGuid()
            //{
            //    Name = "Test Guid 1"
            //};
            //db.Add(tg1);
            //db.SaveChanges();

            //TestGuid tg2 = new TestGuid()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Test Guid 2"
            //};
            //db.Add(tg2);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
