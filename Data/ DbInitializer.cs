


using Microsoft.EntityFrameworkCore;
using EFcore_Migration.Models;


namespace EFcore_Migration.Data;


public static class DbInitializer
{
    public static void Initialize(DataContext context)
    {


       if (context.Students.Any() || context.Courses.Any())
            return;

      

       List<Student>  students = new List<Student>
          {
                new Student{Name="Silje", Age = 20},
                new Student{Name="Lise",Age = 30 },
                new Student{Name="Artur", Age = 40 }
      };

       
        List<Course> courses = new List<Course>
                  {
                new Course{Title="Matte" },
                new Course{Title="Kjemi"},
      };


context.Students.AddRange(students);
context.Courses.AddRange(courses);

students[0].Courses.Add(courses[0]);
students[1].Courses.Add(courses[1]);
students[2].Courses.Add(courses[0]);


context.SaveChanges();

             } }
