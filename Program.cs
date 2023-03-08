using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NewProject;

/*using (var context = new MyDbContext())
{
    var profile = context.profileViewModels.ToList();
    
}*/

var builder = WebApplication.CreateBuilder(args);

var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
var configuration = configBuilder.Build();

// Add services to the container.
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Malwande}/{action=Index}");


app.MapControllerRoute(
    name: "Submission",
    pattern: "{controller=Submission}/{action=Index}");


app.MapControllerRoute(
    name: "Edit",
    pattern: "{controller=Edit}/{action=Index}");

app.MapControllerRoute(
    name: "Delete",
    pattern: "{controller=Delete}/{action=Index}");



app.Run();

/*
using (var context = new MyDbContext())
{
    var profile = context.profileViewModels.ToList();
    Console.WriteLine(profile);

}*/
