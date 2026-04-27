using Day02.Project.Configuration;
using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day02.Project.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetIsmailiaD02Project;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //modelBuilder.Entity<Instructor>().Ignore(i => i.NoOfCourses);

            #region Course => Old
            //modelBuilder.Entity<Course>()
            //    .HasKey(c => c.Crs_Id);

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Name)
            //    .HasMaxLength(50)
            //    .IsRequired();

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Desc)
            //    .HasMaxLength(250)
            //    .IsRequired(false);
            #endregion

            #region Course => New
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.Crs_Id);
                entity.Property(c => c.Crs_Name)
                    .HasMaxLength(50)
                    .IsRequired();
                entity.Property(c => c.Crs_Desc)
                    .HasMaxLength(250)
                    .IsRequired(false);
            });
            #endregion

            // Configuration Files
            //modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<Instructor>().HasQueryFilter(i => !i.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // int => Number of Rows Affected
        public override int SaveChanges()
        {
            // Before Save Validation
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                .Select(e => e.Entity);

            foreach (var item in entries)
            {
                var validationContext = new ValidationContext(item);
                Validator.ValidateObject(item, validationContext, true);
            }

            // Keep
            return base.SaveChanges();
        }
        /*------------------------------------------------------------------*/
        public DbSet<Car> Cars { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        /*------------------------------------------------------------------*/
    }
}

// OwnedEntity
// CreatedOn : 2024-06-26 17:30
// ModifiedOn : 2024-06-26 17:30
// CreatedBy
// ModifiedBy

// DeletedOn

// LastPPChangedOn
// LastPasswordChangedOn
// LastLoginDate