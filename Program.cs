


using Microsoft.EntityFrameworkCore;
using EFcore_Migration.Data;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<DataContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("SQLite")));
var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DataContext>();
    db.Database.Migrate();         

 
    DbInitializer.Initialize(db);
}


     
app.Run();