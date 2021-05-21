using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_deneme1.Models;
using udemy_deneme1.Services;
using Microsoft.EntityFrameworkCore;

namespace udemy_deneme1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb; Database=SchoolDb; Trusted_Connection=true";

            services.AddTransient<ICalculator, Calculator18>();
            //services.AddSingleton<ICalculator, Calculator18>();
            //services.AddScoped<ICalculator, Calculator18>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<SchoolContext>(options=>options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            /*app.UseEndpoints(endpoints =>
            {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}"
                );
            });*/
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {

            routeBuilder.MapRoute("Default","{controller=Home}/{action=Index2}/{id?}" );
            routeBuilder.MapRoute("Route2", "Serhat/{controller=Home}/{action=Index9}/{id?}");
        }
    }
}
