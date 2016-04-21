using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Framework.Configuration;

namespace Mobile
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env, Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment appEnv)
        {
            //Setup the project app path and add the custom config file
            var configurationBuilder = new ConfigurationBuilder(appEnv.ApplicationBasePath);
            configurationBuilder.AddJsonFile("config.json");
            configurationBuilder.AddEnvironmentVariables();
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
            app.UseMvc();
            app.UseStaticFiles();
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
