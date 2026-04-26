using Day02.DbMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.DbMigrations.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmD02;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        #region Tables - Local Container
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<TestGuid> TestGuids { get; set; }
        #endregion
        /*------------------------------------------------------------------*/
    }
}
