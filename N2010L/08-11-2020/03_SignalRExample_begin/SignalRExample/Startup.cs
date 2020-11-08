using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SignalRExample.Hubs;
using SignalRExample.Middleware;
using SignalRExample.Services;

namespace SignalRExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            services.AddMvc();
            
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseSignalR(routes =>
            {
                routes.MapHub<SquaresHub>("/squareshub");
            });

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    name: "Default",
                pattern: "{controller}/{action}",
                defaults: new { controller = "Square", action = "Index" });

            });
                        
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
