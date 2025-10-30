


namespace EFcore_Migration.Models;


public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<Course> Courses { get; set; } = new();
}



