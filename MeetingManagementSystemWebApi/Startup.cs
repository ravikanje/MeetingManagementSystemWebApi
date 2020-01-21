using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingManagementSystemWebApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace MeetingManagementSystemWebApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowFromAll",
                    builder => builder
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
                    .AllowAnyHeader());
            }); ;

            services.AddMvc().
                SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(Options => {

                    var resolver = Options.SerializerSettings.ContractResolver;
                    if (resolver != null) (resolver as DefaultContractResolver).NamingStrategy = null;
                });
            
            services.AddDbContext<MeetingManagementContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowFromAll");
            app.UseMvc();
        }
    }
}
