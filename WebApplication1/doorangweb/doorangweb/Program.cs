using doorang.Business.Services.Abstracts;
using doorang.Business.Services.Concretes;
using doorang.Core.RepostoryAbstracts;
using doorang.Data.DAL;
using doorang.Data.RepostoryConcretes;
using Microsoft.EntityFrameworkCore;

namespace doorangweb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddScoped<IExploreService,ExploreService>(); 
            
            builder.Services.AddScoped<IExploreRepostory,ExploreRepostory>();
            var app = builder.Build();

          
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dasboard}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}