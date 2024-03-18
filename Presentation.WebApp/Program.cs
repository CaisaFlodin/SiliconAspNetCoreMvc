using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Repositories;
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

            builder.Services.AddScoped<AddressRepository>();
            builder.Services.AddScoped<UserRepository>();

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
