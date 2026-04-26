using Day02.OneToOnePP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.OneToOnePP.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmD02OOPP;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeCar>()
                .HasKey(ec => new { ec.EmployeeId, ec.CarId });

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<EmployeeCar> EmployeeCars { get; set; }
        /*------------------------------------------------------------------*/
    }
}
