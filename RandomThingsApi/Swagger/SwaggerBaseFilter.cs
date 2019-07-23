using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomThingsApi.Swagger
{
    public class SwaggerBaseFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Host = "randomthingsapi.azurewebsites.net";
            swaggerDoc.BasePath = "/";
            swaggerDoc.Schemes = new List<string> { "https" };
        }
    }
}
