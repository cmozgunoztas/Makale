using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Interfaces.Repositories;
using Blog.Core.Interfaces.Services;
using Blog.Core.Services;
using Blog.Infrastructure.Data.Context;
using Blog.Infrastructure.Data.Repository.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Blog.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ArticleContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:ArticleDB"],
                OptionsBuilder => OptionsBuilder.MigrationsAssembly("Blog.API")));
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddScoped<IArticleRepository, ArticleRepository>();

            //Data Services
            services.AddScoped<IArticleService, ArticleService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
