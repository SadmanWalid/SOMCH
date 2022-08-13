using SOMCH.Data;
using Microsoft.EntityFrameworkCore;
using SOMCH.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//DI
builder.Services.AddDbContext<Registration2Context>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("RegistrationDataBase")));
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ILoginRepository, LoginRepository>();


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
