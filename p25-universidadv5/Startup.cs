using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;
using p25_universidadv5.Modelo;
using p25_universidadv5.Servicio;

namespace p25_universidadv5
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<ServicioEstudidantes>();
            services.AddScoped<ServicioInstructores>();
            services.AddScoped<ServicioCursos>();
            services.AddScoped<ServicioDepartamentos>();
            services.AddScoped<ServicioInscripciones>();
            services.AddScoped<ServicioOficinaAsignadas>();
            services.AddScoped<ServicioAsignacionCursos>();
            services.AddDbContext<UniContexto>(opciones => opciones.UseSqlite(Configuration.GetConnectionString("ConexionDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
