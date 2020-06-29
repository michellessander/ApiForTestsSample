using System.Collections.Generic;
using ApiForTestsample.Domain;
using ApiForTestsSample.Controllers;
using ApiForTestsSample.Repositories;
using ApiForTestsSample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiForTestsSample
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ListaRepository>(opt => opt.UseInMemoryDatabase("ApiForTestsSample.WebApi"));
            services.AddControllers();
            services.AddScoped<IListaService, ListaService>();
            services.AddScoped<IListaRepository, ListaRepository>();
        }
        
    }
}