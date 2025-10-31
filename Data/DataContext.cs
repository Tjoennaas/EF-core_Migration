
//https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-9.0&tabs=visual-studio



// using migration commands https://www.nuget.org/packages/dotnet-ef/10.0.0-rc.2.25502.107

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

