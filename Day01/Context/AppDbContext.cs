using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmD01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString); // .UseLazyLoadingProxies();
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d=>d.Employees)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);  

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        #region Tables - Local Container
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        #endregion
        /*------------------------------------------------------------------*/
    }
}
