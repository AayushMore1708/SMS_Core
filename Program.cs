using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMS_Core.Models;

var builder = WebApplication.CreateBuilder(args);

// Add JSON configuration files based on the environment
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Configure services
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<SMSDbContext>()
    .AddDefaultTokenProviders();

// Configure Entity Framework Core to use SQL Server with a connection string from appsettings.json
builder.Services.AddDbContext<SMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddLogging(logging =>
{
    logging.AddConsole(); // Add a console logger to output to the console
});



// Add support for MVC controllers and views
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.Logger.LogInformation($"Current environment: {app.Environment.EnvironmentName}");


// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // Show detailed error pages in development
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
