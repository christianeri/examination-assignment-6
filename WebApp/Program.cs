using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Factories;
using WebApp.Models.Entities;
using WebApp.Models.Identity;
using WebApp.Repositories.forDataContext;
using WebApp.Repositories.forUserContext;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();



// CONTEXTS
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("IdentitySql")));
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DataSql")));



// AUTHENTICATION
    builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
    {
        x.SignIn.RequireConfirmedAccount = false;
        x.User.RequireUniqueEmail = true;
        x.Password.RequiredLength = 8;

    }).AddEntityFrameworkStores<IdentityContext>()//.AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>()//;
    .AddDefaultUI()
    .AddDefaultTokenProviders();

//4m9W1a0T6SU
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 8;

}).AddEntityFrameworkStores<IdentityContext>()//.AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>()//;
.AddDefaultUI()
.AddDefaultTokenProviders(); 







builder.Services.AddScoped<AuthenticationService>();
//builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<AddressService>();



//builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserAddressRepository>();
builder.Services.AddScoped<AddressRepository>();



builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/signin";
    x.LogoutPath = "/";
    x.AccessDeniedPath = "/denied";
});






builder.Services.AddScoped<ShowcaseService>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<TagService>();


builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductTagRepository>();






var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
