using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Presentation.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddRouting(x => x.LowercaseUrls = true);

            builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
            builder.Services.AddDefaultIdentity<UserEntity>(x =>
            {
                x.User.RequireUniqueEmail = true;
                x.SignIn.RequireConfirmedAccount = false;
                x.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<DataContext>();

            builder.Services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = "/signin";
                x.Cookie.HttpOnly = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                x.SlidingExpiration = true;
            });

            builder.Services.AddScoped<AddressRepository>();
            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<SubscriberRepository>();
            builder.Services.AddScoped<AddressService>();
            builder.Services.AddScoped<UserService>();
            

            builder.Services.AddScoped<UserFactory>();
            builder.Services.AddScoped<AddressFactory>();

            var app = builder.Build();
            //app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseStatusCodePagesWithReExecute("/error", "?statusCode={0}");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
