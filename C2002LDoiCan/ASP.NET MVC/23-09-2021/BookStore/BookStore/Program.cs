using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using Microsoft.AspNetCore.Builder;
using BookStore.Models;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BookStoreContextConnection");
builder.Services.AddDbContext<BookStoreContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BookStoreContext>()
    .AddUserManager<UserManager<IdentityUser>>();



// Add services to the container.
builder.Services.AddRazorPages();
var serviceProvider = builder.Services.BuildServiceProvider();

/*
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
.AddEntityFrameworkStores<BookStoreContext>();
*/
var app = builder.Build();
//var context = app.Services.GetRequiredService<BookStoreContext>();
var userManager = app.Services.GetService<UserManager<IdentityUser>>();

DbInitializer.InitializeAsync(serviceProvider, userManager).Wait();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();
;

app.Run();
