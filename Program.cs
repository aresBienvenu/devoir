using Microsoft.EntityFrameworkCore;
using TonProjet.Data;

var builder = WebApplication.CreateBuilder(args);

// ----------------------------------------
// CONFIGURATION DE LA BASE DE DONNÉES
// ----------------------------------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ----------------------------------------
// PIPELINE HTTP
// ----------------------------------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ROUTE PAR DÉFAUT MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
