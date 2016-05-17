using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mobile
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env, Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment appEnv)
        {
            //Setup the project app path and add the custom config file
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = configurationBuilder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddEntityFramework()
            //    .AddSqlServer()
            //    .AddDbContext<QuotesAppContext>(options => options.UseSqlServer(Configuration["Data:ConnectionString"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "userRoute", 
                    "User/{action}",
                    new { controller = "App", action = "Login" });
                routes.MapRoute(
                    "adminRoute",
                    "Admin/{action}",
                    new { controller = "App", action = "Login" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=App}/{action=Index}/{id?}");
                routes.MapRoute(
                    "LoginRoute", "Login",
                    new { controller = "App", action = "Login" });
            });
            app.UseStaticFiles();
            app.UseIISPlatformHandler();

        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
