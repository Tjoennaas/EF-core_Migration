
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

};

