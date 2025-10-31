
/*

using Microsoft.EntityFrameworkCore;
using EFcore_Migration.Models;
using EFcore_Migration.Data;



namespace EFcore_Migration.Services;

public readonly DataContext _dataContext;


public StudentServices(DataContext dataContext)
{
    _dataContext = dataContext;
}



public Task<Book> CreateAsync(string title, string author, int year)
    {
        // Enkel validering som demonstrasjon av "forretningslogikk"
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required");
        if (year < 0) throw new ArgumentException("Year must be positive");
        return _repo.AddAsync(new Book(0, title.Trim(), author.Trim(), year));
    }



using (var db = new BloggingContext())
{
    var blogs = await db.Blogs
        .Where(b => b.Rating > 3)
        .OrderBy(b => b.Url)
        .ToListAsync();
}
*/