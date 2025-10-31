
//https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-9.0&tabs=visual-studio

using Microsoft.EntityFrameworkCore;
using EFcore_Migration.Models;

namespace EFcore_Migration.Data;


public class DataContext : DbContext
{

  public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

  public DbSet<Student> Students => Set<Student>();
  public DbSet<Course> Courses => Set<Course>();

}



/*
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    var studentCourses = modelBuilder.Entity<Student>()
         .HasMany(s => s.Courses)
         .WithMany(c => c.Students)
         .UsingEntity<Dictionary<string, object>>("StudentCourses");



    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Course>().HasData(
     new Course { Id = 1, Title = "Matte" },
      new Course { Id = 2, Title = "Kjemi" });

    modelBuilder.Entity<Student>().HasData(

    new Student { Id = 101, Name = "Hans", Age = 20 },
    new Student { Id = 102, Name = "Grete", Age = 25 },
    new Student { Id = 103, Name = "Trine", Age = 33 }
    );


    studentCourses.HasData(
     new { StudentsId = 101, CoursesId = 1 },
     new { StudentsId = 102, CoursesId = 2 },
     new { StudentsId = 103, CoursesId = 2 }
 );
  }
}     */
