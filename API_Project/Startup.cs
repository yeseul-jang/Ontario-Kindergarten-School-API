using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Project.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API_Project
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddDbContext<APIProjectClassLibrary.Entities.API_ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Connection2RDS")));
            services.AddScoped<IPublicSchoolRepository, PublicSchoolRepository>();
            services.AddScoped<IPrivateSchoolRepository, PrivateSchoolRepository>();
            services.AddScoped<IPrivateSchoolRateRepository, PrivateSchoolRateRepository>();
            services.AddScoped<IEnrolmentByGenderRepository, EnrolmentByGenderRepository>();
            services.AddScoped<IEnrolmentBySchoolRepository, EnrolmentBySchoolRepository>();


            //register the swagger generator
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Public & Private School API", Version = "v1" });
            });
            services.AddMvc(options =>
            {
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", "application/xml");
                options.FormatterMappings.SetMediaTypeMappingForFormat("js", "application/json");
            }).AddXmlSerializerFormatters();

            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Enable middleware to server generated Swagger as a JSON endpoint
            app.UseSwagger();

            //specify the Swagger JSON endpoint
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Public & Private School API");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
