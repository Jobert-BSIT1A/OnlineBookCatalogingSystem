using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBookCatalogingSystem.Data;
using OnlineBookCatalogingSystem.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure the primary app database (e.g., for Books)
builder.Services.AddDbContext<OnlineBookCatalogingSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineBookCatalogingSystemContext")));

// Configure Identity and its database context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();


// Add MVC and Razor Pages support (Identity UI lives in Razor Pages)
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseDeveloperExceptionPage(); // Add before UseRouting

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Enable routing for both MVC and Identity Areas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
