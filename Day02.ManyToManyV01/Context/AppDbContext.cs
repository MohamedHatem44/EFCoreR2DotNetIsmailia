using Day02.ManyToManyV01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.ManyToManyV01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmD02MMV01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.Courses)
            //    .WithMany(c => c.Students)
            //    .UsingEntity(
            //        "StudentCourses",
            //        r => r.HasOne(typeof(Course)).WithMany().HasForeignKey("CourseId").HasPrincipalKey(nameof(Course.Id)),
            //        l => l.HasOne(typeof(Student)).WithMany().HasForeignKey("StudentId").HasPrincipalKey(nameof(Student.Id)),
            //        j => j.HasKey("StudentId", "CourseId"));

            //modelBuilder.Entity<Student>()
            //   .HasMany(s => s.Courses)
            //   .WithMany(c => c.Students)
            //   .UsingEntity(sc =>
            //   {
            //       sc.ToTable("StudentCourses");
            //       sc.HasKey("StudentId", "CourseId");  
            //       sc.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
            //   });
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        #region Tables - Local Container
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion
        /*------------------------------------------------------------------*/
    }
}
