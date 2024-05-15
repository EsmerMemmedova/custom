namespace WebInance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); 
            var app = builder.Build();
            app.UseDefaultFiles();

            app.MapControllerRoute(
                name:"default",
                pattern:"{ controller=home}/{action=index}/{id?}"
                );
           

            app.Run();
        }
    }
}