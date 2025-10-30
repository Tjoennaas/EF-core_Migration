


using Microsoft.EntityFrameworkCore;
using EFcore_Migration.Models;

namespace EFcore_Migration.Data;


public class DataContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course>  Courses  => Set<Course>();


//Add Migration sqlite: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers?tabs=dotnet-core-cli
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=Students.db");
  }
}
