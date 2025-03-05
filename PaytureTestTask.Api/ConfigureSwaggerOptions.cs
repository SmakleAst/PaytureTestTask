using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace PaytureTestTask.Api
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) =>
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
                        Title = $"Payture test Api {apiVersion}",
                        Description = "Web Api for working with Payture Api.",
                        TermsOfService = new Uri("https://t.me/Smakle_ast"),
                        Contact = new OpenApiContact
                        {
                            Name = "My telegram",
                            Email = string.Empty,
                            Url = new Uri("https://t.me/Smakle_ast")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "My GitHub",
                            Url = new Uri("https://github.com/SmakleAst")
                        }
                    });
            }
        }
    }
}
