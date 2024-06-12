using Microsoft.EntityFrameworkCore;
using Sunfiit_2._0v.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionstring = builder.Configuration.GetConnectionString("dbConnection");
builder.Services.AddDbContext<db>(options => options.UseSqlServer(connectionstring));
builder.Services.AddDbContext<dbset>(options => options.UseSqlServer(connectionstring));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
