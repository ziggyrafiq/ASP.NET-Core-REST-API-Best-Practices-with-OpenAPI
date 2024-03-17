using Microsoft.OpenApi.Models;

namespace ZR.CodeExample.Definitions
{
    // OpenAPI documentation
    public class OpenApiDefinitions
    {
        public OpenApiInfo Info { get; } = new OpenApiInfo
        {
            Title = "Ziggy Rafiq Task Management API",
            Version = "v1",
            Description = "An API for managing tasks with data validation integrated.",
            Contact = new OpenApiContact
            {
                Name = "Ziggy Rafiq",
                Email = "our.email@example.com"
            }
        };
    }
}
