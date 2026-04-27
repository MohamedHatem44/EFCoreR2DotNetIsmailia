using Day03.PubsDbFirst.Context;
using Day03.PubsDbFirst.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Contracts;
using System.Net;
using System.Numerics;

namespace Day03.PubsDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Context
            PubsDbContext db = new PubsDbContext();
            #endregion
            /*------------------------------------------------------------------*/
            #region Authors
            //var authors = db.Authors.ToList();
            //foreach (var item in authors)
            //{
            //    Console.WriteLine(item.AuFname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Tracking
            //// EF By Default Track Recrod That Retrive from DataBase
            //// And Save it into memory (Local)
            //// So If We Change Any Value in This Record It Will Be Changed in Memory Not In DataBase
            //// Sync With DataBase When We Call SaveChanges Method
            //// Can Use Memeory To Retrive Data and reduce Db Overhead

            //var employee = db.Employees.FirstOrDefault();
            //Console.WriteLine(employee.Fname);
            //employee.Fname = "Omar"; // Entity State Changed To Modified
            ////db.Entry.State(employee).CurrentValues.SetValues(employee); // Entity State Changed To Unchanged
            //db.ChangeTracker.Clear(); // Clear All Change Tracker And Local
            //db.SaveChanges();
            //Console.WriteLine(employee.Fname);

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(db.Employees.Count()); // 43
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(db.Employees.Local.Count());  // 0
            //var employees = db.Employees;
            //Console.WriteLine(db.Employees.Local.Count());  // 0
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(db.Employees.Local.Count());  // 0
            //var employees = db.Employees.ToList();
            //Console.WriteLine(db.Employees.Local.Count());  // 43
            //Console.WriteLine("-----------------------------------");
            //var q1 = db.Employees.Where(e => e.JobLvl < 100).ToList(); // 9
            //Console.WriteLine(q1.Count());  // 9
            //Console.WriteLine(db.Employees.Local.Count());  // 9
            //var q2 = db.Employees.Where(e => e.JobLvl >= 100).ToList();  // 34
            //Console.WriteLine(q2.Count());  // 34
            //Console.WriteLine(db.Employees.Local.Count());  // 43
            //Console.WriteLine("-----------------------------------");
            ////db.ChangeTracker.Clear(); // Clear All Change Tracker And Local
            //Console.WriteLine("-----------------------------------");
            //var q3 = db.Employees.Local.ToList();
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item.Fname);
            //}
            //Console.WriteLine("-----------------------------------");
            //var q4 = db.Employees.AsNoTracking().ToList();
            //Console.WriteLine(db.Employees.Local.Count());  // 0
            //foreach (var item in q4)
            //{
            //    Console.WriteLine(item.Fname);
            //}
            //Console.WriteLine("-----------------------------------");

            // For Displaying => AsNoTracking
            // For Update / Delete => Tracking

            // Get All => AsNoTracking
            // Get By Id => Tracking
            #endregion
            /*------------------------------------------------------------------*/
            #region Find
            //// Return Single Record By Primary Key
            //// Find(PK[]) => If PK Is Composite Key We Need To Pass All Keys
            //// By Default
            //// Search In Local First if Found Return It
            //// If Not Found Connect to DB And Search For It 
            //// If Found Return It And Save It In Local For Next Search
            //// Track Element
            //// If Not Found Return Null and no exception

            ////exec sp_executesql N'SELECT TOP(1) [e].[emp_id], [e].[fname],
            ////[e].[hire_date], [e].[job_id], [e].[job_lvl], [e].[lname],
            ////[e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            ////WHERE[e].[emp_id] = @__p_0',N'@__p_0 char(9)',@__p_0='PMA42628M'
            //var employees = db.Employees.AsNoTracking().ToList();
            //var id = "PMA42628M";
            //var employee = db.Employees.Find(id);
            //if (employee == null)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{

            //    Console.WriteLine(employee.Fname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Explicit Loading
            //// Load All Data in the First Request and Store it in Local
            //Console.WriteLine(db.Employees.Local.Count()); // 0
            //db.Employees.Local.Clear(); // Clear Local
            //db.Employees.Load(); // Explicit Loading
            //Console.WriteLine(db.Employees.Local.Count()); // 43
            #endregion
            /*------------------------------------------------------------------*/
            #region AsEnumerable vs AsQueryable
            //// AsQueryable
            //// Execute Query In DataBase And Return Result
            //// Filter in DataBase => Better Performance
            //// System.Linq.Queryable => For Query That Execute In DataBase

            //// AsEnumerable
            //// Execute Query In Memory
            //// System.Collections.Generic.Enumerable => For Query That Execute In Memory

            //Console.WriteLine("-----------------------------------");
            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            ////[e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            //var q1 = db.Employees.AsEnumerable();
            //var q1F = q1.Where(e => e.JobLvl < 100).ToList();
            //foreach (var item in q1F)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------");
            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            ////[e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit],
            ////[e].[pub_id]
            ////FROM[employee] AS[e]
            ////WHERE[e].[job_lvl] < CAST(100 AS tinyint)
            //var q2 = db.Employees.AsQueryable();
            //var q2F = q2.Where(e => e.JobLvl < 100).ToList();
            //foreach (var item in q2F)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------");
            #endregion
            /*------------------------------------------------------------------*/
            #region Bulk Update and Bulk Delete
            //// Bulk Update
            //db.Employees
            //    .Where(e=>e.JobLvl < 100)
            //    .ExecuteUpdate(s=> s.SetProperty(e=>e.JobLvl, e=>e.JobLvl - 10));

            //// Bulk Delete
            //db.Employees
            //    .Where(e => e.JobLvl < 100)
            //    .ExecuteDelete();
            #endregion
            /*------------------------------------------------------------------*/
            #region SQL Query
            //// Select * from authors
            //var q1 = db.Authors.FromSqlRaw("SELECT * FROM authors").ToList();
            //var q2 = db.Authors.FromSqlRaw("SELECT * FROM authors").OrderBy(a => a.AuFname).ToList();

            ////SELECT[d].[au_id], [d].[address], [d].[au_fname], [d].[au_lname], [d].[city],
            ////[d].[contract], [d].[phone], [d].[state], [d].[zip]
            ////FROM(
            ////    SELECT * FROM authors where au_id = '172-32-1176'
            ////) AS[d]
            ////ORDER BY[d].[au_fname]

            //var id = "172-32-1176";
            //var q3 = db.Authors.FromSqlRaw($"SELECT * FROM authors where au_id ='{id}'").OrderBy(a => a.AuFname).ToList();

            ////exec sp_executesql N'SELECT * FROM authors where au_id = @id
            ////',N'@id nvarchar(11)',@id=N'172 - 32 - 1176'
            //var q4 = db.Authors.FromSqlRaw($"SELECT * FROM authors where au_id = @id", new SqlParameter("@id", id)).ToList();


            //exec sp_executesql N'SELECT * FROM authors where au_id =''@p0''
            //',N'@p0 nvarchar(4000)',@p0=N'172 - 32 - 1176'
            //var q5 = db.Authors.FromSqlInterpolated($"SELECT * FROM authors where au_id ='{id}'").ToList();
            //exec getallauthors
            //var q6 = db.Authors.FromSqlRaw("exec getallauthors").ToList();

            //// SP Can't Be Encapsulated With Other Query
            //var q7 = db.Authors.FromSqlRaw("exec getallauthors").OrderBy(a => a.AuLname).ToList();

            //foreach (var item in q6)
            //{
            //    Console.WriteLine(item.AuFname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
