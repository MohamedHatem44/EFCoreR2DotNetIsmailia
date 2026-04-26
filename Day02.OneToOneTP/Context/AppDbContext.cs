using Day02.OneToOneTP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.OneToOneTP.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmD02OOTP;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Car)
            //    .WithOne(c => c.Employee)
            //    .HasForeignKey<Car>(c => c.EmployeeId);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        /*------------------------------------------------------------------*/
    }
}
