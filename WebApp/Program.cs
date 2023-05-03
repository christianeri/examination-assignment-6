using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models.Identity;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();





builder.Services.AddDbContext<DataContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("ProductSql")));



builder.Services.AddDbContext<UserContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("UserSql")));
builder.Services.AddDefaultIdentity<IdentityUser>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<UserContext>();











//builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("IdentitySql")));
//builder.Services.AddIdentity<CustomIdentityUser, IdentityRole>(x =>
//{
//    x.SignIn.RequireConfirmedAccount = false;
//    x.User.RequireUniqueEmail = true;
//    x.Password.RequiredLength = 8;
//}).AddEntityFrameworkStores<IdentityContext>();






builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<ShowcaseService>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ProductService>();




var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
