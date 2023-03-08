using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NOTABURGER_2.Controllers;
using NOTABURGER_2.Data;
using NOTABURGER_2.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
//dependency injection
builder.Services.AddTransient<IDataAccessLayer, NotABurgerDAL>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
options.SignIn.RequireConfirmedAccount =
false).AddDefaultUI().AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>
();

builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IZipCodeService, ZipCodeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// temp access to Secret Menu.
app.MapControllerRoute(
    name: "SecretMenu",
    pattern: "Missing/vEQww6AoSWo/RIP/EMEPiZZ950I",

    defaults: new { controller = "Home", action = "SecretMenu" });
app.MapControllerRoute(
    name: "Bloopers",
    pattern: "/Bloopers",

    defaults: new { controller = "Home", action = "Bloopers" });


app.MapControllerRoute(
    name: "Credits",
    pattern: "/Credits",

    defaults: new { controller = "Home", action = "Credits" });

app.MapRazorPages();

app.Run();
