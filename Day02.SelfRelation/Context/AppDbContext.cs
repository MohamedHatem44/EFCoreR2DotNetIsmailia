using Day02.SelfRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.SelfRelation.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=SelfRelation;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany(m => m.Employees)
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public DbSet<Employee> Employees { get; set; }
        /*------------------------------------------------------------------*/
    }
}
