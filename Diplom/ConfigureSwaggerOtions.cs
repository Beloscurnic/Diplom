using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace WebAPI
{
    public class ConfigureSwaggerOtions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOtions(IApiVersionDescriptionProvider provider) =>
            _provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                var apiVersion = description.ApiVersion.ToString();
                options.SwaggerDoc(description.GroupName,
                    new OpenApiInfo
                    {
                        Version = apiVersion,
                        Title = $"REST API {apiVersion}",
                        Description = "REST сервис",
                        Contact = new OpenApiContact
                        {
                            Name = "Dan",
                            Email = string.Empty,
                        }
                    });

                options.CustomOperationIds(apiDescription =>
                        apiDescription.TryGetMethodInfo(out MethodInfo methodInfo)
                            ? methodInfo.Name
                            : null);
            }
        }

    }
}
