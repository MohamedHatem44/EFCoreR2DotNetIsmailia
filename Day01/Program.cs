using Day01.Context;
using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            AppDbContext db = new AppDbContext();
            /*------------------------------------------------------------------*/
            #region Db Creation Strategy
            // 1- Ensure Created
            // 2- Migrations


            // Dev Only
            // EnsureDeleted
            // ensures that the database for the context does not exist.
            // If it does not exist, no action is taken.
            // If it does exist then the database is deleted.
            db.Database.EnsureDeleted();

            // EnsureCreated
            // • If the database exists and has any tables, then no action is taken. Nothing
            // is done to ensure the database schema is compatible with the Entity Framework
            // model.
            // • If the database exists but does not have any tables, then the Entity Framework
            // model is used to create the database schema.
            // • If the database does not exist, then the database is created and the Entity
            // Framework model is used to create the database schema.
            db.Database.EnsureCreated();
            #endregion
            /*------------------------------------------------------------------*/
            #region Employee
            //Employee e1 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "John Doe",
            //    Age = 25,
            //    Salary = 60000
            //};

            //// Add Employee To Db
            //// 1- Add Employee To Local Container
            ////db.Employees.Add(e1);
            //db.Add(e1);
            ////db.Entry(e1).State = Microsoft.EntityFrameworkCore.EntityState.Added;

            //// 2- Save Changes (Sync)
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Department
            //Department d1 = new Department()
            //{
            //    DeptName = "IT"
            //};

            //db.Add(d1);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Department - Employee
            //Department d2 = new Department()
            //{
            //    DeptName = "IT"
            //};

            //db.Add(d2);
            //db.SaveChanges();

            //// V01
            //Employee e2 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "John Doe",
            //    Age = 25,
            //    Salary = 60000,
            //    DepartmentId = 1
            //};

            //db.Add(e2);
            //db.SaveChanges();

            //// V02
            //var dept = db.Departments.FirstOrDefault();
            //Employee e3 = new Employee()
            //{
            //    Name = "John Doe",
            //    Age = 25,
            //    Salary = 60000,
            //    Department = dept
            //};
            //db.Add(e3);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Department - Employee shadow foreign key
            //Department d3 = new Department()
            //{
            //    DeptName = "IT"
            //};

            //db.Add(d3);
            //db.SaveChanges();

            //Employee e4 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "John Doe",
            //    Age = 25,
            //    Salary = 60000,
            //    DepartmntId = 1
            //};

            //db.Add(e4);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Crud
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            #region Add Departments
            //Department d1 = new Department() { DeptName = "IT" };
            //Department d2 = new Department() { DeptName = "HR" };
            //Department d3 = new Department() { DeptName = "Finance" };
            //Department d4 = new Department() { DeptName = "Marketing" };
            //Department d5 = new Department() { DeptName = "Sales" };

            ////db.AddRange(new Department[] { d1, d2, d3, d4, d5 });
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

            #region Get Employees
            ////SELECT[e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            ////FROM[Employees] AS[e]
            //var employees = db.Employees;
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            ////SELECT TOP(1) [e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            ////FROM[Employees] AS[e]
            //var emp = db.Employees.FirstOrDefault();
            //Console.WriteLine(emp);
            //Console.WriteLine(emp.Department);

            //// Eager Loading
            ////SELECT[e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary], [d].[Id], [d].[DeptName]
            ////FROM[Employees] AS[e]
            ////INNER JOIN[Departments] AS[d] ON[e].[DepartmentId] = [d].[Id]
            //var employeesWithDepartments = db.Employees.Include(e => e.Department);
            //foreach (var item in employeesWithDepartments)
            //{
            //    Console.WriteLine(item);
            //}

            //// Lazy Loading
            //// N + 1 Problem
            //var employees = db.Employees.ToList();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.Department);
            //}
            #endregion

            #region Update
            //// V01 => Recommended
            //// Catch The Object From Db
            //var emp = db.Employees.FirstOrDefault();
            //if (emp != null)
            //{
            //    // Update The Object
            //    emp.Name = "Updated Name";
            //    emp.Salary = 99999;
            //    db.SaveChanges();
            //}

            //// V02 => Not Recommended
            //var emptoUpdate2 = new Employee() { Id = 1, Name = "Updated Name V02", DepartmentId = 2 };
            //db.Update(emptoUpdate2);
            //db.SaveChanges();
            #endregion

            #region Delete
            //// Catch The Object From Db
            //var emp = db.Employees.FirstOrDefault();
            //if(emp != null)
            //{
            //    // Delete The Object
            //    db.Remove(emp);
            //    db.SaveChanges();
            //}
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
