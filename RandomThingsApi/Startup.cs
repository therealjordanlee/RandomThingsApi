﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RandomThingsApi.Swagger;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace RandomThingsApi
{
    public class Startup
    {
        // https://github.com/domaindrivendev/Swashbuckle.AspNetCore

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.DocumentFilter<SwaggerBaseFilter>();
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "RandomThings API",
                        Version = "v1",

                    }
                );
                var filePath = Path.Combine(System.AppContext.BaseDirectory, "RandomThingsApi.xml");
                c.IncludeXmlComments(filePath);
            });
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RandomThings API V1");
            });
            app.UseMvc();
        }
    }
}
