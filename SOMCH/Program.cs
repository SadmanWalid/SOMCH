using SOMCH.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//DI
builder.Services.AddDbContext<Registration2Context>(options =>
options.UseNpgsql("Name=ConnectionStrings:RegistrationDatabase"));

// Add services to the container.
builder.Services.AddControllersWithViews();

//temp-QA
builder.Services.AddMvcCore(options => options.EnableEndpointRouting = false);



var app = builder.Build();

//Q/A -- builder.build() ar pore, nicher state ta dile error throw kore, amn ta hoi keno?
//temp - remove it
//builder.Services.AddMvcCore(options => options.EnableEndpointRouting = false);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseMvcWithDefaultRoute();
app.Run();
