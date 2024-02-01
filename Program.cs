using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Malawi_Public_Schools_SIS.Data;
using Malawi_Public_Schools_SIS.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Malawi_Public_Schools_SISAuthDBContextConnection") ?? throw new InvalidOperationException("Connection string 'Malawi_Public_Schools_SISAuthDBContextConnection' not found.");

builder.Services.AddDbContext<Malawi_Public_Schools_SISAuthDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Malawi_Public_Schools_SISUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Malawi_Public_Schools_SISAuthDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

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

app.Run();
