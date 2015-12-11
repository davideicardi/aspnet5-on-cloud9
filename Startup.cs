using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseIISPlatformHandler();
            app.UseStaticFiles();


            app.UseMvcWithDefaultRoute();

            app.UseWelcomePage();
        }
    }
}